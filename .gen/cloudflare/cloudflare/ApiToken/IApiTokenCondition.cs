using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ApiToken
{
    [JsiiInterface(nativeType: typeof(IApiTokenCondition), fullyQualifiedName: "cloudflare.apiToken.ApiTokenCondition")]
    public interface IApiTokenCondition
    {
        /// <summary>Client IP restrictions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/api_token#request_ip ApiToken#request_ip}
        /// </remarks>
        [JsiiProperty(name: "requestIp", typeJson: "{\"fqn\":\"cloudflare.apiToken.ApiTokenConditionRequestIp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ApiToken.IApiTokenConditionRequestIp? RequestIp
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiTokenCondition), fullyQualifiedName: "cloudflare.apiToken.ApiTokenCondition")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ApiToken.IApiTokenCondition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Client IP restrictions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/api_token#request_ip ApiToken#request_ip}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestIp", typeJson: "{\"fqn\":\"cloudflare.apiToken.ApiTokenConditionRequestIp\"}", isOptional: true)]
            public cloudflare.ApiToken.IApiTokenConditionRequestIp? RequestIp
            {
                get => GetInstanceProperty<cloudflare.ApiToken.IApiTokenConditionRequestIp?>();
            }
        }
    }
}
