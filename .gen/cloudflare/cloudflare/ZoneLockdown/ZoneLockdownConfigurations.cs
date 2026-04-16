using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZoneLockdown
{
    [JsiiByValue(fqn: "cloudflare.zoneLockdown.ZoneLockdownConfigurations")]
    public class ZoneLockdownConfigurations : cloudflare.ZoneLockdown.IZoneLockdownConfigurations
    {
        /// <summary>The configuration target.</summary>
        /// <remarks>
        /// You must set the target to <c>ip</c> when specifying an IP address in the Zone Lockdown rule.
        /// Available values: "ip", "ip_range".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_lockdown#target ZoneLockdown#target}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Target
        {
            get;
            set;
        }

        /// <summary>The IP address to match. This address will be compared to the IP address of incoming requests.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_lockdown#value ZoneLockdown#value}
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
