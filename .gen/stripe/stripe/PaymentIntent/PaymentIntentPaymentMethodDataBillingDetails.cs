using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiByValue(fqn: "stripe.paymentIntent.PaymentIntentPaymentMethodDataBillingDetails")]
    public class PaymentIntentPaymentMethodDataBillingDetails : stripe.PaymentIntent.IPaymentIntentPaymentMethodDataBillingDetails
    {
        /// <summary>Billing address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#address PaymentIntent#address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataBillingDetailsAddress\"}", isOptional: true)]
        public stripe.PaymentIntent.IPaymentIntentPaymentMethodDataBillingDetailsAddress? Address
        {
            get;
            set;
        }

        /// <summary>Email address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#email PaymentIntent#email}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Email
        {
            get;
            set;
        }

        /// <summary>Full name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#name PaymentIntent#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Billing phone number (including extension).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#phone PaymentIntent#phone}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "phone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Phone
        {
            get;
            set;
        }

        /// <summary>Taxpayer identification number. Used only for transactions between LATAM buyers and non-LATAM sellers.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#tax_id PaymentIntent#tax_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "taxId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TaxId
        {
            get;
            set;
        }
    }
}
