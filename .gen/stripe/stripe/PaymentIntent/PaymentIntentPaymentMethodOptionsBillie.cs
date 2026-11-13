using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiByValue(fqn: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsBillie")]
    public class PaymentIntentPaymentMethodOptionsBillie : stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsBillie
    {
        /// <summary>Controls when the funds will be captured from the customer's account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/payment_intent#capture_method PaymentIntent#capture_method}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "captureMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CaptureMethod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/payment_intent#company_details PaymentIntent#company_details}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "companyDetails", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsBillieCompanyDetails\"}", isOptional: true)]
        public stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsBillieCompanyDetails? CompanyDetails
        {
            get;
            set;
        }

        /// <summary>An identifier or reference that this payment corresponds to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/payment_intent#reference PaymentIntent#reference}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "reference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Reference
        {
            get;
            set;
        }
    }
}
