using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersCronTrigger
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.workersCronTrigger.WorkersCronTriggerSchedules")]
    public class WorkersCronTriggerSchedules : cloudflare.WorkersCronTrigger.IWorkersCronTriggerSchedules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_cron_trigger#cron WorkersCronTrigger#cron}.</summary>
        [JsiiProperty(name: "cron", typeJson: "{\"primitive\":\"string\"}")]
        public string Cron
        {
            get;
            set;
        }
    }
}
