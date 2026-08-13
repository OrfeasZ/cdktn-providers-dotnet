using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingCard
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.issuingCard.IssuingCardLifecycleControls")]
    public class IssuingCardLifecycleControls : stripe.IssuingCard.IIssuingCardLifecycleControls
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#cancel_after IssuingCard#cancel_after}.</summary>
        [JsiiProperty(name: "cancelAfter", typeJson: "{\"fqn\":\"stripe.issuingCard.IssuingCardLifecycleControlsCancelAfter\"}")]
        public stripe.IssuingCard.IIssuingCardLifecycleControlsCancelAfter CancelAfter
        {
            get;
            set;
        }
    }
}
