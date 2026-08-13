using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Source
{
    [JsiiInterface(nativeType: typeof(ISourceSourceOrderShipping), fullyQualifiedName: "stripe.source.SourceSourceOrderShipping")]
    public interface ISourceSourceOrderShipping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#address Source#address}.</summary>
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"stripe.source.SourceSourceOrderShippingAddress\"}")]
        stripe.Source.ISourceSourceOrderShippingAddress Address
        {
            get;
        }

        /// <summary>The delivery service that shipped a physical product, such as Fedex, UPS, USPS, etc.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#carrier Source#carrier}
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

        /// <summary>Recipient name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#name Source#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Recipient phone (including extension).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#phone Source#phone}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#tracking_number Source#tracking_number}
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

        [JsiiTypeProxy(nativeType: typeof(ISourceSourceOrderShipping), fullyQualifiedName: "stripe.source.SourceSourceOrderShipping")]
        internal sealed class _Proxy : DeputyBase, stripe.Source.ISourceSourceOrderShipping
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#address Source#address}.</summary>
            [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"stripe.source.SourceSourceOrderShippingAddress\"}")]
            public stripe.Source.ISourceSourceOrderShippingAddress Address
            {
                get => GetInstanceProperty<stripe.Source.ISourceSourceOrderShippingAddress>()!;
            }

            /// <summary>The delivery service that shipped a physical product, such as Fedex, UPS, USPS, etc.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#carrier Source#carrier}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "carrier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Carrier
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Recipient name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#name Source#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Recipient phone (including extension).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#phone Source#phone}
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#tracking_number Source#tracking_number}
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
