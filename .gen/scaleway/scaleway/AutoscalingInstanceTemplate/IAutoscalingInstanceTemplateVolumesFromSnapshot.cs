using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.AutoscalingInstanceTemplate
{
    [JsiiInterface(nativeType: typeof(IAutoscalingInstanceTemplateVolumesFromSnapshot), fullyQualifiedName: "scaleway.autoscalingInstanceTemplate.AutoscalingInstanceTemplateVolumesFromSnapshot")]
    public interface IAutoscalingInstanceTemplateVolumesFromSnapshot
    {
        /// <summary>ID of the snapshot to clone.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/autoscaling_instance_template#snapshot_id AutoscalingInstanceTemplate#snapshot_id}
        /// </remarks>
        [JsiiProperty(name: "snapshotId", typeJson: "{\"primitive\":\"string\"}")]
        string SnapshotId
        {
            get;
        }

        /// <summary>Override size (in GB) of the cloned volume.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/autoscaling_instance_template#size AutoscalingInstanceTemplate#size}
        /// </remarks>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Size
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingInstanceTemplateVolumesFromSnapshot), fullyQualifiedName: "scaleway.autoscalingInstanceTemplate.AutoscalingInstanceTemplateVolumesFromSnapshot")]
        internal sealed class _Proxy : DeputyBase, scaleway.AutoscalingInstanceTemplate.IAutoscalingInstanceTemplateVolumesFromSnapshot
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ID of the snapshot to clone.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/autoscaling_instance_template#snapshot_id AutoscalingInstanceTemplate#snapshot_id}
            /// </remarks>
            [JsiiProperty(name: "snapshotId", typeJson: "{\"primitive\":\"string\"}")]
            public string SnapshotId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Override size (in GB) of the cloned volume.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/autoscaling_instance_template#size AutoscalingInstanceTemplate#size}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Size
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
