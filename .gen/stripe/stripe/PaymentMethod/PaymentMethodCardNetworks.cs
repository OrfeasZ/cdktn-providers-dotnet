using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiByValue(fqn: "stripe.paymentMethod.PaymentMethodCardNetworks")]
    public class PaymentMethodCardNetworks : stripe.PaymentMethod.IPaymentMethodCardNetworks
    {
        /// <summary>The preferred network for co-branded cards.</summary>
        /// <remarks>
        /// Can be <c>cartes_bancaires</c>, <c>mastercard</c>, <c>visa</c> or <c>invalid_preference</c> if requested network is not valid for the card.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#preferred PaymentMethod#preferred}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "preferred", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Preferred
        {
            get;
            set;
        }
    }
}
