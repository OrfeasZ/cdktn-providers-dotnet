using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMetricExtension
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.stackMonitoringMetricExtension.StackMonitoringMetricExtensionQueryPropertiesScriptDetails")]
    public class StackMonitoringMetricExtensionQueryPropertiesScriptDetails : oci.StackMonitoringMetricExtension.IStackMonitoringMetricExtensionQueryPropertiesScriptDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#content StackMonitoringMetricExtension#content}.</summary>
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
        public string Content
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#name StackMonitoringMetricExtension#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
