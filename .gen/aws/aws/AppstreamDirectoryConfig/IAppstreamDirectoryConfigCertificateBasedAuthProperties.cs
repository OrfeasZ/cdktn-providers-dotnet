using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppstreamDirectoryConfig
{
    [JsiiInterface(nativeType: typeof(IAppstreamDirectoryConfigCertificateBasedAuthProperties), fullyQualifiedName: "aws.appstreamDirectoryConfig.AppstreamDirectoryConfigCertificateBasedAuthProperties")]
    public interface IAppstreamDirectoryConfigCertificateBasedAuthProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appstream_directory_config#certificate_authority_arn AppstreamDirectoryConfig#certificate_authority_arn}.</summary>
        [JsiiProperty(name: "certificateAuthorityArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateAuthorityArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appstream_directory_config#status AppstreamDirectoryConfig#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Status
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppstreamDirectoryConfigCertificateBasedAuthProperties), fullyQualifiedName: "aws.appstreamDirectoryConfig.AppstreamDirectoryConfigCertificateBasedAuthProperties")]
        internal sealed class _Proxy : DeputyBase, aws.AppstreamDirectoryConfig.IAppstreamDirectoryConfigCertificateBasedAuthProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appstream_directory_config#certificate_authority_arn AppstreamDirectoryConfig#certificate_authority_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificateAuthorityArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateAuthorityArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appstream_directory_config#status AppstreamDirectoryConfig#status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
