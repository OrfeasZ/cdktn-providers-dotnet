using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersCronTrigger
{
    [JsiiInterface(nativeType: typeof(IWorkersCronTriggerSchedules), fullyQualifiedName: "cloudflare.workersCronTrigger.WorkersCronTriggerSchedules")]
    public interface IWorkersCronTriggerSchedules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/workers_cron_trigger#cron WorkersCronTrigger#cron}.</summary>
        [JsiiProperty(name: "cron", typeJson: "{\"primitive\":\"string\"}")]
        string Cron
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkersCronTriggerSchedules), fullyQualifiedName: "cloudflare.workersCronTrigger.WorkersCronTriggerSchedules")]
        internal sealed class _Proxy : DeputyBase, cloudflare.WorkersCronTrigger.IWorkersCronTriggerSchedules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/workers_cron_trigger#cron WorkersCronTrigger#cron}.</summary>
            [JsiiProperty(name: "cron", typeJson: "{\"primitive\":\"string\"}")]
            public string Cron
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
