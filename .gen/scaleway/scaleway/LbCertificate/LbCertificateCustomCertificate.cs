using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.LbCertificate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.lbCertificate.LbCertificateCustomCertificate")]
    public class LbCertificateCustomCertificate : scaleway.LbCertificate.ILbCertificateCustomCertificate
    {
        /// <summary>The full PEM-formatted certificate chain.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_certificate#certificate_chain LbCertificate#certificate_chain}
        /// </remarks>
        [JsiiProperty(name: "certificateChain", typeJson: "{\"primitive\":\"string\"}")]
        public string CertificateChain
        {
            get;
            set;
        }
    }
}
