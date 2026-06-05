using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaAlias
{
    [JsiiByValue(fqn: "aws.lambdaAlias.LambdaAliasTimeouts")]
    public class LambdaAliasTimeouts : aws.LambdaAlias.ILambdaAliasTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.49.0/docs/resources/lambda_alias#update LambdaAlias#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
