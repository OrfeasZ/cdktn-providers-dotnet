using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.LbCertificate
{
    [JsiiInterface(nativeType: typeof(ILbCertificateLetsencrypt), fullyQualifiedName: "scaleway.lbCertificate.LbCertificateLetsencrypt")]
    public interface ILbCertificateLetsencrypt
    {
        /// <summary>The main domain name of the certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_certificate#common_name LbCertificate#common_name}
        /// </remarks>
        [JsiiProperty(name: "commonName", typeJson: "{\"primitive\":\"string\"}")]
        string CommonName
        {
            get;
        }

        /// <summary>The alternative domain names of the certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_certificate#subject_alternative_name LbCertificate#subject_alternative_name}
        /// </remarks>
        [JsiiProperty(name: "subjectAlternativeName", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SubjectAlternativeName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILbCertificateLetsencrypt), fullyQualifiedName: "scaleway.lbCertificate.LbCertificateLetsencrypt")]
        internal sealed class _Proxy : DeputyBase, scaleway.LbCertificate.ILbCertificateLetsencrypt
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The main domain name of the certificate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_certificate#common_name LbCertificate#common_name}
            /// </remarks>
            [JsiiProperty(name: "commonName", typeJson: "{\"primitive\":\"string\"}")]
            public string CommonName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The alternative domain names of the certificate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_certificate#subject_alternative_name LbCertificate#subject_alternative_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "subjectAlternativeName", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SubjectAlternativeName
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
