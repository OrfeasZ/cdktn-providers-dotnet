using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AcmCertificate
{
    [JsiiByValue(fqn: "aws.acmCertificate.AcmCertificateOptions")]
    public class AcmCertificateOptions : aws.AcmCertificate.IAcmCertificateOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/acm_certificate#certificate_transparency_logging_preference AcmCertificate#certificate_transparency_logging_preference}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificateTransparencyLoggingPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateTransparencyLoggingPreference
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/acm_certificate#export AcmCertificate#export}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "export", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Export
        {
            get;
            set;
        }
    }
}
