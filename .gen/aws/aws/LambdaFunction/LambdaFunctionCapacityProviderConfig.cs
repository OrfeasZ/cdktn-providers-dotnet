using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaFunction
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lambdaFunction.LambdaFunctionCapacityProviderConfig")]
    public class LambdaFunctionCapacityProviderConfig : aws.LambdaFunction.ILambdaFunctionCapacityProviderConfig
    {
        /// <summary>lambda_managed_instances_capacity_provider_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lambda_function#lambda_managed_instances_capacity_provider_config LambdaFunction#lambda_managed_instances_capacity_provider_config}
        /// </remarks>
        [JsiiProperty(name: "lambdaManagedInstancesCapacityProviderConfig", typeJson: "{\"fqn\":\"aws.lambdaFunction.LambdaFunctionCapacityProviderConfigLambdaManagedInstancesCapacityProviderConfig\"}")]
        public aws.LambdaFunction.ILambdaFunctionCapacityProviderConfigLambdaManagedInstancesCapacityProviderConfig LambdaManagedInstancesCapacityProviderConfig
        {
            get;
            set;
        }
    }
}
