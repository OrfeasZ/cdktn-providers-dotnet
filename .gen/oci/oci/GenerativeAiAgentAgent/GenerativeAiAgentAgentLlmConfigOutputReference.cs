using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentAgent
{
    [JsiiClass(nativeType: typeof(oci.GenerativeAiAgentAgent.GenerativeAiAgentAgentLlmConfigOutputReference), fullyQualifiedName: "oci.generativeAiAgentAgent.GenerativeAiAgentAgentLlmConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GenerativeAiAgentAgentLlmConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GenerativeAiAgentAgentLlmConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GenerativeAiAgentAgentLlmConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GenerativeAiAgentAgentLlmConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRoutingLlmCustomization", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.generativeAiAgentAgent.GenerativeAiAgentAgentLlmConfigRoutingLlmCustomization\"}}]")]
        public virtual void PutRoutingLlmCustomization(oci.GenerativeAiAgentAgent.IGenerativeAiAgentAgentLlmConfigRoutingLlmCustomization @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.GenerativeAiAgentAgent.IGenerativeAiAgentAgentLlmConfigRoutingLlmCustomization)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetRoutingLlmCustomization")]
        public virtual void ResetRoutingLlmCustomization()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "routingLlmCustomization", typeJson: "{\"fqn\":\"oci.generativeAiAgentAgent.GenerativeAiAgentAgentLlmConfigRoutingLlmCustomizationOutputReference\"}")]
        public virtual oci.GenerativeAiAgentAgent.GenerativeAiAgentAgentLlmConfigRoutingLlmCustomizationOutputReference RoutingLlmCustomization
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentAgent.GenerativeAiAgentAgentLlmConfigRoutingLlmCustomizationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "routingLlmCustomizationInput", typeJson: "{\"fqn\":\"oci.generativeAiAgentAgent.GenerativeAiAgentAgentLlmConfigRoutingLlmCustomization\"}", isOptional: true)]
        public virtual oci.GenerativeAiAgentAgent.IGenerativeAiAgentAgentLlmConfigRoutingLlmCustomization? RoutingLlmCustomizationInput
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentAgent.IGenerativeAiAgentAgentLlmConfigRoutingLlmCustomization?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.generativeAiAgentAgent.GenerativeAiAgentAgentLlmConfig\"}", isOptional: true)]
        public virtual oci.GenerativeAiAgentAgent.IGenerativeAiAgentAgentLlmConfig? InternalValue
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentAgent.IGenerativeAiAgentAgentLlmConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
