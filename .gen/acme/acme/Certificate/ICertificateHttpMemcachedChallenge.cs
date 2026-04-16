using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace acme.Certificate
{
    [JsiiInterface(nativeType: typeof(ICertificateHttpMemcachedChallenge), fullyQualifiedName: "acme.certificate.CertificateHttpMemcachedChallenge")]
    public interface ICertificateHttpMemcachedChallenge
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.47.0/docs/resources/certificate#hosts Certificate#hosts}.</summary>
        [JsiiProperty(name: "hosts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Hosts
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICertificateHttpMemcachedChallenge), fullyQualifiedName: "acme.certificate.CertificateHttpMemcachedChallenge")]
        internal sealed class _Proxy : DeputyBase, acme.Certificate.ICertificateHttpMemcachedChallenge
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.47.0/docs/resources/certificate#hosts Certificate#hosts}.</summary>
            [JsiiProperty(name: "hosts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Hosts
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
