using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Source
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.source.SourceSourceOrderShipping")]
    public class SourceSourceOrderShipping : stripe.Source.ISourceSourceOrderShipping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#address Source#address}.</summary>
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"stripe.source.SourceSourceOrderShippingAddress\"}")]
        public stripe.Source.ISourceSourceOrderShippingAddress Address
        {
            get;
            set;
        }

        /// <summary>The delivery service that shipped a physical product, such as Fedex, UPS, USPS, etc.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#carrier Source#carrier}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "carrier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Carrier
        {
            get;
            set;
        }

        /// <summary>Recipient name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#name Source#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Recipient phone (including extension).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#phone Source#phone}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#tracking_number Source#tracking_number}
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
