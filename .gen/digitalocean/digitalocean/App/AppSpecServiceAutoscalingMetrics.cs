using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiByValue(fqn: "digitalocean.app.AppSpecServiceAutoscalingMetrics")]
    public class AppSpecServiceAutoscalingMetrics : digitalocean.App.IAppSpecServiceAutoscalingMetrics
    {
        /// <summary>cpu block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#cpu App#cpu}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cpu", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceAutoscalingMetricsCpu\"}", isOptional: true)]
        public digitalocean.App.IAppSpecServiceAutoscalingMetricsCpu? Cpu
        {
            get;
            set;
        }
    }
}
