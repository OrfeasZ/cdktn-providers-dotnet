using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerInstancesContainerInstance
{
    [JsiiByValue(fqn: "oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceContainersSecurityContext")]
    public class ContainerInstancesContainerInstanceContainersSecurityContext : oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceContainersSecurityContext
    {
        /// <summary>capabilities block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#capabilities ContainerInstancesContainerInstance#capabilities}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "capabilities", typeJson: "{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceContainersSecurityContextCapabilities\"}", isOptional: true)]
        public oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceContainersSecurityContextCapabilities? Capabilities
        {
            get;
            set;
        }

        private object? _isNonRootUserCheckEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#is_non_root_user_check_enabled ContainerInstancesContainerInstance#is_non_root_user_check_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isNonRootUserCheckEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsNonRootUserCheckEnabled
        {
            get => _isNonRootUserCheckEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isNonRootUserCheckEnabled = value;
            }
        }

        private object? _isRootFileSystemReadonly;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#is_root_file_system_readonly ContainerInstancesContainerInstance#is_root_file_system_readonly}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isRootFileSystemReadonly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsRootFileSystemReadonly
        {
            get => _isRootFileSystemReadonly;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isRootFileSystemReadonly = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#run_as_group ContainerInstancesContainerInstance#run_as_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "runAsGroup", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RunAsGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#run_as_user ContainerInstancesContainerInstance#run_as_user}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "runAsUser", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RunAsUser
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#security_context_type ContainerInstancesContainerInstance#security_context_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityContextType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecurityContextType
        {
            get;
            set;
        }
    }
}
