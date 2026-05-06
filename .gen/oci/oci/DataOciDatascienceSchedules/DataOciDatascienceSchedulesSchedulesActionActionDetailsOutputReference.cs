using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatascienceSchedules
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatascienceSchedules.DataOciDatascienceSchedulesSchedulesActionActionDetailsOutputReference), fullyQualifiedName: "oci.dataOciDatascienceSchedules.DataOciDatascienceSchedulesSchedulesActionActionDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatascienceSchedulesSchedulesActionActionDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatascienceSchedulesSchedulesActionActionDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatascienceSchedulesSchedulesActionActionDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatascienceSchedulesSchedulesActionActionDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "createJobRunDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceSchedules.DataOciDatascienceSchedulesSchedulesActionActionDetailsCreateJobRunDetailsList\"}")]
        public virtual oci.DataOciDatascienceSchedules.DataOciDatascienceSchedulesSchedulesActionActionDetailsCreateJobRunDetailsList CreateJobRunDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceSchedules.DataOciDatascienceSchedulesSchedulesActionActionDetailsCreateJobRunDetailsList>()!;
        }

        [JsiiProperty(name: "createPipelineRunDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceSchedules.DataOciDatascienceSchedulesSchedulesActionActionDetailsCreatePipelineRunDetailsList\"}")]
        public virtual oci.DataOciDatascienceSchedules.DataOciDatascienceSchedulesSchedulesActionActionDetailsCreatePipelineRunDetailsList CreatePipelineRunDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceSchedules.DataOciDatascienceSchedulesSchedulesActionActionDetailsCreatePipelineRunDetailsList>()!;
        }

        [JsiiProperty(name: "httpActionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HttpActionType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mlApplicationInstanceViewId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MlApplicationInstanceViewId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "triggerMlApplicationInstanceViewFlowDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceSchedules.DataOciDatascienceSchedulesSchedulesActionActionDetailsTriggerMlApplicationInstanceViewFlowDetailsList\"}")]
        public virtual oci.DataOciDatascienceSchedules.DataOciDatascienceSchedulesSchedulesActionActionDetailsTriggerMlApplicationInstanceViewFlowDetailsList TriggerMlApplicationInstanceViewFlowDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceSchedules.DataOciDatascienceSchedulesSchedulesActionActionDetailsTriggerMlApplicationInstanceViewFlowDetailsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatascienceSchedules.DataOciDatascienceSchedulesSchedulesActionActionDetails\"}", isOptional: true)]
        public virtual oci.DataOciDatascienceSchedules.IDataOciDatascienceSchedulesSchedulesActionActionDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatascienceSchedules.IDataOciDatascienceSchedulesSchedulesActionActionDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
