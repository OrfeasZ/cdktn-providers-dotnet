using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionItem
{
    [JsiiInterface(nativeType: typeof(ISubscriptionItemCurrentTrial), fullyQualifiedName: "stripe.subscriptionItem.SubscriptionItemCurrentTrial")]
    public interface ISubscriptionItemCurrentTrial
    {
        /// <summary>The Trial Offer ID applied to the subscription item.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_item#trial_offer SubscriptionItem#trial_offer}
        /// </remarks>
        [JsiiProperty(name: "trialOffer", typeJson: "{\"primitive\":\"string\"}")]
        string TrialOffer
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionItemCurrentTrial), fullyQualifiedName: "stripe.subscriptionItem.SubscriptionItemCurrentTrial")]
        internal sealed class _Proxy : DeputyBase, stripe.SubscriptionItem.ISubscriptionItemCurrentTrial
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The Trial Offer ID applied to the subscription item.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_item#trial_offer SubscriptionItem#trial_offer}
            /// </remarks>
            [JsiiProperty(name: "trialOffer", typeJson: "{\"primitive\":\"string\"}")]
            public string TrialOffer
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
