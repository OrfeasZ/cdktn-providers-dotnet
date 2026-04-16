using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxS3AccessPointAttachment
{
    [JsiiByValue(fqn: "aws.fsxS3AccessPointAttachment.FsxS3AccessPointAttachmentS3AccessPoint")]
    public class FsxS3AccessPointAttachmentS3AccessPoint : aws.FsxS3AccessPointAttachment.IFsxS3AccessPointAttachmentS3AccessPoint
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/fsx_s3_access_point_attachment#policy FsxS3AccessPointAttachment#policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Policy
        {
            get;
            set;
        }

        private object? _vpcConfiguration;

        /// <summary>vpc_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/fsx_s3_access_point_attachment#vpc_configuration FsxS3AccessPointAttachment#vpc_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vpcConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsxS3AccessPointAttachment.FsxS3AccessPointAttachmentS3AccessPointVpcConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? VpcConfiguration
        {
            get => _vpcConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.FsxS3AccessPointAttachment.IFsxS3AccessPointAttachmentS3AccessPointVpcConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.FsxS3AccessPointAttachment.IFsxS3AccessPointAttachmentS3AccessPointVpcConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _vpcConfiguration = value;
            }
        }
    }
}
