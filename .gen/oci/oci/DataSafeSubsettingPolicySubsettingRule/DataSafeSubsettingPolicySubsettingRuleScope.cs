using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSubsettingPolicySubsettingRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.dataSafeSubsettingPolicySubsettingRule.DataSafeSubsettingPolicySubsettingRuleScope")]
    public class DataSafeSubsettingPolicySubsettingRuleScope : oci.DataSafeSubsettingPolicySubsettingRule.IDataSafeSubsettingPolicySubsettingRuleScope
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#schema_name DataSafeSubsettingPolicySubsettingRule#schema_name}.</summary>
        [JsiiProperty(name: "schemaName", typeJson: "{\"primitive\":\"string\"}")]
        public string SchemaName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#scope_type DataSafeSubsettingPolicySubsettingRule#scope_type}.</summary>
        [JsiiProperty(name: "scopeType", typeJson: "{\"primitive\":\"string\"}")]
        public string ScopeType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#object DataSafeSubsettingPolicySubsettingRule#object}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Object
        {
            get;
            set;
        }
    }
}
