using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentPaymentMethodOptionsBoleto), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsBoleto")]
    public interface IPaymentIntentPaymentMethodOptionsBoleto
    {
        /// <summary>The number of calendar days before a Boleto voucher expires.</summary>
        /// <remarks>
        /// For example, if you create a Boleto voucher on Monday and you set expires_after_days to 2, the Boleto voucher will expire on Wednesday at 23:59 America/Sao_Paulo time.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#expires_after_days PaymentIntent#expires_after_days}
        /// </remarks>
        [JsiiProperty(name: "expiresAfterDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ExpiresAfterDays
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicates that you intend to make future payments with this PaymentIntent's payment method.</summary>
        /// <remarks>
        /// If you provide a Customer with the PaymentIntent, you can use this parameter to <a href="/payments/save-during-payment">attach the payment method</a> to the Customer after the PaymentIntent is confirmed and the customer completes any required actions. If you don't provide a Customer, you can still <a href="/api/payment_methods/attach">attach</a> the payment method to a Customer after the transaction completes.
        ///
        /// If the payment method is <c>card_present</c> and isn't a digital wallet, Stripe creates and attaches a <a href="/api/charges/object#charge_object-payment_method_details-card_present-generated_card">generated_card</a> payment method representing the card to the Customer instead.
        ///
        /// When processing card payments, Stripe uses <c>setup_future_usage</c> to help you comply with regional legislation and network rules, such as <a href="/strong-customer-authentication">SCA</a>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#setup_future_usage PaymentIntent#setup_future_usage}
        /// </remarks>
        [JsiiProperty(name: "setupFutureUsage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SetupFutureUsage
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentPaymentMethodOptionsBoleto), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsBoleto")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsBoleto
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The number of calendar days before a Boleto voucher expires.</summary>
            /// <remarks>
            /// For example, if you create a Boleto voucher on Monday and you set expires_after_days to 2, the Boleto voucher will expire on Wednesday at 23:59 America/Sao_Paulo time.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#expires_after_days PaymentIntent#expires_after_days}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "expiresAfterDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ExpiresAfterDays
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Indicates that you intend to make future payments with this PaymentIntent's payment method.</summary>
            /// <remarks>
            /// If you provide a Customer with the PaymentIntent, you can use this parameter to <a href="/payments/save-during-payment">attach the payment method</a> to the Customer after the PaymentIntent is confirmed and the customer completes any required actions. If you don't provide a Customer, you can still <a href="/api/payment_methods/attach">attach</a> the payment method to a Customer after the transaction completes.
            ///
            /// If the payment method is <c>card_present</c> and isn't a digital wallet, Stripe creates and attaches a <a href="/api/charges/object#charge_object-payment_method_details-card_present-generated_card">generated_card</a> payment method representing the card to the Customer instead.
            ///
            /// When processing card payments, Stripe uses <c>setup_future_usage</c> to help you comply with regional legislation and network rules, such as <a href="/strong-customer-authentication">SCA</a>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#setup_future_usage PaymentIntent#setup_future_usage}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "setupFutureUsage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SetupFutureUsage
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
