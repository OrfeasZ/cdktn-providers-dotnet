using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmSyntheticsMonitor
{
    [JsiiInterface(nativeType: typeof(IApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetailsPassword), fullyQualifiedName: "oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetailsPassword")]
    public interface IApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetailsPassword
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#password ApmSyntheticsMonitor#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Password
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#password_type ApmSyntheticsMonitor#password_type}.</summary>
        [JsiiProperty(name: "passwordType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PasswordType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#vault_secret_id ApmSyntheticsMonitor#vault_secret_id}.</summary>
        [JsiiProperty(name: "vaultSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VaultSecretId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetailsPassword), fullyQualifiedName: "oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetailsPassword")]
        internal sealed class _Proxy : DeputyBase, oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetailsPassword
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#password ApmSyntheticsMonitor#password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Password
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#password_type ApmSyntheticsMonitor#password_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "passwordType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PasswordType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#vault_secret_id ApmSyntheticsMonitor#vault_secret_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vaultSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VaultSecretId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
