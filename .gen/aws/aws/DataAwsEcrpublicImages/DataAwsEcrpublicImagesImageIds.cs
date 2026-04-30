using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEcrpublicImages
{
    [JsiiByValue(fqn: "aws.dataAwsEcrpublicImages.DataAwsEcrpublicImagesImageIds")]
    public class DataAwsEcrpublicImagesImageIds : aws.DataAwsEcrpublicImages.IDataAwsEcrpublicImagesImageIds
    {
        /// <summary>Image digest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/ecrpublic_images#image_digest DataAwsEcrpublicImages#image_digest}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "imageDigest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ImageDigest
        {
            get;
            set;
        }

        /// <summary>Image tag.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/ecrpublic_images#image_tag DataAwsEcrpublicImages#image_tag}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "imageTag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ImageTag
        {
            get;
            set;
        }
    }
}
