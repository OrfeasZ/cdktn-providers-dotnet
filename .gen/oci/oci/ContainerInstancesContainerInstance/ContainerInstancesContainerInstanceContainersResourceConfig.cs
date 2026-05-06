using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerInstancesContainerInstance
{
    [JsiiByValue(fqn: "oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceContainersResourceConfig")]
    public class ContainerInstancesContainerInstanceContainersResourceConfig : oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceContainersResourceConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#memory_limit_in_gbs ContainerInstancesContainerInstance#memory_limit_in_gbs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "memoryLimitInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MemoryLimitInGbs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#vcpus_limit ContainerInstancesContainerInstance#vcpus_limit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vcpusLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? VcpusLimit
        {
            get;
            set;
        }
    }
}
