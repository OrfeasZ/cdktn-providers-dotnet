using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMetricExtension
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.stackMonitoringMetricExtension.StackMonitoringMetricExtensionQueryPropertiesInParamDetails")]
    public class StackMonitoringMetricExtensionQueryPropertiesInParamDetails : oci.StackMonitoringMetricExtension.IStackMonitoringMetricExtensionQueryPropertiesInParamDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#in_param_position StackMonitoringMetricExtension#in_param_position}.</summary>
        [JsiiProperty(name: "inParamPosition", typeJson: "{\"primitive\":\"number\"}")]
        public double InParamPosition
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#in_param_value StackMonitoringMetricExtension#in_param_value}.</summary>
        [JsiiProperty(name: "inParamValue", typeJson: "{\"primitive\":\"string\"}")]
        public string InParamValue
        {
            get;
            set;
        }
    }
}
