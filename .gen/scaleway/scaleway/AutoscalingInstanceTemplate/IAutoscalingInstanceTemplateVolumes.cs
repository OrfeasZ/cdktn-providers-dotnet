using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.AutoscalingInstanceTemplate
{
    [JsiiInterface(nativeType: typeof(IAutoscalingInstanceTemplateVolumes), fullyQualifiedName: "scaleway.autoscalingInstanceTemplate.AutoscalingInstanceTemplateVolumes")]
    public interface IAutoscalingInstanceTemplateVolumes
    {
        /// <summary>The name of the volume.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#name AutoscalingInstanceTemplate#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Type of the volume.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#volume_type AutoscalingInstanceTemplate#volume_type}
        /// </remarks>
        [JsiiProperty(name: "volumeType", typeJson: "{\"primitive\":\"string\"}")]
        string VolumeType
        {
            get;
        }

        /// <summary>Force the Instance to boot on this volume.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#boot AutoscalingInstanceTemplate#boot}
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

        /// <summary>from_empty block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#from_empty AutoscalingInstanceTemplate#from_empty}
        /// </remarks>
        [JsiiProperty(name: "fromEmpty", typeJson: "{\"fqn\":\"scaleway.autoscalingInstanceTemplate.AutoscalingInstanceTemplateVolumesFromEmpty\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.AutoscalingInstanceTemplate.IAutoscalingInstanceTemplateVolumesFromEmpty? FromEmpty
        {
            get
            {
                return null;
            }
        }

        /// <summary>from_snapshot block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#from_snapshot AutoscalingInstanceTemplate#from_snapshot}
        /// </remarks>
        [JsiiProperty(name: "fromSnapshot", typeJson: "{\"fqn\":\"scaleway.autoscalingInstanceTemplate.AutoscalingInstanceTemplateVolumesFromSnapshot\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.AutoscalingInstanceTemplate.IAutoscalingInstanceTemplateVolumesFromSnapshot? FromSnapshot
        {
            get
            {
                return null;
            }
        }

        /// <summary>The maximum IO/s expected, according to the different options available in stock (`5000 | 15000`).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#perf_iops AutoscalingInstanceTemplate#perf_iops}
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

        /// <summary>List of tags assigned to the volume.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#tags AutoscalingInstanceTemplate#tags}
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

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingInstanceTemplateVolumes), fullyQualifiedName: "scaleway.autoscalingInstanceTemplate.AutoscalingInstanceTemplateVolumes")]
        internal sealed class _Proxy : DeputyBase, scaleway.AutoscalingInstanceTemplate.IAutoscalingInstanceTemplateVolumes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of the volume.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#name AutoscalingInstanceTemplate#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Type of the volume.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#volume_type AutoscalingInstanceTemplate#volume_type}
            /// </remarks>
            [JsiiProperty(name: "volumeType", typeJson: "{\"primitive\":\"string\"}")]
            public string VolumeType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Force the Instance to boot on this volume.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#boot AutoscalingInstanceTemplate#boot}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "boot", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Boot
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>from_empty block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#from_empty AutoscalingInstanceTemplate#from_empty}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fromEmpty", typeJson: "{\"fqn\":\"scaleway.autoscalingInstanceTemplate.AutoscalingInstanceTemplateVolumesFromEmpty\"}", isOptional: true)]
            public scaleway.AutoscalingInstanceTemplate.IAutoscalingInstanceTemplateVolumesFromEmpty? FromEmpty
            {
                get => GetInstanceProperty<scaleway.AutoscalingInstanceTemplate.IAutoscalingInstanceTemplateVolumesFromEmpty?>();
            }

            /// <summary>from_snapshot block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#from_snapshot AutoscalingInstanceTemplate#from_snapshot}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fromSnapshot", typeJson: "{\"fqn\":\"scaleway.autoscalingInstanceTemplate.AutoscalingInstanceTemplateVolumesFromSnapshot\"}", isOptional: true)]
            public scaleway.AutoscalingInstanceTemplate.IAutoscalingInstanceTemplateVolumesFromSnapshot? FromSnapshot
            {
                get => GetInstanceProperty<scaleway.AutoscalingInstanceTemplate.IAutoscalingInstanceTemplateVolumesFromSnapshot?>();
            }

            /// <summary>The maximum IO/s expected, according to the different options available in stock (`5000 | 15000`).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#perf_iops AutoscalingInstanceTemplate#perf_iops}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "perfIops", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PerfIops
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>List of tags assigned to the volume.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_template#tags AutoscalingInstanceTemplate#tags}
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
