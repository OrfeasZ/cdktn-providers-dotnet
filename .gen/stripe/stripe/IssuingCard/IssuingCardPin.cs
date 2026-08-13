using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingCard
{
    [JsiiByValue(fqn: "stripe.issuingCard.IssuingCardPin")]
    public class IssuingCardPin : stripe.IssuingCard.IIssuingCardPin
    {
        /// <summary>The card's desired new PIN, encrypted under Stripe's public key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#encrypted_number IssuingCard#encrypted_number}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "encryptedNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EncryptedNumber
        {
            get;
            set;
        }
    }
}
