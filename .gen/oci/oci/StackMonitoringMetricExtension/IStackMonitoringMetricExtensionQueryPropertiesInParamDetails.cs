using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMetricExtension
{
    [JsiiInterface(nativeType: typeof(IStackMonitoringMetricExtensionQueryPropertiesInParamDetails), fullyQualifiedName: "oci.stackMonitoringMetricExtension.StackMonitoringMetricExtensionQueryPropertiesInParamDetails")]
    public interface IStackMonitoringMetricExtensionQueryPropertiesInParamDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#in_param_position StackMonitoringMetricExtension#in_param_position}.</summary>
        [JsiiProperty(name: "inParamPosition", typeJson: "{\"primitive\":\"number\"}")]
        double InParamPosition
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#in_param_value StackMonitoringMetricExtension#in_param_value}.</summary>
        [JsiiProperty(name: "inParamValue", typeJson: "{\"primitive\":\"string\"}")]
        string InParamValue
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IStackMonitoringMetricExtensionQueryPropertiesInParamDetails), fullyQualifiedName: "oci.stackMonitoringMetricExtension.StackMonitoringMetricExtensionQueryPropertiesInParamDetails")]
        internal sealed class _Proxy : DeputyBase, oci.StackMonitoringMetricExtension.IStackMonitoringMetricExtensionQueryPropertiesInParamDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#in_param_position StackMonitoringMetricExtension#in_param_position}.</summary>
            [JsiiProperty(name: "inParamPosition", typeJson: "{\"primitive\":\"number\"}")]
            public double InParamPosition
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#in_param_value StackMonitoringMetricExtension#in_param_value}.</summary>
            [JsiiProperty(name: "inParamValue", typeJson: "{\"primitive\":\"string\"}")]
            public string InParamValue
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
