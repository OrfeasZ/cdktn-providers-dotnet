using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaFunction
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lambdaFunction.LambdaFunctionDurableConfig")]
    public class LambdaFunctionDurableConfig : aws.LambdaFunction.ILambdaFunctionDurableConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lambda_function#execution_timeout LambdaFunction#execution_timeout}.</summary>
        [JsiiProperty(name: "executionTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public double ExecutionTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lambda_function#retention_period LambdaFunction#retention_period}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retentionPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RetentionPeriod
        {
            get;
            set;
        }
    }
}
