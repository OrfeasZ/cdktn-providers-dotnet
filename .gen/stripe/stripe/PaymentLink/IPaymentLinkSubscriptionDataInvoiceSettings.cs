using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiInterface(nativeType: typeof(IPaymentLinkSubscriptionDataInvoiceSettings), fullyQualifiedName: "stripe.paymentLink.PaymentLinkSubscriptionDataInvoiceSettings")]
    public interface IPaymentLinkSubscriptionDataInvoiceSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#issuer PaymentLink#issuer}.</summary>
        [JsiiProperty(name: "issuer", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkSubscriptionDataInvoiceSettingsIssuer\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentLink.IPaymentLinkSubscriptionDataInvoiceSettingsIssuer? Issuer
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentLinkSubscriptionDataInvoiceSettings), fullyQualifiedName: "stripe.paymentLink.PaymentLinkSubscriptionDataInvoiceSettings")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentLink.IPaymentLinkSubscriptionDataInvoiceSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#issuer PaymentLink#issuer}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "issuer", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkSubscriptionDataInvoiceSettingsIssuer\"}", isOptional: true)]
            public stripe.PaymentLink.IPaymentLinkSubscriptionDataInvoiceSettingsIssuer? Issuer
            {
                get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkSubscriptionDataInvoiceSettingsIssuer?>();
            }
        }
    }
}
