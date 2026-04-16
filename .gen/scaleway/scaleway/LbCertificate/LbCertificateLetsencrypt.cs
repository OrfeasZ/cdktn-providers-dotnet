using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.LbCertificate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.lbCertificate.LbCertificateLetsencrypt")]
    public class LbCertificateLetsencrypt : scaleway.LbCertificate.ILbCertificateLetsencrypt
    {
        /// <summary>The main domain name of the certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_certificate#common_name LbCertificate#common_name}
        /// </remarks>
        [JsiiProperty(name: "commonName", typeJson: "{\"primitive\":\"string\"}")]
        public string CommonName
        {
            get;
            set;
        }

        /// <summary>The alternative domain names of the certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_certificate#subject_alternative_name LbCertificate#subject_alternative_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "subjectAlternativeName", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SubjectAlternativeName
        {
            get;
            set;
        }
    }
}
