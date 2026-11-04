using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdawebFunctionEndpoint
{
    [JsiiInterface(nativeType: typeof(ILambdawebFunctionEndpointRevisionWeight), fullyQualifiedName: "aws.lambdawebFunctionEndpoint.LambdawebFunctionEndpointRevisionWeight")]
    public interface ILambdawebFunctionEndpointRevisionWeight
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/lambdaweb_function_endpoint#revision_id LambdawebFunctionEndpoint#revision_id}.</summary>
        [JsiiProperty(name: "revisionId", typeJson: "{\"primitive\":\"string\"}")]
        string RevisionId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/lambdaweb_function_endpoint#weight LambdawebFunctionEndpoint#weight}.</summary>
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}")]
        double Weight
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdawebFunctionEndpointRevisionWeight), fullyQualifiedName: "aws.lambdawebFunctionEndpoint.LambdawebFunctionEndpointRevisionWeight")]
        internal sealed class _Proxy : DeputyBase, aws.LambdawebFunctionEndpoint.ILambdawebFunctionEndpointRevisionWeight
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/lambdaweb_function_endpoint#revision_id LambdawebFunctionEndpoint#revision_id}.</summary>
            [JsiiProperty(name: "revisionId", typeJson: "{\"primitive\":\"string\"}")]
            public string RevisionId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/lambdaweb_function_endpoint#weight LambdawebFunctionEndpoint#weight}.</summary>
            [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}")]
            public double Weight
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
