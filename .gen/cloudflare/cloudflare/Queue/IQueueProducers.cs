using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Queue
{
    [JsiiInterface(nativeType: typeof(IQueueProducers), fullyQualifiedName: "cloudflare.queue.QueueProducers")]
    public interface IQueueProducers
    {

        [JsiiTypeProxy(nativeType: typeof(IQueueProducers), fullyQualifiedName: "cloudflare.queue.QueueProducers")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Queue.IQueueProducers
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
