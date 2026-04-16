using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Worker
{
    [JsiiInterface(nativeType: typeof(IWorkerReferencesDomains), fullyQualifiedName: "cloudflare.worker.WorkerReferencesDomains")]
    public interface IWorkerReferencesDomains
    {

        [JsiiTypeProxy(nativeType: typeof(IWorkerReferencesDomains), fullyQualifiedName: "cloudflare.worker.WorkerReferencesDomains")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Worker.IWorkerReferencesDomains
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
