using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace acme.Certificate
{
    [JsiiInterface(nativeType: typeof(ICertificateTlsChallenge), fullyQualifiedName: "acme.certificate.CertificateTlsChallenge")]
    public interface ICertificateTlsChallenge
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.47.0/docs/resources/certificate#port Certificate#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Port
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICertificateTlsChallenge), fullyQualifiedName: "acme.certificate.CertificateTlsChallenge")]
        internal sealed class _Proxy : DeputyBase, acme.Certificate.ICertificateTlsChallenge
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.47.0/docs/resources/certificate#port Certificate#port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Port
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
