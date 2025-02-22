﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Reflection;
using Azure.Core.TestFramework;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Azure.Core.Tests.DelayStrategies
{
    internal class RetryAfterPollingStrategyTests
    {
        [Test]
        public void RetryAfterWithExponentialFallbackMs(
            [Values("retry-after-ms", "x-ms-retry-after-ms", null)] string headerName,
            [Values(
                new int[] { 500, 5000, 1250, 2000 },
                new int[] { 500, 500, 1250 },
                new int[] { 500, 5000, 1250, 2000, 10000, 7500 },
                new int[] { 500, 5000, 1250, 2000, 10000, 7500, 20000, 20000, 20000, 20000, 20000, 20000, 20000 })] int[] delayValues,
            [Values(500, 1000, 2000, 5000, null)] int? suggestedWaitInMs)
        {
            var fallbackStrategy = new ExponentialDelayStrategy();
            TimeSpan[] defaultDelays = fallbackStrategy.GetType().GetField("_pollingSequence", BindingFlags.NonPublic | BindingFlags.Static).GetValue(null) as TimeSpan[];
            var strategy = new RetryAfterDelayStrategy(fallbackStrategy);
            TimeSpan actual = TimeSpan.Zero;
            TimeSpan? suggestion = suggestedWaitInMs.HasValue ? TimeSpan.FromMilliseconds(suggestedWaitInMs.Value) : null;
            int expected = 0;
            for (int i = 0; i < delayValues.Length; i++)
            {
                var response = new MockResponse(200);
                //ignore suggestion for exponential
                expected += GetExpected(headerName, delayValues[i], null, (int)defaultDelays[Math.Min(i, defaultDelays.Length - 1)].TotalMilliseconds);
                if (headerName is not null)
                    response.AddHeader(new HttpHeader(headerName, delayValues[i].ToString()));
                actual += strategy.GetNextDelay(response, suggestion);
            }

            Assert.AreEqual(TimeSpan.FromMilliseconds(expected), actual);
        }

        [Test]
        public void RetryAfterWithExponentialFallbackS(
            [Values("Retry-After", null)] string headerName,
            [Values(
                new int[] { 1, 2, 1, 2 },
                new int[] { 1, 1, 2 },
                new int[] { 1, 5, 2, 2, 10, 8 },
                new int[] { 1, 5, 1, 2, 10, 8, 20, 20, 20, 20, 20, 20, 20 })] int[] delayValues,
            [Values(1, 2, 5, null)] int? suggestedWaitInMs)
        {
            var fallbackStrategy = new ExponentialDelayStrategy();
            TimeSpan[] defaultDelays = fallbackStrategy.GetType().GetField("_pollingSequence", BindingFlags.NonPublic | BindingFlags.Static).GetValue(null) as TimeSpan[];
            var strategy = new RetryAfterDelayStrategy(fallbackStrategy);
            TimeSpan actual = TimeSpan.Zero;
            TimeSpan? suggestion = suggestedWaitInMs.HasValue ? TimeSpan.FromSeconds(suggestedWaitInMs.Value) : null;
            int expected = 0;
            for (int i = 0; i < delayValues.Length; i++)
            {
                var response = new MockResponse(200);
                //ignore suggestion for exponential
                expected += GetExpected(headerName, delayValues[i], null, (int)defaultDelays[Math.Min(i, defaultDelays.Length - 1)].TotalSeconds);
                if (headerName is not null)
                    response.AddHeader(new HttpHeader(headerName, delayValues[i].ToString()));
                actual += strategy.GetNextDelay(response, suggestion);
            }

            Assert.AreEqual(TimeSpan.FromSeconds(expected), actual);
        }

        [Test]
        public void RetryAfterWithConstantFallbackMs(
            [Values("retry-after-ms", "x-ms-retry-after-ms", null)] string headerName,
            [Values(
                new int[] { 500, 5000, 1250, 2000 },
                new int[] { 500, 500, 1250 },
                new int[] { 500, 5000, 1250, 2000, 10000, 7500 })] int[] delayValues,
            [Values(500, 1000, 2000, 5000, null)] int? suggestedWaitInMs)
        {
            var strategy = new RetryAfterDelayStrategy();
            TimeSpan actual = TimeSpan.Zero;
            TimeSpan? suggestion = suggestedWaitInMs.HasValue ? TimeSpan.FromMilliseconds(suggestedWaitInMs.Value) : null;
            int expected = 0;
            for (int i = 0; i < delayValues.Length; i++)
            {
                var response = new MockResponse(200);
                expected += GetExpected(headerName, delayValues[i], suggestedWaitInMs, (int)ConstantDelayStrategy.DefaultPollingInterval.TotalMilliseconds);
                if (headerName is not null)
                    response.AddHeader(new HttpHeader(headerName, delayValues[i].ToString()));
                actual += strategy.GetNextDelay(response, suggestion);
            }

            Assert.AreEqual(TimeSpan.FromMilliseconds(expected), actual);
        }

        [Test]
        public void RetryAfterWithConstantFallbackS(
            [Values("Retry-After", null)] string headerName,
            [Values(
                new int[] { 1, 5, 2, 2 },
                new int[] { 1, 1, 2 },
                new int[] { 1, 5, 2, 2, 10, 8 })] int[] delayValues,
            [Values(1, 2, 5, null)] int? suggestedWaitInMs)
        {
            var strategy = new RetryAfterDelayStrategy();
            TimeSpan actual = TimeSpan.Zero;
            TimeSpan? suggestion = suggestedWaitInMs.HasValue ? TimeSpan.FromSeconds(suggestedWaitInMs.Value) : null;
            int expected = 0;
            for (int i = 0; i < delayValues.Length; i++)
            {
                var response = new MockResponse(200);
                expected += GetExpected(headerName, delayValues[i], suggestedWaitInMs, (int)ConstantDelayStrategy.DefaultPollingInterval.TotalSeconds);
                if (headerName is not null)
                    response.AddHeader(new HttpHeader(headerName, delayValues[i].ToString()));
                actual += strategy.GetNextDelay(response, suggestion);
            }

            Assert.AreEqual(TimeSpan.FromSeconds(expected), actual);
        }

        private static int GetExpected(string headerName, int delayValue, int? suggestedWaitInMs, int defaultPoll) => (headerName is not null, suggestedWaitInMs.HasValue) switch
        {
            (true, true) => Math.Max(delayValue, Math.Max(suggestedWaitInMs.Value, defaultPoll)),
            (true, false) => Math.Max(delayValue, defaultPoll),
            (false, true) => Math.Max(suggestedWaitInMs.Value, defaultPoll),
            (false, false) => defaultPoll
        };
    }
}
