using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentAgentEndpoint
{
    [JsiiClass(nativeType: typeof(oci.GenerativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointGuardrailConfigPersonallyIdentifiableInformationConfigOutputReference), fullyQualifiedName: "oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointGuardrailConfigPersonallyIdentifiableInformationConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GenerativeAiAgentAgentEndpointGuardrailConfigPersonallyIdentifiableInformationConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GenerativeAiAgentAgentEndpointGuardrailConfigPersonallyIdentifiableInformationConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GenerativeAiAgentAgentEndpointGuardrailConfigPersonallyIdentifiableInformationConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GenerativeAiAgentAgentEndpointGuardrailConfigPersonallyIdentifiableInformationConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetInputGuardrailMode")]
        public virtual void ResetInputGuardrailMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutputGuardrailMode")]
        public virtual void ResetOutputGuardrailMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputGuardrailModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InputGuardrailModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputGuardrailModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OutputGuardrailModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "inputGuardrailMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InputGuardrailMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "outputGuardrailMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutputGuardrailMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointGuardrailConfigPersonallyIdentifiableInformationConfig\"}", isOptional: true)]
        public virtual oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointGuardrailConfigPersonallyIdentifiableInformationConfig? InternalValue
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointGuardrailConfigPersonallyIdentifiableInformationConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
