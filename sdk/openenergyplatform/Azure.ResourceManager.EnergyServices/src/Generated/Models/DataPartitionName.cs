// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EnergyServices.Models
{
    /// <summary> The list of Energy services resource&apos;s Data Partition Names. </summary>
    public partial class DataPartitionName
    {
        /// <summary> Initializes a new instance of DataPartitionName. </summary>
        public DataPartitionName()
        {
        }

        /// <summary> Initializes a new instance of DataPartitionName. </summary>
        /// <param name="name"></param>
        internal DataPartitionName(string name)
        {
            Name = name;
        }

        /// <summary> Gets or sets the name. </summary>
        public string Name { get; set; }
    }
}
