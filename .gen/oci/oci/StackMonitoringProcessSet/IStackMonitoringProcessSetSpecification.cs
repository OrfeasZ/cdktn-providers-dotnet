using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringProcessSet
{
    [JsiiInterface(nativeType: typeof(IStackMonitoringProcessSetSpecification), fullyQualifiedName: "oci.stackMonitoringProcessSet.StackMonitoringProcessSetSpecification")]
    public interface IStackMonitoringProcessSetSpecification
    {
        /// <summary>items block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_process_set#items StackMonitoringProcessSet#items}
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.stackMonitoringProcessSet.StackMonitoringProcessSetSpecificationItems\"},\"kind\":\"array\"}}]}}")]
        object Items
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IStackMonitoringProcessSetSpecification), fullyQualifiedName: "oci.stackMonitoringProcessSet.StackMonitoringProcessSetSpecification")]
        internal sealed class _Proxy : DeputyBase, oci.StackMonitoringProcessSet.IStackMonitoringProcessSetSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_process_set#items StackMonitoringProcessSet#items}
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.stackMonitoringProcessSet.StackMonitoringProcessSetSpecificationItems\"},\"kind\":\"array\"}}]}}")]
            public object Items
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
