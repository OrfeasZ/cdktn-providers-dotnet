using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareMagicTransitSite
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareMagicTransitSiteFilter), fullyQualifiedName: "cloudflare.dataCloudflareMagicTransitSite.DataCloudflareMagicTransitSiteFilter")]
    public interface IDataCloudflareMagicTransitSiteFilter
    {
        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/magic_transit_site#connectorid DataCloudflareMagicTransitSite#connectorid}
        /// </remarks>
        [JsiiProperty(name: "connectorid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Connectorid
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareMagicTransitSiteFilter), fullyQualifiedName: "cloudflare.dataCloudflareMagicTransitSite.DataCloudflareMagicTransitSiteFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareMagicTransitSite.IDataCloudflareMagicTransitSiteFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/magic_transit_site#connectorid DataCloudflareMagicTransitSite#connectorid}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connectorid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Connectorid
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
