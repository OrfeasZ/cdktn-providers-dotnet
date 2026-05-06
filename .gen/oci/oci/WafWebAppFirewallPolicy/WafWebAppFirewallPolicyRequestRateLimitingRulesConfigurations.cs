using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WafWebAppFirewallPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyRequestRateLimitingRulesConfigurations")]
    public class WafWebAppFirewallPolicyRequestRateLimitingRulesConfigurations : oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyRequestRateLimitingRulesConfigurations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#period_in_seconds WafWebAppFirewallPolicy#period_in_seconds}.</summary>
        [JsiiProperty(name: "periodInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public double PeriodInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#requests_limit WafWebAppFirewallPolicy#requests_limit}.</summary>
        [JsiiProperty(name: "requestsLimit", typeJson: "{\"primitive\":\"number\"}")]
        public double RequestsLimit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#action_duration_in_seconds WafWebAppFirewallPolicy#action_duration_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "actionDurationInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ActionDurationInSeconds
        {
            get;
            set;
        }
    }
}
