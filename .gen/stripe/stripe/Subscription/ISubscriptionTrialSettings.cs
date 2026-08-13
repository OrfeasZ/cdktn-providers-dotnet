using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiInterface(nativeType: typeof(ISubscriptionTrialSettings), fullyQualifiedName: "stripe.subscription.SubscriptionTrialSettings")]
    public interface ISubscriptionTrialSettings
    {
        /// <summary>Defines how a subscription behaves when a trial ends.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#end_behavior Subscription#end_behavior}
        /// </remarks>
        [JsiiProperty(name: "endBehavior", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionTrialSettingsEndBehavior\"}")]
        stripe.Subscription.ISubscriptionTrialSettingsEndBehavior EndBehavior
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionTrialSettings), fullyQualifiedName: "stripe.subscription.SubscriptionTrialSettings")]
        internal sealed class _Proxy : DeputyBase, stripe.Subscription.ISubscriptionTrialSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Defines how a subscription behaves when a trial ends.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#end_behavior Subscription#end_behavior}
            /// </remarks>
            [JsiiProperty(name: "endBehavior", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionTrialSettingsEndBehavior\"}")]
            public stripe.Subscription.ISubscriptionTrialSettingsEndBehavior EndBehavior
            {
                get => GetInstanceProperty<stripe.Subscription.ISubscriptionTrialSettingsEndBehavior>()!;
            }
        }
    }
}
