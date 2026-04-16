using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Queue
{
    [JsiiInterface(nativeType: typeof(IQueueConsumers), fullyQualifiedName: "cloudflare.queue.QueueConsumers")]
    public interface IQueueConsumers
    {

        [JsiiTypeProxy(nativeType: typeof(IQueueConsumers), fullyQualifiedName: "cloudflare.queue.QueueConsumers")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Queue.IQueueConsumers
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
