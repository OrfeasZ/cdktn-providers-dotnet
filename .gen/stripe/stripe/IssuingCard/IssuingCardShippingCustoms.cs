using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingCard
{
    [JsiiByValue(fqn: "stripe.issuingCard.IssuingCardShippingCustoms")]
    public class IssuingCardShippingCustoms : stripe.IssuingCard.IIssuingCardShippingCustoms
    {
        /// <summary>A registration number used for customs in Europe. See [https://www.gov.uk/eori](https://www.gov.uk/eori) for the UK and [https://ec.europa.eu/taxation_customs/business/customs-procedures-import-and-export/customs-procedures/economic-operators-registration-and-identification-number-eori_en](https://ec.europa.eu/taxation_customs/business/customs-procedures-import-and-export/customs-procedures/economic-operators-registration-and-identification-number-eori_en) for the EU.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#eori_number IssuingCard#eori_number}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "eoriNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EoriNumber
        {
            get;
            set;
        }
    }
}
