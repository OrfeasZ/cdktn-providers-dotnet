using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMetricExtension
{
    [JsiiInterface(nativeType: typeof(IStackMonitoringMetricExtensionQueryPropertiesSqlDetails), fullyQualifiedName: "oci.stackMonitoringMetricExtension.StackMonitoringMetricExtensionQueryPropertiesSqlDetails")]
    public interface IStackMonitoringMetricExtensionQueryPropertiesSqlDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#content StackMonitoringMetricExtension#content}.</summary>
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
        string Content
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#script_file_name StackMonitoringMetricExtension#script_file_name}.</summary>
        [JsiiProperty(name: "scriptFileName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScriptFileName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStackMonitoringMetricExtensionQueryPropertiesSqlDetails), fullyQualifiedName: "oci.stackMonitoringMetricExtension.StackMonitoringMetricExtensionQueryPropertiesSqlDetails")]
        internal sealed class _Proxy : DeputyBase, oci.StackMonitoringMetricExtension.IStackMonitoringMetricExtensionQueryPropertiesSqlDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#content StackMonitoringMetricExtension#content}.</summary>
            [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
            public string Content
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#script_file_name StackMonitoringMetricExtension#script_file_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scriptFileName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScriptFileName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
