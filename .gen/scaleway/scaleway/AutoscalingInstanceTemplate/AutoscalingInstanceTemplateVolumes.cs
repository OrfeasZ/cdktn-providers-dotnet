using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.AutoscalingInstanceTemplate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.autoscalingInstanceTemplate.AutoscalingInstanceTemplateVolumes")]
    public class AutoscalingInstanceTemplateVolumes : scaleway.AutoscalingInstanceTemplate.IAutoscalingInstanceTemplateVolumes
    {
        /// <summary>The name of the volume.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/autoscaling_instance_template#name AutoscalingInstanceTemplate#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Type of the volume.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/autoscaling_instance_template#volume_type AutoscalingInstanceTemplate#volume_type}
        /// </remarks>
        [JsiiProperty(name: "volumeType", typeJson: "{\"primitive\":\"string\"}")]
        public string VolumeType
        {
            get;
            set;
        }

        private object? _boot;

        /// <summary>Force the Instance to boot on this volume.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/autoscaling_instance_template#boot AutoscalingInstanceTemplate#boot}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "boot", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Boot
        {
            get => _boot;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _boot = value;
            }
        }

        /// <summary>from_empty block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/autoscaling_instance_template#from_empty AutoscalingInstanceTemplate#from_empty}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fromEmpty", typeJson: "{\"fqn\":\"scaleway.autoscalingInstanceTemplate.AutoscalingInstanceTemplateVolumesFromEmpty\"}", isOptional: true)]
        public scaleway.AutoscalingInstanceTemplate.IAutoscalingInstanceTemplateVolumesFromEmpty? FromEmpty
        {
            get;
            set;
        }

        /// <summary>from_snapshot block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/autoscaling_instance_template#from_snapshot AutoscalingInstanceTemplate#from_snapshot}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fromSnapshot", typeJson: "{\"fqn\":\"scaleway.autoscalingInstanceTemplate.AutoscalingInstanceTemplateVolumesFromSnapshot\"}", isOptional: true)]
        public scaleway.AutoscalingInstanceTemplate.IAutoscalingInstanceTemplateVolumesFromSnapshot? FromSnapshot
        {
            get;
            set;
        }

        /// <summary>The maximum IO/s expected, according to the different options available in stock (`5000 | 15000`).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/autoscaling_instance_template#perf_iops AutoscalingInstanceTemplate#perf_iops}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "perfIops", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PerfIops
        {
            get;
            set;
        }

        /// <summary>List of tags assigned to the volume.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/autoscaling_instance_template#tags AutoscalingInstanceTemplate#tags}
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
