using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerInstancesContainerInstance
{
    [JsiiInterface(nativeType: typeof(IContainerInstancesContainerInstanceVolumes), fullyQualifiedName: "oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumes")]
    public interface IContainerInstancesContainerInstanceVolumes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/container_instances_container_instance#name ContainerInstancesContainerInstance#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/container_instances_container_instance#volume_type ContainerInstancesContainerInstance#volume_type}.</summary>
        [JsiiProperty(name: "volumeType", typeJson: "{\"primitive\":\"string\"}")]
        string VolumeType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/container_instances_container_instance#backing_store ContainerInstancesContainerInstance#backing_store}.</summary>
        [JsiiProperty(name: "backingStore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BackingStore
        {
            get
            {
                return null;
            }
        }

        /// <summary>configs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/container_instances_container_instance#configs ContainerInstancesContainerInstance#configs}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesConfigs" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "configs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesConfigs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Configs
        {
            get
            {
                return null;
            }
        }

        /// <summary>export block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/container_instances_container_instance#export ContainerInstancesContainerInstance#export}
        /// </remarks>
        [JsiiProperty(name: "export", typeJson: "{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesExport\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesExport? Export
        {
            get
            {
                return null;
            }
        }

        /// <summary>mount_command block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/container_instances_container_instance#mount_command ContainerInstancesContainerInstance#mount_command}
        /// </remarks>
        [JsiiProperty(name: "mountCommand", typeJson: "{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesMountCommand\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesMountCommand? MountCommand
        {
            get
            {
                return null;
            }
        }

        /// <summary>mount_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/container_instances_container_instance#mount_target ContainerInstancesContainerInstance#mount_target}
        /// </remarks>
        [JsiiProperty(name: "mountTarget", typeJson: "{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesMountTarget\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesMountTarget? MountTarget
        {
            get
            {
                return null;
            }
        }

        /// <summary>security block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/container_instances_container_instance#security ContainerInstancesContainerInstance#security}
        /// </remarks>
        [JsiiProperty(name: "security", typeJson: "{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesSecurity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesSecurity? Security
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/container_instances_container_instance#subnet_id ContainerInstancesContainerInstance#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubnetId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerInstancesContainerInstanceVolumes), fullyQualifiedName: "oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumes")]
        internal sealed class _Proxy : DeputyBase, oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/container_instances_container_instance#name ContainerInstancesContainerInstance#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/container_instances_container_instance#volume_type ContainerInstancesContainerInstance#volume_type}.</summary>
            [JsiiProperty(name: "volumeType", typeJson: "{\"primitive\":\"string\"}")]
            public string VolumeType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/container_instances_container_instance#backing_store ContainerInstancesContainerInstance#backing_store}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backingStore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BackingStore
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>configs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/container_instances_container_instance#configs ContainerInstancesContainerInstance#configs}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesConfigs" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "configs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesConfigs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Configs
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>export block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/container_instances_container_instance#export ContainerInstancesContainerInstance#export}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "export", typeJson: "{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesExport\"}", isOptional: true)]
            public oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesExport? Export
            {
                get => GetInstanceProperty<oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesExport?>();
            }

            /// <summary>mount_command block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/container_instances_container_instance#mount_command ContainerInstancesContainerInstance#mount_command}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mountCommand", typeJson: "{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesMountCommand\"}", isOptional: true)]
            public oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesMountCommand? MountCommand
            {
                get => GetInstanceProperty<oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesMountCommand?>();
            }

            /// <summary>mount_target block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/container_instances_container_instance#mount_target ContainerInstancesContainerInstance#mount_target}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mountTarget", typeJson: "{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesMountTarget\"}", isOptional: true)]
            public oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesMountTarget? MountTarget
            {
                get => GetInstanceProperty<oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesMountTarget?>();
            }

            /// <summary>security block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/container_instances_container_instance#security ContainerInstancesContainerInstance#security}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "security", typeJson: "{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesSecurity\"}", isOptional: true)]
            public oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesSecurity? Security
            {
                get => GetInstanceProperty<oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesSecurity?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/container_instances_container_instance#subnet_id ContainerInstancesContainerInstance#subnet_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubnetId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
