using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeAuditPolicyManagement
{
    [JsiiByValue(fqn: "oci.dataSafeAuditPolicyManagement.DataSafeAuditPolicyManagementAuditConditionsEnableConditions")]
    public class DataSafeAuditPolicyManagementAuditConditionsEnableConditions : oci.DataSafeAuditPolicyManagement.IDataSafeAuditPolicyManagementAuditConditionsEnableConditions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_audit_policy_management#entity_names DataSafeAuditPolicyManagement#entity_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "entityNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? EntityNames
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_audit_policy_management#entity_selection DataSafeAuditPolicyManagement#entity_selection}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "entitySelection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EntitySelection
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_audit_policy_management#entity_type DataSafeAuditPolicyManagement#entity_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "entityType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EntityType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_audit_policy_management#operation_status DataSafeAuditPolicyManagement#operation_status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "operationStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OperationStatus
        {
            get;
            set;
        }
    }
}
