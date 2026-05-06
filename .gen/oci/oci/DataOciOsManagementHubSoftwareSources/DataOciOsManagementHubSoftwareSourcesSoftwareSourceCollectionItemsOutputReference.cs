using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOsManagementHubSoftwareSources
{
    [JsiiClass(nativeType: typeof(oci.DataOciOsManagementHubSoftwareSources.DataOciOsManagementHubSoftwareSourcesSoftwareSourceCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciOsManagementHubSoftwareSources.DataOciOsManagementHubSoftwareSourcesSoftwareSourceCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOsManagementHubSoftwareSourcesSoftwareSourceCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOsManagementHubSoftwareSourcesSoftwareSourceCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOsManagementHubSoftwareSourcesSoftwareSourceCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOsManagementHubSoftwareSourcesSoftwareSourceCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "archType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ArchType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "availability", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Availability
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "availabilityAtOci", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityAtOci
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

        [JsiiProperty(name: "isMandatoryForAutonomousLinux", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsMandatoryForAutonomousLinux
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isMirrorSyncAllowed", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsMirrorSyncAllowed
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "osFamily", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OsFamily
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "packageCount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PackageCount
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "repoId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RepoId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Size
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "softwareSourceSubType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SoftwareSourceSubType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "softwareSourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SoftwareSourceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "softwareSourceVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SoftwareSourceVersion
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

        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Url
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vendorName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VendorName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vendorSoftwareSources", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubSoftwareSources.DataOciOsManagementHubSoftwareSourcesSoftwareSourceCollectionItemsVendorSoftwareSourcesList\"}")]
        public virtual oci.DataOciOsManagementHubSoftwareSources.DataOciOsManagementHubSoftwareSourcesSoftwareSourceCollectionItemsVendorSoftwareSourcesList VendorSoftwareSources
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubSoftwareSources.DataOciOsManagementHubSoftwareSourcesSoftwareSourceCollectionItemsVendorSoftwareSourcesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubSoftwareSources.DataOciOsManagementHubSoftwareSourcesSoftwareSourceCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciOsManagementHubSoftwareSources.IDataOciOsManagementHubSoftwareSourcesSoftwareSourceCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubSoftwareSources.IDataOciOsManagementHubSoftwareSourcesSoftwareSourceCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
