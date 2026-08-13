using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentPaymentMethodOptionsKlarna), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsKlarna")]
    public interface IPaymentIntentPaymentMethodOptionsKlarna
    {
        /// <summary>Controls when the funds will be captured from the customer's account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#capture_method PaymentIntent#capture_method}
        /// </remarks>
        [JsiiProperty(name: "captureMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CaptureMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>On-demand details if setting up or charging an on-demand payment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#on_demand PaymentIntent#on_demand}
        /// </remarks>
        [JsiiProperty(name: "onDemand", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsKlarnaOnDemand\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsKlarnaOnDemand? OnDemand
        {
            get
            {
                return null;
            }
        }

        /// <summary>Preferred locale of the Klarna checkout page that the customer is redirected to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#preferred_locale PaymentIntent#preferred_locale}
        /// </remarks>
        [JsiiProperty(name: "preferredLocale", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreferredLocale
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

        /// <summary>Subscription details if setting up or charging a subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#subscriptions PaymentIntent#subscriptions}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsKlarnaSubscriptions" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "subscriptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsKlarnaSubscriptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Subscriptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentPaymentMethodOptionsKlarna), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsKlarna")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsKlarna
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Controls when the funds will be captured from the customer's account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#capture_method PaymentIntent#capture_method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "captureMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CaptureMethod
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>On-demand details if setting up or charging an on-demand payment.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#on_demand PaymentIntent#on_demand}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "onDemand", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsKlarnaOnDemand\"}", isOptional: true)]
            public stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsKlarnaOnDemand? OnDemand
            {
                get => GetInstanceProperty<stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsKlarnaOnDemand?>();
            }

            /// <summary>Preferred locale of the Klarna checkout page that the customer is redirected to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#preferred_locale PaymentIntent#preferred_locale}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preferredLocale", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreferredLocale
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

            /// <summary>Subscription details if setting up or charging a subscription.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#subscriptions PaymentIntent#subscriptions}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsKlarnaSubscriptions" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "subscriptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsKlarnaSubscriptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Subscriptions
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
