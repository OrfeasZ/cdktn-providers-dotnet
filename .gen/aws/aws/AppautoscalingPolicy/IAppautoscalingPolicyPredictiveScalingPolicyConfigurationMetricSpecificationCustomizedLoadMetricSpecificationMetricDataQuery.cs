using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppautoscalingPolicy
{
    [JsiiInterface(nativeType: typeof(IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQuery), fullyQualifiedName: "aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQuery")]
    public interface IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQuery
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#id AppautoscalingPolicy#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        string Id
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#expression AppautoscalingPolicy#expression}.</summary>
        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Expression
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#label AppautoscalingPolicy#label}.</summary>
        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Label
        {
            get
            {
                return null;
            }
        }

        /// <summary>metric_stat block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#metric_stat AppautoscalingPolicy#metric_stat}
        /// </remarks>
        [JsiiProperty(name: "metricStat", typeJson: "{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStat\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStat? MetricStat
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#return_data AppautoscalingPolicy#return_data}.</summary>
        [JsiiProperty(name: "returnData", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ReturnData
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQuery), fullyQualifiedName: "aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQuery")]
        internal sealed class _Proxy : DeputyBase, aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQuery
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#id AppautoscalingPolicy#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
            public string Id
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#expression AppautoscalingPolicy#expression}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Expression
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#label AppautoscalingPolicy#label}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Label
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>metric_stat block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#metric_stat AppautoscalingPolicy#metric_stat}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metricStat", typeJson: "{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStat\"}", isOptional: true)]
            public aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStat? MetricStat
            {
                get => GetInstanceProperty<aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStat?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#return_data AppautoscalingPolicy#return_data}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "returnData", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ReturnData
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
