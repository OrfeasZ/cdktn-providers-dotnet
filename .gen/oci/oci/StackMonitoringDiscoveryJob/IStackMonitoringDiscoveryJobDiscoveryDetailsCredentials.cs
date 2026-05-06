using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringDiscoveryJob
{
    [JsiiInterface(nativeType: typeof(IStackMonitoringDiscoveryJobDiscoveryDetailsCredentials), fullyQualifiedName: "oci.stackMonitoringDiscoveryJob.StackMonitoringDiscoveryJobDiscoveryDetailsCredentials")]
    public interface IStackMonitoringDiscoveryJobDiscoveryDetailsCredentials
    {
        /// <summary>items block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_discovery_job#items StackMonitoringDiscoveryJob#items}
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.stackMonitoringDiscoveryJob.StackMonitoringDiscoveryJobDiscoveryDetailsCredentialsItems\"},\"kind\":\"array\"}}]}}")]
        object Items
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IStackMonitoringDiscoveryJobDiscoveryDetailsCredentials), fullyQualifiedName: "oci.stackMonitoringDiscoveryJob.StackMonitoringDiscoveryJobDiscoveryDetailsCredentials")]
        internal sealed class _Proxy : DeputyBase, oci.StackMonitoringDiscoveryJob.IStackMonitoringDiscoveryJobDiscoveryDetailsCredentials
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_discovery_job#items StackMonitoringDiscoveryJob#items}
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.stackMonitoringDiscoveryJob.StackMonitoringDiscoveryJobDiscoveryDetailsCredentialsItems\"},\"kind\":\"array\"}}]}}")]
            public object Items
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
