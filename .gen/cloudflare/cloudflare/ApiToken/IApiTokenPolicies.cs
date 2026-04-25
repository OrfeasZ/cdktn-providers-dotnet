using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ApiToken
{
    [JsiiInterface(nativeType: typeof(IApiTokenPolicies), fullyQualifiedName: "cloudflare.apiToken.ApiTokenPolicies")]
    public interface IApiTokenPolicies
    {
        /// <summary>Allow or deny operations against the resources. Available values: "allow", "deny".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/api_token#effect ApiToken#effect}
        /// </remarks>
        [JsiiProperty(name: "effect", typeJson: "{\"primitive\":\"string\"}")]
        string Effect
        {
            get;
        }

        /// <summary>A set of permission groups that are specified to the policy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/api_token#permission_groups ApiToken#permission_groups}
        /// </remarks>
        [JsiiProperty(name: "permissionGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.apiToken.ApiTokenPoliciesPermissionGroups\"},\"kind\":\"array\"}}]}}")]
        object PermissionGroups
        {
            get;
        }

        /// <summary>A json object representing the resources that are specified to the policy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/api_token#resources ApiToken#resources}
        /// </remarks>
        [JsiiProperty(name: "resources", typeJson: "{\"primitive\":\"string\"}")]
        string Resources
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApiTokenPolicies), fullyQualifiedName: "cloudflare.apiToken.ApiTokenPolicies")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ApiToken.IApiTokenPolicies
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Allow or deny operations against the resources. Available values: "allow", "deny".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/api_token#effect ApiToken#effect}
            /// </remarks>
            [JsiiProperty(name: "effect", typeJson: "{\"primitive\":\"string\"}")]
            public string Effect
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A set of permission groups that are specified to the policy.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/api_token#permission_groups ApiToken#permission_groups}
            /// </remarks>
            [JsiiProperty(name: "permissionGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.apiToken.ApiTokenPoliciesPermissionGroups\"},\"kind\":\"array\"}}]}}")]
            public object PermissionGroups
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>A json object representing the resources that are specified to the policy.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/api_token#resources ApiToken#resources}
            /// </remarks>
            [JsiiProperty(name: "resources", typeJson: "{\"primitive\":\"string\"}")]
            public string Resources
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
