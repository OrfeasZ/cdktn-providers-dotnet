using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentAgentEndpoint
{
    [JsiiClass(nativeType: typeof(oci.GenerativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointOutputConfigOutputReference), fullyQualifiedName: "oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointOutputConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GenerativeAiAgentAgentEndpointOutputConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GenerativeAiAgentAgentEndpointOutputConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GenerativeAiAgentAgentEndpointOutputConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GenerativeAiAgentAgentEndpointOutputConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putOutputLocation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointOutputConfigOutputLocation\"}}]")]
        public virtual void PutOutputLocation(oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointOutputConfigOutputLocation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointOutputConfigOutputLocation)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetRetentionPeriodInMinutes")]
        public virtual void ResetRetentionPeriodInMinutes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "outputLocation", typeJson: "{\"fqn\":\"oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointOutputConfigOutputLocationOutputReference\"}")]
        public virtual oci.GenerativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointOutputConfigOutputLocationOutputReference OutputLocation
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointOutputConfigOutputLocationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputLocationInput", typeJson: "{\"fqn\":\"oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointOutputConfigOutputLocation\"}", isOptional: true)]
        public virtual oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointOutputConfigOutputLocation? OutputLocationInput
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointOutputConfigOutputLocation?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retentionPeriodInMinutesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RetentionPeriodInMinutesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "retentionPeriodInMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RetentionPeriodInMinutes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointOutputConfig\"}", isOptional: true)]
        public virtual oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointOutputConfig? InternalValue
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointOutputConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
