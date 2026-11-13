using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiInterface(nativeType: typeof(ISubscriptionStatusDetails), fullyQualifiedName: "stripe.subscription.SubscriptionStatusDetails")]
    public interface ISubscriptionStatusDetails
    {

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionStatusDetails), fullyQualifiedName: "stripe.subscription.SubscriptionStatusDetails")]
        internal sealed class _Proxy : DeputyBase, stripe.Subscription.ISubscriptionStatusDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
