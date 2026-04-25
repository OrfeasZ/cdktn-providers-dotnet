using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AccountToken
{
    [JsiiByValue(fqn: "cloudflare.accountToken.AccountTokenCondition")]
    public class AccountTokenCondition : cloudflare.AccountToken.IAccountTokenCondition
    {
        /// <summary>Client IP restrictions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/account_token#request_ip AccountToken#request_ip}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestIp", typeJson: "{\"fqn\":\"cloudflare.accountToken.AccountTokenConditionRequestIp\"}", isOptional: true)]
        public cloudflare.AccountToken.IAccountTokenConditionRequestIp? RequestIp
        {
            get;
            set;
        }
    }
}
