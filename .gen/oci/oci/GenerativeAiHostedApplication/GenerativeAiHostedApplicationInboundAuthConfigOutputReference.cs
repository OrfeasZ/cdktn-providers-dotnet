using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiHostedApplication
{
    [JsiiClass(nativeType: typeof(oci.GenerativeAiHostedApplication.GenerativeAiHostedApplicationInboundAuthConfigOutputReference), fullyQualifiedName: "oci.generativeAiHostedApplication.GenerativeAiHostedApplicationInboundAuthConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GenerativeAiHostedApplicationInboundAuthConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GenerativeAiHostedApplicationInboundAuthConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GenerativeAiHostedApplicationInboundAuthConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GenerativeAiHostedApplicationInboundAuthConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIdcsConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.generativeAiHostedApplication.GenerativeAiHostedApplicationInboundAuthConfigIdcsConfig\"}}]")]
        public virtual void PutIdcsConfig(oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationInboundAuthConfigIdcsConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationInboundAuthConfigIdcsConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetIdcsConfig")]
        public virtual void ResetIdcsConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "idcsConfig", typeJson: "{\"fqn\":\"oci.generativeAiHostedApplication.GenerativeAiHostedApplicationInboundAuthConfigIdcsConfigOutputReference\"}")]
        public virtual oci.GenerativeAiHostedApplication.GenerativeAiHostedApplicationInboundAuthConfigIdcsConfigOutputReference IdcsConfig
        {
            get => GetInstanceProperty<oci.GenerativeAiHostedApplication.GenerativeAiHostedApplicationInboundAuthConfigIdcsConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idcsConfigInput", typeJson: "{\"fqn\":\"oci.generativeAiHostedApplication.GenerativeAiHostedApplicationInboundAuthConfigIdcsConfig\"}", isOptional: true)]
        public virtual oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationInboundAuthConfigIdcsConfig? IdcsConfigInput
        {
            get => GetInstanceProperty<oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationInboundAuthConfigIdcsConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inboundAuthConfigTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InboundAuthConfigTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "inboundAuthConfigType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InboundAuthConfigType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.generativeAiHostedApplication.GenerativeAiHostedApplicationInboundAuthConfig\"}", isOptional: true)]
        public virtual oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationInboundAuthConfig? InternalValue
        {
            get => GetInstanceProperty<oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationInboundAuthConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
