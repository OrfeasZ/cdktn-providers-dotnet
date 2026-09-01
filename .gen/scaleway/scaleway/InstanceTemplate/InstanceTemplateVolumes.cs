using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.InstanceTemplate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.instanceTemplate.InstanceTemplateVolumes")]
    public class InstanceTemplateVolumes : scaleway.InstanceTemplate.IInstanceTemplateVolumes
    {
        /// <summary>The size of the volume in gigabytes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#size_in_gb InstanceTemplate#size_in_gb}
        /// </remarks>
        [JsiiProperty(name: "sizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        public double SizeInGb
        {
            get;
            set;
        }

        /// <summary>The type of volume.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#volume_type InstanceTemplate#volume_type}
        /// </remarks>
        [JsiiProperty(name: "volumeType", typeJson: "{\"primitive\":\"string\"}")]
        public string VolumeType
        {
            get;
            set;
        }

        /// <summary>The ID of the base snapshot for the volume.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#base_snapshot_id InstanceTemplate#base_snapshot_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "baseSnapshotId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BaseSnapshotId
        {
            get;
            set;
        }

        /// <summary>The label of the image used as base for the volume.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#image_label InstanceTemplate#image_label}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "imageLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ImageLabel
        {
            get;
            set;
        }

        /// <summary>The name of volume. If not provided, a random name will be generated.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#name InstanceTemplate#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>The performance IOPS of the volume.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#perf_iops InstanceTemplate#perf_iops}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "perfIops", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PerfIops
        {
            get;
            set;
        }

        /// <summary>The tags associated with the volume.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#tags InstanceTemplate#tags}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Tags
        {
            get;
            set;
        }
    }
}
