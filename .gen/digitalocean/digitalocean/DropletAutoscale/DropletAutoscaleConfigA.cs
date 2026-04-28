using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DropletAutoscale
{
    [JsiiByValue(fqn: "digitalocean.dropletAutoscale.DropletAutoscaleConfigA")]
    public class DropletAutoscaleConfigA : digitalocean.DropletAutoscale.IDropletAutoscaleConfigA
    {
        /// <summary>Cooldown duration.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/droplet_autoscale#cooldown_minutes DropletAutoscale#cooldown_minutes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cooldownMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CooldownMinutes
        {
            get;
            set;
        }

        /// <summary>Max number of members.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/droplet_autoscale#max_instances DropletAutoscale#max_instances}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maxInstances", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxInstances
        {
            get;
            set;
        }

        /// <summary>Min number of members.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/droplet_autoscale#min_instances DropletAutoscale#min_instances}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "minInstances", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinInstances
        {
            get;
            set;
        }

        /// <summary>CPU target threshold.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/droplet_autoscale#target_cpu_utilization DropletAutoscale#target_cpu_utilization}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetCpuUtilization", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TargetCpuUtilization
        {
            get;
            set;
        }

        /// <summary>Memory target threshold.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/droplet_autoscale#target_memory_utilization DropletAutoscale#target_memory_utilization}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetMemoryUtilization", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TargetMemoryUtilization
        {
            get;
            set;
        }

        /// <summary>Target number of members.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/droplet_autoscale#target_number_instances DropletAutoscale#target_number_instances}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetNumberInstances", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TargetNumberInstances
        {
            get;
            set;
        }
    }
}
