using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ApiToken
{
    [JsiiByValue(fqn: "cloudflare.apiToken.ApiTokenConditionRequestIp")]
    public class ApiTokenConditionRequestIp : cloudflare.ApiToken.IApiTokenConditionRequestIp
    {
        /// <summary>List of IPv4/IPv6 CIDR addresses.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/api_token#in ApiToken#in}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "in", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? In
        {
            get;
            set;
        }

        /// <summary>List of IPv4/IPv6 CIDR addresses.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/api_token#not_in ApiToken#not_in}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "notIn", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NotIn
        {
            get;
            set;
        }
    }
}
