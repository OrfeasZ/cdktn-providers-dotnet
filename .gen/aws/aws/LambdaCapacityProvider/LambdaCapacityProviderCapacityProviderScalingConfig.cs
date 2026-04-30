using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaCapacityProvider
{
    [JsiiByValue(fqn: "aws.lambdaCapacityProvider.LambdaCapacityProviderCapacityProviderScalingConfig")]
    public class LambdaCapacityProviderCapacityProviderScalingConfig : aws.LambdaCapacityProvider.ILambdaCapacityProviderCapacityProviderScalingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lambda_capacity_provider#max_vcpu_count LambdaCapacityProvider#max_vcpu_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxVcpuCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxVcpuCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lambda_capacity_provider#scaling_mode LambdaCapacityProvider#scaling_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scalingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScalingMode
        {
            get;
            set;
        }

        private object? _scalingPolicies;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lambda_capacity_provider#scaling_policies LambdaCapacityProvider#scaling_policies}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scalingPolicies", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdaCapacityProvider.LambdaCapacityProviderCapacityProviderScalingConfigScalingPolicies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ScalingPolicies
        {
            get => _scalingPolicies;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.LambdaCapacityProvider.ILambdaCapacityProviderCapacityProviderScalingConfigScalingPolicies[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.LambdaCapacityProvider.ILambdaCapacityProviderCapacityProviderScalingConfigScalingPolicies).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _scalingPolicies = value;
            }
        }
    }
}
