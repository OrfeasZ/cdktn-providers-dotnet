using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Worker
{
    [JsiiInterface(nativeType: typeof(IWorkerReferencesQueues), fullyQualifiedName: "cloudflare.worker.WorkerReferencesQueues")]
    public interface IWorkerReferencesQueues
    {

        [JsiiTypeProxy(nativeType: typeof(IWorkerReferencesQueues), fullyQualifiedName: "cloudflare.worker.WorkerReferencesQueues")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Worker.IWorkerReferencesQueues
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
