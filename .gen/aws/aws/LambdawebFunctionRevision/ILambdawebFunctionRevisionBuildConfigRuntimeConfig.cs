using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdawebFunctionRevision
{
    [JsiiInterface(nativeType: typeof(ILambdawebFunctionRevisionBuildConfigRuntimeConfig), fullyQualifiedName: "aws.lambdawebFunctionRevision.LambdawebFunctionRevisionBuildConfigRuntimeConfig")]
    public interface ILambdawebFunctionRevisionBuildConfigRuntimeConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/lambdaweb_function_revision#runtime LambdawebFunctionRevision#runtime}.</summary>
        [JsiiProperty(name: "runtime", typeJson: "{\"primitive\":\"string\"}")]
        string Runtime
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdawebFunctionRevisionBuildConfigRuntimeConfig), fullyQualifiedName: "aws.lambdawebFunctionRevision.LambdawebFunctionRevisionBuildConfigRuntimeConfig")]
        internal sealed class _Proxy : DeputyBase, aws.LambdawebFunctionRevision.ILambdawebFunctionRevisionBuildConfigRuntimeConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/lambdaweb_function_revision#runtime LambdawebFunctionRevision#runtime}.</summary>
            [JsiiProperty(name: "runtime", typeJson: "{\"primitive\":\"string\"}")]
            public string Runtime
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
