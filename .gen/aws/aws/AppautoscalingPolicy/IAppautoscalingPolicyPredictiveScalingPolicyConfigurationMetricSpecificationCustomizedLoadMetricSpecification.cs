using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppautoscalingPolicy
{
    [JsiiInterface(nativeType: typeof(IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecification), fullyQualifiedName: "aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecification")]
    public interface IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecification
    {
        /// <summary>metric_data_query block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#metric_data_query AppautoscalingPolicy#metric_data_query}
        /// </remarks>
        [JsiiProperty(name: "metricDataQuery", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQuery\"},\"kind\":\"array\"}}]}}")]
        object MetricDataQuery
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecification), fullyQualifiedName: "aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>metric_data_query block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#metric_data_query AppautoscalingPolicy#metric_data_query}
            /// </remarks>
            [JsiiProperty(name: "metricDataQuery", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQuery\"},\"kind\":\"array\"}}]}}")]
            public object MetricDataQuery
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
