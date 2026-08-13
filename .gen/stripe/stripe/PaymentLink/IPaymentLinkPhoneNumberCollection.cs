using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiInterface(nativeType: typeof(IPaymentLinkPhoneNumberCollection), fullyQualifiedName: "stripe.paymentLink.PaymentLinkPhoneNumberCollection")]
    public interface IPaymentLinkPhoneNumberCollection
    {
        /// <summary>If `true`, a phone number will be collected during checkout.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#enabled PaymentLink#enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentLinkPhoneNumberCollection), fullyQualifiedName: "stripe.paymentLink.PaymentLinkPhoneNumberCollection")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentLink.IPaymentLinkPhoneNumberCollection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>If `true`, a phone number will be collected during checkout.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#enabled PaymentLink#enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
