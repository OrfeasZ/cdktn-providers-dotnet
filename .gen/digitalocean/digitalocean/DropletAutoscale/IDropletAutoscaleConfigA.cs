using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DropletAutoscale
{
    [JsiiInterface(nativeType: typeof(IDropletAutoscaleConfigA), fullyQualifiedName: "digitalocean.dropletAutoscale.DropletAutoscaleConfigA")]
    public interface IDropletAutoscaleConfigA
    {
        /// <summary>Cooldown duration.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/droplet_autoscale#cooldown_minutes DropletAutoscale#cooldown_minutes}
        /// </remarks>
        [JsiiProperty(name: "cooldownMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CooldownMinutes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Max number of members.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/droplet_autoscale#max_instances DropletAutoscale#max_instances}
        /// </remarks>
        [JsiiProperty(name: "maxInstances", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxInstances
        {
            get
            {
                return null;
            }
        }

        /// <summary>Min number of members.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/droplet_autoscale#min_instances DropletAutoscale#min_instances}
        /// </remarks>
        [JsiiProperty(name: "minInstances", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinInstances
        {
            get
            {
                return null;
            }
        }

        /// <summary>CPU target threshold.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/droplet_autoscale#target_cpu_utilization DropletAutoscale#target_cpu_utilization}
        /// </remarks>
        [JsiiProperty(name: "targetCpuUtilization", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TargetCpuUtilization
        {
            get
            {
                return null;
            }
        }

        /// <summary>Memory target threshold.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/droplet_autoscale#target_memory_utilization DropletAutoscale#target_memory_utilization}
        /// </remarks>
        [JsiiProperty(name: "targetMemoryUtilization", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TargetMemoryUtilization
        {
            get
            {
                return null;
            }
        }

        /// <summary>Target number of members.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/droplet_autoscale#target_number_instances DropletAutoscale#target_number_instances}
        /// </remarks>
        [JsiiProperty(name: "targetNumberInstances", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TargetNumberInstances
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDropletAutoscaleConfigA), fullyQualifiedName: "digitalocean.dropletAutoscale.DropletAutoscaleConfigA")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DropletAutoscale.IDropletAutoscaleConfigA
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Cooldown duration.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/droplet_autoscale#cooldown_minutes DropletAutoscale#cooldown_minutes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cooldownMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CooldownMinutes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Max number of members.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/droplet_autoscale#max_instances DropletAutoscale#max_instances}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxInstances", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxInstances
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Min number of members.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/droplet_autoscale#min_instances DropletAutoscale#min_instances}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "minInstances", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinInstances
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>CPU target threshold.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/droplet_autoscale#target_cpu_utilization DropletAutoscale#target_cpu_utilization}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "targetCpuUtilization", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TargetCpuUtilization
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Memory target threshold.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/droplet_autoscale#target_memory_utilization DropletAutoscale#target_memory_utilization}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "targetMemoryUtilization", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TargetMemoryUtilization
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Target number of members.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/droplet_autoscale#target_number_instances DropletAutoscale#target_number_instances}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "targetNumberInstances", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TargetNumberInstances
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
