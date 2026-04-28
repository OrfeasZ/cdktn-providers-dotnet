using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.AutoscalingInstanceTemplate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.autoscalingInstanceTemplate.AutoscalingInstanceTemplateVolumesFromEmpty")]
    public class AutoscalingInstanceTemplateVolumesFromEmpty : scaleway.AutoscalingInstanceTemplate.IAutoscalingInstanceTemplateVolumesFromEmpty
    {
        /// <summary>Size in GB of the new empty volume.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/autoscaling_instance_template#size AutoscalingInstanceTemplate#size}
        /// </remarks>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        public double Size
        {
            get;
            set;
        }
    }
}
