using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataintegrationWorkspaceTasks
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsPollRestCallConfigConfigValuesConfigParamValuesOutputReference), fullyQualifiedName: "oci.dataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsPollRestCallConfigConfigValuesConfigParamValuesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsPollRestCallConfigConfigValuesConfigParamValuesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsPollRestCallConfigConfigValuesConfigParamValuesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsPollRestCallConfigConfigValuesConfigParamValuesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsPollRestCallConfigConfigValuesConfigParamValuesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "pollCondition", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsPollRestCallConfigConfigValuesConfigParamValuesPollConditionList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsPollRestCallConfigConfigValuesConfigParamValuesPollConditionList PollCondition
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsPollRestCallConfigConfigValuesConfigParamValuesPollConditionList>()!;
        }

        [JsiiProperty(name: "pollInterval", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsPollRestCallConfigConfigValuesConfigParamValuesPollIntervalList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsPollRestCallConfigConfigValuesConfigParamValuesPollIntervalList PollInterval
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsPollRestCallConfigConfigValuesConfigParamValuesPollIntervalList>()!;
        }

        [JsiiProperty(name: "pollIntervalUnit", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsPollRestCallConfigConfigValuesConfigParamValuesPollIntervalUnitList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsPollRestCallConfigConfigValuesConfigParamValuesPollIntervalUnitList PollIntervalUnit
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsPollRestCallConfigConfigValuesConfigParamValuesPollIntervalUnitList>()!;
        }

        [JsiiProperty(name: "pollMaxDuration", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsPollRestCallConfigConfigValuesConfigParamValuesPollMaxDurationList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsPollRestCallConfigConfigValuesConfigParamValuesPollMaxDurationList PollMaxDuration
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsPollRestCallConfigConfigValuesConfigParamValuesPollMaxDurationList>()!;
        }

        [JsiiProperty(name: "pollMaxDurationUnit", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsPollRestCallConfigConfigValuesConfigParamValuesPollMaxDurationUnitList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsPollRestCallConfigConfigValuesConfigParamValuesPollMaxDurationUnitList PollMaxDurationUnit
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsPollRestCallConfigConfigValuesConfigParamValuesPollMaxDurationUnitList>()!;
        }

        [JsiiProperty(name: "requestPayload", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsPollRestCallConfigConfigValuesConfigParamValuesRequestPayloadList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsPollRestCallConfigConfigValuesConfigParamValuesRequestPayloadList RequestPayload
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsPollRestCallConfigConfigValuesConfigParamValuesRequestPayloadList>()!;
        }

        [JsiiProperty(name: "requestUrl", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsPollRestCallConfigConfigValuesConfigParamValuesRequestUrlList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsPollRestCallConfigConfigValuesConfigParamValuesRequestUrlList RequestUrl
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsPollRestCallConfigConfigValuesConfigParamValuesRequestUrlList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceTasks.DataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsPollRestCallConfigConfigValuesConfigParamValues\"}", isOptional: true)]
        public virtual oci.DataOciDataintegrationWorkspaceTasks.IDataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsPollRestCallConfigConfigValuesConfigParamValues? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceTasks.IDataOciDataintegrationWorkspaceTasksTaskSummaryCollectionItemsPollRestCallConfigConfigValuesConfigParamValues?>();
            set => SetInstanceProperty(value);
        }
    }
}
