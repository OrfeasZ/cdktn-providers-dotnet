using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicTransitCf1Site
{
    [JsiiByValue(fqn: "cloudflare.magicTransitCf1Site.MagicTransitCf1SiteLocation")]
    public class MagicTransitCf1SiteLocation : cloudflare.MagicTransitCf1Site.IMagicTransitCf1SiteLocation
    {
        /// <summary>Latitude of the CF1 Site.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.0/docs/resources/magic_transit_cf1_site#lat MagicTransitCf1Site#lat}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lat", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Lat
        {
            get;
            set;
        }

        /// <summary>Longitude of the CF1 Site.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.0/docs/resources/magic_transit_cf1_site#long MagicTransitCf1Site#long}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "long", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Long
        {
            get;
            set;
        }

        /// <summary>Name of nearest town, city, or village.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.0/docs/resources/magic_transit_cf1_site#name MagicTransitCf1Site#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }
    }
}
