// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PowerBIDedicated.Models
{
    /// <summary> Specifies the generation of the Power BI Embedded capacity. If no value is specified, the default value &apos;Gen2&apos; is used. [Learn More](https://docs.microsoft.com/power-bi/developer/embedded/power-bi-embedded-generation-2). </summary>
    public readonly partial struct Mode : IEquatable<Mode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Mode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Mode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Gen1Value = "Gen1";
        private const string Gen2Value = "Gen2";

        /// <summary> Gen1. </summary>
        public static Mode Gen1 { get; } = new Mode(Gen1Value);
        /// <summary> Gen2. </summary>
        public static Mode Gen2 { get; } = new Mode(Gen2Value);
        /// <summary> Determines if two <see cref="Mode"/> values are the same. </summary>
        public static bool operator ==(Mode left, Mode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Mode"/> values are not the same. </summary>
        public static bool operator !=(Mode left, Mode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Mode"/>. </summary>
        public static implicit operator Mode(string value) => new Mode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Mode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Mode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
