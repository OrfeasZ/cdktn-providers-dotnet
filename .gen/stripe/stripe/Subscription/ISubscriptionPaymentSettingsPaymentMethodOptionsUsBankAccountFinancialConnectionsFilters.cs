using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiInterface(nativeType: typeof(ISubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters), fullyQualifiedName: "stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters")]
    public interface ISubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters
    {
        /// <summary>The account subcategories to use to filter for possible accounts to link. Valid subcategories are `checking` and `savings`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#account_subcategories Subscription#account_subcategories}
        /// </remarks>
        [JsiiProperty(name: "accountSubcategories", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AccountSubcategories
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters), fullyQualifiedName: "stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters")]
        internal sealed class _Proxy : DeputyBase, stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The account subcategories to use to filter for possible accounts to link. Valid subcategories are `checking` and `savings`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#account_subcategories Subscription#account_subcategories}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accountSubcategories", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AccountSubcategories
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
