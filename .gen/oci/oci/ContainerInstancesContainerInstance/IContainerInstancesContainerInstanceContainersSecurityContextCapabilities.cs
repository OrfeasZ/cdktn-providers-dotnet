using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerInstancesContainerInstance
{
    [JsiiInterface(nativeType: typeof(IContainerInstancesContainerInstanceContainersSecurityContextCapabilities), fullyQualifiedName: "oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceContainersSecurityContextCapabilities")]
    public interface IContainerInstancesContainerInstanceContainersSecurityContextCapabilities
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#add_capabilities ContainerInstancesContainerInstance#add_capabilities}.</summary>
        [JsiiProperty(name: "addCapabilities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AddCapabilities
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#drop_capabilities ContainerInstancesContainerInstance#drop_capabilities}.</summary>
        [JsiiProperty(name: "dropCapabilities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DropCapabilities
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerInstancesContainerInstanceContainersSecurityContextCapabilities), fullyQualifiedName: "oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceContainersSecurityContextCapabilities")]
        internal sealed class _Proxy : DeputyBase, oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceContainersSecurityContextCapabilities
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#add_capabilities ContainerInstancesContainerInstance#add_capabilities}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "addCapabilities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AddCapabilities
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#drop_capabilities ContainerInstancesContainerInstance#drop_capabilities}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dropCapabilities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DropCapabilities
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
