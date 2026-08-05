using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerInstancesContainerInstance
{
    [JsiiByValue(fqn: "oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesMountCommand")]
    public class ContainerInstancesContainerInstanceVolumesMountCommand : oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesMountCommand
    {
        private object? _mountOptions;

        /// <summary>mount_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/container_instances_container_instance#mount_options ContainerInstancesContainerInstance#mount_options}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesMountCommandMountOptions" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mountOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesMountCommandMountOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MountOptions
        {
            get => _mountOptions;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesMountCommandMountOptions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesMountCommandMountOptions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _mountOptions = value;
            }
        }
    }
}
