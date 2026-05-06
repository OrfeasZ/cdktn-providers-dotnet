using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AutoscalingAutoScalingConfiguration
{
    [JsiiByValue(fqn: "oci.autoscalingAutoScalingConfiguration.AutoscalingAutoScalingConfigurationPoliciesRulesMetric")]
    public class AutoscalingAutoScalingConfigurationPoliciesRulesMetric : oci.AutoscalingAutoScalingConfiguration.IAutoscalingAutoScalingConfigurationPoliciesRulesMetric
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/autoscaling_auto_scaling_configuration#metric_compartment_id AutoscalingAutoScalingConfiguration#metric_compartment_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metricCompartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MetricCompartmentId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/autoscaling_auto_scaling_configuration#metric_source AutoscalingAutoScalingConfiguration#metric_source}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metricSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MetricSource
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/autoscaling_auto_scaling_configuration#metric_type AutoscalingAutoScalingConfiguration#metric_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metricType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MetricType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/autoscaling_auto_scaling_configuration#namespace AutoscalingAutoScalingConfiguration#namespace}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Namespace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/autoscaling_auto_scaling_configuration#pending_duration AutoscalingAutoScalingConfiguration#pending_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pendingDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PendingDuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/autoscaling_auto_scaling_configuration#query AutoscalingAutoScalingConfiguration#query}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Query
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/autoscaling_auto_scaling_configuration#resource_group AutoscalingAutoScalingConfiguration#resource_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceGroup
        {
            get;
            set;
        }

        /// <summary>threshold block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/autoscaling_auto_scaling_configuration#threshold AutoscalingAutoScalingConfiguration#threshold}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "threshold", typeJson: "{\"fqn\":\"oci.autoscalingAutoScalingConfiguration.AutoscalingAutoScalingConfigurationPoliciesRulesMetricThreshold\"}", isOptional: true)]
        public oci.AutoscalingAutoScalingConfiguration.IAutoscalingAutoScalingConfigurationPoliciesRulesMetricThreshold? Threshold
        {
            get;
            set;
        }
    }
}
