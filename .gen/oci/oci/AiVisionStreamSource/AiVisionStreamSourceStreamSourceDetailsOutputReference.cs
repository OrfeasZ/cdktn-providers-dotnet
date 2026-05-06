using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiVisionStreamSource
{
    [JsiiClass(nativeType: typeof(oci.AiVisionStreamSource.AiVisionStreamSourceStreamSourceDetailsOutputReference), fullyQualifiedName: "oci.aiVisionStreamSource.AiVisionStreamSourceStreamSourceDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AiVisionStreamSourceStreamSourceDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AiVisionStreamSourceStreamSourceDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AiVisionStreamSourceStreamSourceDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AiVisionStreamSourceStreamSourceDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putStreamNetworkAccessDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.aiVisionStreamSource.AiVisionStreamSourceStreamSourceDetailsStreamNetworkAccessDetails\"}}]")]
        public virtual void PutStreamNetworkAccessDetails(oci.AiVisionStreamSource.IAiVisionStreamSourceStreamSourceDetailsStreamNetworkAccessDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.AiVisionStreamSource.IAiVisionStreamSourceStreamSourceDetailsStreamNetworkAccessDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetSecretId")]
        public virtual void ResetSecretId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "streamNetworkAccessDetails", typeJson: "{\"fqn\":\"oci.aiVisionStreamSource.AiVisionStreamSourceStreamSourceDetailsStreamNetworkAccessDetailsOutputReference\"}")]
        public virtual oci.AiVisionStreamSource.AiVisionStreamSourceStreamSourceDetailsStreamNetworkAccessDetailsOutputReference StreamNetworkAccessDetails
        {
            get => GetInstanceProperty<oci.AiVisionStreamSource.AiVisionStreamSourceStreamSourceDetailsStreamNetworkAccessDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cameraUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CameraUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secretIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecretIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "streamNetworkAccessDetailsInput", typeJson: "{\"fqn\":\"oci.aiVisionStreamSource.AiVisionStreamSourceStreamSourceDetailsStreamNetworkAccessDetails\"}", isOptional: true)]
        public virtual oci.AiVisionStreamSource.IAiVisionStreamSourceStreamSourceDetailsStreamNetworkAccessDetails? StreamNetworkAccessDetailsInput
        {
            get => GetInstanceProperty<oci.AiVisionStreamSource.IAiVisionStreamSourceStreamSourceDetailsStreamNetworkAccessDetails?>();
        }

        [JsiiProperty(name: "cameraUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CameraUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecretId
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.aiVisionStreamSource.AiVisionStreamSourceStreamSourceDetails\"}", isOptional: true)]
        public virtual oci.AiVisionStreamSource.IAiVisionStreamSourceStreamSourceDetails? InternalValue
        {
            get => GetInstanceProperty<oci.AiVisionStreamSource.IAiVisionStreamSourceStreamSourceDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
