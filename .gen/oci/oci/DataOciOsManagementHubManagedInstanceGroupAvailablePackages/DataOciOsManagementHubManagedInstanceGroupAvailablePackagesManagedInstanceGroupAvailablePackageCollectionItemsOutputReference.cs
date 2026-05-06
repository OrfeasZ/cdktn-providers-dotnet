using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOsManagementHubManagedInstanceGroupAvailablePackages
{
    [JsiiClass(nativeType: typeof(oci.DataOciOsManagementHubManagedInstanceGroupAvailablePackages.DataOciOsManagementHubManagedInstanceGroupAvailablePackagesManagedInstanceGroupAvailablePackageCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciOsManagementHubManagedInstanceGroupAvailablePackages.DataOciOsManagementHubManagedInstanceGroupAvailablePackagesManagedInstanceGroupAvailablePackageCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOsManagementHubManagedInstanceGroupAvailablePackagesManagedInstanceGroupAvailablePackageCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOsManagementHubManagedInstanceGroupAvailablePackagesManagedInstanceGroupAvailablePackageCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOsManagementHubManagedInstanceGroupAvailablePackagesManagedInstanceGroupAvailablePackageCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOsManagementHubManagedInstanceGroupAvailablePackagesManagedInstanceGroupAvailablePackageCollectionItemsOutputReference(DeputyProps props): base(props)
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

        [JsiiProperty(name: "isLatest", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsLatest
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "softwareSources", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubManagedInstanceGroupAvailablePackages.DataOciOsManagementHubManagedInstanceGroupAvailablePackagesManagedInstanceGroupAvailablePackageCollectionItemsSoftwareSourcesList\"}")]
        public virtual oci.DataOciOsManagementHubManagedInstanceGroupAvailablePackages.DataOciOsManagementHubManagedInstanceGroupAvailablePackagesManagedInstanceGroupAvailablePackageCollectionItemsSoftwareSourcesList SoftwareSources
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubManagedInstanceGroupAvailablePackages.DataOciOsManagementHubManagedInstanceGroupAvailablePackagesManagedInstanceGroupAvailablePackageCollectionItemsSoftwareSourcesList>()!;
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubManagedInstanceGroupAvailablePackages.DataOciOsManagementHubManagedInstanceGroupAvailablePackagesManagedInstanceGroupAvailablePackageCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciOsManagementHubManagedInstanceGroupAvailablePackages.IDataOciOsManagementHubManagedInstanceGroupAvailablePackagesManagedInstanceGroupAvailablePackageCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubManagedInstanceGroupAvailablePackages.IDataOciOsManagementHubManagedInstanceGroupAvailablePackagesManagedInstanceGroupAvailablePackageCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
