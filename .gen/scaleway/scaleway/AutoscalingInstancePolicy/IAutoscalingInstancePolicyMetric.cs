using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.AutoscalingInstancePolicy
{
    [JsiiInterface(nativeType: typeof(IAutoscalingInstancePolicyMetric), fullyQualifiedName: "scaleway.autoscalingInstancePolicy.AutoscalingInstancePolicyMetric")]
    public interface IAutoscalingInstancePolicyMetric
    {
        /// <summary>How the values sampled for the `metric` should be aggregated.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_policy#aggregate AutoscalingInstancePolicy#aggregate}
        /// </remarks>
        [JsiiProperty(name: "aggregate", typeJson: "{\"primitive\":\"string\"}")]
        string Aggregate
        {
            get;
        }

        /// <summary>Name or description of the metric policy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_policy#name AutoscalingInstancePolicy#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Operator used when comparing the threshold value of the chosen `metric` to the actual sampled and aggregated value.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_policy#operator AutoscalingInstancePolicy#operator}
        /// </remarks>
        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
        string Operator
        {
            get;
        }

        /// <summary>Custom metric to use for this policy.</summary>
        /// <remarks>
        /// This must be stored in Scaleway Cockpit. The metric forms the basis of the condition that will be checked to determine whether a scaling action should be triggered
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_policy#cockpit_metric_name AutoscalingInstancePolicy#cockpit_metric_name}
        /// </remarks>
        [JsiiProperty(name: "cockpitMetricName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CockpitMetricName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Managed metric to use for this policy.</summary>
        /// <remarks>
        /// These are available by default in Cockpit without any configuration or <c>node_exporter</c>. The chosen metric forms the basis of the condition that will be checked to determine whether a scaling action should be triggered
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_policy#managed_metric AutoscalingInstancePolicy#managed_metric}
        /// </remarks>
        [JsiiProperty(name: "managedMetric", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ManagedMetric
        {
            get
            {
                return null;
            }
        }

        /// <summary>Interval of time, in minutes, during which metric is sampled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_policy#sampling_range_min AutoscalingInstancePolicy#sampling_range_min}
        /// </remarks>
        [JsiiProperty(name: "samplingRangeMin", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SamplingRangeMin
        {
            get
            {
                return null;
            }
        }

        /// <summary>Threshold value to measure the aggregated sampled `metric` value against.</summary>
        /// <remarks>
        /// Combined with the <c>operator</c> field, determines whether a scaling action should be triggered
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_policy#threshold AutoscalingInstancePolicy#threshold}
        /// </remarks>
        [JsiiProperty(name: "threshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Threshold
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingInstancePolicyMetric), fullyQualifiedName: "scaleway.autoscalingInstancePolicy.AutoscalingInstancePolicyMetric")]
        internal sealed class _Proxy : DeputyBase, scaleway.AutoscalingInstancePolicy.IAutoscalingInstancePolicyMetric
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>How the values sampled for the `metric` should be aggregated.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_policy#aggregate AutoscalingInstancePolicy#aggregate}
            /// </remarks>
            [JsiiProperty(name: "aggregate", typeJson: "{\"primitive\":\"string\"}")]
            public string Aggregate
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Name or description of the metric policy.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_policy#name AutoscalingInstancePolicy#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Operator used when comparing the threshold value of the chosen `metric` to the actual sampled and aggregated value.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_policy#operator AutoscalingInstancePolicy#operator}
            /// </remarks>
            [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
            public string Operator
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Custom metric to use for this policy.</summary>
            /// <remarks>
            /// This must be stored in Scaleway Cockpit. The metric forms the basis of the condition that will be checked to determine whether a scaling action should be triggered
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_policy#cockpit_metric_name AutoscalingInstancePolicy#cockpit_metric_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cockpitMetricName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CockpitMetricName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Managed metric to use for this policy.</summary>
            /// <remarks>
            /// These are available by default in Cockpit without any configuration or <c>node_exporter</c>. The chosen metric forms the basis of the condition that will be checked to determine whether a scaling action should be triggered
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_policy#managed_metric AutoscalingInstancePolicy#managed_metric}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "managedMetric", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ManagedMetric
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Interval of time, in minutes, during which metric is sampled.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_policy#sampling_range_min AutoscalingInstancePolicy#sampling_range_min}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "samplingRangeMin", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SamplingRangeMin
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Threshold value to measure the aggregated sampled `metric` value against.</summary>
            /// <remarks>
            /// Combined with the <c>operator</c> field, determines whether a scaling action should be triggered
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_policy#threshold AutoscalingInstancePolicy#threshold}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "threshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Threshold
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
