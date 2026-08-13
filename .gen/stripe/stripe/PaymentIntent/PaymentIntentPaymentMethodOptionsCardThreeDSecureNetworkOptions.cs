using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiByValue(fqn: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCardThreeDSecureNetworkOptions")]
    public class PaymentIntentPaymentMethodOptionsCardThreeDSecureNetworkOptions : stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCardThreeDSecureNetworkOptions
    {
        /// <summary>Cartes Bancaires-specific 3DS fields.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#cartes_bancaires PaymentIntent#cartes_bancaires}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cartesBancaires", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCardThreeDSecureNetworkOptionsCartesBancaires\"}", isOptional: true)]
        public stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCardThreeDSecureNetworkOptionsCartesBancaires? CartesBancaires
        {
            get;
            set;
        }
    }
}
