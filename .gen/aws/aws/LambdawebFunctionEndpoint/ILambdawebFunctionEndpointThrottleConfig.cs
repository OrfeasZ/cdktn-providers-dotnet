using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdawebFunctionEndpoint
{
    [JsiiInterface(nativeType: typeof(ILambdawebFunctionEndpointThrottleConfig), fullyQualifiedName: "aws.lambdawebFunctionEndpoint.LambdawebFunctionEndpointThrottleConfig")]
    public interface ILambdawebFunctionEndpointThrottleConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/lambdaweb_function_endpoint#rate_limit LambdawebFunctionEndpoint#rate_limit}.</summary>
        [JsiiProperty(name: "rateLimit", typeJson: "{\"primitive\":\"number\"}")]
        double RateLimit
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdawebFunctionEndpointThrottleConfig), fullyQualifiedName: "aws.lambdawebFunctionEndpoint.LambdawebFunctionEndpointThrottleConfig")]
        internal sealed class _Proxy : DeputyBase, aws.LambdawebFunctionEndpoint.ILambdawebFunctionEndpointThrottleConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/lambdaweb_function_endpoint#rate_limit LambdawebFunctionEndpoint#rate_limit}.</summary>
            [JsiiProperty(name: "rateLimit", typeJson: "{\"primitive\":\"number\"}")]
            public double RateLimit
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
