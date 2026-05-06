using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MarketplaceMarketplaceExternalAttestedMetadata
{
    [JsiiInterface(nativeType: typeof(IMarketplaceMarketplaceExternalAttestedMetadataTimeouts), fullyQualifiedName: "oci.marketplaceMarketplaceExternalAttestedMetadata.MarketplaceMarketplaceExternalAttestedMetadataTimeouts")]
    public interface IMarketplaceMarketplaceExternalAttestedMetadataTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/marketplace_marketplace_external_attested_metadata#create MarketplaceMarketplaceExternalAttestedMetadata#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/marketplace_marketplace_external_attested_metadata#delete MarketplaceMarketplaceExternalAttestedMetadata#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/marketplace_marketplace_external_attested_metadata#update MarketplaceMarketplaceExternalAttestedMetadata#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMarketplaceMarketplaceExternalAttestedMetadataTimeouts), fullyQualifiedName: "oci.marketplaceMarketplaceExternalAttestedMetadata.MarketplaceMarketplaceExternalAttestedMetadataTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.MarketplaceMarketplaceExternalAttestedMetadata.IMarketplaceMarketplaceExternalAttestedMetadataTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/marketplace_marketplace_external_attested_metadata#create MarketplaceMarketplaceExternalAttestedMetadata#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/marketplace_marketplace_external_attested_metadata#delete MarketplaceMarketplaceExternalAttestedMetadata#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/marketplace_marketplace_external_attested_metadata#update MarketplaceMarketplaceExternalAttestedMetadata#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
