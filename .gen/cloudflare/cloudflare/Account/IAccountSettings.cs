using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Account
{
    [JsiiInterface(nativeType: typeof(IAccountSettings), fullyQualifiedName: "cloudflare.account.AccountSettings")]
    public interface IAccountSettings
    {
        /// <summary>Sets an abuse contact email to notify for abuse reports.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/account#abuse_contact_email Account#abuse_contact_email}
        /// </remarks>
        [JsiiProperty(name: "abuseContactEmail", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AbuseContactEmail
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicates whether membership in this account requires that Two-Factor Authentication is enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/account#enforce_twofactor Account#enforce_twofactor}
        /// </remarks>
        [JsiiProperty(name: "enforceTwofactor", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnforceTwofactor
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAccountSettings), fullyQualifiedName: "cloudflare.account.AccountSettings")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Account.IAccountSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets an abuse contact email to notify for abuse reports.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/account#abuse_contact_email Account#abuse_contact_email}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "abuseContactEmail", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AbuseContactEmail
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Indicates whether membership in this account requires that Two-Factor Authentication is enabled.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/account#enforce_twofactor Account#enforce_twofactor}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enforceTwofactor", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EnforceTwofactor
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
