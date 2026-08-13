using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiByValue(fqn: "stripe.subscription.SubscriptionCancellationDetails")]
    public class SubscriptionCancellationDetails : stripe.Subscription.ISubscriptionCancellationDetails
    {
        /// <summary>Additional comments about why the user canceled the subscription, if the subscription was canceled explicitly by the user.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#comment Subscription#comment}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Comment
        {
            get;
            set;
        }

        /// <summary>The customer submitted reason for why they canceled, if the subscription was canceled explicitly by the user.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#feedback Subscription#feedback}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "feedback", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Feedback
        {
            get;
            set;
        }
    }
}
