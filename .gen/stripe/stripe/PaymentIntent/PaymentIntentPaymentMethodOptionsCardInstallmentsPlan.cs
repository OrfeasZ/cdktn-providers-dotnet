using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCardInstallmentsPlan")]
    public class PaymentIntentPaymentMethodOptionsCardInstallmentsPlan : stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCardInstallmentsPlan
    {
        /// <summary>Type of installment plan, one of `fixed_count`, `bonus`, or `revolving`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#type PaymentIntent#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>For `fixed_count` installment plans, this is the number of installment payments your customer will make to their credit card.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#count PaymentIntent#count}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <summary>For `fixed_count` installment plans, this is the interval between installment payments your customer will make to their credit card.</summary>
        /// <remarks>
        /// One of <c>month</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#interval PaymentIntent#interval}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Interval
        {
            get;
            set;
        }
    }
}
