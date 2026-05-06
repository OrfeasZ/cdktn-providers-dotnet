using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmSyntheticsMonitor
{
    [JsiiByValue(fqn: "oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationClientCertificateDetailsClientCertificate")]
    public class ApmSyntheticsMonitorConfigurationClientCertificateDetailsClientCertificate : oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationClientCertificateDetailsClientCertificate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#content ApmSyntheticsMonitor#content}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Content
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#file_name ApmSyntheticsMonitor#file_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fileName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FileName
        {
            get;
            set;
        }
    }
}
