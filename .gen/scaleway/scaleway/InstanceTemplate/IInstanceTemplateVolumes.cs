using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.InstanceTemplate
{
    [JsiiInterface(nativeType: typeof(IInstanceTemplateVolumes), fullyQualifiedName: "scaleway.instanceTemplate.InstanceTemplateVolumes")]
    public interface IInstanceTemplateVolumes
    {
        /// <summary>The size of the volume in gigabytes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#size_in_gb InstanceTemplate#size_in_gb}
        /// </remarks>
        [JsiiProperty(name: "sizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        double SizeInGb
        {
            get;
        }

        /// <summary>The type of volume.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#volume_type InstanceTemplate#volume_type}
        /// </remarks>
        [JsiiProperty(name: "volumeType", typeJson: "{\"primitive\":\"string\"}")]
        string VolumeType
        {
            get;
        }

        /// <summary>The ID of the base snapshot for the volume.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#base_snapshot_id InstanceTemplate#base_snapshot_id}
        /// </remarks>
        [JsiiProperty(name: "baseSnapshotId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BaseSnapshotId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The label of the image used as base for the volume.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#image_label InstanceTemplate#image_label}
        /// </remarks>
        [JsiiProperty(name: "imageLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ImageLabel
        {
            get
            {
                return null;
            }
        }

        /// <summary>The name of volume. If not provided, a random name will be generated.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#name InstanceTemplate#name}
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

        /// <summary>The performance IOPS of the volume.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#perf_iops InstanceTemplate#perf_iops}
        /// </remarks>
        [JsiiProperty(name: "perfIops", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PerfIops
        {
            get
            {
                return null;
            }
        }

        /// <summary>The tags associated with the volume.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#tags InstanceTemplate#tags}
        /// </remarks>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInstanceTemplateVolumes), fullyQualifiedName: "scaleway.instanceTemplate.InstanceTemplateVolumes")]
        internal sealed class _Proxy : DeputyBase, scaleway.InstanceTemplate.IInstanceTemplateVolumes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The size of the volume in gigabytes.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#size_in_gb InstanceTemplate#size_in_gb}
            /// </remarks>
            [JsiiProperty(name: "sizeInGb", typeJson: "{\"primitive\":\"number\"}")]
            public double SizeInGb
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>The type of volume.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#volume_type InstanceTemplate#volume_type}
            /// </remarks>
            [JsiiProperty(name: "volumeType", typeJson: "{\"primitive\":\"string\"}")]
            public string VolumeType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The ID of the base snapshot for the volume.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#base_snapshot_id InstanceTemplate#base_snapshot_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "baseSnapshotId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BaseSnapshotId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The label of the image used as base for the volume.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#image_label InstanceTemplate#image_label}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "imageLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ImageLabel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The name of volume. If not provided, a random name will be generated.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#name InstanceTemplate#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The performance IOPS of the volume.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#perf_iops InstanceTemplate#perf_iops}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "perfIops", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PerfIops
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The tags associated with the volume.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#tags InstanceTemplate#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Tags
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
