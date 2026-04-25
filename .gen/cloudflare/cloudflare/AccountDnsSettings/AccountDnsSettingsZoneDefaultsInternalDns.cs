using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AccountDnsSettings
{
    [JsiiByValue(fqn: "cloudflare.accountDnsSettings.AccountDnsSettingsZoneDefaultsInternalDns")]
    public class AccountDnsSettingsZoneDefaultsInternalDns : cloudflare.AccountDnsSettings.IAccountDnsSettingsZoneDefaultsInternalDns
    {
        /// <summary>The ID of the zone to fallback to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/account_dns_settings#reference_zone_id AccountDnsSettings#reference_zone_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "referenceZoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReferenceZoneId
        {
            get;
            set;
        }
    }
}
