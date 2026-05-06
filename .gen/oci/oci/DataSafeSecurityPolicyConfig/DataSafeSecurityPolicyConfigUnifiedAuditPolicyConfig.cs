using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSecurityPolicyConfig
{
    [JsiiByValue(fqn: "oci.dataSafeSecurityPolicyConfig.DataSafeSecurityPolicyConfigUnifiedAuditPolicyConfig")]
    public class DataSafeSecurityPolicyConfigUnifiedAuditPolicyConfig : oci.DataSafeSecurityPolicyConfig.IDataSafeSecurityPolicyConfigUnifiedAuditPolicyConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_security_policy_config#exclude_datasafe_user DataSafeSecurityPolicyConfigA#exclude_datasafe_user}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludeDatasafeUser", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExcludeDatasafeUser
        {
            get;
            set;
        }
    }
}
