using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustOrganization
{
    [JsiiInterface(nativeType: typeof(IZeroTrustOrganizationCustomPages), fullyQualifiedName: "cloudflare.zeroTrustOrganization.ZeroTrustOrganizationCustomPages")]
    public interface IZeroTrustOrganizationCustomPages
    {
        /// <summary>The uid of the custom page to use when a user is denied access after failing a non-identity rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#forbidden ZeroTrustOrganization#forbidden}
        /// </remarks>
        [JsiiProperty(name: "forbidden", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Forbidden
        {
            get
            {
                return null;
            }
        }

        /// <summary>The uid of the custom page to use when a user is denied access.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#identity_denied ZeroTrustOrganization#identity_denied}
        /// </remarks>
        [JsiiProperty(name: "identityDenied", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IdentityDenied
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustOrganizationCustomPages), fullyQualifiedName: "cloudflare.zeroTrustOrganization.ZeroTrustOrganizationCustomPages")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustOrganization.IZeroTrustOrganizationCustomPages
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The uid of the custom page to use when a user is denied access after failing a non-identity rule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#forbidden ZeroTrustOrganization#forbidden}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forbidden", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Forbidden
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The uid of the custom page to use when a user is denied access.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_organization#identity_denied ZeroTrustOrganization#identity_denied}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identityDenied", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IdentityDenied
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
