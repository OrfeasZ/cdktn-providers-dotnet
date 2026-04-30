using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppautoscalingPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecification")]
    public class AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecification : aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/appautoscaling_policy#target_value AppautoscalingPolicy#target_value}.</summary>
        [JsiiProperty(name: "targetValue", typeJson: "{\"primitive\":\"string\"}")]
        public string TargetValue
        {
            get;
            set;
        }

        /// <summary>customized_capacity_metric_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/appautoscaling_policy#customized_capacity_metric_specification AppautoscalingPolicy#customized_capacity_metric_specification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customizedCapacityMetricSpecification", typeJson: "{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecification\"}", isOptional: true)]
        public aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecification? CustomizedCapacityMetricSpecification
        {
            get;
            set;
        }

        /// <summary>customized_load_metric_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/appautoscaling_policy#customized_load_metric_specification AppautoscalingPolicy#customized_load_metric_specification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customizedLoadMetricSpecification", typeJson: "{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecification\"}", isOptional: true)]
        public aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecification? CustomizedLoadMetricSpecification
        {
            get;
            set;
        }

        /// <summary>customized_scaling_metric_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/appautoscaling_policy#customized_scaling_metric_specification AppautoscalingPolicy#customized_scaling_metric_specification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customizedScalingMetricSpecification", typeJson: "{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecification\"}", isOptional: true)]
        public aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecification? CustomizedScalingMetricSpecification
        {
            get;
            set;
        }

        /// <summary>predefined_load_metric_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/appautoscaling_policy#predefined_load_metric_specification AppautoscalingPolicy#predefined_load_metric_specification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "predefinedLoadMetricSpecification", typeJson: "{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedLoadMetricSpecification\"}", isOptional: true)]
        public aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedLoadMetricSpecification? PredefinedLoadMetricSpecification
        {
            get;
            set;
        }

        /// <summary>predefined_metric_pair_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/appautoscaling_policy#predefined_metric_pair_specification AppautoscalingPolicy#predefined_metric_pair_specification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "predefinedMetricPairSpecification", typeJson: "{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedMetricPairSpecification\"}", isOptional: true)]
        public aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedMetricPairSpecification? PredefinedMetricPairSpecification
        {
            get;
            set;
        }

        /// <summary>predefined_scaling_metric_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/appautoscaling_policy#predefined_scaling_metric_specification AppautoscalingPolicy#predefined_scaling_metric_specification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "predefinedScalingMetricSpecification", typeJson: "{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedScalingMetricSpecification\"}", isOptional: true)]
        public aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedScalingMetricSpecification? PredefinedScalingMetricSpecification
        {
            get;
            set;
        }
    }
}
