using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiInterface(nativeType: typeof(IPaymentLinkConsentCollection), fullyQualifiedName: "stripe.paymentLink.PaymentLinkConsentCollection")]
    public interface IPaymentLinkConsentCollection
    {
        /// <summary>Settings related to the payment method reuse text shown in the Checkout UI.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#payment_method_reuse_agreement PaymentLink#payment_method_reuse_agreement}
        /// </remarks>
        [JsiiProperty(name: "paymentMethodReuseAgreement", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkConsentCollectionPaymentMethodReuseAgreement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentLink.IPaymentLinkConsentCollectionPaymentMethodReuseAgreement? PaymentMethodReuseAgreement
        {
            get
            {
                return null;
            }
        }

        /// <summary>If set to `auto`, enables the collection of customer consent for promotional communications.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#promotions PaymentLink#promotions}
        /// </remarks>
        [JsiiProperty(name: "promotions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Promotions
        {
            get
            {
                return null;
            }
        }

        /// <summary>If set to `required`, it requires cutomers to accept the terms of service before being able to pay.</summary>
        /// <remarks>
        /// If set to <c>none</c>, customers won't be shown a checkbox to accept the terms of service.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#terms_of_service PaymentLink#terms_of_service}
        /// </remarks>
        [JsiiProperty(name: "termsOfService", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TermsOfService
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentLinkConsentCollection), fullyQualifiedName: "stripe.paymentLink.PaymentLinkConsentCollection")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentLink.IPaymentLinkConsentCollection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Settings related to the payment method reuse text shown in the Checkout UI.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#payment_method_reuse_agreement PaymentLink#payment_method_reuse_agreement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "paymentMethodReuseAgreement", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkConsentCollectionPaymentMethodReuseAgreement\"}", isOptional: true)]
            public stripe.PaymentLink.IPaymentLinkConsentCollectionPaymentMethodReuseAgreement? PaymentMethodReuseAgreement
            {
                get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkConsentCollectionPaymentMethodReuseAgreement?>();
            }

            /// <summary>If set to `auto`, enables the collection of customer consent for promotional communications.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#promotions PaymentLink#promotions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "promotions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Promotions
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>If set to `required`, it requires cutomers to accept the terms of service before being able to pay.</summary>
            /// <remarks>
            /// If set to <c>none</c>, customers won't be shown a checkbox to accept the terms of service.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#terms_of_service PaymentLink#terms_of_service}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "termsOfService", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TermsOfService
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
