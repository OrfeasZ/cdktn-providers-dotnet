using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiInterface(nativeType: typeof(ISubscriptionPaymentSettingsPaymentMethodOptionsBillie), fullyQualifiedName: "stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBillie")]
    public interface ISubscriptionPaymentSettingsPaymentMethodOptionsBillie
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#company_details Subscription#company_details}.</summary>
        [JsiiProperty(name: "companyDetails", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetails? CompanyDetails
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionPaymentSettingsPaymentMethodOptionsBillie), fullyQualifiedName: "stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBillie")]
        internal sealed class _Proxy : DeputyBase, stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsBillie
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#company_details Subscription#company_details}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "companyDetails", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetails\"}", isOptional: true)]
            public stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetails? CompanyDetails
            {
                get => GetInstanceProperty<stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetails?>();
            }
        }
    }
}
