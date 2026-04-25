using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AccountToken
{
    [JsiiInterface(nativeType: typeof(IAccountTokenCondition), fullyQualifiedName: "cloudflare.accountToken.AccountTokenCondition")]
    public interface IAccountTokenCondition
    {
        /// <summary>Client IP restrictions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/account_token#request_ip AccountToken#request_ip}
        /// </remarks>
        [JsiiProperty(name: "requestIp", typeJson: "{\"fqn\":\"cloudflare.accountToken.AccountTokenConditionRequestIp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.AccountToken.IAccountTokenConditionRequestIp? RequestIp
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAccountTokenCondition), fullyQualifiedName: "cloudflare.accountToken.AccountTokenCondition")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AccountToken.IAccountTokenCondition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Client IP restrictions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/account_token#request_ip AccountToken#request_ip}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestIp", typeJson: "{\"fqn\":\"cloudflare.accountToken.AccountTokenConditionRequestIp\"}", isOptional: true)]
            public cloudflare.AccountToken.IAccountTokenConditionRequestIp? RequestIp
            {
                get => GetInstanceProperty<cloudflare.AccountToken.IAccountTokenConditionRequestIp?>();
            }
        }
    }
}
