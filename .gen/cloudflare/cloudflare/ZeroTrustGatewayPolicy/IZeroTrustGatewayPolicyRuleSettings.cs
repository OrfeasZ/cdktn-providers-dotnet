using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustGatewayPolicy
{
    [JsiiInterface(nativeType: typeof(IZeroTrustGatewayPolicyRuleSettings), fullyQualifiedName: "cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettings")]
    public interface IZeroTrustGatewayPolicyRuleSettings
    {
        /// <summary>Add custom headers to allowed requests as key-value pairs.</summary>
        /// <remarks>
        /// Use header names as keys that map to arrays of header values. Settable only for <c>http</c> rules with the action set to <c>allow</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#add_headers ZeroTrustGatewayPolicy#add_headers}
        /// </remarks>
        [JsiiProperty(name: "addHeaders", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AddHeaders
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set to enable MSP children to bypass this rule.</summary>
        /// <remarks>
        /// Only parent MSP accounts can set this. this rule. Settable for all types of rules.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#allow_child_bypass ZeroTrustGatewayPolicy#allow_child_bypass}
        /// </remarks>
        [JsiiProperty(name: "allowChildBypass", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowChildBypass
        {
            get
            {
                return null;
            }
        }

        /// <summary>Define the settings for the Audit SSH action. Settable only for `l4` rules with `audit_ssh` action.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#audit_ssh ZeroTrustGatewayPolicy#audit_ssh}
        /// </remarks>
        [JsiiProperty(name: "auditSsh", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsAuditSsh\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsAuditSsh? AuditSsh
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configure browser isolation behavior. Settable only for `http` rules with the action set to `isolate`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#biso_admin_controls ZeroTrustGatewayPolicy#biso_admin_controls}
        /// </remarks>
        [JsiiProperty(name: "bisoAdminControls", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsBisoAdminControls\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsBisoAdminControls? BisoAdminControls
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configure custom block page settings.</summary>
        /// <remarks>
        /// If missing or null, use the account settings. Settable only for <c>http</c> rules with the action set to <c>block</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#block_page ZeroTrustGatewayPolicy#block_page}
        /// </remarks>
        [JsiiProperty(name: "blockPage", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsBlockPage\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsBlockPage? BlockPage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enable the custom block page. Settable only for `dns` rules with action `block`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#block_page_enabled ZeroTrustGatewayPolicy#block_page_enabled}
        /// </remarks>
        [JsiiProperty(name: "blockPageEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BlockPageEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Explain why the rule blocks the request.</summary>
        /// <remarks>
        /// The custom block page shows this text (if enabled). Settable only for <c>dns</c>, <c>l4</c>, and <c>http</c> rules when the action set to <c>block</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#block_reason ZeroTrustGatewayPolicy#block_reason}
        /// </remarks>
        [JsiiProperty(name: "blockReason", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BlockReason
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set to enable MSP accounts to bypass their parent's rules.</summary>
        /// <remarks>
        /// Only MSP child accounts can set this. Settable for all types of rules.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#bypass_parent_rule ZeroTrustGatewayPolicy#bypass_parent_rule}
        /// </remarks>
        [JsiiProperty(name: "bypassParentRule", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BypassParentRule
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configure session check behavior. Settable only for `l4` and `http` rules with the action set to `allow`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#check_session ZeroTrustGatewayPolicy#check_session}
        /// </remarks>
        [JsiiProperty(name: "checkSession", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsCheckSession\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsCheckSession? CheckSession
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configure custom resolvers to route queries that match the resolver policy.</summary>
        /// <remarks>
        /// Unused with 'resolve_dns_through_cloudflare' or 'resolve_dns_internally' settings. DNS queries get routed to the address closest to their origin. Only valid when a rule's action set to 'resolve'. Settable only for <c>dns_resolver</c> rules.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#dns_resolvers ZeroTrustGatewayPolicy#dns_resolvers}
        /// </remarks>
        [JsiiProperty(name: "dnsResolvers", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsDnsResolvers\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsDnsResolvers? DnsResolvers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configure how Gateway Proxy traffic egresses.</summary>
        /// <remarks>
        /// You can enable this setting for rules with Egress actions and filters, or omit it to indicate local egress via WARP IPs. Settable only for <c>egress</c> rules.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#egress ZeroTrustGatewayPolicy#egress}
        /// </remarks>
        [JsiiProperty(name: "egress", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsEgress\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsEgress? Egress
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configure whether a copy of the HTTP request will be sent to storage when the rule matches.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#forensic_copy ZeroTrustGatewayPolicy#forensic_copy}
        /// </remarks>
        [JsiiProperty(name: "forensicCopy", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsForensicCopy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsForensicCopy? ForensicCopy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Ignore category matches at CNAME domains in a response.</summary>
        /// <remarks>
        /// When off, evaluate categories in this rule against all CNAME domain categories in the response. Settable only for <c>dns</c> and <c>dns_resolver</c> rules.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#ignore_cname_category_matches ZeroTrustGatewayPolicy#ignore_cname_category_matches}
        /// </remarks>
        [JsiiProperty(name: "ignoreCnameCategoryMatches", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IgnoreCnameCategoryMatches
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specify whether to disable DNSSEC validation (for Allow actions) [INSECURE]. Settable only for `dns` rules.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#insecure_disable_dnssec_validation ZeroTrustGatewayPolicy#insecure_disable_dnssec_validation}
        /// </remarks>
        [JsiiProperty(name: "insecureDisableDnssecValidation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InsecureDisableDnssecValidation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enable IPs in DNS resolver category blocks.</summary>
        /// <remarks>
        /// The system blocks only domain name categories unless you enable this setting. Settable only for <c>dns</c> and <c>dns_resolver</c> rules.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#ip_categories ZeroTrustGatewayPolicy#ip_categories}
        /// </remarks>
        [JsiiProperty(name: "ipCategories", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IpCategories
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicates whether to include IPs in DNS resolver indicator feed blocks.</summary>
        /// <remarks>
        /// Default, indicator feeds block only domain names. Settable only for <c>dns</c> and <c>dns_resolver</c> rules.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#ip_indicator_feeds ZeroTrustGatewayPolicy#ip_indicator_feeds}
        /// </remarks>
        [JsiiProperty(name: "ipIndicatorFeeds", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IpIndicatorFeeds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Send matching traffic to the supplied destination IP address and port.</summary>
        /// <remarks>
        /// Settable only for <c>l4</c> rules with the action set to <c>l4_override</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#l4override ZeroTrustGatewayPolicy#l4override}
        /// </remarks>
        [JsiiProperty(name: "l4Override", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsL4Override\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsL4Override? L4Override
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configure a notification to display on the user's device when this rule matched.</summary>
        /// <remarks>
        /// Settable for all types of rules with the action set to <c>block</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#notification_settings ZeroTrustGatewayPolicy#notification_settings}
        /// </remarks>
        [JsiiProperty(name: "notificationSettings", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsNotificationSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsNotificationSettings? NotificationSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines a hostname for override, for the matching DNS queries.</summary>
        /// <remarks>
        /// Settable only for <c>dns</c> rules with the action set to <c>override</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#override_host ZeroTrustGatewayPolicy#override_host}
        /// </remarks>
        [JsiiProperty(name: "overrideHost", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OverrideHost
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines a an IP or set of IPs for overriding matched DNS queries.</summary>
        /// <remarks>
        /// Settable only for <c>dns</c> rules with the action set to <c>override</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#override_ips ZeroTrustGatewayPolicy#override_ips}
        /// </remarks>
        [JsiiProperty(name: "overrideIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? OverrideIps
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configure DLP payload logging. Settable only for `http` rules.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#payload_log ZeroTrustGatewayPolicy#payload_log}
        /// </remarks>
        [JsiiProperty(name: "payloadLog", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsPayloadLog\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsPayloadLog? PayloadLog
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configure settings that apply to quarantine rules. Settable only for `http` rules.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#quarantine ZeroTrustGatewayPolicy#quarantine}
        /// </remarks>
        [JsiiProperty(name: "quarantine", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsQuarantine\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsQuarantine? Quarantine
        {
            get
            {
                return null;
            }
        }

        /// <summary>Apply settings to redirect rules. Settable only for `http` rules with the action set to `redirect`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#redirect ZeroTrustGatewayPolicy#redirect}
        /// </remarks>
        [JsiiProperty(name: "redirect", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsRedirect\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsRedirect? Redirect
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configure to forward the query to the internal DNS service, passing the specified 'view_id' as input.</summary>
        /// <remarks>
        /// Not used when 'dns_resolvers' is specified or 'resolve_dns_through_cloudflare' is set. Only valid when a rule's action set to 'resolve'. Settable only for <c>dns_resolver</c> rules.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#resolve_dns_internally ZeroTrustGatewayPolicy#resolve_dns_internally}
        /// </remarks>
        [JsiiProperty(name: "resolveDnsInternally", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsResolveDnsInternally\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsResolveDnsInternally? ResolveDnsInternally
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enable to send queries that match the policy to Cloudflare's default 1.1.1.1 DNS resolver. Cannot set when 'dns_resolvers' specified or 'resolve_dns_internally' is set. Only valid when a rule's action set to 'resolve'. Settable only for `dns_resolver` rules.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#resolve_dns_through_cloudflare ZeroTrustGatewayPolicy#resolve_dns_through_cloudflare}
        /// </remarks>
        [JsiiProperty(name: "resolveDnsThroughCloudflare", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResolveDnsThroughCloudflare
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configure behavior when an upstream certificate is invalid or an SSL error occurs.</summary>
        /// <remarks>
        /// Settable only for <c>http</c> rules with the action set to <c>allow</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#untrusted_cert ZeroTrustGatewayPolicy#untrusted_cert}
        /// </remarks>
        [JsiiProperty(name: "untrustedCert", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsUntrustedCert\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsUntrustedCert? UntrustedCert
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustGatewayPolicyRuleSettings), fullyQualifiedName: "cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettings")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Add custom headers to allowed requests as key-value pairs.</summary>
            /// <remarks>
            /// Use header names as keys that map to arrays of header values. Settable only for <c>http</c> rules with the action set to <c>allow</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#add_headers ZeroTrustGatewayPolicy#add_headers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "addHeaders", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? AddHeaders
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Set to enable MSP children to bypass this rule.</summary>
            /// <remarks>
            /// Only parent MSP accounts can set this. this rule. Settable for all types of rules.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#allow_child_bypass ZeroTrustGatewayPolicy#allow_child_bypass}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowChildBypass", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AllowChildBypass
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Define the settings for the Audit SSH action. Settable only for `l4` rules with `audit_ssh` action.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#audit_ssh ZeroTrustGatewayPolicy#audit_ssh}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "auditSsh", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsAuditSsh\"}", isOptional: true)]
            public cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsAuditSsh? AuditSsh
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsAuditSsh?>();
            }

            /// <summary>Configure browser isolation behavior. Settable only for `http` rules with the action set to `isolate`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#biso_admin_controls ZeroTrustGatewayPolicy#biso_admin_controls}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bisoAdminControls", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsBisoAdminControls\"}", isOptional: true)]
            public cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsBisoAdminControls? BisoAdminControls
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsBisoAdminControls?>();
            }

            /// <summary>Configure custom block page settings.</summary>
            /// <remarks>
            /// If missing or null, use the account settings. Settable only for <c>http</c> rules with the action set to <c>block</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#block_page ZeroTrustGatewayPolicy#block_page}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "blockPage", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsBlockPage\"}", isOptional: true)]
            public cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsBlockPage? BlockPage
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsBlockPage?>();
            }

            /// <summary>Enable the custom block page. Settable only for `dns` rules with action `block`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#block_page_enabled ZeroTrustGatewayPolicy#block_page_enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "blockPageEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? BlockPageEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Explain why the rule blocks the request.</summary>
            /// <remarks>
            /// The custom block page shows this text (if enabled). Settable only for <c>dns</c>, <c>l4</c>, and <c>http</c> rules when the action set to <c>block</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#block_reason ZeroTrustGatewayPolicy#block_reason}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "blockReason", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BlockReason
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Set to enable MSP accounts to bypass their parent's rules.</summary>
            /// <remarks>
            /// Only MSP child accounts can set this. Settable for all types of rules.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#bypass_parent_rule ZeroTrustGatewayPolicy#bypass_parent_rule}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bypassParentRule", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? BypassParentRule
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configure session check behavior. Settable only for `l4` and `http` rules with the action set to `allow`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#check_session ZeroTrustGatewayPolicy#check_session}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "checkSession", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsCheckSession\"}", isOptional: true)]
            public cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsCheckSession? CheckSession
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsCheckSession?>();
            }

            /// <summary>Configure custom resolvers to route queries that match the resolver policy.</summary>
            /// <remarks>
            /// Unused with 'resolve_dns_through_cloudflare' or 'resolve_dns_internally' settings. DNS queries get routed to the address closest to their origin. Only valid when a rule's action set to 'resolve'. Settable only for <c>dns_resolver</c> rules.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#dns_resolvers ZeroTrustGatewayPolicy#dns_resolvers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dnsResolvers", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsDnsResolvers\"}", isOptional: true)]
            public cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsDnsResolvers? DnsResolvers
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsDnsResolvers?>();
            }

            /// <summary>Configure how Gateway Proxy traffic egresses.</summary>
            /// <remarks>
            /// You can enable this setting for rules with Egress actions and filters, or omit it to indicate local egress via WARP IPs. Settable only for <c>egress</c> rules.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#egress ZeroTrustGatewayPolicy#egress}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "egress", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsEgress\"}", isOptional: true)]
            public cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsEgress? Egress
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsEgress?>();
            }

            /// <summary>Configure whether a copy of the HTTP request will be sent to storage when the rule matches.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#forensic_copy ZeroTrustGatewayPolicy#forensic_copy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forensicCopy", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsForensicCopy\"}", isOptional: true)]
            public cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsForensicCopy? ForensicCopy
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsForensicCopy?>();
            }

            /// <summary>Ignore category matches at CNAME domains in a response.</summary>
            /// <remarks>
            /// When off, evaluate categories in this rule against all CNAME domain categories in the response. Settable only for <c>dns</c> and <c>dns_resolver</c> rules.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#ignore_cname_category_matches ZeroTrustGatewayPolicy#ignore_cname_category_matches}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ignoreCnameCategoryMatches", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IgnoreCnameCategoryMatches
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Specify whether to disable DNSSEC validation (for Allow actions) [INSECURE]. Settable only for `dns` rules.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#insecure_disable_dnssec_validation ZeroTrustGatewayPolicy#insecure_disable_dnssec_validation}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "insecureDisableDnssecValidation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? InsecureDisableDnssecValidation
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Enable IPs in DNS resolver category blocks.</summary>
            /// <remarks>
            /// The system blocks only domain name categories unless you enable this setting. Settable only for <c>dns</c> and <c>dns_resolver</c> rules.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#ip_categories ZeroTrustGatewayPolicy#ip_categories}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipCategories", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IpCategories
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Indicates whether to include IPs in DNS resolver indicator feed blocks.</summary>
            /// <remarks>
            /// Default, indicator feeds block only domain names. Settable only for <c>dns</c> and <c>dns_resolver</c> rules.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#ip_indicator_feeds ZeroTrustGatewayPolicy#ip_indicator_feeds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipIndicatorFeeds", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IpIndicatorFeeds
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Send matching traffic to the supplied destination IP address and port.</summary>
            /// <remarks>
            /// Settable only for <c>l4</c> rules with the action set to <c>l4_override</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#l4override ZeroTrustGatewayPolicy#l4override}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "l4Override", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsL4Override\"}", isOptional: true)]
            public cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsL4Override? L4Override
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsL4Override?>();
            }

            /// <summary>Configure a notification to display on the user's device when this rule matched.</summary>
            /// <remarks>
            /// Settable for all types of rules with the action set to <c>block</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#notification_settings ZeroTrustGatewayPolicy#notification_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "notificationSettings", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsNotificationSettings\"}", isOptional: true)]
            public cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsNotificationSettings? NotificationSettings
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsNotificationSettings?>();
            }

            /// <summary>Defines a hostname for override, for the matching DNS queries.</summary>
            /// <remarks>
            /// Settable only for <c>dns</c> rules with the action set to <c>override</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#override_host ZeroTrustGatewayPolicy#override_host}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "overrideHost", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OverrideHost
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Defines a an IP or set of IPs for overriding matched DNS queries.</summary>
            /// <remarks>
            /// Settable only for <c>dns</c> rules with the action set to <c>override</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#override_ips ZeroTrustGatewayPolicy#override_ips}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "overrideIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? OverrideIps
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Configure DLP payload logging. Settable only for `http` rules.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#payload_log ZeroTrustGatewayPolicy#payload_log}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "payloadLog", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsPayloadLog\"}", isOptional: true)]
            public cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsPayloadLog? PayloadLog
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsPayloadLog?>();
            }

            /// <summary>Configure settings that apply to quarantine rules. Settable only for `http` rules.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#quarantine ZeroTrustGatewayPolicy#quarantine}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "quarantine", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsQuarantine\"}", isOptional: true)]
            public cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsQuarantine? Quarantine
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsQuarantine?>();
            }

            /// <summary>Apply settings to redirect rules. Settable only for `http` rules with the action set to `redirect`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#redirect ZeroTrustGatewayPolicy#redirect}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "redirect", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsRedirect\"}", isOptional: true)]
            public cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsRedirect? Redirect
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsRedirect?>();
            }

            /// <summary>Configure to forward the query to the internal DNS service, passing the specified 'view_id' as input.</summary>
            /// <remarks>
            /// Not used when 'dns_resolvers' is specified or 'resolve_dns_through_cloudflare' is set. Only valid when a rule's action set to 'resolve'. Settable only for <c>dns_resolver</c> rules.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#resolve_dns_internally ZeroTrustGatewayPolicy#resolve_dns_internally}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resolveDnsInternally", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsResolveDnsInternally\"}", isOptional: true)]
            public cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsResolveDnsInternally? ResolveDnsInternally
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsResolveDnsInternally?>();
            }

            /// <summary>Enable to send queries that match the policy to Cloudflare's default 1.1.1.1 DNS resolver. Cannot set when 'dns_resolvers' specified or 'resolve_dns_internally' is set. Only valid when a rule's action set to 'resolve'. Settable only for `dns_resolver` rules.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#resolve_dns_through_cloudflare ZeroTrustGatewayPolicy#resolve_dns_through_cloudflare}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resolveDnsThroughCloudflare", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ResolveDnsThroughCloudflare
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configure behavior when an upstream certificate is invalid or an SSL error occurs.</summary>
            /// <remarks>
            /// Settable only for <c>http</c> rules with the action set to <c>allow</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#untrusted_cert ZeroTrustGatewayPolicy#untrusted_cert}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "untrustedCert", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsUntrustedCert\"}", isOptional: true)]
            public cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsUntrustedCert? UntrustedCert
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsUntrustedCert?>();
            }
        }
    }
}
