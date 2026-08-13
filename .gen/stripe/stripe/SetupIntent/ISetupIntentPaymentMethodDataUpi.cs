using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiInterface(nativeType: typeof(ISetupIntentPaymentMethodDataUpi), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodDataUpi")]
    public interface ISetupIntentPaymentMethodDataUpi
    {
        /// <summary>Configuration options for setting up an eMandate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#mandate_options SetupIntent#mandate_options}
        /// </remarks>
        [JsiiProperty(name: "mandateOptions", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataUpiMandateOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentPaymentMethodDataUpiMandateOptions? MandateOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISetupIntentPaymentMethodDataUpi), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodDataUpi")]
        internal sealed class _Proxy : DeputyBase, stripe.SetupIntent.ISetupIntentPaymentMethodDataUpi
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configuration options for setting up an eMandate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#mandate_options SetupIntent#mandate_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mandateOptions", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataUpiMandateOptions\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentPaymentMethodDataUpiMandateOptions? MandateOptions
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentPaymentMethodDataUpiMandateOptions?>();
            }
        }
    }
}
