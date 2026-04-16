using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.InstanceServer
{
    [JsiiInterface(nativeType: typeof(IInstanceServerRootVolume), fullyQualifiedName: "scaleway.instanceServer.InstanceServerRootVolume")]
    public interface IInstanceServerRootVolume
    {
        /// <summary>Set the volume where the boot the server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_server#boot InstanceServer#boot}
        /// </remarks>
        [JsiiProperty(name: "boot", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Boot
        {
            get
            {
                return null;
            }
        }

        /// <summary>Force deletion of the root volume on instance termination.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_server#delete_on_termination InstanceServer#delete_on_termination}
        /// </remarks>
        [JsiiProperty(name: "deleteOnTermination", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DeleteOnTermination
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the root volume.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_server#name InstanceServer#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>SBS Volume IOPS, only with volume_type as sbs_volume.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_server#sbs_iops InstanceServer#sbs_iops}
        /// </remarks>
        [JsiiProperty(name: "sbsIops", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SbsIops
        {
            get
            {
                return null;
            }
        }

        /// <summary>Size of the root volume in gigabytes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_server#size_in_gb InstanceServer#size_in_gb}
        /// </remarks>
        [JsiiProperty(name: "sizeInGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SizeInGb
        {
            get
            {
                return null;
            }
        }

        /// <summary>Volume ID of the root volume.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_server#volume_id InstanceServer#volume_id}
        /// </remarks>
        [JsiiProperty(name: "volumeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VolumeId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Volume type of the root volume.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_server#volume_type InstanceServer#volume_type}
        /// </remarks>
        [JsiiProperty(name: "volumeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VolumeType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInstanceServerRootVolume), fullyQualifiedName: "scaleway.instanceServer.InstanceServerRootVolume")]
        internal sealed class _Proxy : DeputyBase, scaleway.InstanceServer.IInstanceServerRootVolume
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Set the volume where the boot the server.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_server#boot InstanceServer#boot}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "boot", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Boot
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Force deletion of the root volume on instance termination.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_server#delete_on_termination InstanceServer#delete_on_termination}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deleteOnTermination", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DeleteOnTermination
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Name of the root volume.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_server#name InstanceServer#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>SBS Volume IOPS, only with volume_type as sbs_volume.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_server#sbs_iops InstanceServer#sbs_iops}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sbsIops", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SbsIops
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Size of the root volume in gigabytes.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_server#size_in_gb InstanceServer#size_in_gb}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sizeInGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SizeInGb
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Volume ID of the root volume.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_server#volume_id InstanceServer#volume_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "volumeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VolumeId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Volume type of the root volume.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_server#volume_type InstanceServer#volume_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "volumeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VolumeType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
