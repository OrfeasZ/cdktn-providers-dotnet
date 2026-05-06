using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFleetAppsManagementRunbook
{
    [JsiiClass(nativeType: typeof(oci.DataOciFleetAppsManagementRunbook.DataOciFleetAppsManagementRunbookRunbookVersionOutputReference), fullyQualifiedName: "oci.dataOciFleetAppsManagementRunbook.DataOciFleetAppsManagementRunbookRunbookVersionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciFleetAppsManagementRunbookRunbookVersionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciFleetAppsManagementRunbookRunbookVersionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciFleetAppsManagementRunbookRunbookVersionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFleetAppsManagementRunbookRunbookVersionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "executionWorkflowDetails", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementRunbook.DataOciFleetAppsManagementRunbookRunbookVersionExecutionWorkflowDetailsList\"}")]
        public virtual oci.DataOciFleetAppsManagementRunbook.DataOciFleetAppsManagementRunbookRunbookVersionExecutionWorkflowDetailsList ExecutionWorkflowDetails
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementRunbook.DataOciFleetAppsManagementRunbookRunbookVersionExecutionWorkflowDetailsList>()!;
        }

        [JsiiProperty(name: "groups", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementRunbook.DataOciFleetAppsManagementRunbookRunbookVersionGroupsList\"}")]
        public virtual oci.DataOciFleetAppsManagementRunbook.DataOciFleetAppsManagementRunbookRunbookVersionGroupsList Groups
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementRunbook.DataOciFleetAppsManagementRunbookRunbookVersionGroupsList>()!;
        }

        [JsiiProperty(name: "isLatest", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsLatest
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "rollbackWorkflowDetails", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementRunbook.DataOciFleetAppsManagementRunbookRunbookVersionRollbackWorkflowDetailsList\"}")]
        public virtual oci.DataOciFleetAppsManagementRunbook.DataOciFleetAppsManagementRunbookRunbookVersionRollbackWorkflowDetailsList RollbackWorkflowDetails
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementRunbook.DataOciFleetAppsManagementRunbookRunbookVersionRollbackWorkflowDetailsList>()!;
        }

        [JsiiProperty(name: "tasks", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementRunbook.DataOciFleetAppsManagementRunbookRunbookVersionTasksList\"}")]
        public virtual oci.DataOciFleetAppsManagementRunbook.DataOciFleetAppsManagementRunbookRunbookVersionTasksList Tasks
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementRunbook.DataOciFleetAppsManagementRunbookRunbookVersionTasksList>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementRunbook.DataOciFleetAppsManagementRunbookRunbookVersion\"}", isOptional: true)]
        public virtual oci.DataOciFleetAppsManagementRunbook.IDataOciFleetAppsManagementRunbookRunbookVersion? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementRunbook.IDataOciFleetAppsManagementRunbookRunbookVersion?>();
            set => SetInstanceProperty(value);
        }
    }
}
