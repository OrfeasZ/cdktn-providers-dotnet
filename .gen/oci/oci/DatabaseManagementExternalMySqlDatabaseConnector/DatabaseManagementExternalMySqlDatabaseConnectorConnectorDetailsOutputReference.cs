using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementExternalMySqlDatabaseConnector
{
    [JsiiClass(nativeType: typeof(oci.DatabaseManagementExternalMySqlDatabaseConnector.DatabaseManagementExternalMySqlDatabaseConnectorConnectorDetailsOutputReference), fullyQualifiedName: "oci.databaseManagementExternalMySqlDatabaseConnector.DatabaseManagementExternalMySqlDatabaseConnectorConnectorDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatabaseManagementExternalMySqlDatabaseConnectorConnectorDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatabaseManagementExternalMySqlDatabaseConnectorConnectorDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatabaseManagementExternalMySqlDatabaseConnectorConnectorDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseManagementExternalMySqlDatabaseConnectorConnectorDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "credentialTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CredentialTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "externalDatabaseIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExternalDatabaseIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HostNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "macsAgentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MacsAgentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkProtocolInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NetworkProtocolInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "portInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sslSecretIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SslSecretIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "credentialType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CredentialType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "externalDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalDatabaseId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hostName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "macsAgentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MacsAgentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "networkProtocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkProtocol
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sslSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslSecretId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.databaseManagementExternalMySqlDatabaseConnector.DatabaseManagementExternalMySqlDatabaseConnectorConnectorDetails\"}", isOptional: true)]
        public virtual oci.DatabaseManagementExternalMySqlDatabaseConnector.IDatabaseManagementExternalMySqlDatabaseConnectorConnectorDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DatabaseManagementExternalMySqlDatabaseConnector.IDatabaseManagementExternalMySqlDatabaseConnectorConnectorDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
