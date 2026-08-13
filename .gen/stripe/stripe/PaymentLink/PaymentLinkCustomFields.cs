using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.paymentLink.PaymentLinkCustomFields")]
    public class PaymentLinkCustomFields : stripe.PaymentLink.IPaymentLinkCustomFields
    {
        /// <summary>String of your choice that your integration can use to reconcile this field.</summary>
        /// <remarks>
        /// Must be unique to this field, alphanumeric, and up to 200 characters.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#key PaymentLink#key}
        /// </remarks>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#label PaymentLink#label}.</summary>
        [JsiiProperty(name: "label", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomFieldsLabel\"}")]
        public stripe.PaymentLink.IPaymentLinkCustomFieldsLabel Label
        {
            get;
            set;
        }

        /// <summary>The type of the field.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#type PaymentLink#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#dropdown PaymentLink#dropdown}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dropdown", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomFieldsDropdown\"}", isOptional: true)]
        public stripe.PaymentLink.IPaymentLinkCustomFieldsDropdown? Dropdown
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#numeric PaymentLink#numeric}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "numeric", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomFieldsNumeric\"}", isOptional: true)]
        public stripe.PaymentLink.IPaymentLinkCustomFieldsNumeric? Numeric
        {
            get;
            set;
        }

        private object? _optional;

        /// <summary>Whether the customer is required to complete the field before completing the Checkout Session. Defaults to `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#optional PaymentLink#optional}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "optional", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Optional
        {
            get => _optional;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _optional = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#text PaymentLink#text}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "text", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomFieldsText\"}", isOptional: true)]
        public stripe.PaymentLink.IPaymentLinkCustomFieldsText? Text
        {
            get;
            set;
        }
    }
}
