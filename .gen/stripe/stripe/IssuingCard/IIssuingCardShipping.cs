using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingCard
{
    [JsiiInterface(nativeType: typeof(IIssuingCardShipping), fullyQualifiedName: "stripe.issuingCard.IssuingCardShipping")]
    public interface IIssuingCardShipping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#address IssuingCard#address}.</summary>
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"stripe.issuingCard.IssuingCardShippingAddress\"}")]
        stripe.IssuingCard.IIssuingCardShippingAddress Address
        {
            get;
        }

        /// <summary>Recipient name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#name IssuingCard#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Address validation details for the shipment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#address_validation IssuingCard#address_validation}
        /// </remarks>
        [JsiiProperty(name: "addressValidation", typeJson: "{\"fqn\":\"stripe.issuingCard.IssuingCardShippingAddressValidation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.IssuingCard.IIssuingCardShippingAddressValidation? AddressValidation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Additional information that may be required for clearing customs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#customs IssuingCard#customs}
        /// </remarks>
        [JsiiProperty(name: "customs", typeJson: "{\"fqn\":\"stripe.issuingCard.IssuingCardShippingCustoms\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.IssuingCard.IIssuingCardShippingCustoms? Customs
        {
            get
            {
                return null;
            }
        }

        /// <summary>The phone number of the receiver of the shipment.</summary>
        /// <remarks>
        /// Our courier partners will use this number to contact you in the event of card delivery issues. For individual shipments to the EU/UK, if this field is empty, we will provide them with the phone number provided when the cardholder was initially created.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#phone_number IssuingCard#phone_number}
        /// </remarks>
        [JsiiProperty(name: "phoneNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PhoneNumber
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether a signature is required for card delivery.</summary>
        /// <remarks>
        /// This feature is only supported for US users. Standard shipping service does not support signature on delivery. The default value for standard shipping service is false and for express and priority services is true.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#require_signature IssuingCard#require_signature}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "requireSignature", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequireSignature
        {
            get
            {
                return null;
            }
        }

        /// <summary>Shipment service, such as `standard` or `express`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#service IssuingCard#service}
        /// </remarks>
        [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Service
        {
            get
            {
                return null;
            }
        }

        /// <summary>Packaging options.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#type IssuingCard#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIssuingCardShipping), fullyQualifiedName: "stripe.issuingCard.IssuingCardShipping")]
        internal sealed class _Proxy : DeputyBase, stripe.IssuingCard.IIssuingCardShipping
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#address IssuingCard#address}.</summary>
            [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"stripe.issuingCard.IssuingCardShippingAddress\"}")]
            public stripe.IssuingCard.IIssuingCardShippingAddress Address
            {
                get => GetInstanceProperty<stripe.IssuingCard.IIssuingCardShippingAddress>()!;
            }

            /// <summary>Recipient name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#name IssuingCard#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Address validation details for the shipment.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#address_validation IssuingCard#address_validation}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "addressValidation", typeJson: "{\"fqn\":\"stripe.issuingCard.IssuingCardShippingAddressValidation\"}", isOptional: true)]
            public stripe.IssuingCard.IIssuingCardShippingAddressValidation? AddressValidation
            {
                get => GetInstanceProperty<stripe.IssuingCard.IIssuingCardShippingAddressValidation?>();
            }

            /// <summary>Additional information that may be required for clearing customs.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#customs IssuingCard#customs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customs", typeJson: "{\"fqn\":\"stripe.issuingCard.IssuingCardShippingCustoms\"}", isOptional: true)]
            public stripe.IssuingCard.IIssuingCardShippingCustoms? Customs
            {
                get => GetInstanceProperty<stripe.IssuingCard.IIssuingCardShippingCustoms?>();
            }

            /// <summary>The phone number of the receiver of the shipment.</summary>
            /// <remarks>
            /// Our courier partners will use this number to contact you in the event of card delivery issues. For individual shipments to the EU/UK, if this field is empty, we will provide them with the phone number provided when the cardholder was initially created.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#phone_number IssuingCard#phone_number}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "phoneNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PhoneNumber
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether a signature is required for card delivery.</summary>
            /// <remarks>
            /// This feature is only supported for US users. Standard shipping service does not support signature on delivery. The default value for standard shipping service is false and for express and priority services is true.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#require_signature IssuingCard#require_signature}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requireSignature", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? RequireSignature
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Shipment service, such as `standard` or `express`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#service IssuingCard#service}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Service
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Packaging options.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#type IssuingCard#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
