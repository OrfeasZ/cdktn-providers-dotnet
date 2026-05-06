using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentAgentEndpoint
{
    [JsiiClass(nativeType: typeof(oci.GenerativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointGuardrailConfigOutputReference), fullyQualifiedName: "oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointGuardrailConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GenerativeAiAgentAgentEndpointGuardrailConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GenerativeAiAgentAgentEndpointGuardrailConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GenerativeAiAgentAgentEndpointGuardrailConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GenerativeAiAgentAgentEndpointGuardrailConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putContentModerationConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointGuardrailConfigContentModerationConfig\"}}]")]
        public virtual void PutContentModerationConfig(oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointGuardrailConfigContentModerationConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointGuardrailConfigContentModerationConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPersonallyIdentifiableInformationConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointGuardrailConfigPersonallyIdentifiableInformationConfig\"}}]")]
        public virtual void PutPersonallyIdentifiableInformationConfig(oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointGuardrailConfigPersonallyIdentifiableInformationConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointGuardrailConfigPersonallyIdentifiableInformationConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPromptInjectionConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointGuardrailConfigPromptInjectionConfig\"}}]")]
        public virtual void PutPromptInjectionConfig(oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointGuardrailConfigPromptInjectionConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointGuardrailConfigPromptInjectionConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetContentModerationConfig")]
        public virtual void ResetContentModerationConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPersonallyIdentifiableInformationConfig")]
        public virtual void ResetPersonallyIdentifiableInformationConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPromptInjectionConfig")]
        public virtual void ResetPromptInjectionConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "contentModerationConfig", typeJson: "{\"fqn\":\"oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointGuardrailConfigContentModerationConfigOutputReference\"}")]
        public virtual oci.GenerativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointGuardrailConfigContentModerationConfigOutputReference ContentModerationConfig
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointGuardrailConfigContentModerationConfigOutputReference>()!;
        }

        [JsiiProperty(name: "personallyIdentifiableInformationConfig", typeJson: "{\"fqn\":\"oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointGuardrailConfigPersonallyIdentifiableInformationConfigOutputReference\"}")]
        public virtual oci.GenerativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointGuardrailConfigPersonallyIdentifiableInformationConfigOutputReference PersonallyIdentifiableInformationConfig
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointGuardrailConfigPersonallyIdentifiableInformationConfigOutputReference>()!;
        }

        [JsiiProperty(name: "promptInjectionConfig", typeJson: "{\"fqn\":\"oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointGuardrailConfigPromptInjectionConfigOutputReference\"}")]
        public virtual oci.GenerativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointGuardrailConfigPromptInjectionConfigOutputReference PromptInjectionConfig
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointGuardrailConfigPromptInjectionConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentModerationConfigInput", typeJson: "{\"fqn\":\"oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointGuardrailConfigContentModerationConfig\"}", isOptional: true)]
        public virtual oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointGuardrailConfigContentModerationConfig? ContentModerationConfigInput
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointGuardrailConfigContentModerationConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "personallyIdentifiableInformationConfigInput", typeJson: "{\"fqn\":\"oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointGuardrailConfigPersonallyIdentifiableInformationConfig\"}", isOptional: true)]
        public virtual oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointGuardrailConfigPersonallyIdentifiableInformationConfig? PersonallyIdentifiableInformationConfigInput
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointGuardrailConfigPersonallyIdentifiableInformationConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "promptInjectionConfigInput", typeJson: "{\"fqn\":\"oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointGuardrailConfigPromptInjectionConfig\"}", isOptional: true)]
        public virtual oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointGuardrailConfigPromptInjectionConfig? PromptInjectionConfigInput
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointGuardrailConfigPromptInjectionConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointGuardrailConfig\"}", isOptional: true)]
        public virtual oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointGuardrailConfig? InternalValue
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointGuardrailConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
