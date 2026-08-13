using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.paymentIntent.PaymentIntentShipping")]
    public class PaymentIntentShipping : stripe.PaymentIntent.IPaymentIntentShipping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#address PaymentIntent#address}.</summary>
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentShippingAddress\"}")]
        public stripe.PaymentIntent.IPaymentIntentShippingAddress Address
        {
            get;
            set;
        }

        /// <summary>Recipient name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#name PaymentIntent#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>The delivery service that shipped a physical product, such as Fedex, UPS, USPS, etc.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#carrier PaymentIntent#carrier}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "carrier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Carrier
        {
            get;
            set;
        }

        /// <summary>Recipient phone (including extension).</summary>
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

        /// <summary>The tracking number for a physical product, obtained from the delivery service.</summary>
        /// <remarks>
        /// If multiple tracking numbers were generated for this purchase, please separate them with commas.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#tracking_number PaymentIntent#tracking_number}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trackingNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TrackingNumber
        {
            get;
            set;
        }
    }
}
