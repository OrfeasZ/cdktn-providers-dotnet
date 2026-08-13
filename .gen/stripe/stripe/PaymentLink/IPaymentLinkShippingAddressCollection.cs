using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiInterface(nativeType: typeof(IPaymentLinkShippingAddressCollection), fullyQualifiedName: "stripe.paymentLink.PaymentLinkShippingAddressCollection")]
    public interface IPaymentLinkShippingAddressCollection
    {
        /// <summary>An array of two-letter ISO country codes representing which countries Checkout should provide as options for shipping locations.</summary>
        /// <remarks>
        /// Unsupported country codes: <c>AS, CX, CC, CU, HM, IR, KP, MH, FM, NF, MP, PW, SD, SY, UM, VI</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#allowed_countries PaymentLink#allowed_countries}
        /// </remarks>
        [JsiiProperty(name: "allowedCountries", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] AllowedCountries
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentLinkShippingAddressCollection), fullyQualifiedName: "stripe.paymentLink.PaymentLinkShippingAddressCollection")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentLink.IPaymentLinkShippingAddressCollection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>An array of two-letter ISO country codes representing which countries Checkout should provide as options for shipping locations.</summary>
            /// <remarks>
            /// Unsupported country codes: <c>AS, CX, CC, CU, HM, IR, KP, MH, FM, NF, MP, PW, SD, SY, UM, VI</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#allowed_countries PaymentLink#allowed_countries}
            /// </remarks>
            [JsiiProperty(name: "allowedCountries", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] AllowedCountries
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
