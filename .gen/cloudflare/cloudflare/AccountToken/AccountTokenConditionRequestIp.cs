using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AccountToken
{
    [JsiiByValue(fqn: "cloudflare.accountToken.AccountTokenConditionRequestIp")]
    public class AccountTokenConditionRequestIp : cloudflare.AccountToken.IAccountTokenConditionRequestIp
    {
        /// <summary>List of IPv4/IPv6 CIDR addresses.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/account_token#in AccountToken#in}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/account_token#not_in AccountToken#not_in}
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
