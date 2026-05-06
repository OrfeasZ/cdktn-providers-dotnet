using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMetricExtension
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.stackMonitoringMetricExtension.StackMonitoringMetricExtensionQueryPropertiesOutParamDetails")]
    public class StackMonitoringMetricExtensionQueryPropertiesOutParamDetails : oci.StackMonitoringMetricExtension.IStackMonitoringMetricExtensionQueryPropertiesOutParamDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#out_param_position StackMonitoringMetricExtension#out_param_position}.</summary>
        [JsiiProperty(name: "outParamPosition", typeJson: "{\"primitive\":\"number\"}")]
        public double OutParamPosition
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#out_param_type StackMonitoringMetricExtension#out_param_type}.</summary>
        [JsiiProperty(name: "outParamType", typeJson: "{\"primitive\":\"string\"}")]
        public string OutParamType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#out_param_name StackMonitoringMetricExtension#out_param_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "outParamName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OutParamName
        {
            get;
            set;
        }
    }
}
