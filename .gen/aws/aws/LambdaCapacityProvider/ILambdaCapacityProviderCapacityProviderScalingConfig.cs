using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaCapacityProvider
{
    [JsiiInterface(nativeType: typeof(ILambdaCapacityProviderCapacityProviderScalingConfig), fullyQualifiedName: "aws.lambdaCapacityProvider.LambdaCapacityProviderCapacityProviderScalingConfig")]
    public interface ILambdaCapacityProviderCapacityProviderScalingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lambda_capacity_provider#max_vcpu_count LambdaCapacityProvider#max_vcpu_count}.</summary>
        [JsiiProperty(name: "maxVcpuCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxVcpuCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lambda_capacity_provider#scaling_mode LambdaCapacityProvider#scaling_mode}.</summary>
        [JsiiProperty(name: "scalingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScalingMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lambda_capacity_provider#scaling_policies LambdaCapacityProvider#scaling_policies}.</summary>
        [JsiiProperty(name: "scalingPolicies", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdaCapacityProvider.LambdaCapacityProviderCapacityProviderScalingConfigScalingPolicies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ScalingPolicies
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaCapacityProviderCapacityProviderScalingConfig), fullyQualifiedName: "aws.lambdaCapacityProvider.LambdaCapacityProviderCapacityProviderScalingConfig")]
        internal sealed class _Proxy : DeputyBase, aws.LambdaCapacityProvider.ILambdaCapacityProviderCapacityProviderScalingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lambda_capacity_provider#max_vcpu_count LambdaCapacityProvider#max_vcpu_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxVcpuCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxVcpuCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lambda_capacity_provider#scaling_mode LambdaCapacityProvider#scaling_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scalingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScalingMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lambda_capacity_provider#scaling_policies LambdaCapacityProvider#scaling_policies}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scalingPolicies", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdaCapacityProvider.LambdaCapacityProviderCapacityProviderScalingConfigScalingPolicies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ScalingPolicies
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
