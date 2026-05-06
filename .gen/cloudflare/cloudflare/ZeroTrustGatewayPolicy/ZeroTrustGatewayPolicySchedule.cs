using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustGatewayPolicy
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicySchedule")]
    public class ZeroTrustGatewayPolicySchedule : cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicySchedule
    {
        /// <summary>The time intervals when the rule will be active on Fridays, in increasing order from 00:00-24:00.</summary>
        /// <remarks>
        /// If this parameter is omitted, the rule will be deactivated on Fridays.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_policy#fri ZeroTrustGatewayPolicy#fri}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Fri
        {
            get;
            set;
        }

        /// <summary>The time intervals when the rule will be active on Mondays, in increasing order from 00:00-24:00.</summary>
        /// <remarks>
        /// If this parameter is omitted, the rule will be deactivated on Mondays.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_policy#mon ZeroTrustGatewayPolicy#mon}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mon", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Mon
        {
            get;
            set;
        }

        /// <summary>The time intervals when the rule will be active on Saturdays, in increasing order from 00:00-24:00.</summary>
        /// <remarks>
        /// If this parameter is omitted, the rule will be deactivated on Saturdays.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_policy#sat ZeroTrustGatewayPolicy#sat}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Sat
        {
            get;
            set;
        }

        /// <summary>The time intervals when the rule will be active on Sundays, in increasing order from 00:00-24:00.</summary>
        /// <remarks>
        /// If this parameter is omitted, the rule will be deactivated on Sundays.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_policy#sun ZeroTrustGatewayPolicy#sun}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sun", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Sun
        {
            get;
            set;
        }

        /// <summary>The time intervals when the rule will be active on Thursdays, in increasing order from 00:00-24:00.</summary>
        /// <remarks>
        /// If this parameter is omitted, the rule will be deactivated on Thursdays.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_policy#thu ZeroTrustGatewayPolicy#thu}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "thu", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Thu
        {
            get;
            set;
        }

        /// <summary>The time zone the rule will be evaluated against.</summary>
        /// <remarks>
        /// If a <a href="https://en.wikipedia.org/wiki/List_of_tz_database_time_zones#List">valid time zone city name</a> is provided, Gateway will always use the current time at that time zone. If this parameter is omitted, then Gateway will use the time zone inferred from the user's source IP to evaluate the rule. If Gateway cannot determine the time zone from the IP, we will fall back to the time zone of the user's connected data center.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_policy#time_zone ZeroTrustGatewayPolicy#time_zone}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeZone
        {
            get;
            set;
        }

        /// <summary>The time intervals when the rule will be active on Tuesdays, in increasing order from 00:00-24:00.</summary>
        /// <remarks>
        /// If this parameter is omitted, the rule will be deactivated on Tuesdays.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_policy#tue ZeroTrustGatewayPolicy#tue}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Tue
        {
            get;
            set;
        }

        /// <summary>The time intervals when the rule will be active on Wednesdays, in increasing order from 00:00-24:00.</summary>
        /// <remarks>
        /// If this parameter is omitted, the rule will be deactivated on Wednesdays.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_policy#wed ZeroTrustGatewayPolicy#wed}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "wed", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Wed
        {
            get;
            set;
        }
    }
}
