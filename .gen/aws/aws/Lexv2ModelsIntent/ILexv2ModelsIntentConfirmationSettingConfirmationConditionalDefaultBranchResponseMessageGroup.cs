using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsIntent
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsIntentConfirmationSettingConfirmationConditionalDefaultBranchResponseMessageGroup), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingConfirmationConditionalDefaultBranchResponseMessageGroup")]
    public interface ILexv2ModelsIntentConfirmationSettingConfirmationConditionalDefaultBranchResponseMessageGroup
    {
        /// <summary>message block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/lexv2models_intent#message Lexv2ModelsIntent#message}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Lexv2ModelsIntent.ILexv2ModelsIntentConfirmationSettingConfirmationConditionalDefaultBranchResponseMessageGroupMessage" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "message", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingConfirmationConditionalDefaultBranchResponseMessageGroupMessage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Message
        {
            get
            {
                return null;
            }
        }

        /// <summary>variation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/lexv2models_intent#variation Lexv2ModelsIntent#variation}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Lexv2ModelsIntent.ILexv2ModelsIntentConfirmationSettingConfirmationConditionalDefaultBranchResponseMessageGroupVariation" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "variation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingConfirmationConditionalDefaultBranchResponseMessageGroupVariation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Variation
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsIntentConfirmationSettingConfirmationConditionalDefaultBranchResponseMessageGroup), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingConfirmationConditionalDefaultBranchResponseMessageGroup")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsIntent.ILexv2ModelsIntentConfirmationSettingConfirmationConditionalDefaultBranchResponseMessageGroup
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>message block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/lexv2models_intent#message Lexv2ModelsIntent#message}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Lexv2ModelsIntent.ILexv2ModelsIntentConfirmationSettingConfirmationConditionalDefaultBranchResponseMessageGroupMessage" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "message", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingConfirmationConditionalDefaultBranchResponseMessageGroupMessage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Message
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>variation block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/lexv2models_intent#variation Lexv2ModelsIntent#variation}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Lexv2ModelsIntent.ILexv2ModelsIntentConfirmationSettingConfirmationConditionalDefaultBranchResponseMessageGroupVariation" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "variation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingConfirmationConditionalDefaultBranchResponseMessageGroupVariation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Variation
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
