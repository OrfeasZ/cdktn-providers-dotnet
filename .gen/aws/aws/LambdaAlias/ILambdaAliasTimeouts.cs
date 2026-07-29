using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaAlias
{
    [JsiiInterface(nativeType: typeof(ILambdaAliasTimeouts), fullyQualifiedName: "aws.lambdaAlias.LambdaAliasTimeouts")]
    public interface ILambdaAliasTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/lambda_alias#update LambdaAlias#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaAliasTimeouts), fullyQualifiedName: "aws.lambdaAlias.LambdaAliasTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.LambdaAlias.ILambdaAliasTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/lambda_alias#update LambdaAlias#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
