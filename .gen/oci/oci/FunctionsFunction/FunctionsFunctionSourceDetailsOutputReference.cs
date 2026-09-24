using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FunctionsFunction
{
    [JsiiClass(nativeType: typeof(oci.FunctionsFunction.FunctionsFunctionSourceDetailsOutputReference), fullyQualifiedName: "oci.functionsFunction.FunctionsFunctionSourceDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FunctionsFunctionSourceDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public FunctionsFunctionSourceDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected FunctionsFunctionSourceDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FunctionsFunctionSourceDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putArchiveSourceDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.functionsFunction.FunctionsFunctionSourceDetailsArchiveSourceDetails\"}}]")]
        public virtual void PutArchiveSourceDetails(oci.FunctionsFunction.IFunctionsFunctionSourceDetailsArchiveSourceDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FunctionsFunction.IFunctionsFunctionSourceDetailsArchiveSourceDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRuntimeConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.functionsFunction.FunctionsFunctionSourceDetailsRuntimeConfig\"}}]")]
        public virtual void PutRuntimeConfig(oci.FunctionsFunction.IFunctionsFunctionSourceDetailsRuntimeConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FunctionsFunction.IFunctionsFunctionSourceDetailsRuntimeConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetArchiveSourceDetails")]
        public virtual void ResetArchiveSourceDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHandler")]
        public virtual void ResetHandler()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImage")]
        public virtual void ResetImage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImageDigest")]
        public virtual void ResetImageDigest()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPbfListingId")]
        public virtual void ResetPbfListingId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRuntimeConfig")]
        public virtual void ResetRuntimeConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "archiveSourceDetails", typeJson: "{\"fqn\":\"oci.functionsFunction.FunctionsFunctionSourceDetailsArchiveSourceDetailsOutputReference\"}")]
        public virtual oci.FunctionsFunction.FunctionsFunctionSourceDetailsArchiveSourceDetailsOutputReference ArchiveSourceDetails
        {
            get => GetInstanceProperty<oci.FunctionsFunction.FunctionsFunctionSourceDetailsArchiveSourceDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "runtimeConfig", typeJson: "{\"fqn\":\"oci.functionsFunction.FunctionsFunctionSourceDetailsRuntimeConfigOutputReference\"}")]
        public virtual oci.FunctionsFunction.FunctionsFunctionSourceDetailsRuntimeConfigOutputReference RuntimeConfig
        {
            get => GetInstanceProperty<oci.FunctionsFunction.FunctionsFunctionSourceDetailsRuntimeConfigOutputReference>()!;
        }

        [JsiiProperty(name: "sourceCodeSha256", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceCodeSha256
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "archiveSourceDetailsInput", typeJson: "{\"fqn\":\"oci.functionsFunction.FunctionsFunctionSourceDetailsArchiveSourceDetails\"}", isOptional: true)]
        public virtual oci.FunctionsFunction.IFunctionsFunctionSourceDetailsArchiveSourceDetails? ArchiveSourceDetailsInput
        {
            get => GetInstanceProperty<oci.FunctionsFunction.IFunctionsFunctionSourceDetailsArchiveSourceDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "handlerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HandlerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageDigestInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImageDigestInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pbfListingIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PbfListingIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "runtimeConfigInput", typeJson: "{\"fqn\":\"oci.functionsFunction.FunctionsFunctionSourceDetailsRuntimeConfig\"}", isOptional: true)]
        public virtual oci.FunctionsFunction.IFunctionsFunctionSourceDetailsRuntimeConfig? RuntimeConfigInput
        {
            get => GetInstanceProperty<oci.FunctionsFunction.IFunctionsFunctionSourceDetailsRuntimeConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "handler", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Handler
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Image
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "imageDigest", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageDigest
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pbfListingId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PbfListingId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.functionsFunction.FunctionsFunctionSourceDetails\"}", isOptional: true)]
        public virtual oci.FunctionsFunction.IFunctionsFunctionSourceDetails? InternalValue
        {
            get => GetInstanceProperty<oci.FunctionsFunction.IFunctionsFunctionSourceDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
