using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ImagebuilderImagePipeline
{
    [JsiiInterface(nativeType: typeof(IImagebuilderImagePipelineLoggingConfiguration), fullyQualifiedName: "aws.imagebuilderImagePipeline.ImagebuilderImagePipelineLoggingConfiguration")]
    public interface IImagebuilderImagePipelineLoggingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/imagebuilder_image_pipeline#image_log_group_name ImagebuilderImagePipeline#image_log_group_name}.</summary>
        [JsiiProperty(name: "imageLogGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ImageLogGroupName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/imagebuilder_image_pipeline#pipeline_log_group_name ImagebuilderImagePipeline#pipeline_log_group_name}.</summary>
        [JsiiProperty(name: "pipelineLogGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PipelineLogGroupName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IImagebuilderImagePipelineLoggingConfiguration), fullyQualifiedName: "aws.imagebuilderImagePipeline.ImagebuilderImagePipelineLoggingConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.ImagebuilderImagePipeline.IImagebuilderImagePipelineLoggingConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/imagebuilder_image_pipeline#image_log_group_name ImagebuilderImagePipeline#image_log_group_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "imageLogGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ImageLogGroupName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/imagebuilder_image_pipeline#pipeline_log_group_name ImagebuilderImagePipeline#pipeline_log_group_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pipelineLogGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PipelineLogGroupName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
