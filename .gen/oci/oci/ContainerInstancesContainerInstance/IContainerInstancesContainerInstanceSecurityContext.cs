using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerInstancesContainerInstance
{
    [JsiiInterface(nativeType: typeof(IContainerInstancesContainerInstanceSecurityContext), fullyQualifiedName: "oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceSecurityContext")]
    public interface IContainerInstancesContainerInstanceSecurityContext
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/container_instances_container_instance#fs_group ContainerInstancesContainerInstance#fs_group}.</summary>
        [JsiiProperty(name: "fsGroup", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FsGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/container_instances_container_instance#fs_group_change_policy ContainerInstancesContainerInstance#fs_group_change_policy}.</summary>
        [JsiiProperty(name: "fsGroupChangePolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FsGroupChangePolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/container_instances_container_instance#security_context_type ContainerInstancesContainerInstance#security_context_type}.</summary>
        [JsiiProperty(name: "securityContextType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecurityContextType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerInstancesContainerInstanceSecurityContext), fullyQualifiedName: "oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceSecurityContext")]
        internal sealed class _Proxy : DeputyBase, oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceSecurityContext
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/container_instances_container_instance#fs_group ContainerInstancesContainerInstance#fs_group}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fsGroup", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FsGroup
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/container_instances_container_instance#fs_group_change_policy ContainerInstancesContainerInstance#fs_group_change_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fsGroupChangePolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FsGroupChangePolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/container_instances_container_instance#security_context_type ContainerInstancesContainerInstance#security_context_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "securityContextType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecurityContextType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
