using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMetricExtension
{
    [JsiiInterface(nativeType: typeof(IStackMonitoringMetricExtensionQueryPropertiesScriptDetails), fullyQualifiedName: "oci.stackMonitoringMetricExtension.StackMonitoringMetricExtensionQueryPropertiesScriptDetails")]
    public interface IStackMonitoringMetricExtensionQueryPropertiesScriptDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#content StackMonitoringMetricExtension#content}.</summary>
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
        string Content
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#name StackMonitoringMetricExtension#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IStackMonitoringMetricExtensionQueryPropertiesScriptDetails), fullyQualifiedName: "oci.stackMonitoringMetricExtension.StackMonitoringMetricExtensionQueryPropertiesScriptDetails")]
        internal sealed class _Proxy : DeputyBase, oci.StackMonitoringMetricExtension.IStackMonitoringMetricExtensionQueryPropertiesScriptDetails
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#name StackMonitoringMetricExtension#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
