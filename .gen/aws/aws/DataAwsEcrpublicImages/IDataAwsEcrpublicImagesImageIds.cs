using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEcrpublicImages
{
    [JsiiInterface(nativeType: typeof(IDataAwsEcrpublicImagesImageIds), fullyQualifiedName: "aws.dataAwsEcrpublicImages.DataAwsEcrpublicImagesImageIds")]
    public interface IDataAwsEcrpublicImagesImageIds
    {
        /// <summary>Image digest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/ecrpublic_images#image_digest DataAwsEcrpublicImages#image_digest}
        /// </remarks>
        [JsiiProperty(name: "imageDigest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ImageDigest
        {
            get
            {
                return null;
            }
        }

        /// <summary>Image tag.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/ecrpublic_images#image_tag DataAwsEcrpublicImages#image_tag}
        /// </remarks>
        [JsiiProperty(name: "imageTag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ImageTag
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsEcrpublicImagesImageIds), fullyQualifiedName: "aws.dataAwsEcrpublicImages.DataAwsEcrpublicImagesImageIds")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsEcrpublicImages.IDataAwsEcrpublicImagesImageIds
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Image digest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/ecrpublic_images#image_digest DataAwsEcrpublicImages#image_digest}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "imageDigest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ImageDigest
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Image tag.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/ecrpublic_images#image_tag DataAwsEcrpublicImages#image_tag}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "imageTag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ImageTag
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
