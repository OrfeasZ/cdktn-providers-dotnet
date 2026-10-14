using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchMetricAlarm
{
    [JsiiClass(nativeType: typeof(aws.CloudwatchMetricAlarm.CloudwatchMetricAlarmEvaluationWindowOutputReference), fullyQualifiedName: "aws.cloudwatchMetricAlarm.CloudwatchMetricAlarmEvaluationWindowOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudwatchMetricAlarmEvaluationWindowOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudwatchMetricAlarmEvaluationWindowOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CloudwatchMetricAlarmEvaluationWindowOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchMetricAlarmEvaluationWindowOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putWallClockWindow", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudwatchMetricAlarm.CloudwatchMetricAlarmEvaluationWindowWallClockWindow\"}}]")]
        public virtual void PutWallClockWindow(aws.CloudwatchMetricAlarm.ICloudwatchMetricAlarmEvaluationWindowWallClockWindow @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudwatchMetricAlarm.ICloudwatchMetricAlarmEvaluationWindowWallClockWindow)}, new object[]{@value});
        }

        [JsiiProperty(name: "wallClockWindow", typeJson: "{\"fqn\":\"aws.cloudwatchMetricAlarm.CloudwatchMetricAlarmEvaluationWindowWallClockWindowOutputReference\"}")]
        public virtual aws.CloudwatchMetricAlarm.CloudwatchMetricAlarmEvaluationWindowWallClockWindowOutputReference WallClockWindow
        {
            get => GetInstanceProperty<aws.CloudwatchMetricAlarm.CloudwatchMetricAlarmEvaluationWindowWallClockWindowOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "wallClockWindowInput", typeJson: "{\"fqn\":\"aws.cloudwatchMetricAlarm.CloudwatchMetricAlarmEvaluationWindowWallClockWindow\"}", isOptional: true)]
        public virtual aws.CloudwatchMetricAlarm.ICloudwatchMetricAlarmEvaluationWindowWallClockWindow? WallClockWindowInput
        {
            get => GetInstanceProperty<aws.CloudwatchMetricAlarm.ICloudwatchMetricAlarmEvaluationWindowWallClockWindow?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudwatchMetricAlarm.CloudwatchMetricAlarmEvaluationWindow\"}", isOptional: true)]
        public virtual aws.CloudwatchMetricAlarm.ICloudwatchMetricAlarmEvaluationWindow? InternalValue
        {
            get => GetInstanceProperty<aws.CloudwatchMetricAlarm.ICloudwatchMetricAlarmEvaluationWindow?>();
            set => SetInstanceProperty(value);
        }
    }
}
