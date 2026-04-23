using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppautoscalingPolicy
{
    [JsiiInterface(nativeType: typeof(IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecification), fullyQualifiedName: "aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecification")]
    public interface IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#target_value AppautoscalingPolicy#target_value}.</summary>
        [JsiiProperty(name: "targetValue", typeJson: "{\"primitive\":\"string\"}")]
        string TargetValue
        {
            get;
        }

        /// <summary>customized_capacity_metric_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#customized_capacity_metric_specification AppautoscalingPolicy#customized_capacity_metric_specification}
        /// </remarks>
        [JsiiProperty(name: "customizedCapacityMetricSpecification", typeJson: "{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecification\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecification? CustomizedCapacityMetricSpecification
        {
            get
            {
                return null;
            }
        }

        /// <summary>customized_load_metric_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#customized_load_metric_specification AppautoscalingPolicy#customized_load_metric_specification}
        /// </remarks>
        [JsiiProperty(name: "customizedLoadMetricSpecification", typeJson: "{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecification\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecification? CustomizedLoadMetricSpecification
        {
            get
            {
                return null;
            }
        }

        /// <summary>customized_scaling_metric_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#customized_scaling_metric_specification AppautoscalingPolicy#customized_scaling_metric_specification}
        /// </remarks>
        [JsiiProperty(name: "customizedScalingMetricSpecification", typeJson: "{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecification\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecification? CustomizedScalingMetricSpecification
        {
            get
            {
                return null;
            }
        }

        /// <summary>predefined_load_metric_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#predefined_load_metric_specification AppautoscalingPolicy#predefined_load_metric_specification}
        /// </remarks>
        [JsiiProperty(name: "predefinedLoadMetricSpecification", typeJson: "{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedLoadMetricSpecification\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedLoadMetricSpecification? PredefinedLoadMetricSpecification
        {
            get
            {
                return null;
            }
        }

        /// <summary>predefined_metric_pair_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#predefined_metric_pair_specification AppautoscalingPolicy#predefined_metric_pair_specification}
        /// </remarks>
        [JsiiProperty(name: "predefinedMetricPairSpecification", typeJson: "{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedMetricPairSpecification\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedMetricPairSpecification? PredefinedMetricPairSpecification
        {
            get
            {
                return null;
            }
        }

        /// <summary>predefined_scaling_metric_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#predefined_scaling_metric_specification AppautoscalingPolicy#predefined_scaling_metric_specification}
        /// </remarks>
        [JsiiProperty(name: "predefinedScalingMetricSpecification", typeJson: "{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedScalingMetricSpecification\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedScalingMetricSpecification? PredefinedScalingMetricSpecification
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecification), fullyQualifiedName: "aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#target_value AppautoscalingPolicy#target_value}.</summary>
            [JsiiProperty(name: "targetValue", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetValue
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>customized_capacity_metric_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#customized_capacity_metric_specification AppautoscalingPolicy#customized_capacity_metric_specification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customizedCapacityMetricSpecification", typeJson: "{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecification\"}", isOptional: true)]
            public aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecification? CustomizedCapacityMetricSpecification
            {
                get => GetInstanceProperty<aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecification?>();
            }

            /// <summary>customized_load_metric_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#customized_load_metric_specification AppautoscalingPolicy#customized_load_metric_specification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customizedLoadMetricSpecification", typeJson: "{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecification\"}", isOptional: true)]
            public aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecification? CustomizedLoadMetricSpecification
            {
                get => GetInstanceProperty<aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecification?>();
            }

            /// <summary>customized_scaling_metric_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#customized_scaling_metric_specification AppautoscalingPolicy#customized_scaling_metric_specification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customizedScalingMetricSpecification", typeJson: "{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecification\"}", isOptional: true)]
            public aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecification? CustomizedScalingMetricSpecification
            {
                get => GetInstanceProperty<aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecification?>();
            }

            /// <summary>predefined_load_metric_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#predefined_load_metric_specification AppautoscalingPolicy#predefined_load_metric_specification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "predefinedLoadMetricSpecification", typeJson: "{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedLoadMetricSpecification\"}", isOptional: true)]
            public aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedLoadMetricSpecification? PredefinedLoadMetricSpecification
            {
                get => GetInstanceProperty<aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedLoadMetricSpecification?>();
            }

            /// <summary>predefined_metric_pair_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#predefined_metric_pair_specification AppautoscalingPolicy#predefined_metric_pair_specification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "predefinedMetricPairSpecification", typeJson: "{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedMetricPairSpecification\"}", isOptional: true)]
            public aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedMetricPairSpecification? PredefinedMetricPairSpecification
            {
                get => GetInstanceProperty<aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedMetricPairSpecification?>();
            }

            /// <summary>predefined_scaling_metric_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#predefined_scaling_metric_specification AppautoscalingPolicy#predefined_scaling_metric_specification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "predefinedScalingMetricSpecification", typeJson: "{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedScalingMetricSpecification\"}", isOptional: true)]
            public aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedScalingMetricSpecification? PredefinedScalingMetricSpecification
            {
                get => GetInstanceProperty<aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedScalingMetricSpecification?>();
            }
        }
    }
}
