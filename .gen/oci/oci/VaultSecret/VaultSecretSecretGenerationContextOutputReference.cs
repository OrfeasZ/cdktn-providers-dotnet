using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.VaultSecret
{
    [JsiiClass(nativeType: typeof(oci.VaultSecret.VaultSecretSecretGenerationContextOutputReference), fullyQualifiedName: "oci.vaultSecret.VaultSecretSecretGenerationContextOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class VaultSecretSecretGenerationContextOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public VaultSecretSecretGenerationContextOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected VaultSecretSecretGenerationContextOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VaultSecretSecretGenerationContextOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetPassphraseLength")]
        public virtual void ResetPassphraseLength()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecretTemplate")]
        public virtual void ResetSecretTemplate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "generationTemplateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GenerationTemplateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "generationTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GenerationTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "passphraseLengthInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PassphraseLengthInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secretTemplateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecretTemplateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "generationTemplate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GenerationTemplate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "generationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GenerationType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "passphraseLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PassphraseLength
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "secretTemplate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecretTemplate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.vaultSecret.VaultSecretSecretGenerationContext\"}", isOptional: true)]
        public virtual oci.VaultSecret.IVaultSecretSecretGenerationContext? InternalValue
        {
            get => GetInstanceProperty<oci.VaultSecret.IVaultSecretSecretGenerationContext?>();
            set => SetInstanceProperty(value);
        }
    }
}
