using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MarketplacePublication
{
    [JsiiInterface(nativeType: typeof(IMarketplacePublicationPackageDetails), fullyQualifiedName: "oci.marketplacePublication.MarketplacePublicationPackageDetails")]
    public interface IMarketplacePublicationPackageDetails
    {
        /// <summary>eula block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/marketplace_publication#eula MarketplacePublication#eula}
        /// </remarks>
        [JsiiProperty(name: "eula", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.marketplacePublication.MarketplacePublicationPackageDetailsEula\"},\"kind\":\"array\"}}]}}")]
        object Eula
        {
            get;
        }

        /// <summary>operating_system block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/marketplace_publication#operating_system MarketplacePublication#operating_system}
        /// </remarks>
        [JsiiProperty(name: "operatingSystem", typeJson: "{\"fqn\":\"oci.marketplacePublication.MarketplacePublicationPackageDetailsOperatingSystem\"}")]
        oci.MarketplacePublication.IMarketplacePublicationPackageDetailsOperatingSystem OperatingSystem
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/marketplace_publication#package_type MarketplacePublication#package_type}.</summary>
        [JsiiProperty(name: "packageType", typeJson: "{\"primitive\":\"string\"}")]
        string PackageType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/marketplace_publication#package_version MarketplacePublication#package_version}.</summary>
        [JsiiProperty(name: "packageVersion", typeJson: "{\"primitive\":\"string\"}")]
        string PackageVersion
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/marketplace_publication#image_id MarketplacePublication#image_id}.</summary>
        [JsiiProperty(name: "imageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ImageId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMarketplacePublicationPackageDetails), fullyQualifiedName: "oci.marketplacePublication.MarketplacePublicationPackageDetails")]
        internal sealed class _Proxy : DeputyBase, oci.MarketplacePublication.IMarketplacePublicationPackageDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>eula block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/marketplace_publication#eula MarketplacePublication#eula}
            /// </remarks>
            [JsiiProperty(name: "eula", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.marketplacePublication.MarketplacePublicationPackageDetailsEula\"},\"kind\":\"array\"}}]}}")]
            public object Eula
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>operating_system block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/marketplace_publication#operating_system MarketplacePublication#operating_system}
            /// </remarks>
            [JsiiProperty(name: "operatingSystem", typeJson: "{\"fqn\":\"oci.marketplacePublication.MarketplacePublicationPackageDetailsOperatingSystem\"}")]
            public oci.MarketplacePublication.IMarketplacePublicationPackageDetailsOperatingSystem OperatingSystem
            {
                get => GetInstanceProperty<oci.MarketplacePublication.IMarketplacePublicationPackageDetailsOperatingSystem>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/marketplace_publication#package_type MarketplacePublication#package_type}.</summary>
            [JsiiProperty(name: "packageType", typeJson: "{\"primitive\":\"string\"}")]
            public string PackageType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/marketplace_publication#package_version MarketplacePublication#package_version}.</summary>
            [JsiiProperty(name: "packageVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string PackageVersion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/marketplace_publication#image_id MarketplacePublication#image_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "imageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ImageId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
