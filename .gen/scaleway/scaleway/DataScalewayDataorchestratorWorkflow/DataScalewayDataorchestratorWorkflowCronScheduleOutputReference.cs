using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayDataorchestratorWorkflow
{
    [JsiiClass(nativeType: typeof(scaleway.DataScalewayDataorchestratorWorkflow.DataScalewayDataorchestratorWorkflowCronScheduleOutputReference), fullyQualifiedName: "scaleway.dataScalewayDataorchestratorWorkflow.DataScalewayDataorchestratorWorkflowCronScheduleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataScalewayDataorchestratorWorkflowCronScheduleOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataScalewayDataorchestratorWorkflowCronScheduleOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayDataorchestratorWorkflowCronScheduleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayDataorchestratorWorkflowCronScheduleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "overlap", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Overlap
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "schedule", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Schedule
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timezoneIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimezoneIdentifier
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.dataScalewayDataorchestratorWorkflow.DataScalewayDataorchestratorWorkflowCronSchedule\"}", isOptional: true)]
        public virtual scaleway.DataScalewayDataorchestratorWorkflow.IDataScalewayDataorchestratorWorkflowCronSchedule? InternalValue
        {
            get => GetInstanceProperty<scaleway.DataScalewayDataorchestratorWorkflow.IDataScalewayDataorchestratorWorkflowCronSchedule?>();
            set => SetInstanceProperty(value);
        }
    }
}
