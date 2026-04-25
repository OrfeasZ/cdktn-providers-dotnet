using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustGatewayPolicy
{
    [JsiiInterface(nativeType: typeof(IZeroTrustGatewayPolicySchedule), fullyQualifiedName: "cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicySchedule")]
    public interface IZeroTrustGatewayPolicySchedule
    {
        /// <summary>Specify the time intervals when the rule is active on Fridays, in the increasing order from 00:00-24:00.</summary>
        /// <remarks>
        /// If this parameter omitted, the rule is deactivated on Fridays. API returns a formatted version of this string, which may cause Terraform drift if a unformatted value is used.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#fri ZeroTrustGatewayPolicy#fri}
        /// </remarks>
        [JsiiProperty(name: "fri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Fri
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specify the time intervals when the rule is active on Mondays, in the increasing order from 00:00-24:00(capped at maximum of 6 time splits).</summary>
        /// <remarks>
        /// If this parameter omitted, the rule is deactivated on Mondays. API returns a formatted version of this string, which may cause Terraform drift if a unformatted value is used.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#mon ZeroTrustGatewayPolicy#mon}
        /// </remarks>
        [JsiiProperty(name: "mon", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Mon
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specify the time intervals when the rule is active on Saturdays, in the increasing order from 00:00-24:00.</summary>
        /// <remarks>
        /// If this parameter omitted, the rule is deactivated on Saturdays. API returns a formatted version of this string, which may cause Terraform drift if a unformatted value is used.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#sat ZeroTrustGatewayPolicy#sat}
        /// </remarks>
        [JsiiProperty(name: "sat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Sat
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specify the time intervals when the rule is active on Sundays, in the increasing order from 00:00-24:00.</summary>
        /// <remarks>
        /// If this parameter omitted, the rule is deactivated on Sundays. API returns a formatted version of this string, which may cause Terraform drift if a unformatted value is used.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#sun ZeroTrustGatewayPolicy#sun}
        /// </remarks>
        [JsiiProperty(name: "sun", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Sun
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specify the time intervals when the rule is active on Thursdays, in the increasing order from 00:00-24:00.</summary>
        /// <remarks>
        /// If this parameter omitted, the rule is deactivated on Thursdays. API returns a formatted version of this string, which may cause Terraform drift if a unformatted value is used.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#thu ZeroTrustGatewayPolicy#thu}
        /// </remarks>
        [JsiiProperty(name: "thu", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Thu
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specify the time zone for rule evaluation.</summary>
        /// <remarks>
        /// When a <a href="https://en.wikipedia.org/wiki/List_of_tz_database_time_zones#List">valid time zone city name</a> is provided, Gateway always uses the current time for that time zone. When this parameter is omitted, Gateway uses the time zone determined from the user's IP address. Colo time zone is used when the user's IP address does not resolve to a location.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#time_zone ZeroTrustGatewayPolicy#time_zone}
        /// </remarks>
        [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeZone
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specify the time intervals when the rule is active on Tuesdays, in the increasing order from 00:00-24:00.</summary>
        /// <remarks>
        /// If this parameter omitted, the rule is deactivated on Tuesdays. API returns a formatted version of this string, which may cause Terraform drift if a unformatted value is used.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#tue ZeroTrustGatewayPolicy#tue}
        /// </remarks>
        [JsiiProperty(name: "tue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Tue
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specify the time intervals when the rule is active on Wednesdays, in the increasing order from 00:00-24:00.</summary>
        /// <remarks>
        /// If this parameter omitted, the rule is deactivated on Wednesdays. API returns a formatted version of this string, which may cause Terraform drift if a unformatted value is used.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#wed ZeroTrustGatewayPolicy#wed}
        /// </remarks>
        [JsiiProperty(name: "wed", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Wed
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustGatewayPolicySchedule), fullyQualifiedName: "cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicySchedule")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicySchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specify the time intervals when the rule is active on Fridays, in the increasing order from 00:00-24:00.</summary>
            /// <remarks>
            /// If this parameter omitted, the rule is deactivated on Fridays. API returns a formatted version of this string, which may cause Terraform drift if a unformatted value is used.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#fri ZeroTrustGatewayPolicy#fri}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Fri
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specify the time intervals when the rule is active on Mondays, in the increasing order from 00:00-24:00(capped at maximum of 6 time splits).</summary>
            /// <remarks>
            /// If this parameter omitted, the rule is deactivated on Mondays. API returns a formatted version of this string, which may cause Terraform drift if a unformatted value is used.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#mon ZeroTrustGatewayPolicy#mon}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mon", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Mon
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specify the time intervals when the rule is active on Saturdays, in the increasing order from 00:00-24:00.</summary>
            /// <remarks>
            /// If this parameter omitted, the rule is deactivated on Saturdays. API returns a formatted version of this string, which may cause Terraform drift if a unformatted value is used.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#sat ZeroTrustGatewayPolicy#sat}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Sat
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specify the time intervals when the rule is active on Sundays, in the increasing order from 00:00-24:00.</summary>
            /// <remarks>
            /// If this parameter omitted, the rule is deactivated on Sundays. API returns a formatted version of this string, which may cause Terraform drift if a unformatted value is used.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#sun ZeroTrustGatewayPolicy#sun}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sun", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Sun
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specify the time intervals when the rule is active on Thursdays, in the increasing order from 00:00-24:00.</summary>
            /// <remarks>
            /// If this parameter omitted, the rule is deactivated on Thursdays. API returns a formatted version of this string, which may cause Terraform drift if a unformatted value is used.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#thu ZeroTrustGatewayPolicy#thu}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "thu", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Thu
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specify the time zone for rule evaluation.</summary>
            /// <remarks>
            /// When a <a href="https://en.wikipedia.org/wiki/List_of_tz_database_time_zones#List">valid time zone city name</a> is provided, Gateway always uses the current time for that time zone. When this parameter is omitted, Gateway uses the time zone determined from the user's IP address. Colo time zone is used when the user's IP address does not resolve to a location.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#time_zone ZeroTrustGatewayPolicy#time_zone}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeZone
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specify the time intervals when the rule is active on Tuesdays, in the increasing order from 00:00-24:00.</summary>
            /// <remarks>
            /// If this parameter omitted, the rule is deactivated on Tuesdays. API returns a formatted version of this string, which may cause Terraform drift if a unformatted value is used.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#tue ZeroTrustGatewayPolicy#tue}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Tue
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specify the time intervals when the rule is active on Wednesdays, in the increasing order from 00:00-24:00.</summary>
            /// <remarks>
            /// If this parameter omitted, the rule is deactivated on Wednesdays. API returns a formatted version of this string, which may cause Terraform drift if a unformatted value is used.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#wed ZeroTrustGatewayPolicy#wed}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "wed", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Wed
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
