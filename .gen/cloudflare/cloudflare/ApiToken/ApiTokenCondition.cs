using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ApiToken
{
    [JsiiByValue(fqn: "cloudflare.apiToken.ApiTokenCondition")]
    public class ApiTokenCondition : cloudflare.ApiToken.IApiTokenCondition
    {
        /// <summary>Client IP restrictions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/api_token#request_ip ApiToken#request_ip}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestIp", typeJson: "{\"fqn\":\"cloudflare.apiToken.ApiTokenConditionRequestIp\"}", isOptional: true)]
        public cloudflare.ApiToken.IApiTokenConditionRequestIp? RequestIp
        {
            get;
            set;
        }
    }
}
