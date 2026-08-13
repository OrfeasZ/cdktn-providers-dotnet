using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingCard
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.issuingCard.IssuingCardLifecycleControlsCancelAfter")]
    public class IssuingCardLifecycleControlsCancelAfter : stripe.IssuingCard.IIssuingCardLifecycleControlsCancelAfter
    {
        /// <summary>The card is automatically cancelled when it makes this number of non-zero payment authorizations and transactions.</summary>
        /// <remarks>
        /// The count includes penny authorizations, but doesn't include non-payment actions, such as authorization advice.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#payment_count IssuingCard#payment_count}
        /// </remarks>
        [JsiiProperty(name: "paymentCount", typeJson: "{\"primitive\":\"number\"}")]
        public double PaymentCount
        {
            get;
            set;
        }
    }
}
