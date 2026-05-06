using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.UsageProxySubscriptionRedeemableUser
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.usageProxySubscriptionRedeemableUser.UsageProxySubscriptionRedeemableUserItems")]
    public class UsageProxySubscriptionRedeemableUserItems : oci.UsageProxySubscriptionRedeemableUser.IUsageProxySubscriptionRedeemableUserItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/usage_proxy_subscription_redeemable_user#email_id UsageProxySubscriptionRedeemableUser#email_id}.</summary>
        [JsiiProperty(name: "emailId", typeJson: "{\"primitive\":\"string\"}")]
        public string EmailId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/usage_proxy_subscription_redeemable_user#first_name UsageProxySubscriptionRedeemableUser#first_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "firstName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FirstName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/usage_proxy_subscription_redeemable_user#last_name UsageProxySubscriptionRedeemableUser#last_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lastName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LastName
        {
            get;
            set;
        }
    }
}
