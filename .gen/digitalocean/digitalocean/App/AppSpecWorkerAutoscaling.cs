using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.app.AppSpecWorkerAutoscaling")]
    public class AppSpecWorkerAutoscaling : digitalocean.App.IAppSpecWorkerAutoscaling
    {
        /// <summary>The maximum amount of instances for this component. Must be more than min_instance_count.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#max_instance_count App#max_instance_count}
        /// </remarks>
        [JsiiProperty(name: "maxInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxInstanceCount
        {
            get;
            set;
        }

        /// <summary>metrics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#metrics App#metrics}
        /// </remarks>
        [JsiiProperty(name: "metrics", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerAutoscalingMetrics\"}")]
        public digitalocean.App.IAppSpecWorkerAutoscalingMetrics Metrics
        {
            get;
            set;
        }

        /// <summary>The minimum amount of instances for this component. Must be less than max_instance_count.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#min_instance_count App#min_instance_count}
        /// </remarks>
        [JsiiProperty(name: "minInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public double MinInstanceCount
        {
            get;
            set;
        }
    }
}
