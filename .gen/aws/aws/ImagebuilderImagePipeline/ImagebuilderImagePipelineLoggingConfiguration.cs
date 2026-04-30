using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ImagebuilderImagePipeline
{
    [JsiiByValue(fqn: "aws.imagebuilderImagePipeline.ImagebuilderImagePipelineLoggingConfiguration")]
    public class ImagebuilderImagePipelineLoggingConfiguration : aws.ImagebuilderImagePipeline.IImagebuilderImagePipelineLoggingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/imagebuilder_image_pipeline#image_log_group_name ImagebuilderImagePipeline#image_log_group_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "imageLogGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ImageLogGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/imagebuilder_image_pipeline#pipeline_log_group_name ImagebuilderImagePipeline#pipeline_log_group_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pipelineLogGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PipelineLogGroupName
        {
            get;
            set;
        }
    }
}
