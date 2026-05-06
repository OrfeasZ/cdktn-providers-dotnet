using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.UsageProxySubscriptionRedeemableUser
{
    [JsiiInterface(nativeType: typeof(IUsageProxySubscriptionRedeemableUserItems), fullyQualifiedName: "oci.usageProxySubscriptionRedeemableUser.UsageProxySubscriptionRedeemableUserItems")]
    public interface IUsageProxySubscriptionRedeemableUserItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/usage_proxy_subscription_redeemable_user#email_id UsageProxySubscriptionRedeemableUser#email_id}.</summary>
        [JsiiProperty(name: "emailId", typeJson: "{\"primitive\":\"string\"}")]
        string EmailId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/usage_proxy_subscription_redeemable_user#first_name UsageProxySubscriptionRedeemableUser#first_name}.</summary>
        [JsiiProperty(name: "firstName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FirstName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/usage_proxy_subscription_redeemable_user#last_name UsageProxySubscriptionRedeemableUser#last_name}.</summary>
        [JsiiProperty(name: "lastName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LastName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IUsageProxySubscriptionRedeemableUserItems), fullyQualifiedName: "oci.usageProxySubscriptionRedeemableUser.UsageProxySubscriptionRedeemableUserItems")]
        internal sealed class _Proxy : DeputyBase, oci.UsageProxySubscriptionRedeemableUser.IUsageProxySubscriptionRedeemableUserItems
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/usage_proxy_subscription_redeemable_user#email_id UsageProxySubscriptionRedeemableUser#email_id}.</summary>
            [JsiiProperty(name: "emailId", typeJson: "{\"primitive\":\"string\"}")]
            public string EmailId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/usage_proxy_subscription_redeemable_user#first_name UsageProxySubscriptionRedeemableUser#first_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "firstName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FirstName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/usage_proxy_subscription_redeemable_user#last_name UsageProxySubscriptionRedeemableUser#last_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lastName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LastName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
