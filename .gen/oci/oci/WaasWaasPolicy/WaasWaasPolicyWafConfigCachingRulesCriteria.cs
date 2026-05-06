using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WaasWaasPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.waasWaasPolicy.WaasWaasPolicyWafConfigCachingRulesCriteria")]
    public class WaasWaasPolicyWafConfigCachingRulesCriteria : oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigCachingRulesCriteria
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#condition WaasWaasPolicy#condition}.</summary>
        [JsiiProperty(name: "condition", typeJson: "{\"primitive\":\"string\"}")]
        public string Condition
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#value WaasWaasPolicy#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
