using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaFunction
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lambdaFunction.LambdaFunctionCapacityProviderConfigLambdaManagedInstancesCapacityProviderConfig")]
    public class LambdaFunctionCapacityProviderConfigLambdaManagedInstancesCapacityProviderConfig : aws.LambdaFunction.ILambdaFunctionCapacityProviderConfigLambdaManagedInstancesCapacityProviderConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lambda_function#capacity_provider_arn LambdaFunction#capacity_provider_arn}.</summary>
        [JsiiProperty(name: "capacityProviderArn", typeJson: "{\"primitive\":\"string\"}")]
        public string CapacityProviderArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lambda_function#execution_environment_memory_gib_per_vcpu LambdaFunction#execution_environment_memory_gib_per_vcpu}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "executionEnvironmentMemoryGibPerVcpu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ExecutionEnvironmentMemoryGibPerVcpu
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lambda_function#per_execution_environment_max_concurrency LambdaFunction#per_execution_environment_max_concurrency}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "perExecutionEnvironmentMaxConcurrency", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PerExecutionEnvironmentMaxConcurrency
        {
            get;
            set;
        }
    }
}
