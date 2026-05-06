using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMetricExtension
{
    [JsiiInterface(nativeType: typeof(IStackMonitoringMetricExtensionQueryPropertiesOutParamDetails), fullyQualifiedName: "oci.stackMonitoringMetricExtension.StackMonitoringMetricExtensionQueryPropertiesOutParamDetails")]
    public interface IStackMonitoringMetricExtensionQueryPropertiesOutParamDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#out_param_position StackMonitoringMetricExtension#out_param_position}.</summary>
        [JsiiProperty(name: "outParamPosition", typeJson: "{\"primitive\":\"number\"}")]
        double OutParamPosition
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#out_param_type StackMonitoringMetricExtension#out_param_type}.</summary>
        [JsiiProperty(name: "outParamType", typeJson: "{\"primitive\":\"string\"}")]
        string OutParamType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#out_param_name StackMonitoringMetricExtension#out_param_name}.</summary>
        [JsiiProperty(name: "outParamName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OutParamName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStackMonitoringMetricExtensionQueryPropertiesOutParamDetails), fullyQualifiedName: "oci.stackMonitoringMetricExtension.StackMonitoringMetricExtensionQueryPropertiesOutParamDetails")]
        internal sealed class _Proxy : DeputyBase, oci.StackMonitoringMetricExtension.IStackMonitoringMetricExtensionQueryPropertiesOutParamDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#out_param_position StackMonitoringMetricExtension#out_param_position}.</summary>
            [JsiiProperty(name: "outParamPosition", typeJson: "{\"primitive\":\"number\"}")]
            public double OutParamPosition
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#out_param_type StackMonitoringMetricExtension#out_param_type}.</summary>
            [JsiiProperty(name: "outParamType", typeJson: "{\"primitive\":\"string\"}")]
            public string OutParamType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#out_param_name StackMonitoringMetricExtension#out_param_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "outParamName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OutParamName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
