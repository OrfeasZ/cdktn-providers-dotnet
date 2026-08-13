using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiInterface(nativeType: typeof(ISubscriptionPaymentSettingsPaymentMethodOptionsAcssDebitMandateOptions), fullyQualifiedName: "stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsAcssDebitMandateOptions")]
    public interface ISubscriptionPaymentSettingsPaymentMethodOptionsAcssDebitMandateOptions
    {
        /// <summary>Transaction type of the mandate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#transaction_type Subscription#transaction_type}
        /// </remarks>
        [JsiiProperty(name: "transactionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TransactionType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionPaymentSettingsPaymentMethodOptionsAcssDebitMandateOptions), fullyQualifiedName: "stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsAcssDebitMandateOptions")]
        internal sealed class _Proxy : DeputyBase, stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsAcssDebitMandateOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Transaction type of the mandate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#transaction_type Subscription#transaction_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "transactionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TransactionType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
