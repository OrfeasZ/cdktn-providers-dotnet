using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementExternalMySqlDatabaseConnectors
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementExternalMySqlDatabaseConnectors.DataOciDatabaseManagementExternalMySqlDatabaseConnectorsMySqlConnectorCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDatabaseManagementExternalMySqlDatabaseConnectors.DataOciDatabaseManagementExternalMySqlDatabaseConnectorsMySqlConnectorCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseManagementExternalMySqlDatabaseConnectorsMySqlConnectorCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseManagementExternalMySqlDatabaseConnectorsMySqlConnectorCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementExternalMySqlDatabaseConnectorsMySqlConnectorCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementExternalMySqlDatabaseConnectorsMySqlConnectorCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "associatedServices", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssociatedServices
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "checkConnectionStatusTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CheckConnectionStatusTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectionStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectorDetails", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementExternalMySqlDatabaseConnectors.DataOciDatabaseManagementExternalMySqlDatabaseConnectorsMySqlConnectorCollectionItemsConnectorDetailsList\"}")]
        public virtual oci.DataOciDatabaseManagementExternalMySqlDatabaseConnectors.DataOciDatabaseManagementExternalMySqlDatabaseConnectorsMySqlConnectorCollectionItemsConnectorDetailsList ConnectorDetails
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementExternalMySqlDatabaseConnectors.DataOciDatabaseManagementExternalMySqlDatabaseConnectorsMySqlConnectorCollectionItemsConnectorDetailsList>()!;
        }

        [JsiiProperty(name: "connectorType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectorType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "credentialType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CredentialType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "externalDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalDatabaseId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hostName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isTestConnectionParam", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsTestConnectionParam
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "macsAgentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MacsAgentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkProtocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkProtocol
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sourceDatabase", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceDatabase
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceDatabaseType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceDatabaseType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sslSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslSecretId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sslSecretName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslSecretName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeConnectionStatusUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeConnectionStatusUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementExternalMySqlDatabaseConnectors.DataOciDatabaseManagementExternalMySqlDatabaseConnectorsMySqlConnectorCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseManagementExternalMySqlDatabaseConnectors.IDataOciDatabaseManagementExternalMySqlDatabaseConnectorsMySqlConnectorCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementExternalMySqlDatabaseConnectors.IDataOciDatabaseManagementExternalMySqlDatabaseConnectorsMySqlConnectorCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
