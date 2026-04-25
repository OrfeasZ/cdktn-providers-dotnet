using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessApplicationPoliciesConnectionRulesSsh), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesConnectionRulesSsh")]
    public interface IZeroTrustAccessApplicationPoliciesConnectionRulesSsh
    {
        /// <summary>Contains the Unix usernames that may be used when connecting over SSH.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#usernames ZeroTrustAccessApplication#usernames}
        /// </remarks>
        [JsiiProperty(name: "usernames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Usernames
        {
            get;
        }

        /// <summary>Enables using Identity Provider email alias as SSH username.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#allow_email_alias ZeroTrustAccessApplication#allow_email_alias}
        /// </remarks>
        [JsiiProperty(name: "allowEmailAlias", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowEmailAlias
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessApplicationPoliciesConnectionRulesSsh), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesConnectionRulesSsh")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesConnectionRulesSsh
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Contains the Unix usernames that may be used when connecting over SSH.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#usernames ZeroTrustAccessApplication#usernames}
            /// </remarks>
            [JsiiProperty(name: "usernames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Usernames
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Enables using Identity Provider email alias as SSH username.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#allow_email_alias ZeroTrustAccessApplication#allow_email_alias}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowEmailAlias", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AllowEmailAlias
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
