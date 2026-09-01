using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace acme.Certificate
{
    [JsiiInterface(nativeType: typeof(ICertificateDnsChallenge), fullyQualifiedName: "acme.certificate.CertificateDnsChallenge")]
    public interface ICertificateDnsChallenge
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/3.0.1/docs/resources/certificate#provider Certificate#provider}.</summary>
        [JsiiProperty(name: "provider", typeJson: "{\"primitive\":\"string\"}")]
        string Provider
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/3.0.1/docs/resources/certificate#config Certificate#config}.</summary>
        [JsiiProperty(name: "config", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Config
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/3.0.1/docs/resources/certificate#match_domains Certificate#match_domains}.</summary>
        [JsiiProperty(name: "matchDomains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? MatchDomains
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICertificateDnsChallenge), fullyQualifiedName: "acme.certificate.CertificateDnsChallenge")]
        internal sealed class _Proxy : DeputyBase, acme.Certificate.ICertificateDnsChallenge
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/3.0.1/docs/resources/certificate#provider Certificate#provider}.</summary>
            [JsiiProperty(name: "provider", typeJson: "{\"primitive\":\"string\"}")]
            public string Provider
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/3.0.1/docs/resources/certificate#config Certificate#config}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "config", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Config
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/3.0.1/docs/resources/certificate#match_domains Certificate#match_domains}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "matchDomains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? MatchDomains
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
