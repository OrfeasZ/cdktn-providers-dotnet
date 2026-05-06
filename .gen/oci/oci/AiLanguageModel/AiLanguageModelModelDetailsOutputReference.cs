using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiLanguageModel
{
    [JsiiClass(nativeType: typeof(oci.AiLanguageModel.AiLanguageModelModelDetailsOutputReference), fullyQualifiedName: "oci.aiLanguageModel.AiLanguageModelModelDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AiLanguageModelModelDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AiLanguageModelModelDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AiLanguageModelModelDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AiLanguageModelModelDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putClassificationMode", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelModelDetailsClassificationMode\"}}]")]
        public virtual void PutClassificationMode(oci.AiLanguageModel.IAiLanguageModelModelDetailsClassificationMode @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.AiLanguageModel.IAiLanguageModelModelDetailsClassificationMode)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetClassificationMode")]
        public virtual void ResetClassificationMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLanguageCode")]
        public virtual void ResetLanguageCode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVersion")]
        public virtual void ResetVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "classificationMode", typeJson: "{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelModelDetailsClassificationModeOutputReference\"}")]
        public virtual oci.AiLanguageModel.AiLanguageModelModelDetailsClassificationModeOutputReference ClassificationMode
        {
            get => GetInstanceProperty<oci.AiLanguageModel.AiLanguageModelModelDetailsClassificationModeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "classificationModeInput", typeJson: "{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelModelDetailsClassificationMode\"}", isOptional: true)]
        public virtual oci.AiLanguageModel.IAiLanguageModelModelDetailsClassificationMode? ClassificationModeInput
        {
            get => GetInstanceProperty<oci.AiLanguageModel.IAiLanguageModelModelDetailsClassificationMode?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "languageCodeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LanguageCodeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModelTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "languageCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LanguageCode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "modelType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelModelDetails\"}", isOptional: true)]
        public virtual oci.AiLanguageModel.IAiLanguageModelModelDetails? InternalValue
        {
            get => GetInstanceProperty<oci.AiLanguageModel.IAiLanguageModelModelDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
