using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaFunction
{
    [JsiiInterface(nativeType: typeof(ILambdaFunctionCapacityProviderConfig), fullyQualifiedName: "aws.lambdaFunction.LambdaFunctionCapacityProviderConfig")]
    public interface ILambdaFunctionCapacityProviderConfig
    {
        /// <summary>lambda_managed_instances_capacity_provider_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lambda_function#lambda_managed_instances_capacity_provider_config LambdaFunction#lambda_managed_instances_capacity_provider_config}
        /// </remarks>
        [JsiiProperty(name: "lambdaManagedInstancesCapacityProviderConfig", typeJson: "{\"fqn\":\"aws.lambdaFunction.LambdaFunctionCapacityProviderConfigLambdaManagedInstancesCapacityProviderConfig\"}")]
        aws.LambdaFunction.ILambdaFunctionCapacityProviderConfigLambdaManagedInstancesCapacityProviderConfig LambdaManagedInstancesCapacityProviderConfig
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaFunctionCapacityProviderConfig), fullyQualifiedName: "aws.lambdaFunction.LambdaFunctionCapacityProviderConfig")]
        internal sealed class _Proxy : DeputyBase, aws.LambdaFunction.ILambdaFunctionCapacityProviderConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>lambda_managed_instances_capacity_provider_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lambda_function#lambda_managed_instances_capacity_provider_config LambdaFunction#lambda_managed_instances_capacity_provider_config}
            /// </remarks>
            [JsiiProperty(name: "lambdaManagedInstancesCapacityProviderConfig", typeJson: "{\"fqn\":\"aws.lambdaFunction.LambdaFunctionCapacityProviderConfigLambdaManagedInstancesCapacityProviderConfig\"}")]
            public aws.LambdaFunction.ILambdaFunctionCapacityProviderConfigLambdaManagedInstancesCapacityProviderConfig LambdaManagedInstancesCapacityProviderConfig
            {
                get => GetInstanceProperty<aws.LambdaFunction.ILambdaFunctionCapacityProviderConfigLambdaManagedInstancesCapacityProviderConfig>()!;
            }
        }
    }
}
