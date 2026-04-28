using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace acme.Certificate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "acme.certificate.CertificateHttpWebrootChallenge")]
    public class CertificateHttpWebrootChallenge : acme.Certificate.ICertificateHttpWebrootChallenge
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.1/docs/resources/certificate#directory Certificate#directory}.</summary>
        [JsiiProperty(name: "directory", typeJson: "{\"primitive\":\"string\"}")]
        public string Directory
        {
            get;
            set;
        }
    }
}
