using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceApplicationTaskSchedule
{
    [JsiiClass(nativeType: typeof(oci.DataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetailsOutputReference), fullyQualifiedName: "oci.dataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTime", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetailsTime\"}}]")]
        public virtual void PutTime(oci.DataintegrationWorkspaceApplicationTaskSchedule.IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetailsTime @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataintegrationWorkspaceApplicationTaskSchedule.IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetailsTime)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCustomExpression")]
        public virtual void ResetCustomExpression()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDayOfWeek")]
        public virtual void ResetDayOfWeek()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDays")]
        public virtual void ResetDays()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFrequency")]
        public virtual void ResetFrequency()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInterval")]
        public virtual void ResetInterval()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTime")]
        public virtual void ResetTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWeekOfMonth")]
        public virtual void ResetWeekOfMonth()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "time", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetailsTimeOutputReference\"}")]
        public virtual oci.DataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetailsTimeOutputReference Time
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetailsTimeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "customExpressionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomExpressionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dayOfWeekInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DayOfWeekInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "daysInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual double[]? DaysInput
        {
            get => GetInstanceProperty<double[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "frequencyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FrequencyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "intervalInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? IntervalInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModelTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeInput", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetailsTime\"}", isOptional: true)]
        public virtual oci.DataintegrationWorkspaceApplicationTaskSchedule.IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetailsTime? TimeInput
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceApplicationTaskSchedule.IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetailsTime?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "weekOfMonthInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WeekOfMonthInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "customExpression", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomExpression
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DayOfWeek
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "days", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public virtual double[] Days
        {
            get => GetInstanceProperty<double[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "frequency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Frequency
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Interval
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "modelType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "weekOfMonth", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WeekOfMonth
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetails\"}", isOptional: true)]
        public virtual oci.DataintegrationWorkspaceApplicationTaskSchedule.IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceApplicationTaskSchedule.IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
