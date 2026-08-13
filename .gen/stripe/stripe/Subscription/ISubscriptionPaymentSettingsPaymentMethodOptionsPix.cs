using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiInterface(nativeType: typeof(ISubscriptionPaymentSettingsPaymentMethodOptionsPix), fullyQualifiedName: "stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsPix")]
    public interface ISubscriptionPaymentSettingsPaymentMethodOptionsPix
    {
        /// <summary>The number of seconds (between 10 and 1209600) after which Pix payment will expire. Defaults to 86400 seconds.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#expires_after_seconds Subscription#expires_after_seconds}
        /// </remarks>
        [JsiiProperty(name: "expiresAfterSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ExpiresAfterSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#mandate_options Subscription#mandate_options}.</summary>
        [JsiiProperty(name: "mandateOptions", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsPixMandateOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsPixMandateOptions? MandateOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionPaymentSettingsPaymentMethodOptionsPix), fullyQualifiedName: "stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsPix")]
        internal sealed class _Proxy : DeputyBase, stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsPix
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The number of seconds (between 10 and 1209600) after which Pix payment will expire. Defaults to 86400 seconds.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#expires_after_seconds Subscription#expires_after_seconds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "expiresAfterSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ExpiresAfterSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#mandate_options Subscription#mandate_options}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mandateOptions", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsPixMandateOptions\"}", isOptional: true)]
            public stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsPixMandateOptions? MandateOptions
            {
                get => GetInstanceProperty<stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsPixMandateOptions?>();
            }
        }
    }
}
