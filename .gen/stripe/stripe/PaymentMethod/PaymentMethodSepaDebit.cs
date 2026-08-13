using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.paymentMethod.PaymentMethodSepaDebit")]
    public class PaymentMethodSepaDebit : stripe.PaymentMethod.IPaymentMethodSepaDebit
    {
        /// <summary>IBAN of the bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#iban PaymentMethod#iban}
        /// </remarks>
        [JsiiProperty(name: "iban", typeJson: "{\"primitive\":\"string\"}")]
        public string Iban
        {
            get;
            set;
        }
    }
}
