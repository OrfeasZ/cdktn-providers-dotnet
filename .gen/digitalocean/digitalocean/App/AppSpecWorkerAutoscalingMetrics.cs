using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiByValue(fqn: "digitalocean.app.AppSpecWorkerAutoscalingMetrics")]
    public class AppSpecWorkerAutoscalingMetrics : digitalocean.App.IAppSpecWorkerAutoscalingMetrics
    {
        /// <summary>cpu block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#cpu App#cpu}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cpu", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerAutoscalingMetricsCpu\"}", isOptional: true)]
        public digitalocean.App.IAppSpecWorkerAutoscalingMetricsCpu? Cpu
        {
            get;
            set;
        }
    }
}
