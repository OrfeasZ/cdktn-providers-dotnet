using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaFunctionScalingConfig
{
    [JsiiInterface(nativeType: typeof(ILambdaFunctionScalingConfigFunctionScalingConfig), fullyQualifiedName: "aws.lambdaFunctionScalingConfig.LambdaFunctionScalingConfigFunctionScalingConfig")]
    public interface ILambdaFunctionScalingConfigFunctionScalingConfig
    {
        /// <summary>Maximum number of execution environments that can be provisioned for the function.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/lambda_function_scaling_config#max_execution_environments LambdaFunctionScalingConfig#max_execution_environments}
        /// </remarks>
        [JsiiProperty(name: "maxExecutionEnvironments", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxExecutionEnvironments
        {
            get
            {
                return null;
            }
        }

        /// <summary>Minimum number of execution environments to maintain for the function.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/lambda_function_scaling_config#min_execution_environments LambdaFunctionScalingConfig#min_execution_environments}
        /// </remarks>
        [JsiiProperty(name: "minExecutionEnvironments", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinExecutionEnvironments
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaFunctionScalingConfigFunctionScalingConfig), fullyQualifiedName: "aws.lambdaFunctionScalingConfig.LambdaFunctionScalingConfigFunctionScalingConfig")]
        internal sealed class _Proxy : DeputyBase, aws.LambdaFunctionScalingConfig.ILambdaFunctionScalingConfigFunctionScalingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Maximum number of execution environments that can be provisioned for the function.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/lambda_function_scaling_config#max_execution_environments LambdaFunctionScalingConfig#max_execution_environments}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxExecutionEnvironments", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxExecutionEnvironments
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Minimum number of execution environments to maintain for the function.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/lambda_function_scaling_config#min_execution_environments LambdaFunctionScalingConfig#min_execution_environments}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "minExecutionEnvironments", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinExecutionEnvironments
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
