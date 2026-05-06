using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciLustreFileStorageLustreFileSystems
{
    [JsiiClass(nativeType: typeof(oci.DataOciLustreFileStorageLustreFileSystems.DataOciLustreFileStorageLustreFileSystemsLustreFileSystemCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciLustreFileStorageLustreFileSystems.DataOciLustreFileStorageLustreFileSystemsLustreFileSystemCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciLustreFileStorageLustreFileSystemsLustreFileSystemCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciLustreFileStorageLustreFileSystemsLustreFileSystemCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciLustreFileStorageLustreFileSystemsLustreFileSystemCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciLustreFileStorageLustreFileSystemsLustreFileSystemCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "capacityInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CapacityInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "clusterPlacementGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterPlacementGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
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

        [JsiiProperty(name: "fileSystemDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FileSystemDescription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fileSystemName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FileSystemName
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

        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lnet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Lnet
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"fqn\":\"oci.dataOciLustreFileStorageLustreFileSystems.DataOciLustreFileStorageLustreFileSystemsLustreFileSystemCollectionItemsMaintenanceWindowList\"}")]
        public virtual oci.DataOciLustreFileStorageLustreFileSystems.DataOciLustreFileStorageLustreFileSystemsLustreFileSystemCollectionItemsMaintenanceWindowList MaintenanceWindow
        {
            get => GetInstanceProperty<oci.DataOciLustreFileStorageLustreFileSystems.DataOciLustreFileStorageLustreFileSystemsLustreFileSystemCollectionItemsMaintenanceWindowList>()!;
        }

        [JsiiProperty(name: "majorVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MajorVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managementServiceAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagementServiceAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NsgIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "performanceTier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PerformanceTier
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rootSquashConfiguration", typeJson: "{\"fqn\":\"oci.dataOciLustreFileStorageLustreFileSystems.DataOciLustreFileStorageLustreFileSystemsLustreFileSystemCollectionItemsRootSquashConfigurationList\"}")]
        public virtual oci.DataOciLustreFileStorageLustreFileSystems.DataOciLustreFileStorageLustreFileSystemsLustreFileSystemCollectionItemsRootSquashConfigurationList RootSquashConfiguration
        {
            get => GetInstanceProperty<oci.DataOciLustreFileStorageLustreFileSystems.DataOciLustreFileStorageLustreFileSystemsLustreFileSystemCollectionItemsRootSquashConfigurationList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeBillingCycleEnd", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeBillingCycleEnd
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciLustreFileStorageLustreFileSystems.DataOciLustreFileStorageLustreFileSystemsLustreFileSystemCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciLustreFileStorageLustreFileSystems.IDataOciLustreFileStorageLustreFileSystemsLustreFileSystemCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciLustreFileStorageLustreFileSystems.IDataOciLustreFileStorageLustreFileSystemsLustreFileSystemCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
