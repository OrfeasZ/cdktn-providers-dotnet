using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseExternalDatabaseConnectors
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseExternalDatabaseConnectors.DataOciDatabaseExternalDatabaseConnectorsExternalDatabaseConnectorsOutputReference), fullyQualifiedName: "oci.dataOciDatabaseExternalDatabaseConnectors.DataOciDatabaseExternalDatabaseConnectorsExternalDatabaseConnectorsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseExternalDatabaseConnectorsExternalDatabaseConnectorsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseExternalDatabaseConnectorsExternalDatabaseConnectorsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseExternalDatabaseConnectorsExternalDatabaseConnectorsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseExternalDatabaseConnectorsExternalDatabaseConnectorsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectionCredentials", typeJson: "{\"fqn\":\"oci.dataOciDatabaseExternalDatabaseConnectors.DataOciDatabaseExternalDatabaseConnectorsExternalDatabaseConnectorsConnectionCredentialsList\"}")]
        public virtual oci.DataOciDatabaseExternalDatabaseConnectors.DataOciDatabaseExternalDatabaseConnectorsExternalDatabaseConnectorsConnectionCredentialsList ConnectionCredentials
        {
            get => GetInstanceProperty<oci.DataOciDatabaseExternalDatabaseConnectors.DataOciDatabaseExternalDatabaseConnectorsExternalDatabaseConnectorsConnectionCredentialsList>()!;
        }

        [JsiiProperty(name: "connectionStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectionString", typeJson: "{\"fqn\":\"oci.dataOciDatabaseExternalDatabaseConnectors.DataOciDatabaseExternalDatabaseConnectorsExternalDatabaseConnectorsConnectionStringList\"}")]
        public virtual oci.DataOciDatabaseExternalDatabaseConnectors.DataOciDatabaseExternalDatabaseConnectorsExternalDatabaseConnectorsConnectionStringList ConnectionString
        {
            get => GetInstanceProperty<oci.DataOciDatabaseExternalDatabaseConnectors.DataOciDatabaseExternalDatabaseConnectorsExternalDatabaseConnectorsConnectionStringList>()!;
        }

        [JsiiProperty(name: "connectorAgentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectorAgentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectorType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectorType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
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

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeConnectionStatusLastUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeConnectionStatusLastUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseExternalDatabaseConnectors.DataOciDatabaseExternalDatabaseConnectorsExternalDatabaseConnectors\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseExternalDatabaseConnectors.IDataOciDatabaseExternalDatabaseConnectorsExternalDatabaseConnectors? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseExternalDatabaseConnectors.IDataOciDatabaseExternalDatabaseConnectorsExternalDatabaseConnectors?>();
            set => SetInstanceProperty(value);
        }
    }
}
