using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiInterface(nativeType: typeof(IPaymentLinkCustomText), fullyQualifiedName: "stripe.paymentLink.PaymentLinkCustomText")]
    public interface IPaymentLinkCustomText
    {
        /// <summary>Custom text that should be displayed after the payment confirmation button.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#after_submit PaymentLink#after_submit}
        /// </remarks>
        [JsiiProperty(name: "afterSubmit", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomTextAfterSubmit\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentLink.IPaymentLinkCustomTextAfterSubmit? AfterSubmit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Custom text that should be displayed alongside shipping address collection.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#shipping_address PaymentLink#shipping_address}
        /// </remarks>
        [JsiiProperty(name: "shippingAddress", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomTextShippingAddress\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentLink.IPaymentLinkCustomTextShippingAddress? ShippingAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>Custom text that should be displayed alongside the payment confirmation button.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#submit PaymentLink#submit}
        /// </remarks>
        [JsiiProperty(name: "submit", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomTextSubmit\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentLink.IPaymentLinkCustomTextSubmit? Submit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Custom text that should be displayed in place of the default terms of service agreement text.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#terms_of_service_acceptance PaymentLink#terms_of_service_acceptance}
        /// </remarks>
        [JsiiProperty(name: "termsOfServiceAcceptance", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomTextTermsOfServiceAcceptance\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentLink.IPaymentLinkCustomTextTermsOfServiceAcceptance? TermsOfServiceAcceptance
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentLinkCustomText), fullyQualifiedName: "stripe.paymentLink.PaymentLinkCustomText")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentLink.IPaymentLinkCustomText
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Custom text that should be displayed after the payment confirmation button.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#after_submit PaymentLink#after_submit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "afterSubmit", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomTextAfterSubmit\"}", isOptional: true)]
            public stripe.PaymentLink.IPaymentLinkCustomTextAfterSubmit? AfterSubmit
            {
                get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkCustomTextAfterSubmit?>();
            }

            /// <summary>Custom text that should be displayed alongside shipping address collection.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#shipping_address PaymentLink#shipping_address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shippingAddress", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomTextShippingAddress\"}", isOptional: true)]
            public stripe.PaymentLink.IPaymentLinkCustomTextShippingAddress? ShippingAddress
            {
                get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkCustomTextShippingAddress?>();
            }

            /// <summary>Custom text that should be displayed alongside the payment confirmation button.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#submit PaymentLink#submit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "submit", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomTextSubmit\"}", isOptional: true)]
            public stripe.PaymentLink.IPaymentLinkCustomTextSubmit? Submit
            {
                get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkCustomTextSubmit?>();
            }

            /// <summary>Custom text that should be displayed in place of the default terms of service agreement text.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#terms_of_service_acceptance PaymentLink#terms_of_service_acceptance}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "termsOfServiceAcceptance", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomTextTermsOfServiceAcceptance\"}", isOptional: true)]
            public stripe.PaymentLink.IPaymentLinkCustomTextTermsOfServiceAcceptance? TermsOfServiceAcceptance
            {
                get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkCustomTextTermsOfServiceAcceptance?>();
            }
        }
    }
}
