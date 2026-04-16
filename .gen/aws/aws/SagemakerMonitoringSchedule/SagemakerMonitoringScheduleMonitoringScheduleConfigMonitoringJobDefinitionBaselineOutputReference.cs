using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerMonitoringSchedule
{
    [JsiiClass(nativeType: typeof(aws.SagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaselineOutputReference), fullyQualifiedName: "aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaselineOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaselineOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaselineOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaselineOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaselineOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putConstraintsResource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaselineConstraintsResource\"}}]")]
        public virtual void PutConstraintsResource(aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaselineConstraintsResource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaselineConstraintsResource)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStatisticsResource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaselineStatisticsResource\"}}]")]
        public virtual void PutStatisticsResource(aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaselineStatisticsResource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaselineStatisticsResource)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBaseliningJobName")]
        public virtual void ResetBaseliningJobName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConstraintsResource")]
        public virtual void ResetConstraintsResource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStatisticsResource")]
        public virtual void ResetStatisticsResource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "constraintsResource", typeJson: "{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaselineConstraintsResourceOutputReference\"}")]
        public virtual aws.SagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaselineConstraintsResourceOutputReference ConstraintsResource
        {
            get => GetInstanceProperty<aws.SagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaselineConstraintsResourceOutputReference>()!;
        }

        [JsiiProperty(name: "statisticsResource", typeJson: "{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaselineStatisticsResourceOutputReference\"}")]
        public virtual aws.SagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaselineStatisticsResourceOutputReference StatisticsResource
        {
            get => GetInstanceProperty<aws.SagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaselineStatisticsResourceOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "baseliningJobNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BaseliningJobNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "constraintsResourceInput", typeJson: "{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaselineConstraintsResource\"}", isOptional: true)]
        public virtual aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaselineConstraintsResource? ConstraintsResourceInput
        {
            get => GetInstanceProperty<aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaselineConstraintsResource?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statisticsResourceInput", typeJson: "{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaselineStatisticsResource\"}", isOptional: true)]
        public virtual aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaselineStatisticsResource? StatisticsResourceInput
        {
            get => GetInstanceProperty<aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaselineStatisticsResource?>();
        }

        [JsiiProperty(name: "baseliningJobName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BaseliningJobName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaseline\"}", isOptional: true)]
        public virtual aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaseline? InternalValue
        {
            get => GetInstanceProperty<aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaseline?>();
            set => SetInstanceProperty(value);
        }
    }
}
