using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentShipping), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentShipping")]
    public interface IPaymentIntentShipping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#address PaymentIntent#address}.</summary>
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentShippingAddress\"}")]
        stripe.PaymentIntent.IPaymentIntentShippingAddress Address
        {
            get;
        }

        /// <summary>Recipient name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#name PaymentIntent#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>The delivery service that shipped a physical product, such as Fedex, UPS, USPS, etc.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#carrier PaymentIntent#carrier}
        /// </remarks>
        [JsiiProperty(name: "carrier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Carrier
        {
            get
            {
                return null;
            }
        }

        /// <summary>Recipient phone (including extension).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#phone PaymentIntent#phone}
        /// </remarks>
        [JsiiProperty(name: "phone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Phone
        {
            get
            {
                return null;
            }
        }

        /// <summary>The tracking number for a physical product, obtained from the delivery service.</summary>
        /// <remarks>
        /// If multiple tracking numbers were generated for this purchase, please separate them with commas.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#tracking_number PaymentIntent#tracking_number}
        /// </remarks>
        [JsiiProperty(name: "trackingNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TrackingNumber
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentShipping), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentShipping")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentShipping
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#address PaymentIntent#address}.</summary>
            [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentShippingAddress\"}")]
            public stripe.PaymentIntent.IPaymentIntentShippingAddress Address
            {
                get => GetInstanceProperty<stripe.PaymentIntent.IPaymentIntentShippingAddress>()!;
            }

            /// <summary>Recipient name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#name PaymentIntent#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The delivery service that shipped a physical product, such as Fedex, UPS, USPS, etc.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#carrier PaymentIntent#carrier}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "carrier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Carrier
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Recipient phone (including extension).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#phone PaymentIntent#phone}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "phone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Phone
            {
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
