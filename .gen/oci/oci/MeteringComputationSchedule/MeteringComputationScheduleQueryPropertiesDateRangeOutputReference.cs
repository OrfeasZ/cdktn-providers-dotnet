using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MeteringComputationSchedule
{
    [JsiiClass(nativeType: typeof(oci.MeteringComputationSchedule.MeteringComputationScheduleQueryPropertiesDateRangeOutputReference), fullyQualifiedName: "oci.meteringComputationSchedule.MeteringComputationScheduleQueryPropertiesDateRangeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MeteringComputationScheduleQueryPropertiesDateRangeOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MeteringComputationScheduleQueryPropertiesDateRangeOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MeteringComputationScheduleQueryPropertiesDateRangeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MeteringComputationScheduleQueryPropertiesDateRangeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDynamicDateRangeType")]
        public virtual void ResetDynamicDateRangeType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeUsageEnded")]
        public virtual void ResetTimeUsageEnded()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeUsageStarted")]
        public virtual void ResetTimeUsageStarted()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "dateRangeTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DateRangeTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dynamicDateRangeTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DynamicDateRangeTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeUsageEndedInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeUsageEndedInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeUsageStartedInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeUsageStartedInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "dateRangeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DateRangeType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dynamicDateRangeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DynamicDateRangeType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeUsageEnded", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUsageEnded
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeUsageStarted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUsageStarted
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.meteringComputationSchedule.MeteringComputationScheduleQueryPropertiesDateRange\"}", isOptional: true)]
        public virtual oci.MeteringComputationSchedule.IMeteringComputationScheduleQueryPropertiesDateRange? InternalValue
        {
            get => GetInstanceProperty<oci.MeteringComputationSchedule.IMeteringComputationScheduleQueryPropertiesDateRange?>();
            set => SetInstanceProperty(value);
        }
    }
}
