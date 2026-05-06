using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmSyntheticsMonitor
{
    [JsiiInterface(nativeType: typeof(IApmSyntheticsMonitorConfigurationClientCertificateDetailsClientCertificate), fullyQualifiedName: "oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationClientCertificateDetailsClientCertificate")]
    public interface IApmSyntheticsMonitorConfigurationClientCertificateDetailsClientCertificate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#content ApmSyntheticsMonitor#content}.</summary>
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Content
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#file_name ApmSyntheticsMonitor#file_name}.</summary>
        [JsiiProperty(name: "fileName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FileName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApmSyntheticsMonitorConfigurationClientCertificateDetailsClientCertificate), fullyQualifiedName: "oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationClientCertificateDetailsClientCertificate")]
        internal sealed class _Proxy : DeputyBase, oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationClientCertificateDetailsClientCertificate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#content ApmSyntheticsMonitor#content}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Content
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#file_name ApmSyntheticsMonitor#file_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fileName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FileName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
