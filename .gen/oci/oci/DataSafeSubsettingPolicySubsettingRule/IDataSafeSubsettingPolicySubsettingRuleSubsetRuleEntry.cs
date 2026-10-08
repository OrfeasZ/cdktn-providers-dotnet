using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSubsettingPolicySubsettingRule
{
    [JsiiInterface(nativeType: typeof(IDataSafeSubsettingPolicySubsettingRuleSubsetRuleEntry), fullyQualifiedName: "oci.dataSafeSubsettingPolicySubsettingRule.DataSafeSubsettingPolicySubsettingRuleSubsetRuleEntry")]
    public interface IDataSafeSubsettingPolicySubsettingRuleSubsetRuleEntry
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#rule_type DataSafeSubsettingPolicySubsettingRule#rule_type}.</summary>
        [JsiiProperty(name: "ruleType", typeJson: "{\"primitive\":\"string\"}")]
        string RuleType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#condition DataSafeSubsettingPolicySubsettingRule#condition}.</summary>
        [JsiiProperty(name: "condition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Condition
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#partitions_list DataSafeSubsettingPolicySubsettingRule#partitions_list}.</summary>
        [JsiiProperty(name: "partitionsList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PartitionsList
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#percent DataSafeSubsettingPolicySubsettingRule#percent}.</summary>
        [JsiiProperty(name: "percent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Percent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#sub_partitions_list DataSafeSubsettingPolicySubsettingRule#sub_partitions_list}.</summary>
        [JsiiProperty(name: "subPartitionsList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SubPartitionsList
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeSubsettingPolicySubsettingRuleSubsetRuleEntry), fullyQualifiedName: "oci.dataSafeSubsettingPolicySubsettingRule.DataSafeSubsettingPolicySubsettingRuleSubsetRuleEntry")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeSubsettingPolicySubsettingRule.IDataSafeSubsettingPolicySubsettingRuleSubsetRuleEntry
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#rule_type DataSafeSubsettingPolicySubsettingRule#rule_type}.</summary>
            [JsiiProperty(name: "ruleType", typeJson: "{\"primitive\":\"string\"}")]
            public string RuleType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#condition DataSafeSubsettingPolicySubsettingRule#condition}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "condition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Condition
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#partitions_list DataSafeSubsettingPolicySubsettingRule#partitions_list}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "partitionsList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PartitionsList
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#percent DataSafeSubsettingPolicySubsettingRule#percent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "percent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Percent
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#sub_partitions_list DataSafeSubsettingPolicySubsettingRule#sub_partitions_list}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subPartitionsList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SubPartitionsList
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
