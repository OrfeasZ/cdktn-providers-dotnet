using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSecurityPolicyConfig
{
    [JsiiInterface(nativeType: typeof(IDataSafeSecurityPolicyConfigFirewallConfig), fullyQualifiedName: "oci.dataSafeSecurityPolicyConfig.DataSafeSecurityPolicyConfigFirewallConfig")]
    public interface IDataSafeSecurityPolicyConfigFirewallConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_security_policy_config#exclude_job DataSafeSecurityPolicyConfigA#exclude_job}.</summary>
        [JsiiProperty(name: "excludeJob", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExcludeJob
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_security_policy_config#status DataSafeSecurityPolicyConfigA#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Status
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_security_policy_config#violation_log_auto_purge DataSafeSecurityPolicyConfigA#violation_log_auto_purge}.</summary>
        [JsiiProperty(name: "violationLogAutoPurge", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ViolationLogAutoPurge
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeSecurityPolicyConfigFirewallConfig), fullyQualifiedName: "oci.dataSafeSecurityPolicyConfig.DataSafeSecurityPolicyConfigFirewallConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeSecurityPolicyConfig.IDataSafeSecurityPolicyConfigFirewallConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_security_policy_config#exclude_job DataSafeSecurityPolicyConfigA#exclude_job}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "excludeJob", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExcludeJob
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_security_policy_config#status DataSafeSecurityPolicyConfigA#status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_security_policy_config#violation_log_auto_purge DataSafeSecurityPolicyConfigA#violation_log_auto_purge}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "violationLogAutoPurge", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ViolationLogAutoPurge
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
