using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.LbCertificate
{
    [JsiiInterface(nativeType: typeof(ILbCertificateCustomCertificate), fullyQualifiedName: "scaleway.lbCertificate.LbCertificateCustomCertificate")]
    public interface ILbCertificateCustomCertificate
    {
        /// <summary>The full PEM-formatted certificate chain.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_certificate#certificate_chain LbCertificate#certificate_chain}
        /// </remarks>
        [JsiiProperty(name: "certificateChain", typeJson: "{\"primitive\":\"string\"}")]
        string CertificateChain
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILbCertificateCustomCertificate), fullyQualifiedName: "scaleway.lbCertificate.LbCertificateCustomCertificate")]
        internal sealed class _Proxy : DeputyBase, scaleway.LbCertificate.ILbCertificateCustomCertificate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The full PEM-formatted certificate chain.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_certificate#certificate_chain LbCertificate#certificate_chain}
            /// </remarks>
            [JsiiProperty(name: "certificateChain", typeJson: "{\"primitive\":\"string\"}")]
            public string CertificateChain
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
