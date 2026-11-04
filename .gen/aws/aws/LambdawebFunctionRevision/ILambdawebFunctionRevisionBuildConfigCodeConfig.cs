using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdawebFunctionRevision
{
    [JsiiInterface(nativeType: typeof(ILambdawebFunctionRevisionBuildConfigCodeConfig), fullyQualifiedName: "aws.lambdawebFunctionRevision.LambdawebFunctionRevisionBuildConfigCodeConfig")]
    public interface ILambdawebFunctionRevisionBuildConfigCodeConfig
    {
        /// <summary>s3_object block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/lambdaweb_function_revision#s3_object LambdawebFunctionRevision#s3_object}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.LambdawebFunctionRevision.ILambdawebFunctionRevisionBuildConfigCodeConfigS3Object" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "s3Object", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdawebFunctionRevision.LambdawebFunctionRevisionBuildConfigCodeConfigS3Object\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? S3Object
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdawebFunctionRevisionBuildConfigCodeConfig), fullyQualifiedName: "aws.lambdawebFunctionRevision.LambdawebFunctionRevisionBuildConfigCodeConfig")]
        internal sealed class _Proxy : DeputyBase, aws.LambdawebFunctionRevision.ILambdawebFunctionRevisionBuildConfigCodeConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>s3_object block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/lambdaweb_function_revision#s3_object LambdawebFunctionRevision#s3_object}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.LambdawebFunctionRevision.ILambdawebFunctionRevisionBuildConfigCodeConfigS3Object" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3Object", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdawebFunctionRevision.LambdawebFunctionRevisionBuildConfigCodeConfigS3Object\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? S3Object
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
