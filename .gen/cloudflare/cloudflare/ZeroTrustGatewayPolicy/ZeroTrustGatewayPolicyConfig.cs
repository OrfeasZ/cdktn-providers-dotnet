using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustGatewayPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyConfig")]
    public class ZeroTrustGatewayPolicyConfig : cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#account_id ZeroTrustGatewayPolicy#account_id}.</summary>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public string AccountId
        {
            get;
            set;
        }

        /// <summary>Specify the action to perform when the associated traffic, identity, and device posture expressions either absent or evaluate to `true`.</summary>
        /// <remarks>
        /// Available values: "on", "off", "allow", "block", "scan", "noscan", "safesearch", "ytrestricted", "isolate", "noisolate", "override", "l4_override", "egress", "resolve", "quarantine", "redirect".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#action ZeroTrustGatewayPolicy#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public string Action
        {
            get;
            set;
        }

        /// <summary>Specify the rule name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#name ZeroTrustGatewayPolicy#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Specify the rule description.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#description ZeroTrustGatewayPolicy#description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Specify the wirefilter expression used for device posture check.</summary>
        /// <remarks>
        /// The API automatically formats and sanitizes expressions before storing them. To prevent Terraform state drift, use the formatted expression returned in the API response.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#device_posture ZeroTrustGatewayPolicy#device_posture}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "devicePosture", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DevicePosture
        {
            get;
            set;
        }

        private object? _enabled;

        /// <summary>Specify whether the rule is enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#enabled ZeroTrustGatewayPolicy#enabled}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Enabled
        {
            get => _enabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enabled = value;
            }
        }

        /// <summary>Defines the expiration time stamp and default duration of a DNS policy.</summary>
        /// <remarks>
        /// Takes precedence over the policy's <c>schedule</c> configuration, if any. This  does not apply to HTTP or network policies. Settable only for <c>dns</c> rules.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#expiration ZeroTrustGatewayPolicy#expiration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "expiration", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyExpiration\"}", isOptional: true)]
        public cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyExpiration? Expiration
        {
            get;
            set;
        }

        /// <summary>Specify the protocol or layer to evaluate the traffic, identity, and device posture expressions.</summary>
        /// <remarks>
        /// Can only contain a single value.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#filters ZeroTrustGatewayPolicy#filters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Filters
        {
            get;
            set;
        }

        /// <summary>Specify the wirefilter expression used for identity matching.</summary>
        /// <remarks>
        /// The API automatically formats and sanitizes expressions before storing them. To prevent Terraform state drift, use the formatted expression returned in the API response.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#identity ZeroTrustGatewayPolicy#identity}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "identity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Identity
        {
            get;
            set;
        }

        /// <summary>Set the order of your rules.</summary>
        /// <remarks>
        /// Lower values indicate higher precedence. At each processing phase, evaluate applicable rules in ascending order of this value. Refer to <a href="http://developers.cloudflare.com/learning-paths/secure-internet-traffic/understand-policies/order-of-enforcement/#manage-precedence-with-terraform">Order of enforcement</a> to manage precedence via Terraform.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#precedence ZeroTrustGatewayPolicy#precedence}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "precedence", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Precedence
        {
            get;
            set;
        }

        /// <summary>Defines settings for this rule.</summary>
        /// <remarks>
        /// Settings apply only to specific rule types and must use compatible selectors. If Terraform detects drift, confirm the setting supports your rule type and check whether the API modifies the value. Use API-returned values in your configuration to prevent drift.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#rule_settings ZeroTrustGatewayPolicy#rule_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ruleSettings", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettings\"}", isOptional: true)]
        public cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettings? RuleSettings
        {
            get;
            set;
        }

        /// <summary>Defines the schedule for activating DNS policies. Settable only for `dns` and `dns_resolver` rules.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#schedule ZeroTrustGatewayPolicy#schedule}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "schedule", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicySchedule\"}", isOptional: true)]
        public cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicySchedule? Schedule
        {
            get;
            set;
        }

        /// <summary>Specify the wirefilter expression used for traffic matching.</summary>
        /// <remarks>
        /// The API automatically formats and sanitizes expressions before storing them. To prevent Terraform state drift, use the formatted expression returned in the API response.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#traffic ZeroTrustGatewayPolicy#traffic}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "traffic", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Traffic
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}
