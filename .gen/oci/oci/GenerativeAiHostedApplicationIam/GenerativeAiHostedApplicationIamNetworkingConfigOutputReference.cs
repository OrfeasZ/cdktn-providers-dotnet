using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiHostedApplicationIam
{
    [JsiiClass(nativeType: typeof(oci.GenerativeAiHostedApplicationIam.GenerativeAiHostedApplicationIamNetworkingConfigOutputReference), fullyQualifiedName: "oci.generativeAiHostedApplicationIam.GenerativeAiHostedApplicationIamNetworkingConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GenerativeAiHostedApplicationIamNetworkingConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GenerativeAiHostedApplicationIamNetworkingConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GenerativeAiHostedApplicationIamNetworkingConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GenerativeAiHostedApplicationIamNetworkingConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putInboundNetworkingConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.generativeAiHostedApplicationIam.GenerativeAiHostedApplicationIamNetworkingConfigInboundNetworkingConfig\"}}]")]
        public virtual void PutInboundNetworkingConfig(oci.GenerativeAiHostedApplicationIam.IGenerativeAiHostedApplicationIamNetworkingConfigInboundNetworkingConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.GenerativeAiHostedApplicationIam.IGenerativeAiHostedApplicationIamNetworkingConfigInboundNetworkingConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOutboundNetworkingConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.generativeAiHostedApplicationIam.GenerativeAiHostedApplicationIamNetworkingConfigOutboundNetworkingConfig\"}}]")]
        public virtual void PutOutboundNetworkingConfig(oci.GenerativeAiHostedApplicationIam.IGenerativeAiHostedApplicationIamNetworkingConfigOutboundNetworkingConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.GenerativeAiHostedApplicationIam.IGenerativeAiHostedApplicationIamNetworkingConfigOutboundNetworkingConfig)}, new object[]{@value});
        }

        [JsiiProperty(name: "inboundNetworkingConfig", typeJson: "{\"fqn\":\"oci.generativeAiHostedApplicationIam.GenerativeAiHostedApplicationIamNetworkingConfigInboundNetworkingConfigOutputReference\"}")]
        public virtual oci.GenerativeAiHostedApplicationIam.GenerativeAiHostedApplicationIamNetworkingConfigInboundNetworkingConfigOutputReference InboundNetworkingConfig
        {
            get => GetInstanceProperty<oci.GenerativeAiHostedApplicationIam.GenerativeAiHostedApplicationIamNetworkingConfigInboundNetworkingConfigOutputReference>()!;
        }

        [JsiiProperty(name: "outboundNetworkingConfig", typeJson: "{\"fqn\":\"oci.generativeAiHostedApplicationIam.GenerativeAiHostedApplicationIamNetworkingConfigOutboundNetworkingConfigOutputReference\"}")]
        public virtual oci.GenerativeAiHostedApplicationIam.GenerativeAiHostedApplicationIamNetworkingConfigOutboundNetworkingConfigOutputReference OutboundNetworkingConfig
        {
            get => GetInstanceProperty<oci.GenerativeAiHostedApplicationIam.GenerativeAiHostedApplicationIamNetworkingConfigOutboundNetworkingConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "inboundNetworkingConfigInput", typeJson: "{\"fqn\":\"oci.generativeAiHostedApplicationIam.GenerativeAiHostedApplicationIamNetworkingConfigInboundNetworkingConfig\"}", isOptional: true)]
        public virtual oci.GenerativeAiHostedApplicationIam.IGenerativeAiHostedApplicationIamNetworkingConfigInboundNetworkingConfig? InboundNetworkingConfigInput
        {
            get => GetInstanceProperty<oci.GenerativeAiHostedApplicationIam.IGenerativeAiHostedApplicationIamNetworkingConfigInboundNetworkingConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outboundNetworkingConfigInput", typeJson: "{\"fqn\":\"oci.generativeAiHostedApplicationIam.GenerativeAiHostedApplicationIamNetworkingConfigOutboundNetworkingConfig\"}", isOptional: true)]
        public virtual oci.GenerativeAiHostedApplicationIam.IGenerativeAiHostedApplicationIamNetworkingConfigOutboundNetworkingConfig? OutboundNetworkingConfigInput
        {
            get => GetInstanceProperty<oci.GenerativeAiHostedApplicationIam.IGenerativeAiHostedApplicationIamNetworkingConfigOutboundNetworkingConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.generativeAiHostedApplicationIam.GenerativeAiHostedApplicationIamNetworkingConfig\"}", isOptional: true)]
        public virtual oci.GenerativeAiHostedApplicationIam.IGenerativeAiHostedApplicationIamNetworkingConfig? InternalValue
        {
            get => GetInstanceProperty<oci.GenerativeAiHostedApplicationIam.IGenerativeAiHostedApplicationIamNetworkingConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
