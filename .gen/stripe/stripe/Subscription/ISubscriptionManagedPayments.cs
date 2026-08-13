using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiInterface(nativeType: typeof(ISubscriptionManagedPayments), fullyQualifiedName: "stripe.subscription.SubscriptionManagedPayments")]
    public interface ISubscriptionManagedPayments
    {

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionManagedPayments), fullyQualifiedName: "stripe.subscription.SubscriptionManagedPayments")]
        internal sealed class _Proxy : DeputyBase, stripe.Subscription.ISubscriptionManagedPayments
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
