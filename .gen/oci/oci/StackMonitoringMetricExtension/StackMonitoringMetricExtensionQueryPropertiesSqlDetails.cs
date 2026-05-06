using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMetricExtension
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.stackMonitoringMetricExtension.StackMonitoringMetricExtensionQueryPropertiesSqlDetails")]
    public class StackMonitoringMetricExtensionQueryPropertiesSqlDetails : oci.StackMonitoringMetricExtension.IStackMonitoringMetricExtensionQueryPropertiesSqlDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#content StackMonitoringMetricExtension#content}.</summary>
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
        public string Content
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#script_file_name StackMonitoringMetricExtension#script_file_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scriptFileName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScriptFileName
        {
            get;
            set;
        }
    }
}
