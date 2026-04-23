using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaFunction
{
    [JsiiInterface(nativeType: typeof(ILambdaFunctionCapacityProviderConfigLambdaManagedInstancesCapacityProviderConfig), fullyQualifiedName: "aws.lambdaFunction.LambdaFunctionCapacityProviderConfigLambdaManagedInstancesCapacityProviderConfig")]
    public interface ILambdaFunctionCapacityProviderConfigLambdaManagedInstancesCapacityProviderConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lambda_function#capacity_provider_arn LambdaFunction#capacity_provider_arn}.</summary>
        [JsiiProperty(name: "capacityProviderArn", typeJson: "{\"primitive\":\"string\"}")]
        string CapacityProviderArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lambda_function#execution_environment_memory_gib_per_vcpu LambdaFunction#execution_environment_memory_gib_per_vcpu}.</summary>
        [JsiiProperty(name: "executionEnvironmentMemoryGibPerVcpu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ExecutionEnvironmentMemoryGibPerVcpu
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lambda_function#per_execution_environment_max_concurrency LambdaFunction#per_execution_environment_max_concurrency}.</summary>
        [JsiiProperty(name: "perExecutionEnvironmentMaxConcurrency", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PerExecutionEnvironmentMaxConcurrency
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaFunctionCapacityProviderConfigLambdaManagedInstancesCapacityProviderConfig), fullyQualifiedName: "aws.lambdaFunction.LambdaFunctionCapacityProviderConfigLambdaManagedInstancesCapacityProviderConfig")]
        internal sealed class _Proxy : DeputyBase, aws.LambdaFunction.ILambdaFunctionCapacityProviderConfigLambdaManagedInstancesCapacityProviderConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lambda_function#capacity_provider_arn LambdaFunction#capacity_provider_arn}.</summary>
            [JsiiProperty(name: "capacityProviderArn", typeJson: "{\"primitive\":\"string\"}")]
            public string CapacityProviderArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lambda_function#execution_environment_memory_gib_per_vcpu LambdaFunction#execution_environment_memory_gib_per_vcpu}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "executionEnvironmentMemoryGibPerVcpu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ExecutionEnvironmentMemoryGibPerVcpu
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lambda_function#per_execution_environment_max_concurrency LambdaFunction#per_execution_environment_max_concurrency}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "perExecutionEnvironmentMaxConcurrency", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PerExecutionEnvironmentMaxConcurrency
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
