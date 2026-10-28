using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaFunction
{
    [JsiiInterface(nativeType: typeof(ILambdaFunctionDurableConfig), fullyQualifiedName: "aws.lambdaFunction.LambdaFunctionDurableConfig")]
    public interface ILambdaFunctionDurableConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/lambda_function#execution_timeout LambdaFunction#execution_timeout}.</summary>
        [JsiiProperty(name: "executionTimeout", typeJson: "{\"primitive\":\"number\"}")]
        double ExecutionTimeout
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/lambda_function#kms_key_arn LambdaFunction#kms_key_arn}.</summary>
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/lambda_function#retention_period LambdaFunction#retention_period}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/lambda_function#execution_timeout LambdaFunction#execution_timeout}.</summary>
            [JsiiProperty(name: "executionTimeout", typeJson: "{\"primitive\":\"number\"}")]
            public double ExecutionTimeout
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/lambda_function#kms_key_arn LambdaFunction#kms_key_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/lambda_function#retention_period LambdaFunction#retention_period}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "retentionPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RetentionPeriod
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
