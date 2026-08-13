using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Charge
{
    [JsiiInterface(nativeType: typeof(IChargeShipping), fullyQualifiedName: "stripe.charge.ChargeShipping")]
    public interface IChargeShipping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#address Charge#address}.</summary>
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"stripe.charge.ChargeShippingAddress\"}")]
        stripe.Charge.IChargeShippingAddress Address
        {
            get;
        }

        /// <summary>Recipient name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#name Charge#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>The delivery service that shipped a physical product, such as Fedex, UPS, USPS, etc.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#carrier Charge#carrier}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#phone Charge#phone}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#tracking_number Charge#tracking_number}
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

        [JsiiTypeProxy(nativeType: typeof(IChargeShipping), fullyQualifiedName: "stripe.charge.ChargeShipping")]
        internal sealed class _Proxy : DeputyBase, stripe.Charge.IChargeShipping
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#address Charge#address}.</summary>
            [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"stripe.charge.ChargeShippingAddress\"}")]
            public stripe.Charge.IChargeShippingAddress Address
            {
                get => GetInstanceProperty<stripe.Charge.IChargeShippingAddress>()!;
            }

            /// <summary>Recipient name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#name Charge#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The delivery service that shipped a physical product, such as Fedex, UPS, USPS, etc.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#carrier Charge#carrier}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "carrier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Carrier
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Recipient phone (including extension).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#phone Charge#phone}
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#tracking_number Charge#tracking_number}
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
