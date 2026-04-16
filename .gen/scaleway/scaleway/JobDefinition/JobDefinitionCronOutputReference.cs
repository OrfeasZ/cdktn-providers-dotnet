using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.JobDefinition
{
    [JsiiClass(nativeType: typeof(scaleway.JobDefinition.JobDefinitionCronOutputReference), fullyQualifiedName: "scaleway.jobDefinition.JobDefinitionCronOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class JobDefinitionCronOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public JobDefinitionCronOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected JobDefinitionCronOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected JobDefinitionCronOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "scheduleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScheduleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timezoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimezoneInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "schedule", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Schedule
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Timezone
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.jobDefinition.JobDefinitionCron\"}", isOptional: true)]
        public virtual scaleway.JobDefinition.IJobDefinitionCron? InternalValue
        {
            get => GetInstanceProperty<scaleway.JobDefinition.IJobDefinitionCron?>();
            set => SetInstanceProperty(value);
        }
    }
}
