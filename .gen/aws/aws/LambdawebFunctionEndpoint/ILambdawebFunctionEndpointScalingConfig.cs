using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdawebFunctionEndpoint
{
    [JsiiInterface(nativeType: typeof(ILambdawebFunctionEndpointScalingConfig), fullyQualifiedName: "aws.lambdawebFunctionEndpoint.LambdawebFunctionEndpointScalingConfig")]
    public interface ILambdawebFunctionEndpointScalingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/lambdaweb_function_endpoint#max_environments LambdawebFunctionEndpoint#max_environments}.</summary>
        [JsiiProperty(name: "maxEnvironments", typeJson: "{\"primitive\":\"number\"}")]
        double MaxEnvironments
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdawebFunctionEndpointScalingConfig), fullyQualifiedName: "aws.lambdawebFunctionEndpoint.LambdawebFunctionEndpointScalingConfig")]
        internal sealed class _Proxy : DeputyBase, aws.LambdawebFunctionEndpoint.ILambdawebFunctionEndpointScalingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/lambdaweb_function_endpoint#max_environments LambdawebFunctionEndpoint#max_environments}.</summary>
            [JsiiProperty(name: "maxEnvironments", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxEnvironments
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
