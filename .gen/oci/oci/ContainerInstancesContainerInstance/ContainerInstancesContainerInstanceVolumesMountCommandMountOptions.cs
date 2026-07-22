using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerInstancesContainerInstance
{
    [JsiiByValue(fqn: "oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesMountCommandMountOptions")]
    public class ContainerInstancesContainerInstanceVolumesMountCommandMountOptions : oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesMountCommandMountOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/container_instances_container_instance#option ContainerInstancesContainerInstance#option}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "option", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Option
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/container_instances_container_instance#value ContainerInstancesContainerInstance#value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}
