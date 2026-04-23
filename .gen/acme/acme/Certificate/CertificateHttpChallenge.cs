using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace acme.Certificate
{
    [JsiiByValue(fqn: "acme.certificate.CertificateHttpChallenge")]
    public class CertificateHttpChallenge : acme.Certificate.ICertificateHttpChallenge
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#port Certificate#port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#proxy_header Certificate#proxy_header}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "proxyHeader", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProxyHeader
        {
            get;
            set;
        }
    }
}
