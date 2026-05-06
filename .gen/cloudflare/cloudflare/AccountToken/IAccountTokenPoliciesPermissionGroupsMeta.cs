using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AccountToken
{
    [JsiiInterface(nativeType: typeof(IAccountTokenPoliciesPermissionGroupsMeta), fullyQualifiedName: "cloudflare.accountToken.AccountTokenPoliciesPermissionGroupsMeta")]
    public interface IAccountTokenPoliciesPermissionGroupsMeta
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/account_token#key AccountToken#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Key
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/account_token#value AccountToken#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Value
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAccountTokenPoliciesPermissionGroupsMeta), fullyQualifiedName: "cloudflare.accountToken.AccountTokenPoliciesPermissionGroupsMeta")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AccountToken.IAccountTokenPoliciesPermissionGroupsMeta
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/account_token#key AccountToken#key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Key
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/account_token#value AccountToken#value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Value
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
