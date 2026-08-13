using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentPaymentMethodOptionsWechatPay), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsWechatPay")]
    public interface IPaymentIntentPaymentMethodOptionsWechatPay
    {
        /// <summary>The app ID registered with WeChat Pay. Only required when client is ios or android.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#app_id PaymentIntent#app_id}
        /// </remarks>
        [JsiiProperty(name: "appId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AppId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The client type that the end customer will pay from.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#client PaymentIntent#client}
        /// </remarks>
        [JsiiProperty(name: "client", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Client
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

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentPaymentMethodOptionsWechatPay), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsWechatPay")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsWechatPay
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The app ID registered with WeChat Pay. Only required when client is ios or android.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#app_id PaymentIntent#app_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "appId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AppId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The client type that the end customer will pay from.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#client PaymentIntent#client}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "client", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Client
            {
                get => GetInstanceProperty<string?>();
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
