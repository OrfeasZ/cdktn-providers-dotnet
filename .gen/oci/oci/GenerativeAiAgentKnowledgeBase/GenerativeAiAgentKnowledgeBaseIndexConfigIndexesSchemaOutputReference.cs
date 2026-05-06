using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentKnowledgeBase
{
    [JsiiClass(nativeType: typeof(oci.GenerativeAiAgentKnowledgeBase.GenerativeAiAgentKnowledgeBaseIndexConfigIndexesSchemaOutputReference), fullyQualifiedName: "oci.generativeAiAgentKnowledgeBase.GenerativeAiAgentKnowledgeBaseIndexConfigIndexesSchemaOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GenerativeAiAgentKnowledgeBaseIndexConfigIndexesSchemaOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GenerativeAiAgentKnowledgeBaseIndexConfigIndexesSchemaOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GenerativeAiAgentKnowledgeBaseIndexConfigIndexesSchemaOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GenerativeAiAgentKnowledgeBaseIndexConfigIndexesSchemaOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetBodyKey")]
        public virtual void ResetBodyKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmbeddingBodyKey")]
        public virtual void ResetEmbeddingBodyKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTitleKey")]
        public virtual void ResetTitleKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUrlKey")]
        public virtual void ResetUrlKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "bodyKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BodyKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "embeddingBodyKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EmbeddingBodyKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "titleKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TitleKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urlKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UrlKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "bodyKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BodyKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "embeddingBodyKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmbeddingBodyKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "titleKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TitleKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "urlKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UrlKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.generativeAiAgentKnowledgeBase.GenerativeAiAgentKnowledgeBaseIndexConfigIndexesSchema\"}", isOptional: true)]
        public virtual oci.GenerativeAiAgentKnowledgeBase.IGenerativeAiAgentKnowledgeBaseIndexConfigIndexesSchema? InternalValue
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentKnowledgeBase.IGenerativeAiAgentKnowledgeBaseIndexConfigIndexesSchema?>();
            set => SetInstanceProperty(value);
        }
    }
}
