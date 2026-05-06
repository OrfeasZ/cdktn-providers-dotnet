using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerInstancesContainerInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceImagePullSecrets")]
    public class ContainerInstancesContainerInstanceImagePullSecrets : oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceImagePullSecrets
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#registry_endpoint ContainerInstancesContainerInstance#registry_endpoint}.</summary>
        [JsiiProperty(name: "registryEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public string RegistryEndpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#secret_type ContainerInstancesContainerInstance#secret_type}.</summary>
        [JsiiProperty(name: "secretType", typeJson: "{\"primitive\":\"string\"}")]
        public string SecretType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#password ContainerInstancesContainerInstance#password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Password
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#secret_id ContainerInstancesContainerInstance#secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#username ContainerInstancesContainerInstance#username}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Username
        {
            get;
            set;
        }
    }
}
