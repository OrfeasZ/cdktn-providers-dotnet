using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WafWebAppFirewallPolicy
{
    [JsiiByValue(fqn: "oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyRequestProtectionRulesProtectionCapabilitySettings")]
    public class WafWebAppFirewallPolicyRequestProtectionRulesProtectionCapabilitySettings : oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyRequestProtectionRulesProtectionCapabilitySettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#allowed_http_methods WafWebAppFirewallPolicy#allowed_http_methods}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowedHttpMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowedHttpMethods
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#max_http_request_header_length WafWebAppFirewallPolicy#max_http_request_header_length}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxHttpRequestHeaderLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxHttpRequestHeaderLength
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#max_http_request_headers WafWebAppFirewallPolicy#max_http_request_headers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxHttpRequestHeaders", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxHttpRequestHeaders
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#max_number_of_arguments WafWebAppFirewallPolicy#max_number_of_arguments}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxNumberOfArguments", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxNumberOfArguments
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#max_single_argument_length WafWebAppFirewallPolicy#max_single_argument_length}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxSingleArgumentLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxSingleArgumentLength
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#max_total_argument_length WafWebAppFirewallPolicy#max_total_argument_length}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxTotalArgumentLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxTotalArgumentLength
        {
            get;
            set;
        }
    }
}
