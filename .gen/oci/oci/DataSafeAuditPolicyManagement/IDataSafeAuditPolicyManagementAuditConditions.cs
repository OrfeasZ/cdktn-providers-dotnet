using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeAuditPolicyManagement
{
    [JsiiInterface(nativeType: typeof(IDataSafeAuditPolicyManagementAuditConditions), fullyQualifiedName: "oci.dataSafeAuditPolicyManagement.DataSafeAuditPolicyManagementAuditConditions")]
    public interface IDataSafeAuditPolicyManagementAuditConditions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_audit_policy_management#audit_policy_name DataSafeAuditPolicyManagement#audit_policy_name}.</summary>
        [JsiiProperty(name: "auditPolicyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuditPolicyName
        {
            get
            {
                return null;
            }
        }

        /// <summary>enable_conditions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_audit_policy_management#enable_conditions DataSafeAuditPolicyManagement#enable_conditions}
        /// </remarks>
        [JsiiProperty(name: "enableConditions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataSafeAuditPolicyManagement.DataSafeAuditPolicyManagementAuditConditionsEnableConditions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableConditions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_audit_policy_management#is_data_safe_service_account_audited DataSafeAuditPolicyManagement#is_data_safe_service_account_audited}.</summary>
        [JsiiProperty(name: "isDataSafeServiceAccountAudited", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsDataSafeServiceAccountAudited
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_audit_policy_management#is_enabled DataSafeAuditPolicyManagement#is_enabled}.</summary>
        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_audit_policy_management#is_priv_users_managed_by_data_safe DataSafeAuditPolicyManagement#is_priv_users_managed_by_data_safe}.</summary>
        [JsiiProperty(name: "isPrivUsersManagedByDataSafe", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsPrivUsersManagedByDataSafe
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeAuditPolicyManagementAuditConditions), fullyQualifiedName: "oci.dataSafeAuditPolicyManagement.DataSafeAuditPolicyManagementAuditConditions")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeAuditPolicyManagement.IDataSafeAuditPolicyManagementAuditConditions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_audit_policy_management#audit_policy_name DataSafeAuditPolicyManagement#audit_policy_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "auditPolicyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuditPolicyName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>enable_conditions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_audit_policy_management#enable_conditions DataSafeAuditPolicyManagement#enable_conditions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enableConditions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataSafeAuditPolicyManagement.DataSafeAuditPolicyManagementAuditConditionsEnableConditions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? EnableConditions
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_audit_policy_management#is_data_safe_service_account_audited DataSafeAuditPolicyManagement#is_data_safe_service_account_audited}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isDataSafeServiceAccountAudited", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsDataSafeServiceAccountAudited
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_audit_policy_management#is_enabled DataSafeAuditPolicyManagement#is_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_audit_policy_management#is_priv_users_managed_by_data_safe DataSafeAuditPolicyManagement#is_priv_users_managed_by_data_safe}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isPrivUsersManagedByDataSafe", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsPrivUsersManagedByDataSafe
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
