using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WaasProtectionRule
{
    [JsiiByValue(fqn: "oci.waasProtectionRule.WaasProtectionRuleExclusions")]
    public class WaasProtectionRuleExclusions : oci.WaasProtectionRule.IWaasProtectionRuleExclusions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_protection_rule#exclusions WaasProtectionRule#exclusions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "exclusions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Exclusions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_protection_rule#target WaasProtectionRule#target}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Target
        {
            get;
            set;
        }
    }
}
