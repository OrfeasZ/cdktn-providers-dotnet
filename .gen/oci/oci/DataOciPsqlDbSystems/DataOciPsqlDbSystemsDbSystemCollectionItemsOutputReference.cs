using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciPsqlDbSystems
{
    [JsiiClass(nativeType: typeof(oci.DataOciPsqlDbSystems.DataOciPsqlDbSystemsDbSystemCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciPsqlDbSystems.DataOciPsqlDbSystemsDbSystemCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciPsqlDbSystemsDbSystemCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciPsqlDbSystemsDbSystemCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciPsqlDbSystemsDbSystemCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciPsqlDbSystemsDbSystemCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "adminUsername", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminUsername
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "applyConfig", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplyConfig
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "credentials", typeJson: "{\"fqn\":\"oci.dataOciPsqlDbSystems.DataOciPsqlDbSystemsDbSystemCollectionItemsCredentialsList\"}")]
        public virtual oci.DataOciPsqlDbSystems.DataOciPsqlDbSystemsDbSystemCollectionItemsCredentialsList Credentials
        {
            get => GetInstanceProperty<oci.DataOciPsqlDbSystems.DataOciPsqlDbSystemsDbSystemCollectionItemsCredentialsList>()!;
        }

        [JsiiProperty(name: "dbVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
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

        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InstanceCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "instanceMemorySizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InstanceMemorySizeInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "instanceOcpuCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InstanceOcpuCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "instances", typeJson: "{\"fqn\":\"oci.dataOciPsqlDbSystems.DataOciPsqlDbSystemsDbSystemCollectionItemsInstancesList\"}")]
        public virtual oci.DataOciPsqlDbSystems.DataOciPsqlDbSystemsDbSystemCollectionItemsInstancesList Instances
        {
            get => GetInstanceProperty<oci.DataOciPsqlDbSystems.DataOciPsqlDbSystemsDbSystemCollectionItemsInstancesList>()!;
        }

        [JsiiProperty(name: "instancesDetails", typeJson: "{\"fqn\":\"oci.dataOciPsqlDbSystems.DataOciPsqlDbSystemsDbSystemCollectionItemsInstancesDetailsList\"}")]
        public virtual oci.DataOciPsqlDbSystems.DataOciPsqlDbSystemsDbSystemCollectionItemsInstancesDetailsList InstancesDetails
        {
            get => GetInstanceProperty<oci.DataOciPsqlDbSystems.DataOciPsqlDbSystemsDbSystemCollectionItemsInstancesDetailsList>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managementPolicy", typeJson: "{\"fqn\":\"oci.dataOciPsqlDbSystems.DataOciPsqlDbSystemsDbSystemCollectionItemsManagementPolicyList\"}")]
        public virtual oci.DataOciPsqlDbSystems.DataOciPsqlDbSystemsDbSystemCollectionItemsManagementPolicyList ManagementPolicy
        {
            get => GetInstanceProperty<oci.DataOciPsqlDbSystems.DataOciPsqlDbSystemsDbSystemCollectionItemsManagementPolicyList>()!;
        }

        [JsiiProperty(name: "networkDetails", typeJson: "{\"fqn\":\"oci.dataOciPsqlDbSystems.DataOciPsqlDbSystemsDbSystemCollectionItemsNetworkDetailsList\"}")]
        public virtual oci.DataOciPsqlDbSystems.DataOciPsqlDbSystemsDbSystemCollectionItemsNetworkDetailsList NetworkDetails
        {
            get => GetInstanceProperty<oci.DataOciPsqlDbSystems.DataOciPsqlDbSystemsDbSystemCollectionItemsNetworkDetailsList>()!;
        }

        [JsiiProperty(name: "patchOperations", typeJson: "{\"fqn\":\"oci.dataOciPsqlDbSystems.DataOciPsqlDbSystemsDbSystemCollectionItemsPatchOperationsList\"}")]
        public virtual oci.DataOciPsqlDbSystems.DataOciPsqlDbSystemsDbSystemCollectionItemsPatchOperationsList PatchOperations
        {
            get => GetInstanceProperty<oci.DataOciPsqlDbSystems.DataOciPsqlDbSystemsDbSystemCollectionItemsPatchOperationsList>()!;
        }

        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Shape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"oci.dataOciPsqlDbSystems.DataOciPsqlDbSystemsDbSystemCollectionItemsSourceList\"}")]
        public virtual oci.DataOciPsqlDbSystems.DataOciPsqlDbSystemsDbSystemCollectionItemsSourceList Source
        {
            get => GetInstanceProperty<oci.DataOciPsqlDbSystems.DataOciPsqlDbSystemsDbSystemCollectionItemsSourceList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageDetails", typeJson: "{\"fqn\":\"oci.dataOciPsqlDbSystems.DataOciPsqlDbSystemsDbSystemCollectionItemsStorageDetailsList\"}")]
        public virtual oci.DataOciPsqlDbSystems.DataOciPsqlDbSystemsDbSystemCollectionItemsStorageDetailsList StorageDetails
        {
            get => GetInstanceProperty<oci.DataOciPsqlDbSystems.DataOciPsqlDbSystemsDbSystemCollectionItemsStorageDetailsList>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "systemType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SystemType
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciPsqlDbSystems.DataOciPsqlDbSystemsDbSystemCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciPsqlDbSystems.IDataOciPsqlDbSystemsDbSystemCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciPsqlDbSystems.IDataOciPsqlDbSystemsDbSystemCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
