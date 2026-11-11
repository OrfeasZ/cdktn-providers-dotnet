using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdawebFunctionEndpoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lambdawebFunctionEndpoint.LambdawebFunctionEndpointScalingConfig")]
    public class LambdawebFunctionEndpointScalingConfig : aws.LambdawebFunctionEndpoint.ILambdawebFunctionEndpointScalingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/lambdaweb_function_endpoint#max_environments LambdawebFunctionEndpoint#max_environments}.</summary>
        [JsiiProperty(name: "maxEnvironments", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxEnvironments
        {
            get;
            set;
        }
    }
}
