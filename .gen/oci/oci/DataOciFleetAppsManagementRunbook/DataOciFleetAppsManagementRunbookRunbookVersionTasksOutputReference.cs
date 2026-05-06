using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFleetAppsManagementRunbook
{
    [JsiiClass(nativeType: typeof(oci.DataOciFleetAppsManagementRunbook.DataOciFleetAppsManagementRunbookRunbookVersionTasksOutputReference), fullyQualifiedName: "oci.dataOciFleetAppsManagementRunbook.DataOciFleetAppsManagementRunbookRunbookVersionTasksOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciFleetAppsManagementRunbookRunbookVersionTasksOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciFleetAppsManagementRunbookRunbookVersionTasksOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciFleetAppsManagementRunbookRunbookVersionTasksOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFleetAppsManagementRunbookRunbookVersionTasksOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "outputVariableMappings", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementRunbook.DataOciFleetAppsManagementRunbookRunbookVersionTasksOutputVariableMappingsList\"}")]
        public virtual oci.DataOciFleetAppsManagementRunbook.DataOciFleetAppsManagementRunbookRunbookVersionTasksOutputVariableMappingsList OutputVariableMappings
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementRunbook.DataOciFleetAppsManagementRunbookRunbookVersionTasksOutputVariableMappingsList>()!;
        }

        [JsiiProperty(name: "stepName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StepName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stepProperties", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementRunbook.DataOciFleetAppsManagementRunbookRunbookVersionTasksStepPropertiesList\"}")]
        public virtual oci.DataOciFleetAppsManagementRunbook.DataOciFleetAppsManagementRunbookRunbookVersionTasksStepPropertiesList StepProperties
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementRunbook.DataOciFleetAppsManagementRunbookRunbookVersionTasksStepPropertiesList>()!;
        }

        [JsiiProperty(name: "taskRecordDetails", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementRunbook.DataOciFleetAppsManagementRunbookRunbookVersionTasksTaskRecordDetailsList\"}")]
        public virtual oci.DataOciFleetAppsManagementRunbook.DataOciFleetAppsManagementRunbookRunbookVersionTasksTaskRecordDetailsList TaskRecordDetails
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementRunbook.DataOciFleetAppsManagementRunbookRunbookVersionTasksTaskRecordDetailsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementRunbook.DataOciFleetAppsManagementRunbookRunbookVersionTasks\"}", isOptional: true)]
        public virtual oci.DataOciFleetAppsManagementRunbook.IDataOciFleetAppsManagementRunbookRunbookVersionTasks? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementRunbook.IDataOciFleetAppsManagementRunbookRunbookVersionTasks?>();
            set => SetInstanceProperty(value);
        }
    }
}
