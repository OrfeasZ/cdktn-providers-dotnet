using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOsManagementHubManagedInstanceGroupAvailablePackages
{
    [JsiiClass(nativeType: typeof(oci.DataOciOsManagementHubManagedInstanceGroupAvailablePackages.DataOciOsManagementHubManagedInstanceGroupAvailablePackagesManagedInstanceGroupAvailablePackageCollectionOutputReference), fullyQualifiedName: "oci.dataOciOsManagementHubManagedInstanceGroupAvailablePackages.DataOciOsManagementHubManagedInstanceGroupAvailablePackagesManagedInstanceGroupAvailablePackageCollectionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOsManagementHubManagedInstanceGroupAvailablePackagesManagedInstanceGroupAvailablePackageCollectionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOsManagementHubManagedInstanceGroupAvailablePackagesManagedInstanceGroupAvailablePackageCollectionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOsManagementHubManagedInstanceGroupAvailablePackagesManagedInstanceGroupAvailablePackageCollectionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOsManagementHubManagedInstanceGroupAvailablePackagesManagedInstanceGroupAvailablePackageCollectionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "items", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubManagedInstanceGroupAvailablePackages.DataOciOsManagementHubManagedInstanceGroupAvailablePackagesManagedInstanceGroupAvailablePackageCollectionItemsList\"}")]
        public virtual oci.DataOciOsManagementHubManagedInstanceGroupAvailablePackages.DataOciOsManagementHubManagedInstanceGroupAvailablePackagesManagedInstanceGroupAvailablePackageCollectionItemsList Items
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubManagedInstanceGroupAvailablePackages.DataOciOsManagementHubManagedInstanceGroupAvailablePackagesManagedInstanceGroupAvailablePackageCollectionItemsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubManagedInstanceGroupAvailablePackages.DataOciOsManagementHubManagedInstanceGroupAvailablePackagesManagedInstanceGroupAvailablePackageCollection\"}", isOptional: true)]
        public virtual oci.DataOciOsManagementHubManagedInstanceGroupAvailablePackages.IDataOciOsManagementHubManagedInstanceGroupAvailablePackagesManagedInstanceGroupAvailablePackageCollection? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubManagedInstanceGroupAvailablePackages.IDataOciOsManagementHubManagedInstanceGroupAvailablePackagesManagedInstanceGroupAvailablePackageCollection?>();
            set => SetInstanceProperty(value);
        }
    }
}
