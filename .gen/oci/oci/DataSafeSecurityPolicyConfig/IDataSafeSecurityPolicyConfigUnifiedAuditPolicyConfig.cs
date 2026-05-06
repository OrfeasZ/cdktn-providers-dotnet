using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSecurityPolicyConfig
{
    [JsiiInterface(nativeType: typeof(IDataSafeSecurityPolicyConfigUnifiedAuditPolicyConfig), fullyQualifiedName: "oci.dataSafeSecurityPolicyConfig.DataSafeSecurityPolicyConfigUnifiedAuditPolicyConfig")]
    public interface IDataSafeSecurityPolicyConfigUnifiedAuditPolicyConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_security_policy_config#exclude_datasafe_user DataSafeSecurityPolicyConfigA#exclude_datasafe_user}.</summary>
        [JsiiProperty(name: "excludeDatasafeUser", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExcludeDatasafeUser
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeSecurityPolicyConfigUnifiedAuditPolicyConfig), fullyQualifiedName: "oci.dataSafeSecurityPolicyConfig.DataSafeSecurityPolicyConfigUnifiedAuditPolicyConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeSecurityPolicyConfig.IDataSafeSecurityPolicyConfigUnifiedAuditPolicyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_security_policy_config#exclude_datasafe_user DataSafeSecurityPolicyConfigA#exclude_datasafe_user}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "excludeDatasafeUser", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExcludeDatasafeUser
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
