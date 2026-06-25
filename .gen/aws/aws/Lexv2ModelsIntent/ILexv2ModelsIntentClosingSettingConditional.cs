using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsIntent
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsIntentClosingSettingConditional), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentClosingSettingConditional")]
    public interface ILexv2ModelsIntentClosingSettingConditional
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/lexv2models_intent#active Lexv2ModelsIntent#active}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "active", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Active
        {
            get;
        }

        /// <summary>conditional_branch block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/lexv2models_intent#conditional_branch Lexv2ModelsIntent#conditional_branch}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Lexv2ModelsIntent.ILexv2ModelsIntentClosingSettingConditionalConditionalBranch" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "conditionalBranch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentClosingSettingConditionalConditionalBranch\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ConditionalBranch
        {
            get
            {
                return null;
            }
        }

        /// <summary>default_branch block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/lexv2models_intent#default_branch Lexv2ModelsIntent#default_branch}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Lexv2ModelsIntent.ILexv2ModelsIntentClosingSettingConditionalDefaultBranch" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "defaultBranch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentClosingSettingConditionalDefaultBranch\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DefaultBranch
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsIntentClosingSettingConditional), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentClosingSettingConditional")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsIntent.ILexv2ModelsIntentClosingSettingConditional
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/lexv2models_intent#active Lexv2ModelsIntent#active}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "active", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Active
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>conditional_branch block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/lexv2models_intent#conditional_branch Lexv2ModelsIntent#conditional_branch}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Lexv2ModelsIntent.ILexv2ModelsIntentClosingSettingConditionalConditionalBranch" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "conditionalBranch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentClosingSettingConditionalConditionalBranch\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ConditionalBranch
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>default_branch block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/lexv2models_intent#default_branch Lexv2ModelsIntent#default_branch}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Lexv2ModelsIntent.ILexv2ModelsIntentClosingSettingConditionalDefaultBranch" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultBranch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentClosingSettingConditionalDefaultBranch\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DefaultBranch
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
