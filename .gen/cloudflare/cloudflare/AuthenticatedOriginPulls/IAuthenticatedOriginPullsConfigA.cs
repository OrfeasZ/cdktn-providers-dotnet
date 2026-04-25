using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AuthenticatedOriginPulls
{
    [JsiiInterface(nativeType: typeof(IAuthenticatedOriginPullsConfigA), fullyQualifiedName: "cloudflare.authenticatedOriginPulls.AuthenticatedOriginPullsConfigA")]
    public interface IAuthenticatedOriginPullsConfigA
    {
        /// <summary>Certificate identifier tag.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/authenticated_origin_pulls#cert_id AuthenticatedOriginPulls#cert_id}
        /// </remarks>
        [JsiiProperty(name: "certId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicates whether hostname-level authenticated origin pulls is enabled. A null value voids the association.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/authenticated_origin_pulls#enabled AuthenticatedOriginPulls#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>The hostname on the origin for which the client certificate uploaded will be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/authenticated_origin_pulls#hostname AuthenticatedOriginPulls#hostname}
        /// </remarks>
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Hostname
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAuthenticatedOriginPullsConfigA), fullyQualifiedName: "cloudflare.authenticatedOriginPulls.AuthenticatedOriginPullsConfigA")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AuthenticatedOriginPulls.IAuthenticatedOriginPullsConfigA
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Certificate identifier tag.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/authenticated_origin_pulls#cert_id AuthenticatedOriginPulls#cert_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "certId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Indicates whether hostname-level authenticated origin pulls is enabled. A null value voids the association.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/authenticated_origin_pulls#enabled AuthenticatedOriginPulls#enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The hostname on the origin for which the client certificate uploaded will be used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/authenticated_origin_pulls#hostname AuthenticatedOriginPulls#hostname}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Hostname
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
