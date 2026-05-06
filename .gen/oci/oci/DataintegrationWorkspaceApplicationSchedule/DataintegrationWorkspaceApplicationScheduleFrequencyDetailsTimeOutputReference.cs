using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceApplicationSchedule
{
    [JsiiClass(nativeType: typeof(oci.DataintegrationWorkspaceApplicationSchedule.DataintegrationWorkspaceApplicationScheduleFrequencyDetailsTimeOutputReference), fullyQualifiedName: "oci.dataintegrationWorkspaceApplicationSchedule.DataintegrationWorkspaceApplicationScheduleFrequencyDetailsTimeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataintegrationWorkspaceApplicationScheduleFrequencyDetailsTimeOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataintegrationWorkspaceApplicationScheduleFrequencyDetailsTimeOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataintegrationWorkspaceApplicationScheduleFrequencyDetailsTimeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataintegrationWorkspaceApplicationScheduleFrequencyDetailsTimeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetHour")]
        public virtual void ResetHour()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinute")]
        public virtual void ResetMinute()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecond")]
        public virtual void ResetSecond()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "hourInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HourInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minuteInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinuteInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secondInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SecondInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "hour", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Hour
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minute", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Minute
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "second", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Second
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceApplicationSchedule.DataintegrationWorkspaceApplicationScheduleFrequencyDetailsTime\"}", isOptional: true)]
        public virtual oci.DataintegrationWorkspaceApplicationSchedule.IDataintegrationWorkspaceApplicationScheduleFrequencyDetailsTime? InternalValue
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceApplicationSchedule.IDataintegrationWorkspaceApplicationScheduleFrequencyDetailsTime?>();
            set => SetInstanceProperty(value);
        }
    }
}
