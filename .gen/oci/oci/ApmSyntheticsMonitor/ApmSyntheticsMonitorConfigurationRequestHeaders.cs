using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmSyntheticsMonitor
{
    [JsiiByValue(fqn: "oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationRequestHeaders")]
    public class ApmSyntheticsMonitorConfigurationRequestHeaders : oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationRequestHeaders
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#header_name ApmSyntheticsMonitor#header_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "headerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HeaderName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#header_value ApmSyntheticsMonitor#header_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "headerValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HeaderValue
        {
            get;
            set;
        }
    }
}
