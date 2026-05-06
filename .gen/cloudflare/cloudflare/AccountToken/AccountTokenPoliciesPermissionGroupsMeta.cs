using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AccountToken
{
    [JsiiByValue(fqn: "cloudflare.accountToken.AccountTokenPoliciesPermissionGroupsMeta")]
    public class AccountTokenPoliciesPermissionGroupsMeta : cloudflare.AccountToken.IAccountTokenPoliciesPermissionGroupsMeta
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/account_token#key AccountToken#key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/account_token#value AccountToken#value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}
