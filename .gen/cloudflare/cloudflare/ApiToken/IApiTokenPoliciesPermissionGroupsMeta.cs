using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ApiToken
{
    [JsiiInterface(nativeType: typeof(IApiTokenPoliciesPermissionGroupsMeta), fullyQualifiedName: "cloudflare.apiToken.ApiTokenPoliciesPermissionGroupsMeta")]
    public interface IApiTokenPoliciesPermissionGroupsMeta
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/api_token#key ApiToken#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Key
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/api_token#value ApiToken#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Value
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiTokenPoliciesPermissionGroupsMeta), fullyQualifiedName: "cloudflare.apiToken.ApiTokenPoliciesPermissionGroupsMeta")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ApiToken.IApiTokenPoliciesPermissionGroupsMeta
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/api_token#key ApiToken#key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Key
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/api_token#value ApiToken#value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Value
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
