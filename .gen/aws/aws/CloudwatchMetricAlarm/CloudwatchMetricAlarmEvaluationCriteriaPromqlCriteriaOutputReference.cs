using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchMetricAlarm
{
    [JsiiClass(nativeType: typeof(aws.CloudwatchMetricAlarm.CloudwatchMetricAlarmEvaluationCriteriaPromqlCriteriaOutputReference), fullyQualifiedName: "aws.cloudwatchMetricAlarm.CloudwatchMetricAlarmEvaluationCriteriaPromqlCriteriaOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudwatchMetricAlarmEvaluationCriteriaPromqlCriteriaOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudwatchMetricAlarmEvaluationCriteriaPromqlCriteriaOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CloudwatchMetricAlarmEvaluationCriteriaPromqlCriteriaOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchMetricAlarmEvaluationCriteriaPromqlCriteriaOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetPendingPeriod")]
        public virtual void ResetPendingPeriod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRecoveryPeriod")]
        public virtual void ResetRecoveryPeriod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "pendingPeriodInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PendingPeriodInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? QueryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "recoveryPeriodInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RecoveryPeriodInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "pendingPeriod", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PendingPeriod
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Query
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "recoveryPeriod", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RecoveryPeriod
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudwatchMetricAlarm.CloudwatchMetricAlarmEvaluationCriteriaPromqlCriteria\"}", isOptional: true)]
        public virtual aws.CloudwatchMetricAlarm.ICloudwatchMetricAlarmEvaluationCriteriaPromqlCriteria? InternalValue
        {
            get => GetInstanceProperty<aws.CloudwatchMetricAlarm.ICloudwatchMetricAlarmEvaluationCriteriaPromqlCriteria?>();
            set => SetInstanceProperty(value);
        }
    }
}
