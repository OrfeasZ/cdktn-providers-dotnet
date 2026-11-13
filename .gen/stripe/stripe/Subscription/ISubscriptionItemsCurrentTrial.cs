using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiInterface(nativeType: typeof(ISubscriptionItemsCurrentTrial), fullyQualifiedName: "stripe.subscription.SubscriptionItemsCurrentTrial")]
    public interface ISubscriptionItemsCurrentTrial
    {
        /// <summary>The ID of the trial offer to apply to the subscription item.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#trial_offer Subscription#trial_offer}
        /// </remarks>
        [JsiiProperty(name: "trialOffer", typeJson: "{\"primitive\":\"string\"}")]
        string TrialOffer
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionItemsCurrentTrial), fullyQualifiedName: "stripe.subscription.SubscriptionItemsCurrentTrial")]
        internal sealed class _Proxy : DeputyBase, stripe.Subscription.ISubscriptionItemsCurrentTrial
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of the trial offer to apply to the subscription item.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#trial_offer Subscription#trial_offer}
            /// </remarks>
            [JsiiProperty(name: "trialOffer", typeJson: "{\"primitive\":\"string\"}")]
            public string TrialOffer
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
