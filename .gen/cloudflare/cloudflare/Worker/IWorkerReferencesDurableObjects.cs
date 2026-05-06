using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Worker
{
    [JsiiInterface(nativeType: typeof(IWorkerReferencesDurableObjects), fullyQualifiedName: "cloudflare.worker.WorkerReferencesDurableObjects")]
    public interface IWorkerReferencesDurableObjects
    {

        [JsiiTypeProxy(nativeType: typeof(IWorkerReferencesDurableObjects), fullyQualifiedName: "cloudflare.worker.WorkerReferencesDurableObjects")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Worker.IWorkerReferencesDurableObjects
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
