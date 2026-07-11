using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataFactoryLinkedServiceSftp
{
    [JsiiClass(nativeType: typeof(azurerm.DataFactoryLinkedServiceSftp.DataFactoryLinkedServiceSftpKeyVaultPrivateKeyPassphraseOutputReference), fullyQualifiedName: "azurerm.dataFactoryLinkedServiceSftp.DataFactoryLinkedServiceSftpKeyVaultPrivateKeyPassphraseOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataFactoryLinkedServiceSftpKeyVaultPrivateKeyPassphraseOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataFactoryLinkedServiceSftpKeyVaultPrivateKeyPassphraseOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataFactoryLinkedServiceSftpKeyVaultPrivateKeyPassphraseOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataFactoryLinkedServiceSftpKeyVaultPrivateKeyPassphraseOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "linkedServiceNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LinkedServiceNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secretNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecretNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "linkedServiceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LinkedServiceName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecretName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataFactoryLinkedServiceSftp.DataFactoryLinkedServiceSftpKeyVaultPrivateKeyPassphrase\"}", isOptional: true)]
        public virtual azurerm.DataFactoryLinkedServiceSftp.IDataFactoryLinkedServiceSftpKeyVaultPrivateKeyPassphrase? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataFactoryLinkedServiceSftp.IDataFactoryLinkedServiceSftpKeyVaultPrivateKeyPassphrase?>();
            set => SetInstanceProperty(value);
        }
    }
}
