using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaFunction
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lambdaFunction.LambdaFunctionAcceleratorConfig")]
    public class LambdaFunctionAcceleratorConfig : aws.LambdaFunction.ILambdaFunctionAcceleratorConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/lambda_function#accelerator_memory_size LambdaFunction#accelerator_memory_size}.</summary>
        [JsiiProperty(name: "acceleratorMemorySize", typeJson: "{\"primitive\":\"number\"}")]
        public double AcceleratorMemorySize
        {
            get;
            set;
        }
    }
}
