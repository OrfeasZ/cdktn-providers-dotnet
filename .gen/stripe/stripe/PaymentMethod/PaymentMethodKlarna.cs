using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiByValue(fqn: "stripe.paymentMethod.PaymentMethodKlarna")]
    public class PaymentMethodKlarna : stripe.PaymentMethod.IPaymentMethodKlarna
    {
        /// <summary>The customer's date of birth, if provided.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#dob PaymentMethod#dob}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dob", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodKlarnaDob\"}", isOptional: true)]
        public stripe.PaymentMethod.IPaymentMethodKlarnaDob? Dob
        {
            get;
            set;
        }
    }
}
