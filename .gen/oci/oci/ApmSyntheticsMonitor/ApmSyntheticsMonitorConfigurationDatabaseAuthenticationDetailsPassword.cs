using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmSyntheticsMonitor
{
    [JsiiByValue(fqn: "oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationDatabaseAuthenticationDetailsPassword")]
    public class ApmSyntheticsMonitorConfigurationDatabaseAuthenticationDetailsPassword : oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationDatabaseAuthenticationDetailsPassword
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#password ApmSyntheticsMonitor#password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Password
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#password_type ApmSyntheticsMonitor#password_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "passwordType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PasswordType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#vault_secret_id ApmSyntheticsMonitor#vault_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vaultSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VaultSecretId
        {
            get;
            set;
        }
    }
}
