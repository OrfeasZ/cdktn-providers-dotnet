using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiInterface(nativeType: typeof(ISubscriptionPaymentSettingsPaymentMethodOptionsBlik), fullyQualifiedName: "stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBlik")]
    public interface ISubscriptionPaymentSettingsPaymentMethodOptionsBlik
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#mandate_options Subscription#mandate_options}.</summary>
        [JsiiProperty(name: "mandateOptions", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBlikMandateOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsBlikMandateOptions? MandateOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionPaymentSettingsPaymentMethodOptionsBlik), fullyQualifiedName: "stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBlik")]
        internal sealed class _Proxy : DeputyBase, stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsBlik
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#mandate_options Subscription#mandate_options}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mandateOptions", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBlikMandateOptions\"}", isOptional: true)]
            public stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsBlikMandateOptions? MandateOptions
            {
                get => GetInstanceProperty<stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsBlikMandateOptions?>();
            }
        }
    }
}
