using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.OriginCaCertificate
{
    [JsiiInterface(nativeType: typeof(IOriginCaCertificateConfig), fullyQualifiedName: "cloudflare.originCaCertificate.OriginCaCertificateConfig")]
    public interface IOriginCaCertificateConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The Certificate Signing Request (CSR). Must be newline-encoded.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/origin_ca_certificate#csr OriginCaCertificate#csr}
        /// </remarks>
        [JsiiProperty(name: "csr", typeJson: "{\"primitive\":\"string\"}")]
        string Csr
        {
            get;
        }

        /// <summary>Array of hostnames or wildcard names bound to the certificate.</summary>
        /// <remarks>
        /// Hostnames must be fully qualified domain names (FQDNs) belonging to zones on your account (e.g., <c>example.com</c> or <c>sub.example.com</c>). Wildcards are supported only as a <c>*.</c> prefix for a single level (e.g., <c>*.example.com</c>). Double wildcards (<c>*.*.example.com</c>) and interior wildcards (<c>foo.*.example.com</c>) are not allowed. The wildcard suffix must be a multi-label domain (<c>*.example.com</c> is valid, but <c>*.com</c> is not). Unicode/IDN hostnames are accepted and automatically converted to punycode.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/origin_ca_certificate#hostnames OriginCaCertificate#hostnames}
        /// </remarks>
        [JsiiProperty(name: "hostnames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Hostnames
        {
            get;
        }

        /// <summary>Signature type desired on certificate ("origin-rsa" (rsa), "origin-ecc" (ecdsa), or "keyless-certificate" (for Keyless SSL servers). Available values: "origin-rsa", "origin-ecc", "keyless-certificate".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/origin_ca_certificate#request_type OriginCaCertificate#request_type}
        /// </remarks>
        [JsiiProperty(name: "requestType", typeJson: "{\"primitive\":\"string\"}")]
        string RequestType
        {
            get;
        }

        /// <summary>The number of days for which the certificate should be valid. Available values: 7, 30, 90, 365, 730, 1095, 5475.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/origin_ca_certificate#requested_validity OriginCaCertificate#requested_validity}
        /// </remarks>
        [JsiiProperty(name: "requestedValidity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RequestedValidity
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOriginCaCertificateConfig), fullyQualifiedName: "cloudflare.originCaCertificate.OriginCaCertificateConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.OriginCaCertificate.IOriginCaCertificateConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The Certificate Signing Request (CSR). Must be newline-encoded.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/origin_ca_certificate#csr OriginCaCertificate#csr}
            /// </remarks>
            [JsiiProperty(name: "csr", typeJson: "{\"primitive\":\"string\"}")]
            public string Csr
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Array of hostnames or wildcard names bound to the certificate.</summary>
            /// <remarks>
            /// Hostnames must be fully qualified domain names (FQDNs) belonging to zones on your account (e.g., <c>example.com</c> or <c>sub.example.com</c>). Wildcards are supported only as a <c>*.</c> prefix for a single level (e.g., <c>*.example.com</c>). Double wildcards (<c>*.*.example.com</c>) and interior wildcards (<c>foo.*.example.com</c>) are not allowed. The wildcard suffix must be a multi-label domain (<c>*.example.com</c> is valid, but <c>*.com</c> is not). Unicode/IDN hostnames are accepted and automatically converted to punycode.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/origin_ca_certificate#hostnames OriginCaCertificate#hostnames}
            /// </remarks>
            [JsiiProperty(name: "hostnames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Hostnames
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Signature type desired on certificate ("origin-rsa" (rsa), "origin-ecc" (ecdsa), or "keyless-certificate" (for Keyless SSL servers). Available values: "origin-rsa", "origin-ecc", "keyless-certificate".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/origin_ca_certificate#request_type OriginCaCertificate#request_type}
            /// </remarks>
            [JsiiProperty(name: "requestType", typeJson: "{\"primitive\":\"string\"}")]
            public string RequestType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The number of days for which the certificate should be valid. Available values: 7, 30, 90, 365, 730, 1095, 5475.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/origin_ca_certificate#requested_validity OriginCaCertificate#requested_validity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestedValidity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RequestedValidity
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
