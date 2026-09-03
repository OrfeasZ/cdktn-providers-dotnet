using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsSlot
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsSlotValueElicitationSettingWaitAndContinueSpecificationStillWaitingResponseMessageGroupMessage), fullyQualifiedName: "aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingWaitAndContinueSpecificationStillWaitingResponseMessageGroupMessage")]
    public interface ILexv2ModelsSlotValueElicitationSettingWaitAndContinueSpecificationStillWaitingResponseMessageGroupMessage
    {
        /// <summary>custom_payload block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lexv2models_slot#custom_payload Lexv2ModelsSlot#custom_payload}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Lexv2ModelsSlot.ILexv2ModelsSlotValueElicitationSettingWaitAndContinueSpecificationStillWaitingResponseMessageGroupMessageCustomPayload" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "customPayload", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingWaitAndContinueSpecificationStillWaitingResponseMessageGroupMessageCustomPayload\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomPayload
        {
            get
            {
                return null;
            }
        }

        /// <summary>image_response_card block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lexv2models_slot#image_response_card Lexv2ModelsSlot#image_response_card}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Lexv2ModelsSlot.ILexv2ModelsSlotValueElicitationSettingWaitAndContinueSpecificationStillWaitingResponseMessageGroupMessageImageResponseCard" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "imageResponseCard", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingWaitAndContinueSpecificationStillWaitingResponseMessageGroupMessageImageResponseCard\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ImageResponseCard
        {
            get
            {
                return null;
            }
        }

        /// <summary>plain_text_message block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lexv2models_slot#plain_text_message Lexv2ModelsSlot#plain_text_message}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Lexv2ModelsSlot.ILexv2ModelsSlotValueElicitationSettingWaitAndContinueSpecificationStillWaitingResponseMessageGroupMessagePlainTextMessage" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "plainTextMessage", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingWaitAndContinueSpecificationStillWaitingResponseMessageGroupMessagePlainTextMessage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PlainTextMessage
        {
            get
            {
                return null;
            }
        }

        /// <summary>ssml_message block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lexv2models_slot#ssml_message Lexv2ModelsSlot#ssml_message}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Lexv2ModelsSlot.ILexv2ModelsSlotValueElicitationSettingWaitAndContinueSpecificationStillWaitingResponseMessageGroupMessageSsmlMessage" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "ssmlMessage", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingWaitAndContinueSpecificationStillWaitingResponseMessageGroupMessageSsmlMessage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SsmlMessage
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsSlotValueElicitationSettingWaitAndContinueSpecificationStillWaitingResponseMessageGroupMessage), fullyQualifiedName: "aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingWaitAndContinueSpecificationStillWaitingResponseMessageGroupMessage")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsSlot.ILexv2ModelsSlotValueElicitationSettingWaitAndContinueSpecificationStillWaitingResponseMessageGroupMessage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>custom_payload block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lexv2models_slot#custom_payload Lexv2ModelsSlot#custom_payload}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Lexv2ModelsSlot.ILexv2ModelsSlotValueElicitationSettingWaitAndContinueSpecificationStillWaitingResponseMessageGroupMessageCustomPayload" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customPayload", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingWaitAndContinueSpecificationStillWaitingResponseMessageGroupMessageCustomPayload\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomPayload
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>image_response_card block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lexv2models_slot#image_response_card Lexv2ModelsSlot#image_response_card}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Lexv2ModelsSlot.ILexv2ModelsSlotValueElicitationSettingWaitAndContinueSpecificationStillWaitingResponseMessageGroupMessageImageResponseCard" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "imageResponseCard", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingWaitAndContinueSpecificationStillWaitingResponseMessageGroupMessageImageResponseCard\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ImageResponseCard
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>plain_text_message block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lexv2models_slot#plain_text_message Lexv2ModelsSlot#plain_text_message}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Lexv2ModelsSlot.ILexv2ModelsSlotValueElicitationSettingWaitAndContinueSpecificationStillWaitingResponseMessageGroupMessagePlainTextMessage" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "plainTextMessage", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingWaitAndContinueSpecificationStillWaitingResponseMessageGroupMessagePlainTextMessage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PlainTextMessage
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ssml_message block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lexv2models_slot#ssml_message Lexv2ModelsSlot#ssml_message}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Lexv2ModelsSlot.ILexv2ModelsSlotValueElicitationSettingWaitAndContinueSpecificationStillWaitingResponseMessageGroupMessageSsmlMessage" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ssmlMessage", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingWaitAndContinueSpecificationStillWaitingResponseMessageGroupMessageSsmlMessage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SsmlMessage
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
