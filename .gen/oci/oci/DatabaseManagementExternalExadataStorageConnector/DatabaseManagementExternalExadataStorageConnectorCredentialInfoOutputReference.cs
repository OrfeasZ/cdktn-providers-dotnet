using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementExternalExadataStorageConnector
{
    [JsiiClass(nativeType: typeof(oci.DatabaseManagementExternalExadataStorageConnector.DatabaseManagementExternalExadataStorageConnectorCredentialInfoOutputReference), fullyQualifiedName: "oci.databaseManagementExternalExadataStorageConnector.DatabaseManagementExternalExadataStorageConnectorCredentialInfoOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatabaseManagementExternalExadataStorageConnectorCredentialInfoOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatabaseManagementExternalExadataStorageConnectorCredentialInfoOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatabaseManagementExternalExadataStorageConnectorCredentialInfoOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseManagementExternalExadataStorageConnectorCredentialInfoOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetSslTrustStoreLocation")]
        public virtual void ResetSslTrustStoreLocation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSslTrustStorePassword")]
        public virtual void ResetSslTrustStorePassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSslTrustStoreType")]
        public virtual void ResetSslTrustStoreType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "passwordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sslTrustStoreLocationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SslTrustStoreLocationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sslTrustStorePasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SslTrustStorePasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sslTrustStoreTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SslTrustStoreTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "usernameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UsernameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Password
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sslTrustStoreLocation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslTrustStoreLocation
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sslTrustStorePassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslTrustStorePassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sslTrustStoreType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslTrustStoreType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Username
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.databaseManagementExternalExadataStorageConnector.DatabaseManagementExternalExadataStorageConnectorCredentialInfo\"}", isOptional: true)]
        public virtual oci.DatabaseManagementExternalExadataStorageConnector.IDatabaseManagementExternalExadataStorageConnectorCredentialInfo? InternalValue
        {
            get => GetInstanceProperty<oci.DatabaseManagementExternalExadataStorageConnector.IDatabaseManagementExternalExadataStorageConnectorCredentialInfo?>();
            set => SetInstanceProperty(value);
        }
    }
}
