using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsSlot
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsSlotValueElicitationSettingWaitAndContinueSpecificationStillWaitingResponse), fullyQualifiedName: "aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingWaitAndContinueSpecificationStillWaitingResponse")]
    public interface ILexv2ModelsSlotValueElicitationSettingWaitAndContinueSpecificationStillWaitingResponse
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/lexv2models_slot#frequency_in_seconds Lexv2ModelsSlot#frequency_in_seconds}.</summary>
        [JsiiProperty(name: "frequencyInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        double FrequencyInSeconds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/lexv2models_slot#timeout_in_seconds Lexv2ModelsSlot#timeout_in_seconds}.</summary>
        [JsiiProperty(name: "timeoutInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        double TimeoutInSeconds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/lexv2models_slot#allow_interrupt Lexv2ModelsSlot#allow_interrupt}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/lexv2models_slot#message_group Lexv2ModelsSlot#message_group}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Lexv2ModelsSlot.ILexv2ModelsSlotValueElicitationSettingWaitAndContinueSpecificationStillWaitingResponseMessageGroup" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "messageGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingWaitAndContinueSpecificationStillWaitingResponseMessageGroup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MessageGroup
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsSlotValueElicitationSettingWaitAndContinueSpecificationStillWaitingResponse), fullyQualifiedName: "aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingWaitAndContinueSpecificationStillWaitingResponse")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsSlot.ILexv2ModelsSlotValueElicitationSettingWaitAndContinueSpecificationStillWaitingResponse
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/lexv2models_slot#frequency_in_seconds Lexv2ModelsSlot#frequency_in_seconds}.</summary>
            [JsiiProperty(name: "frequencyInSeconds", typeJson: "{\"primitive\":\"number\"}")]
            public double FrequencyInSeconds
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/lexv2models_slot#timeout_in_seconds Lexv2ModelsSlot#timeout_in_seconds}.</summary>
            [JsiiProperty(name: "timeoutInSeconds", typeJson: "{\"primitive\":\"number\"}")]
            public double TimeoutInSeconds
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/lexv2models_slot#allow_interrupt Lexv2ModelsSlot#allow_interrupt}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/lexv2models_slot#message_group Lexv2ModelsSlot#message_group}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Lexv2ModelsSlot.ILexv2ModelsSlotValueElicitationSettingWaitAndContinueSpecificationStillWaitingResponseMessageGroup" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "messageGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingWaitAndContinueSpecificationStillWaitingResponseMessageGroup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MessageGroup
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
