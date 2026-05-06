using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFleetAppsManagementRunbooks
{
    [JsiiClass(nativeType: typeof(oci.DataOciFleetAppsManagementRunbooks.DataOciFleetAppsManagementRunbooksRunbookCollectionItemsRunbookVersionOutputReference), fullyQualifiedName: "oci.dataOciFleetAppsManagementRunbooks.DataOciFleetAppsManagementRunbooksRunbookCollectionItemsRunbookVersionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciFleetAppsManagementRunbooksRunbookCollectionItemsRunbookVersionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciFleetAppsManagementRunbooksRunbookCollectionItemsRunbookVersionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciFleetAppsManagementRunbooksRunbookCollectionItemsRunbookVersionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFleetAppsManagementRunbooksRunbookCollectionItemsRunbookVersionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "executionWorkflowDetails", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementRunbooks.DataOciFleetAppsManagementRunbooksRunbookCollectionItemsRunbookVersionExecutionWorkflowDetailsList\"}")]
        public virtual oci.DataOciFleetAppsManagementRunbooks.DataOciFleetAppsManagementRunbooksRunbookCollectionItemsRunbookVersionExecutionWorkflowDetailsList ExecutionWorkflowDetails
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementRunbooks.DataOciFleetAppsManagementRunbooksRunbookCollectionItemsRunbookVersionExecutionWorkflowDetailsList>()!;
        }

        [JsiiProperty(name: "groups", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementRunbooks.DataOciFleetAppsManagementRunbooksRunbookCollectionItemsRunbookVersionGroupsList\"}")]
        public virtual oci.DataOciFleetAppsManagementRunbooks.DataOciFleetAppsManagementRunbooksRunbookCollectionItemsRunbookVersionGroupsList Groups
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementRunbooks.DataOciFleetAppsManagementRunbooksRunbookCollectionItemsRunbookVersionGroupsList>()!;
        }

        [JsiiProperty(name: "isLatest", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsLatest
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "rollbackWorkflowDetails", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementRunbooks.DataOciFleetAppsManagementRunbooksRunbookCollectionItemsRunbookVersionRollbackWorkflowDetailsList\"}")]
        public virtual oci.DataOciFleetAppsManagementRunbooks.DataOciFleetAppsManagementRunbooksRunbookCollectionItemsRunbookVersionRollbackWorkflowDetailsList RollbackWorkflowDetails
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementRunbooks.DataOciFleetAppsManagementRunbooksRunbookCollectionItemsRunbookVersionRollbackWorkflowDetailsList>()!;
        }

        [JsiiProperty(name: "tasks", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementRunbooks.DataOciFleetAppsManagementRunbooksRunbookCollectionItemsRunbookVersionTasksList\"}")]
        public virtual oci.DataOciFleetAppsManagementRunbooks.DataOciFleetAppsManagementRunbooksRunbookCollectionItemsRunbookVersionTasksList Tasks
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementRunbooks.DataOciFleetAppsManagementRunbooksRunbookCollectionItemsRunbookVersionTasksList>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementRunbooks.DataOciFleetAppsManagementRunbooksRunbookCollectionItemsRunbookVersion\"}", isOptional: true)]
        public virtual oci.DataOciFleetAppsManagementRunbooks.IDataOciFleetAppsManagementRunbooksRunbookCollectionItemsRunbookVersion? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementRunbooks.IDataOciFleetAppsManagementRunbooksRunbookCollectionItemsRunbookVersion?>();
            set => SetInstanceProperty(value);
        }
    }
}
