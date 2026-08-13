using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiByValue(fqn: "stripe.setupIntent.SetupIntentPaymentMethodDataNaverPay")]
    public class SetupIntentPaymentMethodDataNaverPay : stripe.SetupIntent.ISetupIntentPaymentMethodDataNaverPay
    {
        /// <summary>Whether to use Naver Pay points or a card to fund this transaction.</summary>
        /// <remarks>
        /// If not provided, this defaults to <c>card</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#funding SetupIntent#funding}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "funding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Funding
        {
            get;
            set;
        }
    }
}
