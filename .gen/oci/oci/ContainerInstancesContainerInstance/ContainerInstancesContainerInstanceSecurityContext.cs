using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerInstancesContainerInstance
{
    [JsiiByValue(fqn: "oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceSecurityContext")]
    public class ContainerInstancesContainerInstanceSecurityContext : oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceSecurityContext
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/container_instances_container_instance#fs_group ContainerInstancesContainerInstance#fs_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fsGroup", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FsGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/container_instances_container_instance#fs_group_change_policy ContainerInstancesContainerInstance#fs_group_change_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fsGroupChangePolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FsGroupChangePolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/container_instances_container_instance#security_context_type ContainerInstancesContainerInstance#security_context_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityContextType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecurityContextType
        {
            get;
            set;
        }
    }
}
