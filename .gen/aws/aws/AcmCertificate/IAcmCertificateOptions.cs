using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AcmCertificate
{
    [JsiiInterface(nativeType: typeof(IAcmCertificateOptions), fullyQualifiedName: "aws.acmCertificate.AcmCertificateOptions")]
    public interface IAcmCertificateOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/acm_certificate#certificate_transparency_logging_preference AcmCertificate#certificate_transparency_logging_preference}.</summary>
        [JsiiProperty(name: "certificateTransparencyLoggingPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateTransparencyLoggingPreference
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/acm_certificate#export AcmCertificate#export}.</summary>
        [JsiiProperty(name: "export", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Export
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAcmCertificateOptions), fullyQualifiedName: "aws.acmCertificate.AcmCertificateOptions")]
        internal sealed class _Proxy : DeputyBase, aws.AcmCertificate.IAcmCertificateOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/acm_certificate#certificate_transparency_logging_preference AcmCertificate#certificate_transparency_logging_preference}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificateTransparencyLoggingPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateTransparencyLoggingPreference
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/acm_certificate#export AcmCertificate#export}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "export", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Export
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
