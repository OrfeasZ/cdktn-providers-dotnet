using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiHostedApplication
{
    [JsiiClass(nativeType: typeof(oci.GenerativeAiHostedApplication.GenerativeAiHostedApplicationInboundAuthConfigIdcsConfigOutputReference), fullyQualifiedName: "oci.generativeAiHostedApplication.GenerativeAiHostedApplicationInboundAuthConfigIdcsConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GenerativeAiHostedApplicationInboundAuthConfigIdcsConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GenerativeAiHostedApplicationInboundAuthConfigIdcsConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GenerativeAiHostedApplicationInboundAuthConfigIdcsConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GenerativeAiHostedApplicationInboundAuthConfigIdcsConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAudience")]
        public virtual void ResetAudience()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "audienceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AudienceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DomainUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scopeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScopeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "audience", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Audience
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "domainUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Scope
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.generativeAiHostedApplication.GenerativeAiHostedApplicationInboundAuthConfigIdcsConfig\"}", isOptional: true)]
        public virtual oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationInboundAuthConfigIdcsConfig? InternalValue
        {
            get => GetInstanceProperty<oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationInboundAuthConfigIdcsConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
