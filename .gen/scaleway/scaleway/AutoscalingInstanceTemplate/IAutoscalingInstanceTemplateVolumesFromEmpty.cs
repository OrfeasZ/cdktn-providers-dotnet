using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.AutoscalingInstanceTemplate
{
    [JsiiInterface(nativeType: typeof(IAutoscalingInstanceTemplateVolumesFromEmpty), fullyQualifiedName: "scaleway.autoscalingInstanceTemplate.AutoscalingInstanceTemplateVolumesFromEmpty")]
    public interface IAutoscalingInstanceTemplateVolumesFromEmpty
    {
        /// <summary>Size in GB of the new empty volume.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#size AutoscalingInstanceTemplate#size}
        /// </remarks>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        double Size
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingInstanceTemplateVolumesFromEmpty), fullyQualifiedName: "scaleway.autoscalingInstanceTemplate.AutoscalingInstanceTemplateVolumesFromEmpty")]
        internal sealed class _Proxy : DeputyBase, scaleway.AutoscalingInstanceTemplate.IAutoscalingInstanceTemplateVolumesFromEmpty
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Size in GB of the new empty volume.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#size AutoscalingInstanceTemplate#size}
            /// </remarks>
            [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
            public double Size
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
