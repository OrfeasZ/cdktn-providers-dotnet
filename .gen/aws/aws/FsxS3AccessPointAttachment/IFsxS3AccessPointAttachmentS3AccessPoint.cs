using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxS3AccessPointAttachment
{
    [JsiiInterface(nativeType: typeof(IFsxS3AccessPointAttachmentS3AccessPoint), fullyQualifiedName: "aws.fsxS3AccessPointAttachment.FsxS3AccessPointAttachmentS3AccessPoint")]
    public interface IFsxS3AccessPointAttachmentS3AccessPoint
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/fsx_s3_access_point_attachment#policy FsxS3AccessPointAttachment#policy}.</summary>
        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Policy
        {
            get
            {
                return null;
            }
        }

        /// <summary>vpc_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/fsx_s3_access_point_attachment#vpc_configuration FsxS3AccessPointAttachment#vpc_configuration}
        /// </remarks>
        [JsiiProperty(name: "vpcConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsxS3AccessPointAttachment.FsxS3AccessPointAttachmentS3AccessPointVpcConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VpcConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFsxS3AccessPointAttachmentS3AccessPoint), fullyQualifiedName: "aws.fsxS3AccessPointAttachment.FsxS3AccessPointAttachmentS3AccessPoint")]
        internal sealed class _Proxy : DeputyBase, aws.FsxS3AccessPointAttachment.IFsxS3AccessPointAttachmentS3AccessPoint
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/fsx_s3_access_point_attachment#policy FsxS3AccessPointAttachment#policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Policy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>vpc_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/fsx_s3_access_point_attachment#vpc_configuration FsxS3AccessPointAttachment#vpc_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vpcConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsxS3AccessPointAttachment.FsxS3AccessPointAttachmentS3AccessPointVpcConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? VpcConfiguration
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
