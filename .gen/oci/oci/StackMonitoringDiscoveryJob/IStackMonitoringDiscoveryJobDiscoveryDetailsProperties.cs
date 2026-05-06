using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringDiscoveryJob
{
    [JsiiInterface(nativeType: typeof(IStackMonitoringDiscoveryJobDiscoveryDetailsProperties), fullyQualifiedName: "oci.stackMonitoringDiscoveryJob.StackMonitoringDiscoveryJobDiscoveryDetailsProperties")]
    public interface IStackMonitoringDiscoveryJobDiscoveryDetailsProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_discovery_job#properties_map StackMonitoringDiscoveryJob#properties_map}.</summary>
        [JsiiProperty(name: "propertiesMap", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? PropertiesMap
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStackMonitoringDiscoveryJobDiscoveryDetailsProperties), fullyQualifiedName: "oci.stackMonitoringDiscoveryJob.StackMonitoringDiscoveryJobDiscoveryDetailsProperties")]
        internal sealed class _Proxy : DeputyBase, oci.StackMonitoringDiscoveryJob.IStackMonitoringDiscoveryJobDiscoveryDetailsProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_discovery_job#properties_map StackMonitoringDiscoveryJob#properties_map}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "propertiesMap", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? PropertiesMap
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}
