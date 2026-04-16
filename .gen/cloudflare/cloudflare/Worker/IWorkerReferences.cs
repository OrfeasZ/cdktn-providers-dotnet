using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Worker
{
    [JsiiInterface(nativeType: typeof(IWorkerReferences), fullyQualifiedName: "cloudflare.worker.WorkerReferences")]
    public interface IWorkerReferences
    {

        [JsiiTypeProxy(nativeType: typeof(IWorkerReferences), fullyQualifiedName: "cloudflare.worker.WorkerReferences")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Worker.IWorkerReferences
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
