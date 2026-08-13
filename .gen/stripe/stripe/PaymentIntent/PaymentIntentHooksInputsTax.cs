using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.paymentIntent.PaymentIntentHooksInputsTax")]
    public class PaymentIntentHooksInputsTax : stripe.PaymentIntent.IPaymentIntentHooksInputsTax
    {
        /// <summary>The [TaxCalculation](https://docs.stripe.com/api/tax/calculations) id.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#calculation PaymentIntent#calculation}
        /// </remarks>
        [JsiiProperty(name: "calculation", typeJson: "{\"primitive\":\"string\"}")]
        public string Calculation
        {
            get;
            set;
        }
    }
}
