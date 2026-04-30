using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ImagebuilderImage
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.imagebuilderImage.ImagebuilderImageLoggingConfiguration")]
    public class ImagebuilderImageLoggingConfiguration : aws.ImagebuilderImage.IImagebuilderImageLoggingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/imagebuilder_image#log_group_name ImagebuilderImage#log_group_name}.</summary>
        [JsiiProperty(name: "logGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public string LogGroupName
        {
            get;
            set;
        }
    }
}
