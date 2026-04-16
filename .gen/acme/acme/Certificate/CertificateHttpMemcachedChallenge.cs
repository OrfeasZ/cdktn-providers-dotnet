using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace acme.Certificate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "acme.certificate.CertificateHttpMemcachedChallenge")]
    public class CertificateHttpMemcachedChallenge : acme.Certificate.ICertificateHttpMemcachedChallenge
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.47.0/docs/resources/certificate#hosts Certificate#hosts}.</summary>
        [JsiiProperty(name: "hosts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Hosts
        {
            get;
            set;
        }
    }
}
