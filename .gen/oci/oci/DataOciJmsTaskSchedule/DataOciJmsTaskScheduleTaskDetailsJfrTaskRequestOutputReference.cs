using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciJmsTaskSchedule
{
    [JsiiClass(nativeType: typeof(oci.DataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsJfrTaskRequestOutputReference), fullyQualifiedName: "oci.dataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsJfrTaskRequestOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciJmsTaskScheduleTaskDetailsJfrTaskRequestOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciJmsTaskScheduleTaskDetailsJfrTaskRequestOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciJmsTaskScheduleTaskDetailsJfrTaskRequestOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciJmsTaskScheduleTaskDetailsJfrTaskRequestOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "jfcProfileName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JfcProfileName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jfcV1", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JfcV1
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jfcV2", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JfcV2
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "recordingDurationInMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RecordingDurationInMinutes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "recordingSizeInMb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RecordingSizeInMb
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "targets", typeJson: "{\"fqn\":\"oci.dataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsJfrTaskRequestTargetsList\"}")]
        public virtual oci.DataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsJfrTaskRequestTargetsList Targets
        {
            get => GetInstanceProperty<oci.DataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsJfrTaskRequestTargetsList>()!;
        }

        [JsiiProperty(name: "waitingPeriodInMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WaitingPeriodInMinutes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsJfrTaskRequest\"}", isOptional: true)]
        public virtual oci.DataOciJmsTaskSchedule.IDataOciJmsTaskScheduleTaskDetailsJfrTaskRequest? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciJmsTaskSchedule.IDataOciJmsTaskScheduleTaskDetailsJfrTaskRequest?>();
            set => SetInstanceProperty(value);
        }
    }
}
