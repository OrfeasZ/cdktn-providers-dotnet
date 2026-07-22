using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiHostedApplication
{
    [JsiiClass(nativeType: typeof(oci.GenerativeAiHostedApplication.GenerativeAiHostedApplicationNetworkingConfigOutputReference), fullyQualifiedName: "oci.generativeAiHostedApplication.GenerativeAiHostedApplicationNetworkingConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GenerativeAiHostedApplicationNetworkingConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GenerativeAiHostedApplicationNetworkingConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GenerativeAiHostedApplicationNetworkingConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GenerativeAiHostedApplicationNetworkingConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putInboundNetworkingConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.generativeAiHostedApplication.GenerativeAiHostedApplicationNetworkingConfigInboundNetworkingConfig\"}}]")]
        public virtual void PutInboundNetworkingConfig(oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationNetworkingConfigInboundNetworkingConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationNetworkingConfigInboundNetworkingConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOutboundNetworkingConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.generativeAiHostedApplication.GenerativeAiHostedApplicationNetworkingConfigOutboundNetworkingConfig\"}}]")]
        public virtual void PutOutboundNetworkingConfig(oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationNetworkingConfigOutboundNetworkingConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationNetworkingConfigOutboundNetworkingConfig)}, new object[]{@value});
        }

        [JsiiProperty(name: "inboundNetworkingConfig", typeJson: "{\"fqn\":\"oci.generativeAiHostedApplication.GenerativeAiHostedApplicationNetworkingConfigInboundNetworkingConfigOutputReference\"}")]
        public virtual oci.GenerativeAiHostedApplication.GenerativeAiHostedApplicationNetworkingConfigInboundNetworkingConfigOutputReference InboundNetworkingConfig
        {
            get => GetInstanceProperty<oci.GenerativeAiHostedApplication.GenerativeAiHostedApplicationNetworkingConfigInboundNetworkingConfigOutputReference>()!;
        }

        [JsiiProperty(name: "outboundNetworkingConfig", typeJson: "{\"fqn\":\"oci.generativeAiHostedApplication.GenerativeAiHostedApplicationNetworkingConfigOutboundNetworkingConfigOutputReference\"}")]
        public virtual oci.GenerativeAiHostedApplication.GenerativeAiHostedApplicationNetworkingConfigOutboundNetworkingConfigOutputReference OutboundNetworkingConfig
        {
            get => GetInstanceProperty<oci.GenerativeAiHostedApplication.GenerativeAiHostedApplicationNetworkingConfigOutboundNetworkingConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "inboundNetworkingConfigInput", typeJson: "{\"fqn\":\"oci.generativeAiHostedApplication.GenerativeAiHostedApplicationNetworkingConfigInboundNetworkingConfig\"}", isOptional: true)]
        public virtual oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationNetworkingConfigInboundNetworkingConfig? InboundNetworkingConfigInput
        {
            get => GetInstanceProperty<oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationNetworkingConfigInboundNetworkingConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outboundNetworkingConfigInput", typeJson: "{\"fqn\":\"oci.generativeAiHostedApplication.GenerativeAiHostedApplicationNetworkingConfigOutboundNetworkingConfig\"}", isOptional: true)]
        public virtual oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationNetworkingConfigOutboundNetworkingConfig? OutboundNetworkingConfigInput
        {
            get => GetInstanceProperty<oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationNetworkingConfigOutboundNetworkingConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.generativeAiHostedApplication.GenerativeAiHostedApplicationNetworkingConfig\"}", isOptional: true)]
        public virtual oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationNetworkingConfig? InternalValue
        {
            get => GetInstanceProperty<oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationNetworkingConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
