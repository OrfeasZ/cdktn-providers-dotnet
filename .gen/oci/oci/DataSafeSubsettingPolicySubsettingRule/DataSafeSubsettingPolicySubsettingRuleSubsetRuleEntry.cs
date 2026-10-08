using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSubsettingPolicySubsettingRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.dataSafeSubsettingPolicySubsettingRule.DataSafeSubsettingPolicySubsettingRuleSubsetRuleEntry")]
    public class DataSafeSubsettingPolicySubsettingRuleSubsetRuleEntry : oci.DataSafeSubsettingPolicySubsettingRule.IDataSafeSubsettingPolicySubsettingRuleSubsetRuleEntry
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#rule_type DataSafeSubsettingPolicySubsettingRule#rule_type}.</summary>
        [JsiiProperty(name: "ruleType", typeJson: "{\"primitive\":\"string\"}")]
        public string RuleType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#condition DataSafeSubsettingPolicySubsettingRule#condition}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "condition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Condition
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#partitions_list DataSafeSubsettingPolicySubsettingRule#partitions_list}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "partitionsList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PartitionsList
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#percent DataSafeSubsettingPolicySubsettingRule#percent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "percent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Percent
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#sub_partitions_list DataSafeSubsettingPolicySubsettingRule#sub_partitions_list}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subPartitionsList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SubPartitionsList
        {
            get;
            set;
        }
    }
}
