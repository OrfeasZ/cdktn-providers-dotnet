using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmSyntheticsMonitor
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.apmSyntheticsMonitor.ApmSyntheticsMonitorVantagePoints")]
    public class ApmSyntheticsMonitorVantagePoints : oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorVantagePoints
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#name ApmSyntheticsMonitor#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#display_name ApmSyntheticsMonitor#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }
    }
}
