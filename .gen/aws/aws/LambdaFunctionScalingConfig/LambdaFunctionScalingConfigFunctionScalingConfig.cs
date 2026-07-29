using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaFunctionScalingConfig
{
    [JsiiByValue(fqn: "aws.lambdaFunctionScalingConfig.LambdaFunctionScalingConfigFunctionScalingConfig")]
    public class LambdaFunctionScalingConfigFunctionScalingConfig : aws.LambdaFunctionScalingConfig.ILambdaFunctionScalingConfigFunctionScalingConfig
    {
        /// <summary>Maximum number of execution environments that can be provisioned for the function.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/lambda_function_scaling_config#max_execution_environments LambdaFunctionScalingConfig#max_execution_environments}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maxExecutionEnvironments", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxExecutionEnvironments
        {
            get;
            set;
        }

        /// <summary>Minimum number of execution environments to maintain for the function.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/lambda_function_scaling_config#min_execution_environments LambdaFunctionScalingConfig#min_execution_environments}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "minExecutionEnvironments", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinExecutionEnvironments
        {
            get;
            set;
        }
    }
}
