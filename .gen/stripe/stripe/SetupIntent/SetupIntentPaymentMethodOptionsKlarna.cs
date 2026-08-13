using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiByValue(fqn: "stripe.setupIntent.SetupIntentPaymentMethodOptionsKlarna")]
    public class SetupIntentPaymentMethodOptionsKlarna : stripe.SetupIntent.ISetupIntentPaymentMethodOptionsKlarna
    {
        /// <summary>The currency of the setup intent. Three letter ISO currency code.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#currency SetupIntent#currency}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Currency
        {
            get;
            set;
        }

        /// <summary>On-demand details if setting up a payment method for on-demand payments.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#on_demand SetupIntent#on_demand}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "onDemand", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsKlarnaOnDemand\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentPaymentMethodOptionsKlarnaOnDemand? OnDemand
        {
            get;
            set;
        }

        /// <summary>Preferred locale of the Klarna checkout page that the customer is redirected to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#preferred_locale SetupIntent#preferred_locale}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "preferredLocale", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PreferredLocale
        {
            get;
            set;
        }

        private object? _subscriptions;

        /// <summary>Subscription details if setting up or charging a subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#subscriptions SetupIntent#subscriptions}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.SetupIntent.ISetupIntentPaymentMethodOptionsKlarnaSubscriptions" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "subscriptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsKlarnaSubscriptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Subscriptions
        {
            get => _subscriptions;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case stripe.SetupIntent.ISetupIntentPaymentMethodOptionsKlarnaSubscriptions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.SetupIntent.ISetupIntentPaymentMethodOptionsKlarnaSubscriptions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _subscriptions = value;
            }
        }
    }
}
