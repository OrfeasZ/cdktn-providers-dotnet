using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZoneDnsSettings
{
    [JsiiByValue(fqn: "cloudflare.zoneDnsSettings.ZoneDnsSettingsNameservers")]
    public class ZoneDnsSettingsNameservers : cloudflare.ZoneDnsSettings.IZoneDnsSettingsNameservers
    {
        /// <summary>Configured nameserver set to be used for this zone.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_dns_settings#ns_set ZoneDnsSettings#ns_set}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nsSet", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NsSet
        {
            get;
            set;
        }

        /// <summary>Nameserver type Available values: "cloudflare.standard", "custom.account", "custom.tenant", "custom.zone".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_dns_settings#type ZoneDnsSettings#type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
