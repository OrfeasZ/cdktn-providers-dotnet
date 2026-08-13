using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiInterface(nativeType: typeof(ISubscriptionPaymentSettings), fullyQualifiedName: "stripe.subscription.SubscriptionPaymentSettings")]
    public interface ISubscriptionPaymentSettings
    {
        /// <summary>Payment-method-specific configuration to provide to invoices created by the subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#payment_method_options Subscription#payment_method_options}
        /// </remarks>
        [JsiiProperty(name: "paymentMethodOptions", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptions? PaymentMethodOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>The list of payment method types to provide to every invoice created by the subscription.</summary>
        /// <remarks>
        /// If not set, Stripe attempts to automatically determine the types to use by looking at the invoice’s default payment method, the subscription’s default payment method, the customer’s default payment method, and your <a href="https://dashboard.stripe.com/settings/billing/invoice">invoice template settings</a>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#payment_method_types Subscription#payment_method_types}
        /// </remarks>
        [JsiiProperty(name: "paymentMethodTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PaymentMethodTypes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configure whether Stripe updates `subscription.default_payment_method` when payment succeeds. Defaults to `off`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#save_default_payment_method Subscription#save_default_payment_method}
        /// </remarks>
        [JsiiProperty(name: "saveDefaultPaymentMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SaveDefaultPaymentMethod
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionPaymentSettings), fullyQualifiedName: "stripe.subscription.SubscriptionPaymentSettings")]
        internal sealed class _Proxy : DeputyBase, stripe.Subscription.ISubscriptionPaymentSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Payment-method-specific configuration to provide to invoices created by the subscription.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#payment_method_options Subscription#payment_method_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "paymentMethodOptions", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptions\"}", isOptional: true)]
            public stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptions? PaymentMethodOptions
            {
                get => GetInstanceProperty<stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptions?>();
            }

            /// <summary>The list of payment method types to provide to every invoice created by the subscription.</summary>
            /// <remarks>
            /// If not set, Stripe attempts to automatically determine the types to use by looking at the invoice’s default payment method, the subscription’s default payment method, the customer’s default payment method, and your <a href="https://dashboard.stripe.com/settings/billing/invoice">invoice template settings</a>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#payment_method_types Subscription#payment_method_types}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "paymentMethodTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PaymentMethodTypes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Configure whether Stripe updates `subscription.default_payment_method` when payment succeeds. Defaults to `off`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#save_default_payment_method Subscription#save_default_payment_method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "saveDefaultPaymentMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SaveDefaultPaymentMethod
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
