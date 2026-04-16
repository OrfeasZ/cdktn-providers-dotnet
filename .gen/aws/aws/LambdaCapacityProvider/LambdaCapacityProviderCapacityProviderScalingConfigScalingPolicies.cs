using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaCapacityProvider
{
    [JsiiByValue(fqn: "aws.lambdaCapacityProvider.LambdaCapacityProviderCapacityProviderScalingConfigScalingPolicies")]
    public class LambdaCapacityProviderCapacityProviderScalingConfigScalingPolicies : aws.LambdaCapacityProvider.ILambdaCapacityProviderCapacityProviderScalingConfigScalingPolicies
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lambda_capacity_provider#predefined_metric_type LambdaCapacityProvider#predefined_metric_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "predefinedMetricType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PredefinedMetricType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lambda_capacity_provider#target_value LambdaCapacityProvider#target_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetValue", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TargetValue
        {
            get;
            set;
        }
    }
}
