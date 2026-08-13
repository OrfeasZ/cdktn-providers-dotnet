using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiInterface(nativeType: typeof(ISubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalance), fullyQualifiedName: "stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalance")]
    public interface ISubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalance
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#bank_transfer Subscription#bank_transfer}.</summary>
        [JsiiProperty(name: "bankTransfer", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransfer\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransfer? BankTransfer
        {
            get
            {
                return null;
            }
        }

        /// <summary>The funding method type to be used when there are not enough funds in the customer balance.</summary>
        /// <remarks>
        /// Permitted values include: <c>bank_transfer</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#funding_type Subscription#funding_type}
        /// </remarks>
        [JsiiProperty(name: "fundingType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FundingType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalance), fullyQualifiedName: "stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalance")]
        internal sealed class _Proxy : DeputyBase, stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalance
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#bank_transfer Subscription#bank_transfer}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bankTransfer", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransfer\"}", isOptional: true)]
            public stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransfer? BankTransfer
            {
                get => GetInstanceProperty<stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransfer?>();
            }

            /// <summary>The funding method type to be used when there are not enough funds in the customer balance.</summary>
            /// <remarks>
            /// Permitted values include: <c>bank_transfer</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#funding_type Subscription#funding_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fundingType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FundingType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
