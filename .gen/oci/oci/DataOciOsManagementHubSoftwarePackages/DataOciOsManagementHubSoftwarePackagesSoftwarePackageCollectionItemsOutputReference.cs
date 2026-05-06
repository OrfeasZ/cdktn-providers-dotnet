using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOsManagementHubSoftwarePackages
{
    [JsiiClass(nativeType: typeof(oci.DataOciOsManagementHubSoftwarePackages.DataOciOsManagementHubSoftwarePackagesSoftwarePackageCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciOsManagementHubSoftwarePackages.DataOciOsManagementHubSoftwarePackagesSoftwarePackageCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOsManagementHubSoftwarePackagesSoftwarePackageCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOsManagementHubSoftwarePackagesSoftwarePackageCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOsManagementHubSoftwarePackagesSoftwarePackageCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOsManagementHubSoftwarePackagesSoftwarePackageCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "architecture", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Architecture
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "checksum", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Checksum
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "checksumType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ChecksumType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dependencies", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubSoftwarePackages.DataOciOsManagementHubSoftwarePackagesSoftwarePackageCollectionItemsDependenciesList\"}")]
        public virtual oci.DataOciOsManagementHubSoftwarePackages.DataOciOsManagementHubSoftwarePackagesSoftwarePackageCollectionItemsDependenciesList Dependencies
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubSoftwarePackages.DataOciOsManagementHubSoftwarePackagesSoftwarePackageCollectionItemsDependenciesList>()!;
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

        [JsiiProperty(name: "files", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubSoftwarePackages.DataOciOsManagementHubSoftwarePackagesSoftwarePackageCollectionItemsFilesList\"}")]
        public virtual oci.DataOciOsManagementHubSoftwarePackages.DataOciOsManagementHubSoftwarePackagesSoftwarePackageCollectionItemsFilesList Files
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubSoftwarePackages.DataOciOsManagementHubSoftwarePackagesSoftwarePackageCollectionItemsFilesList>()!;
        }

        [JsiiProperty(name: "isLatest", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsLatest
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lastModifiedDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastModifiedDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "osFamilies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] OsFamilies
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "sizeInBytes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SizeInBytes
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "softwareSources", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubSoftwarePackages.DataOciOsManagementHubSoftwarePackagesSoftwarePackageCollectionItemsSoftwareSourcesList\"}")]
        public virtual oci.DataOciOsManagementHubSoftwarePackages.DataOciOsManagementHubSoftwarePackagesSoftwarePackageCollectionItemsSoftwareSourcesList SoftwareSources
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubSoftwarePackages.DataOciOsManagementHubSoftwarePackagesSoftwarePackageCollectionItemsSoftwareSourcesList>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubSoftwarePackages.DataOciOsManagementHubSoftwarePackagesSoftwarePackageCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciOsManagementHubSoftwarePackages.IDataOciOsManagementHubSoftwarePackagesSoftwarePackageCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubSoftwarePackages.IDataOciOsManagementHubSoftwarePackagesSoftwarePackageCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
