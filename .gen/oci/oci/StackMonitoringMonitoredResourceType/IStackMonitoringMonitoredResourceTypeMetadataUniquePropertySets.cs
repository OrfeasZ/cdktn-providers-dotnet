using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMonitoredResourceType
{
    [JsiiInterface(nativeType: typeof(IStackMonitoringMonitoredResourceTypeMetadataUniquePropertySets), fullyQualifiedName: "oci.stackMonitoringMonitoredResourceType.StackMonitoringMonitoredResourceTypeMetadataUniquePropertySets")]
    public interface IStackMonitoringMonitoredResourceTypeMetadataUniquePropertySets
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_type#properties StackMonitoringMonitoredResourceType#properties}.</summary>
        [JsiiProperty(name: "properties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Properties
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IStackMonitoringMonitoredResourceTypeMetadataUniquePropertySets), fullyQualifiedName: "oci.stackMonitoringMonitoredResourceType.StackMonitoringMonitoredResourceTypeMetadataUniquePropertySets")]
        internal sealed class _Proxy : DeputyBase, oci.StackMonitoringMonitoredResourceType.IStackMonitoringMonitoredResourceTypeMetadataUniquePropertySets
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource_type#properties StackMonitoringMonitoredResourceType#properties}.</summary>
            [JsiiProperty(name: "properties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Properties
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
