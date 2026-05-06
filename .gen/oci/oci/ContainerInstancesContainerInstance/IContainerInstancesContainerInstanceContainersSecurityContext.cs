using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerInstancesContainerInstance
{
    [JsiiInterface(nativeType: typeof(IContainerInstancesContainerInstanceContainersSecurityContext), fullyQualifiedName: "oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceContainersSecurityContext")]
    public interface IContainerInstancesContainerInstanceContainersSecurityContext
    {
        /// <summary>capabilities block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#capabilities ContainerInstancesContainerInstance#capabilities}
        /// </remarks>
        [JsiiProperty(name: "capabilities", typeJson: "{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceContainersSecurityContextCapabilities\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceContainersSecurityContextCapabilities? Capabilities
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#is_non_root_user_check_enabled ContainerInstancesContainerInstance#is_non_root_user_check_enabled}.</summary>
        [JsiiProperty(name: "isNonRootUserCheckEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsNonRootUserCheckEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#is_root_file_system_readonly ContainerInstancesContainerInstance#is_root_file_system_readonly}.</summary>
        [JsiiProperty(name: "isRootFileSystemReadonly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsRootFileSystemReadonly
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#run_as_group ContainerInstancesContainerInstance#run_as_group}.</summary>
        [JsiiProperty(name: "runAsGroup", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RunAsGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#run_as_user ContainerInstancesContainerInstance#run_as_user}.</summary>
        [JsiiProperty(name: "runAsUser", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RunAsUser
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#security_context_type ContainerInstancesContainerInstance#security_context_type}.</summary>
        [JsiiProperty(name: "securityContextType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecurityContextType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerInstancesContainerInstanceContainersSecurityContext), fullyQualifiedName: "oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceContainersSecurityContext")]
        internal sealed class _Proxy : DeputyBase, oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceContainersSecurityContext
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>capabilities block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#capabilities ContainerInstancesContainerInstance#capabilities}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "capabilities", typeJson: "{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceContainersSecurityContextCapabilities\"}", isOptional: true)]
            public oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceContainersSecurityContextCapabilities? Capabilities
            {
                get => GetInstanceProperty<oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceContainersSecurityContextCapabilities?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#is_non_root_user_check_enabled ContainerInstancesContainerInstance#is_non_root_user_check_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isNonRootUserCheckEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsNonRootUserCheckEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#is_root_file_system_readonly ContainerInstancesContainerInstance#is_root_file_system_readonly}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isRootFileSystemReadonly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsRootFileSystemReadonly
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#run_as_group ContainerInstancesContainerInstance#run_as_group}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "runAsGroup", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RunAsGroup
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#run_as_user ContainerInstancesContainerInstance#run_as_user}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "runAsUser", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RunAsUser
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#security_context_type ContainerInstancesContainerInstance#security_context_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "securityContextType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecurityContextType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
