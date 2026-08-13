using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentMandateData), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentMandateData")]
    public interface IPaymentIntentMandateData
    {
        /// <summary>This hash contains details about the customer acceptance of the Mandate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#customer_acceptance PaymentIntent#customer_acceptance}
        /// </remarks>
        [JsiiProperty(name: "customerAcceptance", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentMandateDataCustomerAcceptance\"}")]
        stripe.PaymentIntent.IPaymentIntentMandateDataCustomerAcceptance CustomerAcceptance
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentMandateData), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentMandateData")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentMandateData
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>This hash contains details about the customer acceptance of the Mandate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#customer_acceptance PaymentIntent#customer_acceptance}
            /// </remarks>
            [JsiiProperty(name: "customerAcceptance", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentMandateDataCustomerAcceptance\"}")]
            public stripe.PaymentIntent.IPaymentIntentMandateDataCustomerAcceptance CustomerAcceptance
            {
                get => GetInstanceProperty<stripe.PaymentIntent.IPaymentIntentMandateDataCustomerAcceptance>()!;
            }
        }
    }
}
