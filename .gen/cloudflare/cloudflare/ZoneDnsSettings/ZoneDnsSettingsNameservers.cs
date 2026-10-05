using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZoneDnsSettings
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zoneDnsSettings.ZoneDnsSettingsNameservers")]
    public class ZoneDnsSettingsNameservers : cloudflare.ZoneDnsSettings.IZoneDnsSettingsNameservers
    {
        /// <summary>Nameserver type. Available values: "cloudflare.standard", "cloudflare.advanced", "custom.account", "custom.tenant", "custom.zone", "custom".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zone_dns_settings#type ZoneDnsSettings#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Identifier of the account-owned Custom Nameserver Set to use for this zone.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zone_dns_settings#nameserver_set_id ZoneDnsSettings#nameserver_set_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nameserverSetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NameserverSetId
        {
            get;
            set;
        }

        /// <summary>Configured nameserver set number to use for this zone.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zone_dns_settings#ns_set ZoneDnsSettings#ns_set}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nsSet", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NsSet
        {
            get;
            set;
        }
    }
}
