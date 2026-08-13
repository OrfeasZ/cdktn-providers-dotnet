using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.paymentLink.PaymentLinkShippingAddressCollection")]
    public class PaymentLinkShippingAddressCollection : stripe.PaymentLink.IPaymentLinkShippingAddressCollection
    {
        /// <summary>An array of two-letter ISO country codes representing which countries Checkout should provide as options for shipping locations.</summary>
        /// <remarks>
        /// Unsupported country codes: <c>AS, CX, CC, CU, HM, IR, KP, MH, FM, NF, MP, PW, SD, SY, UM, VI</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#allowed_countries PaymentLink#allowed_countries}
        /// </remarks>
        [JsiiProperty(name: "allowedCountries", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] AllowedCountries
        {
            get;
            set;
        }
    }
}
