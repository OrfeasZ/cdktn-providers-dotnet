using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.UsageProxySubscriptionRedeemableUser
{
    [JsiiByValue(fqn: "oci.usageProxySubscriptionRedeemableUser.UsageProxySubscriptionRedeemableUserTimeouts")]
    public class UsageProxySubscriptionRedeemableUserTimeouts : oci.UsageProxySubscriptionRedeemableUser.IUsageProxySubscriptionRedeemableUserTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/usage_proxy_subscription_redeemable_user#create UsageProxySubscriptionRedeemableUser#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/usage_proxy_subscription_redeemable_user#delete UsageProxySubscriptionRedeemableUser#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/usage_proxy_subscription_redeemable_user#update UsageProxySubscriptionRedeemableUser#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
