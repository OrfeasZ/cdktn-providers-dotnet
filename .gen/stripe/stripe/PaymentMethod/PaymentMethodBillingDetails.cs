using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiByValue(fqn: "stripe.paymentMethod.PaymentMethodBillingDetails")]
    public class PaymentMethodBillingDetails : stripe.PaymentMethod.IPaymentMethodBillingDetails
    {
        /// <summary>Billing address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#address PaymentMethod#address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodBillingDetailsAddress\"}", isOptional: true)]
        public stripe.PaymentMethod.IPaymentMethodBillingDetailsAddress? Address
        {
            get;
            set;
        }

        /// <summary>Email address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#email PaymentMethod#email}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#name PaymentMethod#name}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#phone PaymentMethod#phone}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#tax_id PaymentMethod#tax_id}
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
