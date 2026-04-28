using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace acme.Certificate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "acme.certificate.CertificateDnsChallenge")]
    public class CertificateDnsChallenge : acme.Certificate.ICertificateDnsChallenge
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.1/docs/resources/certificate#provider Certificate#provider}.</summary>
        [JsiiProperty(name: "provider", typeJson: "{\"primitive\":\"string\"}")]
        public string Provider
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.1/docs/resources/certificate#config Certificate#config}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "config", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Config
        {
            get;
            set;
        }
    }
}
