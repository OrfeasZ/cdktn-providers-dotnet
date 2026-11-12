using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZoneLockdown
{
    [JsiiByValue(fqn: "cloudflare.zoneLockdown.ZoneLockdownConfigurations")]
    public class ZoneLockdownConfigurations : cloudflare.ZoneLockdown.IZoneLockdownConfigurations
    {
        /// <summary>For `target: ip`: The configuration target.</summary>
        /// <remarks>
        /// You must set the target to <c>ip</c> when specifying an IP address in the Zone Lockdown rule.
        ///
        /// For <c>target: ip_range</c>: The configuration target. You must set the target to <c>ip_range</c> when specifying an IP address range in the Zone Lockdown rule.
        /// Available values: "ip", "ip_range".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zone_lockdown#target ZoneLockdown#target}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Target
        {
            get;
            set;
        }

        /// <summary>For `target: ip`: The IP address to match.</summary>
        /// <remarks>
        /// This address will be compared to the IP address of incoming requests.
        ///
        /// For <c>target: ip_range</c>: The IP address range to match. You can only use prefix lengths <c>/16</c> and <c>/24</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zone_lockdown#value ZoneLockdown#value}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}
