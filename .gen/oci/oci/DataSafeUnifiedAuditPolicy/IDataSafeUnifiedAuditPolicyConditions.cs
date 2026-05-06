using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeUnifiedAuditPolicy
{
    [JsiiInterface(nativeType: typeof(IDataSafeUnifiedAuditPolicyConditions), fullyQualifiedName: "oci.dataSafeUnifiedAuditPolicy.DataSafeUnifiedAuditPolicyConditions")]
    public interface IDataSafeUnifiedAuditPolicyConditions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_unified_audit_policy#entity_selection DataSafeUnifiedAuditPolicy#entity_selection}.</summary>
        [JsiiProperty(name: "entitySelection", typeJson: "{\"primitive\":\"string\"}")]
        string EntitySelection
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_unified_audit_policy#entity_type DataSafeUnifiedAuditPolicy#entity_type}.</summary>
        [JsiiProperty(name: "entityType", typeJson: "{\"primitive\":\"string\"}")]
        string EntityType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_unified_audit_policy#operation_status DataSafeUnifiedAuditPolicy#operation_status}.</summary>
        [JsiiProperty(name: "operationStatus", typeJson: "{\"primitive\":\"string\"}")]
        string OperationStatus
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_unified_audit_policy#attribute_set_id DataSafeUnifiedAuditPolicy#attribute_set_id}.</summary>
        [JsiiProperty(name: "attributeSetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AttributeSetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_unified_audit_policy#role_names DataSafeUnifiedAuditPolicy#role_names}.</summary>
        [JsiiProperty(name: "roleNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? RoleNames
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_unified_audit_policy#user_names DataSafeUnifiedAuditPolicy#user_names}.</summary>
        [JsiiProperty(name: "userNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? UserNames
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeUnifiedAuditPolicyConditions), fullyQualifiedName: "oci.dataSafeUnifiedAuditPolicy.DataSafeUnifiedAuditPolicyConditions")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeUnifiedAuditPolicy.IDataSafeUnifiedAuditPolicyConditions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_unified_audit_policy#entity_selection DataSafeUnifiedAuditPolicy#entity_selection}.</summary>
            [JsiiProperty(name: "entitySelection", typeJson: "{\"primitive\":\"string\"}")]
            public string EntitySelection
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_unified_audit_policy#entity_type DataSafeUnifiedAuditPolicy#entity_type}.</summary>
            [JsiiProperty(name: "entityType", typeJson: "{\"primitive\":\"string\"}")]
            public string EntityType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_unified_audit_policy#operation_status DataSafeUnifiedAuditPolicy#operation_status}.</summary>
            [JsiiProperty(name: "operationStatus", typeJson: "{\"primitive\":\"string\"}")]
            public string OperationStatus
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_unified_audit_policy#attribute_set_id DataSafeUnifiedAuditPolicy#attribute_set_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "attributeSetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AttributeSetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_unified_audit_policy#role_names DataSafeUnifiedAuditPolicy#role_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "roleNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? RoleNames
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_unified_audit_policy#user_names DataSafeUnifiedAuditPolicy#user_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? UserNames
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
