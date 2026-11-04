using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdawebFunctionRevision
{
    [JsiiInterface(nativeType: typeof(ILambdawebFunctionRevisionBuildConfig), fullyQualifiedName: "aws.lambdawebFunctionRevision.LambdawebFunctionRevisionBuildConfig")]
    public interface ILambdawebFunctionRevisionBuildConfig
    {
        /// <summary>code_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/lambdaweb_function_revision#code_config LambdawebFunctionRevision#code_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.LambdawebFunctionRevision.ILambdawebFunctionRevisionBuildConfigCodeConfig" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "codeConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdawebFunctionRevision.LambdawebFunctionRevisionBuildConfigCodeConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CodeConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>runtime_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/lambdaweb_function_revision#runtime_config LambdawebFunctionRevision#runtime_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.LambdawebFunctionRevision.ILambdawebFunctionRevisionBuildConfigRuntimeConfig" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "runtimeConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdawebFunctionRevision.LambdawebFunctionRevisionBuildConfigRuntimeConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RuntimeConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdawebFunctionRevisionBuildConfig), fullyQualifiedName: "aws.lambdawebFunctionRevision.LambdawebFunctionRevisionBuildConfig")]
        internal sealed class _Proxy : DeputyBase, aws.LambdawebFunctionRevision.ILambdawebFunctionRevisionBuildConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>code_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/lambdaweb_function_revision#code_config LambdawebFunctionRevision#code_config}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.LambdawebFunctionRevision.ILambdawebFunctionRevisionBuildConfigCodeConfig" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "codeConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdawebFunctionRevision.LambdawebFunctionRevisionBuildConfigCodeConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CodeConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>runtime_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/lambdaweb_function_revision#runtime_config LambdawebFunctionRevision#runtime_config}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.LambdawebFunctionRevision.ILambdawebFunctionRevisionBuildConfigRuntimeConfig" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "runtimeConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdawebFunctionRevision.LambdawebFunctionRevisionBuildConfigRuntimeConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RuntimeConfig
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
