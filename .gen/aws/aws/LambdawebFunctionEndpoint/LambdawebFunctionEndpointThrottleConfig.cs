using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdawebFunctionEndpoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lambdawebFunctionEndpoint.LambdawebFunctionEndpointThrottleConfig")]
    public class LambdawebFunctionEndpointThrottleConfig : aws.LambdawebFunctionEndpoint.ILambdawebFunctionEndpointThrottleConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/lambdaweb_function_endpoint#rate_limit LambdawebFunctionEndpoint#rate_limit}.</summary>
        [JsiiProperty(name: "rateLimit", typeJson: "{\"primitive\":\"number\"}")]
        public double RateLimit
        {
            get;
            set;
        }
    }
}
