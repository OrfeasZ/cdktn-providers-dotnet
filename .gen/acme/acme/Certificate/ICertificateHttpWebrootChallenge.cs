using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace acme.Certificate
{
    [JsiiInterface(nativeType: typeof(ICertificateHttpWebrootChallenge), fullyQualifiedName: "acme.certificate.CertificateHttpWebrootChallenge")]
    public interface ICertificateHttpWebrootChallenge
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.1/docs/resources/certificate#directory Certificate#directory}.</summary>
        [JsiiProperty(name: "directory", typeJson: "{\"primitive\":\"string\"}")]
        string Directory
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICertificateHttpWebrootChallenge), fullyQualifiedName: "acme.certificate.CertificateHttpWebrootChallenge")]
        internal sealed class _Proxy : DeputyBase, acme.Certificate.ICertificateHttpWebrootChallenge
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.1/docs/resources/certificate#directory Certificate#directory}.</summary>
            [JsiiProperty(name: "directory", typeJson: "{\"primitive\":\"string\"}")]
            public string Directory
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
