using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiByValue(fqn: "stripe.paymentMethod.PaymentMethodP24")]
    public class PaymentMethodP24 : stripe.PaymentMethod.IPaymentMethodP24
    {
        /// <summary>The customer's bank, if provided.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#bank PaymentMethod#bank}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bank", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Bank
        {
            get;
            set;
        }
    }
}
