using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmSyntheticsMonitor
{
    [JsiiInterface(nativeType: typeof(IApmSyntheticsMonitorConfigurationDatabaseAuthenticationDetails), fullyQualifiedName: "oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationDatabaseAuthenticationDetails")]
    public interface IApmSyntheticsMonitorConfigurationDatabaseAuthenticationDetails
    {
        /// <summary>password block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#password ApmSyntheticsMonitor#password}
        /// </remarks>
        [JsiiProperty(name: "password", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationDatabaseAuthenticationDetailsPassword\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationDatabaseAuthenticationDetailsPassword? Password
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#username ApmSyntheticsMonitor#username}.</summary>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Username
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApmSyntheticsMonitorConfigurationDatabaseAuthenticationDetails), fullyQualifiedName: "oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationDatabaseAuthenticationDetails")]
        internal sealed class _Proxy : DeputyBase, oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationDatabaseAuthenticationDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>password block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#password ApmSyntheticsMonitor#password}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "password", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationDatabaseAuthenticationDetailsPassword\"}", isOptional: true)]
            public oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationDatabaseAuthenticationDetailsPassword? Password
            {
                get => GetInstanceProperty<oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationDatabaseAuthenticationDetailsPassword?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#username ApmSyntheticsMonitor#username}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Username
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
