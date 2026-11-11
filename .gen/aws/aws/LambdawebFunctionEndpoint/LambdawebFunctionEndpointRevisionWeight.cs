using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdawebFunctionEndpoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lambdawebFunctionEndpoint.LambdawebFunctionEndpointRevisionWeight")]
    public class LambdawebFunctionEndpointRevisionWeight : aws.LambdawebFunctionEndpoint.ILambdawebFunctionEndpointRevisionWeight
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/lambdaweb_function_endpoint#revision_id LambdawebFunctionEndpoint#revision_id}.</summary>
        [JsiiProperty(name: "revisionId", typeJson: "{\"primitive\":\"string\"}")]
        public string RevisionId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/lambdaweb_function_endpoint#weight LambdawebFunctionEndpoint#weight}.</summary>
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}")]
        public double Weight
        {
            get;
            set;
        }
    }
}
