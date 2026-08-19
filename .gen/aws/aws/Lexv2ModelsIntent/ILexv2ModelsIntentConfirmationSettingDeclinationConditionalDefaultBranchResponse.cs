using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsIntent
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsIntentConfirmationSettingDeclinationConditionalDefaultBranchResponse), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingDeclinationConditionalDefaultBranchResponse")]
    public interface ILexv2ModelsIntentConfirmationSettingDeclinationConditionalDefaultBranchResponse
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/lexv2models_intent#allow_interrupt Lexv2ModelsIntent#allow_interrupt}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "allowInterrupt", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowInterrupt
        {
            get
            {
                return null;
            }
        }

        /// <summary>message_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/lexv2models_intent#message_group Lexv2ModelsIntent#message_group}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Lexv2ModelsIntent.ILexv2ModelsIntentConfirmationSettingDeclinationConditionalDefaultBranchResponseMessageGroup" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "messageGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingDeclinationConditionalDefaultBranchResponseMessageGroup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MessageGroup
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsIntentConfirmationSettingDeclinationConditionalDefaultBranchResponse), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingDeclinationConditionalDefaultBranchResponse")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsIntent.ILexv2ModelsIntentConfirmationSettingDeclinationConditionalDefaultBranchResponse
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/lexv2models_intent#allow_interrupt Lexv2ModelsIntent#allow_interrupt}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowInterrupt", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AllowInterrupt
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>message_group block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/lexv2models_intent#message_group Lexv2ModelsIntent#message_group}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Lexv2ModelsIntent.ILexv2ModelsIntentConfirmationSettingDeclinationConditionalDefaultBranchResponseMessageGroup" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "messageGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingDeclinationConditionalDefaultBranchResponseMessageGroup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MessageGroup
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
