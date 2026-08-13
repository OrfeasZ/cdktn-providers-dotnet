using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiInterface(nativeType: typeof(IPaymentLinkCustomFields), fullyQualifiedName: "stripe.paymentLink.PaymentLinkCustomFields")]
    public interface IPaymentLinkCustomFields
    {
        /// <summary>String of your choice that your integration can use to reconcile this field.</summary>
        /// <remarks>
        /// Must be unique to this field, alphanumeric, and up to 200 characters.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#key PaymentLink#key}
        /// </remarks>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#label PaymentLink#label}.</summary>
        [JsiiProperty(name: "label", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomFieldsLabel\"}")]
        stripe.PaymentLink.IPaymentLinkCustomFieldsLabel Label
        {
            get;
        }

        /// <summary>The type of the field.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#type PaymentLink#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#dropdown PaymentLink#dropdown}.</summary>
        [JsiiProperty(name: "dropdown", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomFieldsDropdown\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentLink.IPaymentLinkCustomFieldsDropdown? Dropdown
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#numeric PaymentLink#numeric}.</summary>
        [JsiiProperty(name: "numeric", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomFieldsNumeric\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentLink.IPaymentLinkCustomFieldsNumeric? Numeric
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether the customer is required to complete the field before completing the Checkout Session. Defaults to `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#optional PaymentLink#optional}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "optional", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Optional
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#text PaymentLink#text}.</summary>
        [JsiiProperty(name: "text", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomFieldsText\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentLink.IPaymentLinkCustomFieldsText? Text
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentLinkCustomFields), fullyQualifiedName: "stripe.paymentLink.PaymentLinkCustomFields")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentLink.IPaymentLinkCustomFields
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>String of your choice that your integration can use to reconcile this field.</summary>
            /// <remarks>
            /// Must be unique to this field, alphanumeric, and up to 200 characters.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#key PaymentLink#key}
            /// </remarks>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#label PaymentLink#label}.</summary>
            [JsiiProperty(name: "label", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomFieldsLabel\"}")]
            public stripe.PaymentLink.IPaymentLinkCustomFieldsLabel Label
            {
                get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkCustomFieldsLabel>()!;
            }

            /// <summary>The type of the field.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#type PaymentLink#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#dropdown PaymentLink#dropdown}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dropdown", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomFieldsDropdown\"}", isOptional: true)]
            public stripe.PaymentLink.IPaymentLinkCustomFieldsDropdown? Dropdown
            {
                get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkCustomFieldsDropdown?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#numeric PaymentLink#numeric}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "numeric", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomFieldsNumeric\"}", isOptional: true)]
            public stripe.PaymentLink.IPaymentLinkCustomFieldsNumeric? Numeric
            {
                get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkCustomFieldsNumeric?>();
            }

            /// <summary>Whether the customer is required to complete the field before completing the Checkout Session. Defaults to `false`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#optional PaymentLink#optional}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "optional", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Optional
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#text PaymentLink#text}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "text", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomFieldsText\"}", isOptional: true)]
            public stripe.PaymentLink.IPaymentLinkCustomFieldsText? Text
            {
                get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkCustomFieldsText?>();
            }
        }
    }
}
