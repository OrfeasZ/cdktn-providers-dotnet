using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerInstancesContainerInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumes")]
    public class ContainerInstancesContainerInstanceVolumes : oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/container_instances_container_instance#name ContainerInstancesContainerInstance#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/container_instances_container_instance#volume_type ContainerInstancesContainerInstance#volume_type}.</summary>
        [JsiiProperty(name: "volumeType", typeJson: "{\"primitive\":\"string\"}")]
        public string VolumeType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/container_instances_container_instance#backing_store ContainerInstancesContainerInstance#backing_store}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backingStore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BackingStore
        {
            get;
            set;
        }

        private object? _configs;

        /// <summary>configs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/container_instances_container_instance#configs ContainerInstancesContainerInstance#configs}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesConfigs" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "configs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesConfigs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Configs
        {
            get => _configs;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesConfigs[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesConfigs).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _configs = value;
            }
        }

        /// <summary>export block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/container_instances_container_instance#export ContainerInstancesContainerInstance#export}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "export", typeJson: "{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesExport\"}", isOptional: true)]
        public oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesExport? Export
        {
            get;
            set;
        }

        /// <summary>mount_command block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/container_instances_container_instance#mount_command ContainerInstancesContainerInstance#mount_command}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mountCommand", typeJson: "{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesMountCommand\"}", isOptional: true)]
        public oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesMountCommand? MountCommand
        {
            get;
            set;
        }

        /// <summary>mount_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/container_instances_container_instance#mount_target ContainerInstancesContainerInstance#mount_target}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mountTarget", typeJson: "{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesMountTarget\"}", isOptional: true)]
        public oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesMountTarget? MountTarget
        {
            get;
            set;
        }

        /// <summary>security block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/container_instances_container_instance#security ContainerInstancesContainerInstance#security}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "security", typeJson: "{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesSecurity\"}", isOptional: true)]
        public oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesSecurity? Security
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/container_instances_container_instance#subnet_id ContainerInstancesContainerInstance#subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubnetId
        {
            get;
            set;
        }
    }
}
