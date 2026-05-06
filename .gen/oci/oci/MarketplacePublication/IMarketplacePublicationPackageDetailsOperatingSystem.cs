using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MarketplacePublication
{
    [JsiiInterface(nativeType: typeof(IMarketplacePublicationPackageDetailsOperatingSystem), fullyQualifiedName: "oci.marketplacePublication.MarketplacePublicationPackageDetailsOperatingSystem")]
    public interface IMarketplacePublicationPackageDetailsOperatingSystem
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/marketplace_publication#name MarketplacePublication#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMarketplacePublicationPackageDetailsOperatingSystem), fullyQualifiedName: "oci.marketplacePublication.MarketplacePublicationPackageDetailsOperatingSystem")]
        internal sealed class _Proxy : DeputyBase, oci.MarketplacePublication.IMarketplacePublicationPackageDetailsOperatingSystem
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/marketplace_publication#name MarketplacePublication#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
