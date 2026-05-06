using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeUnifiedAuditPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.dataSafeUnifiedAuditPolicy.DataSafeUnifiedAuditPolicyConditions")]
    public class DataSafeUnifiedAuditPolicyConditions : oci.DataSafeUnifiedAuditPolicy.IDataSafeUnifiedAuditPolicyConditions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_unified_audit_policy#entity_selection DataSafeUnifiedAuditPolicy#entity_selection}.</summary>
        [JsiiProperty(name: "entitySelection", typeJson: "{\"primitive\":\"string\"}")]
        public string EntitySelection
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_unified_audit_policy#entity_type DataSafeUnifiedAuditPolicy#entity_type}.</summary>
        [JsiiProperty(name: "entityType", typeJson: "{\"primitive\":\"string\"}")]
        public string EntityType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_unified_audit_policy#operation_status DataSafeUnifiedAuditPolicy#operation_status}.</summary>
        [JsiiProperty(name: "operationStatus", typeJson: "{\"primitive\":\"string\"}")]
        public string OperationStatus
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_unified_audit_policy#attribute_set_id DataSafeUnifiedAuditPolicy#attribute_set_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "attributeSetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AttributeSetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_unified_audit_policy#role_names DataSafeUnifiedAuditPolicy#role_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "roleNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? RoleNames
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_unified_audit_policy#user_names DataSafeUnifiedAuditPolicy#user_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? UserNames
        {
            get;
            set;
        }
    }
}
