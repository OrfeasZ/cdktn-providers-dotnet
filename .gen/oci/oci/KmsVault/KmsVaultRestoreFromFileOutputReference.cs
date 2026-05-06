using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.KmsVault
{
    [JsiiClass(nativeType: typeof(oci.KmsVault.KmsVaultRestoreFromFileOutputReference), fullyQualifiedName: "oci.kmsVault.KmsVaultRestoreFromFileOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KmsVaultRestoreFromFileOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KmsVaultRestoreFromFileOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected KmsVaultRestoreFromFileOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KmsVaultRestoreFromFileOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetContentMd5")]
        public virtual void ResetContentMd5()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentLengthInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContentLengthInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentMd5Input", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContentMd5Input
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "restoreVaultFromFileDetailsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RestoreVaultFromFileDetailsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "contentLength", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContentLength
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "contentMd5", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContentMd5
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "restoreVaultFromFileDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RestoreVaultFromFileDetails
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.kmsVault.KmsVaultRestoreFromFile\"}", isOptional: true)]
        public virtual oci.KmsVault.IKmsVaultRestoreFromFile? InternalValue
        {
            get => GetInstanceProperty<oci.KmsVault.IKmsVaultRestoreFromFile?>();
            set => SetInstanceProperty(value);
        }
    }
}
