using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSubsettingPolicySubsettingRule
{
    [JsiiInterface(nativeType: typeof(IDataSafeSubsettingPolicySubsettingRuleScope), fullyQualifiedName: "oci.dataSafeSubsettingPolicySubsettingRule.DataSafeSubsettingPolicySubsettingRuleScope")]
    public interface IDataSafeSubsettingPolicySubsettingRuleScope
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#schema_name DataSafeSubsettingPolicySubsettingRule#schema_name}.</summary>
        [JsiiProperty(name: "schemaName", typeJson: "{\"primitive\":\"string\"}")]
        string SchemaName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#scope_type DataSafeSubsettingPolicySubsettingRule#scope_type}.</summary>
        [JsiiProperty(name: "scopeType", typeJson: "{\"primitive\":\"string\"}")]
        string ScopeType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#object DataSafeSubsettingPolicySubsettingRule#object}.</summary>
        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Object
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeSubsettingPolicySubsettingRuleScope), fullyQualifiedName: "oci.dataSafeSubsettingPolicySubsettingRule.DataSafeSubsettingPolicySubsettingRuleScope")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeSubsettingPolicySubsettingRule.IDataSafeSubsettingPolicySubsettingRuleScope
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#schema_name DataSafeSubsettingPolicySubsettingRule#schema_name}.</summary>
            [JsiiProperty(name: "schemaName", typeJson: "{\"primitive\":\"string\"}")]
            public string SchemaName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#scope_type DataSafeSubsettingPolicySubsettingRule#scope_type}.</summary>
            [JsiiProperty(name: "scopeType", typeJson: "{\"primitive\":\"string\"}")]
            public string ScopeType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_subsetting_rule#object DataSafeSubsettingPolicySubsettingRule#object}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Object
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
