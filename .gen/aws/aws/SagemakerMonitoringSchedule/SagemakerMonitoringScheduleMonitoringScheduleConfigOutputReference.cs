using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerMonitoringSchedule
{
    [JsiiClass(nativeType: typeof(aws.SagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigOutputReference), fullyQualifiedName: "aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SagemakerMonitoringScheduleMonitoringScheduleConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SagemakerMonitoringScheduleMonitoringScheduleConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SagemakerMonitoringScheduleMonitoringScheduleConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerMonitoringScheduleMonitoringScheduleConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putMonitoringJobDefinition", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinition\"}}]")]
        public virtual void PutMonitoringJobDefinition(aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinition @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinition)}, new object[]{@value});
        }

        [JsiiMethod(name: "putScheduleConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigScheduleConfig\"}}]")]
        public virtual void PutScheduleConfig(aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigScheduleConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigScheduleConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMonitoringJobDefinition")]
        public virtual void ResetMonitoringJobDefinition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMonitoringJobDefinitionName")]
        public virtual void ResetMonitoringJobDefinitionName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScheduleConfig")]
        public virtual void ResetScheduleConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "monitoringJobDefinition", typeJson: "{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionOutputReference\"}")]
        public virtual aws.SagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionOutputReference MonitoringJobDefinition
        {
            get => GetInstanceProperty<aws.SagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionOutputReference>()!;
        }

        [JsiiProperty(name: "scheduleConfig", typeJson: "{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigScheduleConfigOutputReference\"}")]
        public virtual aws.SagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigScheduleConfigOutputReference ScheduleConfig
        {
            get => GetInstanceProperty<aws.SagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigScheduleConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "monitoringJobDefinitionInput", typeJson: "{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinition\"}", isOptional: true)]
        public virtual aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinition? MonitoringJobDefinitionInput
        {
            get => GetInstanceProperty<aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinition?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "monitoringJobDefinitionNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MonitoringJobDefinitionNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "monitoringTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MonitoringTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scheduleConfigInput", typeJson: "{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigScheduleConfig\"}", isOptional: true)]
        public virtual aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigScheduleConfig? ScheduleConfigInput
        {
            get => GetInstanceProperty<aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigScheduleConfig?>();
        }

        [JsiiProperty(name: "monitoringJobDefinitionName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MonitoringJobDefinitionName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "monitoringType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MonitoringType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfig\"}", isOptional: true)]
        public virtual aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfig? InternalValue
        {
            get => GetInstanceProperty<aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
