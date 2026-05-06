using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMonitoredResourceTask
{
    [JsiiInterface(nativeType: typeof(IStackMonitoringMonitoredResourceTaskTaskDetailsReceiverProperties), fullyQualifiedName: "oci.stackMonitoringMonitoredResourceTask.StackMonitoringMonitoredResourceTaskTaskDetailsReceiverProperties")]
    public interface IStackMonitoringMonitoredResourceTaskTaskDetailsReceiverProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#listener_port StackMonitoringMonitoredResourceTask#listener_port}.</summary>
        [JsiiProperty(name: "listenerPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ListenerPort
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStackMonitoringMonitoredResourceTaskTaskDetailsReceiverProperties), fullyQualifiedName: "oci.stackMonitoringMonitoredResourceTask.StackMonitoringMonitoredResourceTaskTaskDetailsReceiverProperties")]
        internal sealed class _Proxy : DeputyBase, oci.StackMonitoringMonitoredResourceTask.IStackMonitoringMonitoredResourceTaskTaskDetailsReceiverProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_task#listener_port StackMonitoringMonitoredResourceTask#listener_port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "listenerPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ListenerPort
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
