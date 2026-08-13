using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiInterface(nativeType: typeof(IPaymentLinkAfterCompletion), fullyQualifiedName: "stripe.paymentLink.PaymentLinkAfterCompletion")]
    public interface IPaymentLinkAfterCompletion
    {
        /// <summary>The specified behavior after the purchase is complete.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#type PaymentLink#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#hosted_confirmation PaymentLink#hosted_confirmation}.</summary>
        [JsiiProperty(name: "hostedConfirmation", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkAfterCompletionHostedConfirmation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentLink.IPaymentLinkAfterCompletionHostedConfirmation? HostedConfirmation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#redirect PaymentLink#redirect}.</summary>
        [JsiiProperty(name: "redirect", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkAfterCompletionRedirect\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentLink.IPaymentLinkAfterCompletionRedirect? Redirect
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentLinkAfterCompletion), fullyQualifiedName: "stripe.paymentLink.PaymentLinkAfterCompletion")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentLink.IPaymentLinkAfterCompletion
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The specified behavior after the purchase is complete.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#type PaymentLink#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#hosted_confirmation PaymentLink#hosted_confirmation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hostedConfirmation", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkAfterCompletionHostedConfirmation\"}", isOptional: true)]
            public stripe.PaymentLink.IPaymentLinkAfterCompletionHostedConfirmation? HostedConfirmation
            {
                get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkAfterCompletionHostedConfirmation?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#redirect PaymentLink#redirect}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "redirect", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkAfterCompletionRedirect\"}", isOptional: true)]
            public stripe.PaymentLink.IPaymentLinkAfterCompletionRedirect? Redirect
            {
                get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkAfterCompletionRedirect?>();
            }
        }
    }
}
