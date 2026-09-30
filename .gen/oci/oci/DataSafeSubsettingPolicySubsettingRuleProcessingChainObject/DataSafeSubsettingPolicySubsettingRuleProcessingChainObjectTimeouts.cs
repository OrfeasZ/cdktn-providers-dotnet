using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSubsettingPolicySubsettingRuleProcessingChainObject
{
    [JsiiByValue(fqn: "oci.dataSafeSubsettingPolicySubsettingRuleProcessingChainObject.DataSafeSubsettingPolicySubsettingRuleProcessingChainObjectTimeouts")]
    public class DataSafeSubsettingPolicySubsettingRuleProcessingChainObjectTimeouts : oci.DataSafeSubsettingPolicySubsettingRuleProcessingChainObject.IDataSafeSubsettingPolicySubsettingRuleProcessingChainObjectTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subsetting_policy_subsetting_rule_processing_chain_object#create DataSafeSubsettingPolicySubsettingRuleProcessingChainObject#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subsetting_policy_subsetting_rule_processing_chain_object#delete DataSafeSubsettingPolicySubsettingRuleProcessingChainObject#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subsetting_policy_subsetting_rule_processing_chain_object#update DataSafeSubsettingPolicySubsettingRuleProcessingChainObject#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
