using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.AutoscalingInstanceTemplate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.autoscalingInstanceTemplate.AutoscalingInstanceTemplateVolumesFromSnapshot")]
    public class AutoscalingInstanceTemplateVolumesFromSnapshot : scaleway.AutoscalingInstanceTemplate.IAutoscalingInstanceTemplateVolumesFromSnapshot
    {
        /// <summary>ID of the snapshot to clone.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/autoscaling_instance_template#snapshot_id AutoscalingInstanceTemplate#snapshot_id}
        /// </remarks>
        [JsiiProperty(name: "snapshotId", typeJson: "{\"primitive\":\"string\"}")]
        public string SnapshotId
        {
            get;
            set;
        }

        /// <summary>Override size (in GB) of the cloned volume.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/autoscaling_instance_template#size AutoscalingInstanceTemplate#size}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Size
        {
            get;
            set;
        }
    }
}
