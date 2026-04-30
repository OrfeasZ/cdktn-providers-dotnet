using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaCapacityProvider
{
    [JsiiInterface(nativeType: typeof(ILambdaCapacityProviderCapacityProviderScalingConfigScalingPolicies), fullyQualifiedName: "aws.lambdaCapacityProvider.LambdaCapacityProviderCapacityProviderScalingConfigScalingPolicies")]
    public interface ILambdaCapacityProviderCapacityProviderScalingConfigScalingPolicies
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lambda_capacity_provider#predefined_metric_type LambdaCapacityProvider#predefined_metric_type}.</summary>
        [JsiiProperty(name: "predefinedMetricType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PredefinedMetricType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lambda_capacity_provider#target_value LambdaCapacityProvider#target_value}.</summary>
        [JsiiProperty(name: "targetValue", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TargetValue
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaCapacityProviderCapacityProviderScalingConfigScalingPolicies), fullyQualifiedName: "aws.lambdaCapacityProvider.LambdaCapacityProviderCapacityProviderScalingConfigScalingPolicies")]
        internal sealed class _Proxy : DeputyBase, aws.LambdaCapacityProvider.ILambdaCapacityProviderCapacityProviderScalingConfigScalingPolicies
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lambda_capacity_provider#predefined_metric_type LambdaCapacityProvider#predefined_metric_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "predefinedMetricType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PredefinedMetricType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lambda_capacity_provider#target_value LambdaCapacityProvider#target_value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetValue", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TargetValue
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
