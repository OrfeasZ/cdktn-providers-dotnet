using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementCloudDbSystemConnector
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementCloudDbSystemConnector.DataOciDatabaseManagementCloudDbSystemConnectorConnectionInfoOutputReference), fullyQualifiedName: "oci.dataOciDatabaseManagementCloudDbSystemConnector.DataOciDatabaseManagementCloudDbSystemConnectorConnectionInfoOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseManagementCloudDbSystemConnectorConnectionInfoOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseManagementCloudDbSystemConnectorConnectionInfoOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseManagementCloudDbSystemConnectorConnectionInfoOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementCloudDbSystemConnectorConnectionInfoOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "componentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComponentType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectionCredentials", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementCloudDbSystemConnector.DataOciDatabaseManagementCloudDbSystemConnectorConnectionInfoConnectionCredentialsList\"}")]
        public virtual oci.DataOciDatabaseManagementCloudDbSystemConnector.DataOciDatabaseManagementCloudDbSystemConnectorConnectionInfoConnectionCredentialsList ConnectionCredentials
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementCloudDbSystemConnector.DataOciDatabaseManagementCloudDbSystemConnectorConnectionInfoConnectionCredentialsList>()!;
        }

        [JsiiProperty(name: "connectionString", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementCloudDbSystemConnector.DataOciDatabaseManagementCloudDbSystemConnectorConnectionInfoConnectionStringList\"}")]
        public virtual oci.DataOciDatabaseManagementCloudDbSystemConnector.DataOciDatabaseManagementCloudDbSystemConnectorConnectionInfoConnectionStringList ConnectionString
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementCloudDbSystemConnector.DataOciDatabaseManagementCloudDbSystemConnectorConnectionInfoConnectionStringList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementCloudDbSystemConnector.DataOciDatabaseManagementCloudDbSystemConnectorConnectionInfo\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseManagementCloudDbSystemConnector.IDataOciDatabaseManagementCloudDbSystemConnectorConnectionInfo? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementCloudDbSystemConnector.IDataOciDatabaseManagementCloudDbSystemConnectorConnectionInfo?>();
            set => SetInstanceProperty(value);
        }
    }
}
