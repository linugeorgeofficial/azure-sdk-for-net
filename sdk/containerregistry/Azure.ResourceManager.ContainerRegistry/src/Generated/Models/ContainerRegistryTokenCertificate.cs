// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The properties of a certificate used for authenticating a token. </summary>
    public partial class ContainerRegistryTokenCertificate
    {
        /// <summary> Initializes a new instance of ContainerRegistryTokenCertificate. </summary>
        public ContainerRegistryTokenCertificate()
        {
        }

        /// <summary> Initializes a new instance of ContainerRegistryTokenCertificate. </summary>
        /// <param name="name"></param>
        /// <param name="expireOn"> The expiry datetime of the certificate. </param>
        /// <param name="thumbprint"> The thumbprint of the certificate. </param>
        /// <param name="encodedPemCertificate"> Base 64 encoded string of the public certificate1 in PEM format that will be used for authenticating the token. </param>
        internal ContainerRegistryTokenCertificate(ContainerRegistryTokenCertificateName? name, DateTimeOffset? expireOn, string thumbprint, string encodedPemCertificate)
        {
            Name = name;
            ExpireOn = expireOn;
            Thumbprint = thumbprint;
            EncodedPemCertificate = encodedPemCertificate;
        }

        /// <summary> Gets or sets the name. </summary>
        public ContainerRegistryTokenCertificateName? Name { get; set; }
        /// <summary> The expiry datetime of the certificate. </summary>
        public DateTimeOffset? ExpireOn { get; set; }
        /// <summary> The thumbprint of the certificate. </summary>
        public string Thumbprint { get; set; }
        /// <summary> Base 64 encoded string of the public certificate1 in PEM format that will be used for authenticating the token. </summary>
        public string EncodedPemCertificate { get; set; }
    }
}
