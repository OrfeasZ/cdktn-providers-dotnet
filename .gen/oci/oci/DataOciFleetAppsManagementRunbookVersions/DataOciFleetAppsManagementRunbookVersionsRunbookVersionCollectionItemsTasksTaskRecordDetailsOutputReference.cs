using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFleetAppsManagementRunbookVersions
{
    [JsiiClass(nativeType: typeof(oci.DataOciFleetAppsManagementRunbookVersions.DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsTasksTaskRecordDetailsOutputReference), fullyQualifiedName: "oci.dataOciFleetAppsManagementRunbookVersions.DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsTasksTaskRecordDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsTasksTaskRecordDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsTasksTaskRecordDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsTasksTaskRecordDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsTasksTaskRecordDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "executionDetails", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementRunbookVersions.DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsTasksTaskRecordDetailsExecutionDetailsList\"}")]
        public virtual oci.DataOciFleetAppsManagementRunbookVersions.DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsTasksTaskRecordDetailsExecutionDetailsList ExecutionDetails
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementRunbookVersions.DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsTasksTaskRecordDetailsExecutionDetailsList>()!;
        }

        [JsiiProperty(name: "isApplySubjectTask", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsApplySubjectTask
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isCopyToLibraryEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsCopyToLibraryEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isDiscoveryOutputTask", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsDiscoveryOutputTask
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "osType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OsType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "platform", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Platform
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "properties", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementRunbookVersions.DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsTasksTaskRecordDetailsPropertiesList\"}")]
        public virtual oci.DataOciFleetAppsManagementRunbookVersions.DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsTasksTaskRecordDetailsPropertiesList Properties
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementRunbookVersions.DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsTasksTaskRecordDetailsPropertiesList>()!;
        }

        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Scope
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "taskRecordId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaskRecordId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementRunbookVersions.DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsTasksTaskRecordDetails\"}", isOptional: true)]
        public virtual oci.DataOciFleetAppsManagementRunbookVersions.IDataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsTasksTaskRecordDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementRunbookVersions.IDataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsTasksTaskRecordDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
