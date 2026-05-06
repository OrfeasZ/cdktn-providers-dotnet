using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerInstancesContainerInstance
{
    [JsiiByValue(fqn: "oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceContainersHealthChecksHeaders")]
    public class ContainerInstancesContainerInstanceContainersHealthChecksHeaders : oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceContainersHealthChecksHeaders
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#name ContainerInstancesContainerInstance#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#value ContainerInstancesContainerInstance#value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}
