using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementExternalMySqlDatabaseConnector
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementExternalMySqlDatabaseConnector.DataOciDatabaseManagementExternalMySqlDatabaseConnectorConnectorDetailsOutputReference), fullyQualifiedName: "oci.dataOciDatabaseManagementExternalMySqlDatabaseConnector.DataOciDatabaseManagementExternalMySqlDatabaseConnectorConnectorDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseManagementExternalMySqlDatabaseConnectorConnectorDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseManagementExternalMySqlDatabaseConnectorConnectorDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseManagementExternalMySqlDatabaseConnectorConnectorDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementExternalMySqlDatabaseConnectorConnectorDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "credentialType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CredentialType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
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

        [JsiiProperty(name: "macsAgentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MacsAgentId
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

        [JsiiProperty(name: "sslSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslSecretId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementExternalMySqlDatabaseConnector.DataOciDatabaseManagementExternalMySqlDatabaseConnectorConnectorDetails\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseManagementExternalMySqlDatabaseConnector.IDataOciDatabaseManagementExternalMySqlDatabaseConnectorConnectorDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementExternalMySqlDatabaseConnector.IDataOciDatabaseManagementExternalMySqlDatabaseConnectorConnectorDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
