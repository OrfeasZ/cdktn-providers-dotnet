using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ImagebuilderImagePipeline
{
    [JsiiByValue(fqn: "aws.imagebuilderImagePipeline.ImagebuilderImagePipelineImageScanningConfiguration")]
    public class ImagebuilderImagePipelineImageScanningConfiguration : aws.ImagebuilderImagePipeline.IImagebuilderImagePipelineImageScanningConfiguration
    {
        /// <summary>ecr_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/imagebuilder_image_pipeline#ecr_configuration ImagebuilderImagePipeline#ecr_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ecrConfiguration", typeJson: "{\"fqn\":\"aws.imagebuilderImagePipeline.ImagebuilderImagePipelineImageScanningConfigurationEcrConfiguration\"}", isOptional: true)]
        public aws.ImagebuilderImagePipeline.IImagebuilderImagePipelineImageScanningConfigurationEcrConfiguration? EcrConfiguration
        {
            get;
            set;
        }

        private object? _imageScanningEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/imagebuilder_image_pipeline#image_scanning_enabled ImagebuilderImagePipeline#image_scanning_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "imageScanningEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ImageScanningEnabled
        {
            get => _imageScanningEnabled;
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
                _imageScanningEnabled = value;
            }
        }
    }
}
