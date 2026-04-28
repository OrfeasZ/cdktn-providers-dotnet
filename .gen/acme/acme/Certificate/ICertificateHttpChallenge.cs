using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace acme.Certificate
{
    [JsiiInterface(nativeType: typeof(ICertificateHttpChallenge), fullyQualifiedName: "acme.certificate.CertificateHttpChallenge")]
    public interface ICertificateHttpChallenge
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.1/docs/resources/certificate#port Certificate#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Port
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.1/docs/resources/certificate#proxy_header Certificate#proxy_header}.</summary>
        [JsiiProperty(name: "proxyHeader", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProxyHeader
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICertificateHttpChallenge), fullyQualifiedName: "acme.certificate.CertificateHttpChallenge")]
        internal sealed class _Proxy : DeputyBase, acme.Certificate.ICertificateHttpChallenge
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.1/docs/resources/certificate#port Certificate#port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Port
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.1/docs/resources/certificate#proxy_header Certificate#proxy_header}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "proxyHeader", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProxyHeader
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
