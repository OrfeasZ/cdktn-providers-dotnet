using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatascienceSchedule
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatascienceSchedule.DataOciDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsOutputReference), fullyQualifiedName: "oci.dataOciDatascienceSchedule.DataOciDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configurationOverrideDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceSchedule.DataOciDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsConfigurationOverrideDetailsList\"}")]
        public virtual oci.DataOciDatascienceSchedule.DataOciDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsConfigurationOverrideDetailsList ConfigurationOverrideDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceSchedule.DataOciDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsConfigurationOverrideDetailsList>()!;
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

        [JsiiProperty(name: "logConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceSchedule.DataOciDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsLogConfigurationOverrideDetailsList\"}")]
        public virtual oci.DataOciDatascienceSchedule.DataOciDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsLogConfigurationOverrideDetailsList LogConfigurationOverrideDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceSchedule.DataOciDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsLogConfigurationOverrideDetailsList>()!;
        }

        [JsiiProperty(name: "pipelineId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PipelineId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stepOverrideDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceSchedule.DataOciDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetailsList\"}")]
        public virtual oci.DataOciDatascienceSchedule.DataOciDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetailsList StepOverrideDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceSchedule.DataOciDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetailsList>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatascienceSchedule.DataOciDatascienceScheduleActionActionDetailsCreatePipelineRunDetails\"}", isOptional: true)]
        public virtual oci.DataOciDatascienceSchedule.IDataOciDatascienceScheduleActionActionDetailsCreatePipelineRunDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatascienceSchedule.IDataOciDatascienceScheduleActionActionDetailsCreatePipelineRunDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
