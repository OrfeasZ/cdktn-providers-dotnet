using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppautoscalingPolicy
{
    [JsiiInterface(nativeType: typeof(IAppautoscalingPolicyPredictiveScalingPolicyConfiguration), fullyQualifiedName: "aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfiguration")]
    public interface IAppautoscalingPolicyPredictiveScalingPolicyConfiguration
    {
        /// <summary>metric_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/appautoscaling_policy#metric_specification AppautoscalingPolicy#metric_specification}
        /// </remarks>
        [JsiiProperty(name: "metricSpecification", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecification\"},\"kind\":\"array\"}}]}}")]
        object MetricSpecification
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/appautoscaling_policy#max_capacity_breach_behavior AppautoscalingPolicy#max_capacity_breach_behavior}.</summary>
        [JsiiProperty(name: "maxCapacityBreachBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaxCapacityBreachBehavior
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/appautoscaling_policy#max_capacity_buffer AppautoscalingPolicy#max_capacity_buffer}.</summary>
        [JsiiProperty(name: "maxCapacityBuffer", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxCapacityBuffer
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/appautoscaling_policy#mode AppautoscalingPolicy#mode}.</summary>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Mode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/appautoscaling_policy#scheduling_buffer_time AppautoscalingPolicy#scheduling_buffer_time}.</summary>
        [JsiiProperty(name: "schedulingBufferTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SchedulingBufferTime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppautoscalingPolicyPredictiveScalingPolicyConfiguration), fullyQualifiedName: "aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>metric_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/appautoscaling_policy#metric_specification AppautoscalingPolicy#metric_specification}
            /// </remarks>
            [JsiiProperty(name: "metricSpecification", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecification\"},\"kind\":\"array\"}}]}}")]
            public object MetricSpecification
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/appautoscaling_policy#max_capacity_breach_behavior AppautoscalingPolicy#max_capacity_breach_behavior}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxCapacityBreachBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaxCapacityBreachBehavior
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/appautoscaling_policy#max_capacity_buffer AppautoscalingPolicy#max_capacity_buffer}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxCapacityBuffer", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxCapacityBuffer
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/appautoscaling_policy#mode AppautoscalingPolicy#mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Mode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/appautoscaling_policy#scheduling_buffer_time AppautoscalingPolicy#scheduling_buffer_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "schedulingBufferTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SchedulingBufferTime
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
