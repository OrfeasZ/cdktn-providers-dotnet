using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace acme.Certificate
{
    [JsiiInterface(nativeType: typeof(ICertificateHttpS3Challenge), fullyQualifiedName: "acme.certificate.CertificateHttpS3Challenge")]
    public interface ICertificateHttpS3Challenge
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#s3_bucket Certificate#s3_bucket}.</summary>
        [JsiiProperty(name: "s3Bucket", typeJson: "{\"primitive\":\"string\"}")]
        string S3Bucket
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICertificateHttpS3Challenge), fullyQualifiedName: "acme.certificate.CertificateHttpS3Challenge")]
        internal sealed class _Proxy : DeputyBase, acme.Certificate.ICertificateHttpS3Challenge
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/certificate#s3_bucket Certificate#s3_bucket}.</summary>
            [JsiiProperty(name: "s3Bucket", typeJson: "{\"primitive\":\"string\"}")]
            public string S3Bucket
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
