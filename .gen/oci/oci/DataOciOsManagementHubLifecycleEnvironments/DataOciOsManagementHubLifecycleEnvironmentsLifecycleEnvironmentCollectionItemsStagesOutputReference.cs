using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOsManagementHubLifecycleEnvironments
{
    [JsiiClass(nativeType: typeof(oci.DataOciOsManagementHubLifecycleEnvironments.DataOciOsManagementHubLifecycleEnvironmentsLifecycleEnvironmentCollectionItemsStagesOutputReference), fullyQualifiedName: "oci.dataOciOsManagementHubLifecycleEnvironments.DataOciOsManagementHubLifecycleEnvironmentsLifecycleEnvironmentCollectionItemsStagesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOsManagementHubLifecycleEnvironmentsLifecycleEnvironmentCollectionItemsStagesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOsManagementHubLifecycleEnvironmentsLifecycleEnvironmentCollectionItemsStagesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOsManagementHubLifecycleEnvironmentsLifecycleEnvironmentCollectionItemsStagesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOsManagementHubLifecycleEnvironmentsLifecycleEnvironmentCollectionItemsStagesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "archType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ArchType
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

        [JsiiProperty(name: "lifecycleEnvironmentDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleEnvironmentDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleEnvironmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleEnvironmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managedInstances", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ManagedInstances
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "osFamily", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OsFamily
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rank", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Rank
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "softwareSourceId", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubLifecycleEnvironments.DataOciOsManagementHubLifecycleEnvironmentsLifecycleEnvironmentCollectionItemsStagesSoftwareSourceIdList\"}")]
        public virtual oci.DataOciOsManagementHubLifecycleEnvironments.DataOciOsManagementHubLifecycleEnvironmentsLifecycleEnvironmentCollectionItemsStagesSoftwareSourceIdList SoftwareSourceId
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubLifecycleEnvironments.DataOciOsManagementHubLifecycleEnvironmentsLifecycleEnvironmentCollectionItemsStagesSoftwareSourceIdList>()!;
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

        [JsiiProperty(name: "timeModified", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeModified
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vendorName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VendorName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubLifecycleEnvironments.DataOciOsManagementHubLifecycleEnvironmentsLifecycleEnvironmentCollectionItemsStages\"}", isOptional: true)]
        public virtual oci.DataOciOsManagementHubLifecycleEnvironments.IDataOciOsManagementHubLifecycleEnvironmentsLifecycleEnvironmentCollectionItemsStages? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubLifecycleEnvironments.IDataOciOsManagementHubLifecycleEnvironmentsLifecycleEnvironmentCollectionItemsStages?>();
            set => SetInstanceProperty(value);
        }
    }
}
