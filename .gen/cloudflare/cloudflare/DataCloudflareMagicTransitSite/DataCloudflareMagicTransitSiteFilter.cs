using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareMagicTransitSite
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareMagicTransitSite.DataCloudflareMagicTransitSiteFilter")]
    public class DataCloudflareMagicTransitSiteFilter : cloudflare.DataCloudflareMagicTransitSite.IDataCloudflareMagicTransitSiteFilter
    {
        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/magic_transit_site#connectorid DataCloudflareMagicTransitSite#connectorid}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connectorid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Connectorid
        {
            get;
            set;
        }
    }
}
