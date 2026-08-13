using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingCardholder
{
    [JsiiByValue(fqn: "stripe.issuingCardholder.IssuingCardholderCompany")]
    public class IssuingCardholderCompany : stripe.IssuingCardholder.IIssuingCardholderCompany
    {
        /// <summary>The entity's business ID number.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#tax_id IssuingCardholder#tax_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "taxId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TaxId
        {
            get;
            set;
        }
    }
}
