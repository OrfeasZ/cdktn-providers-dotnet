using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MarketplacePublication
{
    [JsiiInterface(nativeType: typeof(IMarketplacePublicationPackageDetailsEula), fullyQualifiedName: "oci.marketplacePublication.MarketplacePublicationPackageDetailsEula")]
    public interface IMarketplacePublicationPackageDetailsEula
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/marketplace_publication#eula_type MarketplacePublication#eula_type}.</summary>
        [JsiiProperty(name: "eulaType", typeJson: "{\"primitive\":\"string\"}")]
        string EulaType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/marketplace_publication#license_text MarketplacePublication#license_text}.</summary>
        [JsiiProperty(name: "licenseText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LicenseText
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMarketplacePublicationPackageDetailsEula), fullyQualifiedName: "oci.marketplacePublication.MarketplacePublicationPackageDetailsEula")]
        internal sealed class _Proxy : DeputyBase, oci.MarketplacePublication.IMarketplacePublicationPackageDetailsEula
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/marketplace_publication#eula_type MarketplacePublication#eula_type}.</summary>
            [JsiiProperty(name: "eulaType", typeJson: "{\"primitive\":\"string\"}")]
            public string EulaType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/marketplace_publication#license_text MarketplacePublication#license_text}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "licenseText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LicenseText
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
