using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingCard
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.issuingCard.IssuingCardShippingAddressValidation")]
    public class IssuingCardShippingAddressValidation : stripe.IssuingCard.IIssuingCardShippingAddressValidation
    {
        /// <summary>The address validation capabilities to use.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#mode IssuingCard#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public string Mode
        {
            get;
            set;
        }
    }
}
