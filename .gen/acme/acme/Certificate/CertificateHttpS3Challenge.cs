using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace acme.Certificate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "acme.certificate.CertificateHttpS3Challenge")]
    public class CertificateHttpS3Challenge : acme.Certificate.ICertificateHttpS3Challenge
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#s3_bucket Certificate#s3_bucket}.</summary>
        [JsiiProperty(name: "s3Bucket", typeJson: "{\"primitive\":\"string\"}")]
        public string S3Bucket
        {
            get;
            set;
        }
    }
}
