using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFleetAppsManagementRunbookVersions
{
    [JsiiClass(nativeType: typeof(oci.DataOciFleetAppsManagementRunbookVersions.DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciFleetAppsManagementRunbookVersions.DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsOutputReference(DeputyProps props): base(props)
        {
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

        [JsiiProperty(name: "executionWorkflowDetails", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementRunbookVersions.DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsExecutionWorkflowDetailsList\"}")]
        public virtual oci.DataOciFleetAppsManagementRunbookVersions.DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsExecutionWorkflowDetailsList ExecutionWorkflowDetails
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementRunbookVersions.DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsExecutionWorkflowDetailsList>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "groups", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementRunbookVersions.DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsGroupsList\"}")]
        public virtual oci.DataOciFleetAppsManagementRunbookVersions.DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsGroupsList Groups
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementRunbookVersions.DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsGroupsList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isLatest", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsLatest
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rollbackWorkflowDetails", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementRunbookVersions.DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsRollbackWorkflowDetailsList\"}")]
        public virtual oci.DataOciFleetAppsManagementRunbookVersions.DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsRollbackWorkflowDetailsList RollbackWorkflowDetails
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementRunbookVersions.DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsRollbackWorkflowDetailsList>()!;
        }

        [JsiiProperty(name: "runbookId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RunbookId
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

        [JsiiProperty(name: "tasks", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementRunbookVersions.DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsTasksList\"}")]
        public virtual oci.DataOciFleetAppsManagementRunbookVersions.DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsTasksList Tasks
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementRunbookVersions.DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItemsTasksList>()!;
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementRunbookVersions.DataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciFleetAppsManagementRunbookVersions.IDataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementRunbookVersions.IDataOciFleetAppsManagementRunbookVersionsRunbookVersionCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
