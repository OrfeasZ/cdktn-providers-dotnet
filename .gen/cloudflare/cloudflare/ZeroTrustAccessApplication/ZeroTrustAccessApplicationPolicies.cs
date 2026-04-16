using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPolicies")]
    public class ZeroTrustAccessApplicationPolicies : cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPolicies
    {
        /// <summary>The rules that define how users may connect to the targets secured by your application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#connection_rules ZeroTrustAccessApplication#connection_rules}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connectionRules", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesConnectionRules\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesConnectionRules? ConnectionRules
        {
            get;
            set;
        }

        /// <summary>The action Access will take if a user matches this policy.</summary>
        /// <remarks>
        /// Infrastructure application policies can only use the Allow action.
        /// Available values: "allow", "deny", "non_identity", "bypass".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#decision ZeroTrustAccessApplication#decision}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "decision", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Decision
        {
            get;
            set;
        }

        private object? _exclude;

        /// <summary>Rules evaluated with a NOT logical operator.</summary>
        /// <remarks>
        /// To match the policy, a user cannot meet any of the Exclude rules.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#exclude ZeroTrustAccessApplication#exclude}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "exclude", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExclude\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Exclude
        {
            get => _exclude;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExclude[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExclude).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _exclude = value;
            }
        }

        /// <summary>The UUID of the policy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#id ZeroTrustAccessApplication#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        private object? _include;

        /// <summary>Rules evaluated with an OR logical operator. A user needs to meet only one of the Include rules.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#include ZeroTrustAccessApplication#include}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "include", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesInclude\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Include
        {
            get => _include;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesInclude[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesInclude).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _include = value;
            }
        }

        /// <summary>The name of the Access policy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#name ZeroTrustAccessApplication#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>The order of execution for this policy. Must be unique for each policy within an app.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#precedence ZeroTrustAccessApplication#precedence}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "precedence", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Precedence
        {
            get;
            set;
        }

        private object? _require;

        /// <summary>Rules evaluated with an AND logical operator.</summary>
        /// <remarks>
        /// To match the policy, a user must meet all of the Require rules.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#require ZeroTrustAccessApplication#require}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "require", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequire\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Require
        {
            get => _require;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequire[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequire).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _require = value;
            }
        }
    }
}
