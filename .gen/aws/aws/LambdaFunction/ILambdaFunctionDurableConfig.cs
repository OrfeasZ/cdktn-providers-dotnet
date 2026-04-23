using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaFunction
{
    [JsiiInterface(nativeType: typeof(ILambdaFunctionDurableConfig), fullyQualifiedName: "aws.lambdaFunction.LambdaFunctionDurableConfig")]
    public interface ILambdaFunctionDurableConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lambda_function#execution_timeout LambdaFunction#execution_timeout}.</summary>
        [JsiiProperty(name: "executionTimeout", typeJson: "{\"primitive\":\"number\"}")]
        double ExecutionTimeout
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lambda_function#retention_period LambdaFunction#retention_period}.</summary>
        [JsiiProperty(name: "retentionPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RetentionPeriod
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaFunctionDurableConfig), fullyQualifiedName: "aws.lambdaFunction.LambdaFunctionDurableConfig")]
        internal sealed class _Proxy : DeputyBase, aws.LambdaFunction.ILambdaFunctionDurableConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lambda_function#execution_timeout LambdaFunction#execution_timeout}.</summary>
            [JsiiProperty(name: "executionTimeout", typeJson: "{\"primitive\":\"number\"}")]
            public double ExecutionTimeout
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lambda_function#retention_period LambdaFunction#retention_period}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "retentionPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RetentionPeriod
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
