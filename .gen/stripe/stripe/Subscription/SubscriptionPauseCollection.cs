using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiByValue(fqn: "stripe.subscription.SubscriptionPauseCollection")]
    public class SubscriptionPauseCollection : stripe.Subscription.ISubscriptionPauseCollection
    {
        /// <summary>The payment collection behavior for this subscription while paused.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#behavior Subscription#behavior}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "behavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Behavior
        {
            get;
            set;
        }

        /// <summary>The time after which the subscription will resume collecting payments.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#resumes_at Subscription#resumes_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resumesAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ResumesAt
        {
            get;
            set;
        }
    }
}
