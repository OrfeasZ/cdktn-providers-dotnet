using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiInterface(nativeType: typeof(ISetupIntentMandateData), fullyQualifiedName: "stripe.setupIntent.SetupIntentMandateData")]
    public interface ISetupIntentMandateData
    {
        /// <summary>This hash contains details about the customer acceptance of the Mandate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#customer_acceptance SetupIntent#customer_acceptance}
        /// </remarks>
        [JsiiProperty(name: "customerAcceptance", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentMandateDataCustomerAcceptance\"}")]
        stripe.SetupIntent.ISetupIntentMandateDataCustomerAcceptance CustomerAcceptance
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISetupIntentMandateData), fullyQualifiedName: "stripe.setupIntent.SetupIntentMandateData")]
        internal sealed class _Proxy : DeputyBase, stripe.SetupIntent.ISetupIntentMandateData
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>This hash contains details about the customer acceptance of the Mandate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#customer_acceptance SetupIntent#customer_acceptance}
            /// </remarks>
            [JsiiProperty(name: "customerAcceptance", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentMandateDataCustomerAcceptance\"}")]
            public stripe.SetupIntent.ISetupIntentMandateDataCustomerAcceptance CustomerAcceptance
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentMandateDataCustomerAcceptance>()!;
            }
        }
    }
}
