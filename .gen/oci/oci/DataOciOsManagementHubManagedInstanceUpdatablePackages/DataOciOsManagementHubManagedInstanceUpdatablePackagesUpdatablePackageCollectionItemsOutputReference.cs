using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOsManagementHubManagedInstanceUpdatablePackages
{
    [JsiiClass(nativeType: typeof(oci.DataOciOsManagementHubManagedInstanceUpdatablePackages.DataOciOsManagementHubManagedInstanceUpdatablePackagesUpdatablePackageCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciOsManagementHubManagedInstanceUpdatablePackages.DataOciOsManagementHubManagedInstanceUpdatablePackagesUpdatablePackageCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOsManagementHubManagedInstanceUpdatablePackagesUpdatablePackageCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOsManagementHubManagedInstanceUpdatablePackagesUpdatablePackageCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOsManagementHubManagedInstanceUpdatablePackagesUpdatablePackageCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOsManagementHubManagedInstanceUpdatablePackagesUpdatablePackageCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "architecture", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Architecture
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "errata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Errata
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "installedVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstalledVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "packageClassification", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PackageClassification
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "relatedCves", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RelatedCves
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "softwareSources", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubManagedInstanceUpdatablePackages.DataOciOsManagementHubManagedInstanceUpdatablePackagesUpdatablePackageCollectionItemsSoftwareSourcesList\"}")]
        public virtual oci.DataOciOsManagementHubManagedInstanceUpdatablePackages.DataOciOsManagementHubManagedInstanceUpdatablePackagesUpdatablePackageCollectionItemsSoftwareSourcesList SoftwareSources
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubManagedInstanceUpdatablePackages.DataOciOsManagementHubManagedInstanceUpdatablePackagesUpdatablePackageCollectionItemsSoftwareSourcesList>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updateType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdateType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubManagedInstanceUpdatablePackages.DataOciOsManagementHubManagedInstanceUpdatablePackagesUpdatablePackageCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciOsManagementHubManagedInstanceUpdatablePackages.IDataOciOsManagementHubManagedInstanceUpdatablePackagesUpdatablePackageCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubManagedInstanceUpdatablePackages.IDataOciOsManagementHubManagedInstanceUpdatablePackagesUpdatablePackageCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
