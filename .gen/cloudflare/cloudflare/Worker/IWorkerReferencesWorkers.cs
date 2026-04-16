using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Worker
{
    [JsiiInterface(nativeType: typeof(IWorkerReferencesWorkers), fullyQualifiedName: "cloudflare.worker.WorkerReferencesWorkers")]
    public interface IWorkerReferencesWorkers
    {

        [JsiiTypeProxy(nativeType: typeof(IWorkerReferencesWorkers), fullyQualifiedName: "cloudflare.worker.WorkerReferencesWorkers")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Worker.IWorkerReferencesWorkers
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
