using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingCardholder
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.issuingCardholder.IssuingCardholderBilling")]
    public class IssuingCardholderBilling : stripe.IssuingCardholder.IIssuingCardholderBilling
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#address IssuingCardholder#address}.</summary>
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderBillingAddress\"}")]
        public stripe.IssuingCardholder.IIssuingCardholderBillingAddress Address
        {
            get;
            set;
        }
    }
}
