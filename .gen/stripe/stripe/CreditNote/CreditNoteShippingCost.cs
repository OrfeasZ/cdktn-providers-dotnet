using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.CreditNote
{
    [JsiiByValue(fqn: "stripe.creditNote.CreditNoteShippingCost")]
    public class CreditNoteShippingCost : stripe.CreditNote.ICreditNoteShippingCost
    {
        /// <summary>The ID of the ShippingRate for this invoice.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#shipping_rate CreditNote#shipping_rate}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shippingRate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ShippingRate
        {
            get;
            set;
        }
    }
}
