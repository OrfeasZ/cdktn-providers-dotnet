using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppstreamDirectoryConfig
{
    [JsiiByValue(fqn: "aws.appstreamDirectoryConfig.AppstreamDirectoryConfigCertificateBasedAuthProperties")]
    public class AppstreamDirectoryConfigCertificateBasedAuthProperties : aws.AppstreamDirectoryConfig.IAppstreamDirectoryConfigCertificateBasedAuthProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appstream_directory_config#certificate_authority_arn AppstreamDirectoryConfig#certificate_authority_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificateAuthorityArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateAuthorityArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appstream_directory_config#status AppstreamDirectoryConfig#status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Status
        {
            get;
            set;
        }
    }
}
