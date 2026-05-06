using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmSyntheticsMonitor
{
    [JsiiInterface(nativeType: typeof(IApmSyntheticsMonitorConfigurationClientCertificateDetails), fullyQualifiedName: "oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationClientCertificateDetails")]
    public interface IApmSyntheticsMonitorConfigurationClientCertificateDetails
    {
        /// <summary>client_certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#client_certificate ApmSyntheticsMonitor#client_certificate}
        /// </remarks>
        [JsiiProperty(name: "clientCertificate", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationClientCertificateDetailsClientCertificate\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationClientCertificateDetailsClientCertificate? ClientCertificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>private_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#private_key ApmSyntheticsMonitor#private_key}
        /// </remarks>
        [JsiiProperty(name: "privateKey", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationClientCertificateDetailsPrivateKey\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationClientCertificateDetailsPrivateKey? PrivateKey
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApmSyntheticsMonitorConfigurationClientCertificateDetails), fullyQualifiedName: "oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationClientCertificateDetails")]
        internal sealed class _Proxy : DeputyBase, oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationClientCertificateDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>client_certificate block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#client_certificate ApmSyntheticsMonitor#client_certificate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientCertificate", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationClientCertificateDetailsClientCertificate\"}", isOptional: true)]
            public oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationClientCertificateDetailsClientCertificate? ClientCertificate
            {
                get => GetInstanceProperty<oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationClientCertificateDetailsClientCertificate?>();
            }

            /// <summary>private_key block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#private_key ApmSyntheticsMonitor#private_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privateKey", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationClientCertificateDetailsPrivateKey\"}", isOptional: true)]
            public oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationClientCertificateDetailsPrivateKey? PrivateKey
            {
                get => GetInstanceProperty<oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationClientCertificateDetailsPrivateKey?>();
            }
        }
    }
}
