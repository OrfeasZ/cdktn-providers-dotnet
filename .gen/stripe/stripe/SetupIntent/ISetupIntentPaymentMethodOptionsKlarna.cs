using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiInterface(nativeType: typeof(ISetupIntentPaymentMethodOptionsKlarna), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodOptionsKlarna")]
    public interface ISetupIntentPaymentMethodOptionsKlarna
    {
        /// <summary>The currency of the setup intent. Three letter ISO currency code.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#currency SetupIntent#currency}
        /// </remarks>
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Currency
        {
            get
            {
                return null;
            }
        }

        /// <summary>On-demand details if setting up a payment method for on-demand payments.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#on_demand SetupIntent#on_demand}
        /// </remarks>
        [JsiiProperty(name: "onDemand", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsKlarnaOnDemand\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentPaymentMethodOptionsKlarnaOnDemand? OnDemand
        {
            get
            {
                return null;
            }
        }

        /// <summary>Preferred locale of the Klarna checkout page that the customer is redirected to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#preferred_locale SetupIntent#preferred_locale}
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

        /// <summary>Subscription details if setting up or charging a subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#subscriptions SetupIntent#subscriptions}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.SetupIntent.ISetupIntentPaymentMethodOptionsKlarnaSubscriptions" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "subscriptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsKlarnaSubscriptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Subscriptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISetupIntentPaymentMethodOptionsKlarna), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodOptionsKlarna")]
        internal sealed class _Proxy : DeputyBase, stripe.SetupIntent.ISetupIntentPaymentMethodOptionsKlarna
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The currency of the setup intent. Three letter ISO currency code.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#currency SetupIntent#currency}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Currency
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>On-demand details if setting up a payment method for on-demand payments.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#on_demand SetupIntent#on_demand}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "onDemand", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsKlarnaOnDemand\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentPaymentMethodOptionsKlarnaOnDemand? OnDemand
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentPaymentMethodOptionsKlarnaOnDemand?>();
            }

            /// <summary>Preferred locale of the Klarna checkout page that the customer is redirected to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#preferred_locale SetupIntent#preferred_locale}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preferredLocale", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreferredLocale
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Subscription details if setting up or charging a subscription.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#subscriptions SetupIntent#subscriptions}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.SetupIntent.ISetupIntentPaymentMethodOptionsKlarnaSubscriptions" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "subscriptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsKlarnaSubscriptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Subscriptions
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
