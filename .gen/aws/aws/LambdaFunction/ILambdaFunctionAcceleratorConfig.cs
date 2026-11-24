using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaFunction
{
    [JsiiInterface(nativeType: typeof(ILambdaFunctionAcceleratorConfig), fullyQualifiedName: "aws.lambdaFunction.LambdaFunctionAcceleratorConfig")]
    public interface ILambdaFunctionAcceleratorConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/lambda_function#accelerator_memory_size LambdaFunction#accelerator_memory_size}.</summary>
        [JsiiProperty(name: "acceleratorMemorySize", typeJson: "{\"primitive\":\"number\"}")]
        double AcceleratorMemorySize
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaFunctionAcceleratorConfig), fullyQualifiedName: "aws.lambdaFunction.LambdaFunctionAcceleratorConfig")]
        internal sealed class _Proxy : DeputyBase, aws.LambdaFunction.ILambdaFunctionAcceleratorConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/lambda_function#accelerator_memory_size LambdaFunction#accelerator_memory_size}.</summary>
            [JsiiProperty(name: "acceleratorMemorySize", typeJson: "{\"primitive\":\"number\"}")]
            public double AcceleratorMemorySize
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
