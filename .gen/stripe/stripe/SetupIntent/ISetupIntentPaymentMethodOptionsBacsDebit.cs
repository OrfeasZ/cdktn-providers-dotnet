using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiInterface(nativeType: typeof(ISetupIntentPaymentMethodOptionsBacsDebit), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodOptionsBacsDebit")]
    public interface ISetupIntentPaymentMethodOptionsBacsDebit
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#mandate_options SetupIntent#mandate_options}.</summary>
        [JsiiProperty(name: "mandateOptions", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsBacsDebitMandateOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentPaymentMethodOptionsBacsDebitMandateOptions? MandateOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISetupIntentPaymentMethodOptionsBacsDebit), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodOptionsBacsDebit")]
        internal sealed class _Proxy : DeputyBase, stripe.SetupIntent.ISetupIntentPaymentMethodOptionsBacsDebit
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#mandate_options SetupIntent#mandate_options}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mandateOptions", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsBacsDebitMandateOptions\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentPaymentMethodOptionsBacsDebitMandateOptions? MandateOptions
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentPaymentMethodOptionsBacsDebitMandateOptions?>();
            }
        }
    }
}
