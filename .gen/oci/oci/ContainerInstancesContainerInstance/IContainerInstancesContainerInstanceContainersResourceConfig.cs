using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerInstancesContainerInstance
{
    [JsiiInterface(nativeType: typeof(IContainerInstancesContainerInstanceContainersResourceConfig), fullyQualifiedName: "oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceContainersResourceConfig")]
    public interface IContainerInstancesContainerInstanceContainersResourceConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#memory_limit_in_gbs ContainerInstancesContainerInstance#memory_limit_in_gbs}.</summary>
        [JsiiProperty(name: "memoryLimitInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MemoryLimitInGbs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#vcpus_limit ContainerInstancesContainerInstance#vcpus_limit}.</summary>
        [JsiiProperty(name: "vcpusLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? VcpusLimit
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerInstancesContainerInstanceContainersResourceConfig), fullyQualifiedName: "oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceContainersResourceConfig")]
        internal sealed class _Proxy : DeputyBase, oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceContainersResourceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#memory_limit_in_gbs ContainerInstancesContainerInstance#memory_limit_in_gbs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "memoryLimitInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MemoryLimitInGbs
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#vcpus_limit ContainerInstancesContainerInstance#vcpus_limit}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vcpusLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? VcpusLimit
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
