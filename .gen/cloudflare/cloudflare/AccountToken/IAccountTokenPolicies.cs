using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AccountToken
{
    [JsiiInterface(nativeType: typeof(IAccountTokenPolicies), fullyQualifiedName: "cloudflare.accountToken.AccountTokenPolicies")]
    public interface IAccountTokenPolicies
    {
        /// <summary>Allow or deny operations against the resources. Available values: "allow", "deny".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/account_token#effect AccountToken#effect}
        /// </remarks>
        [JsiiProperty(name: "effect", typeJson: "{\"primitive\":\"string\"}")]
        string Effect
        {
            get;
        }

        /// <summary>A set of permission groups that are specified to the policy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/account_token#permission_groups AccountToken#permission_groups}
        /// </remarks>
        [JsiiProperty(name: "permissionGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.accountToken.AccountTokenPoliciesPermissionGroups\"},\"kind\":\"array\"}}]}}")]
        object PermissionGroups
        {
            get;
        }

        /// <summary>A json object representing the resources that are specified to the policy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/account_token#resources AccountToken#resources}
        /// </remarks>
        [JsiiProperty(name: "resources", typeJson: "{\"primitive\":\"string\"}")]
        string Resources
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAccountTokenPolicies), fullyQualifiedName: "cloudflare.accountToken.AccountTokenPolicies")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AccountToken.IAccountTokenPolicies
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Allow or deny operations against the resources. Available values: "allow", "deny".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/account_token#effect AccountToken#effect}
            /// </remarks>
            [JsiiProperty(name: "effect", typeJson: "{\"primitive\":\"string\"}")]
            public string Effect
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A set of permission groups that are specified to the policy.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/account_token#permission_groups AccountToken#permission_groups}
            /// </remarks>
            [JsiiProperty(name: "permissionGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.accountToken.AccountTokenPoliciesPermissionGroups\"},\"kind\":\"array\"}}]}}")]
            public object PermissionGroups
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>A json object representing the resources that are specified to the policy.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/account_token#resources AccountToken#resources}
            /// </remarks>
            [JsiiProperty(name: "resources", typeJson: "{\"primitive\":\"string\"}")]
            public string Resources
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
