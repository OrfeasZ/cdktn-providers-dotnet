using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementExternalDbSystemDiscovery
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementExternalDbSystemDiscovery.DataOciDatabaseManagementExternalDbSystemDiscoveryDiscoveredComponentsPluggableDatabasesOutputReference), fullyQualifiedName: "oci.dataOciDatabaseManagementExternalDbSystemDiscovery.DataOciDatabaseManagementExternalDbSystemDiscoveryDiscoveredComponentsPluggableDatabasesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseManagementExternalDbSystemDiscoveryDiscoveredComponentsPluggableDatabasesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseManagementExternalDbSystemDiscoveryDiscoveredComponentsPluggableDatabasesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseManagementExternalDbSystemDiscoveryDiscoveredComponentsPluggableDatabasesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementExternalDbSystemDiscoveryDiscoveredComponentsPluggableDatabasesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connector", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementExternalDbSystemDiscovery.DataOciDatabaseManagementExternalDbSystemDiscoveryDiscoveredComponentsPluggableDatabasesConnectorList\"}")]
        public virtual oci.DataOciDatabaseManagementExternalDbSystemDiscovery.DataOciDatabaseManagementExternalDbSystemDiscoveryDiscoveredComponentsPluggableDatabasesConnectorList Connector
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementExternalDbSystemDiscovery.DataOciDatabaseManagementExternalDbSystemDiscoveryDiscoveredComponentsPluggableDatabasesConnectorList>()!;
        }

        [JsiiProperty(name: "containerDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerDatabaseId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "guid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Guid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementExternalDbSystemDiscovery.DataOciDatabaseManagementExternalDbSystemDiscoveryDiscoveredComponentsPluggableDatabases\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseManagementExternalDbSystemDiscovery.IDataOciDatabaseManagementExternalDbSystemDiscoveryDiscoveredComponentsPluggableDatabases? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementExternalDbSystemDiscovery.IDataOciDatabaseManagementExternalDbSystemDiscoveryDiscoveredComponentsPluggableDatabases?>();
            set => SetInstanceProperty(value);
        }
    }
}
