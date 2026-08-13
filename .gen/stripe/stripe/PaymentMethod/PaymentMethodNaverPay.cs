using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiByValue(fqn: "stripe.paymentMethod.PaymentMethodNaverPay")]
    public class PaymentMethodNaverPay : stripe.PaymentMethod.IPaymentMethodNaverPay
    {
        /// <summary>Whether to fund this transaction with Naver Pay points or a card.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#funding PaymentMethod#funding}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "funding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Funding
        {
            get;
            set;
        }
    }
}
