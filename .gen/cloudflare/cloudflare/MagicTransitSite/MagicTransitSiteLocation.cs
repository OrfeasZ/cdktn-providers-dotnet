using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicTransitSite
{
    [JsiiByValue(fqn: "cloudflare.magicTransitSite.MagicTransitSiteLocation")]
    public class MagicTransitSiteLocation : cloudflare.MagicTransitSite.IMagicTransitSiteLocation
    {
        /// <summary>Latitude.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site#lat MagicTransitSite#lat}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Lat
        {
            get;
            set;
        }

        /// <summary>Longitude.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site#lon MagicTransitSite#lon}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lon", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Lon
        {
            get;
            set;
        }
    }
}
