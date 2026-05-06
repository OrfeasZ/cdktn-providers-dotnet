using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WafWebAppFirewallPolicy
{
    [JsiiByValue(fqn: "oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyRequestRateLimiting")]
    public class WafWebAppFirewallPolicyRequestRateLimiting : oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyRequestRateLimiting
    {
        private object? _rules;

        /// <summary>rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#rules WafWebAppFirewallPolicy#rules}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyRequestRateLimitingRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Rules
        {
            get => _rules;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyRequestRateLimitingRules[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyRequestRateLimitingRules).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _rules = value;
            }
        }
    }
}
