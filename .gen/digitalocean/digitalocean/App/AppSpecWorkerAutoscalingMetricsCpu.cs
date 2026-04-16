using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.app.AppSpecWorkerAutoscalingMetricsCpu")]
    public class AppSpecWorkerAutoscalingMetricsCpu : digitalocean.App.IAppSpecWorkerAutoscalingMetricsCpu
    {
        /// <summary>The average target CPU utilization for the component.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#percent App#percent}
        /// </remarks>
        [JsiiProperty(name: "percent", typeJson: "{\"primitive\":\"number\"}")]
        public double Percent
        {
            get;
            set;
        }
    }
}
