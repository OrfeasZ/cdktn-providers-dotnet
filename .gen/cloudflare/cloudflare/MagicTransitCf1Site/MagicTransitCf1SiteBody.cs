using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicTransitCf1Site
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.magicTransitCf1Site.MagicTransitCf1SiteBody")]
    public class MagicTransitCf1SiteBody : cloudflare.MagicTransitCf1Site.IMagicTransitCf1SiteBody
    {
        /// <summary>A human-provided name describing the CF1 Site that should be unique within the account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/magic_transit_cf1_site#name MagicTransitCf1Site#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>A human-provided description of the CF1 Site.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/magic_transit_cf1_site#description MagicTransitCf1Site#description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/magic_transit_cf1_site#location MagicTransitCf1Site#location}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "location", typeJson: "{\"fqn\":\"cloudflare.magicTransitCf1Site.MagicTransitCf1SiteBodyLocation\"}", isOptional: true)]
        public cloudflare.MagicTransitCf1Site.IMagicTransitCf1SiteBodyLocation? Location
        {
            get;
            set;
        }
    }
}
