using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxFunctionAppSlot
{
    [JsiiClass(nativeType: typeof(azurerm.LinuxFunctionAppSlot.LinuxFunctionAppSlotBackupScheduleOutputReference), fullyQualifiedName: "azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotBackupScheduleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LinuxFunctionAppSlotBackupScheduleOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LinuxFunctionAppSlotBackupScheduleOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LinuxFunctionAppSlotBackupScheduleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LinuxFunctionAppSlotBackupScheduleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetKeepAtLeastOneBackup")]
        public virtual void ResetKeepAtLeastOneBackup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetentionPeriodDays")]
        public virtual void ResetRetentionPeriodDays()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStartTime")]
        public virtual void ResetStartTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "lastExecutionTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastExecutionTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "frequencyIntervalInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? FrequencyIntervalInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "frequencyUnitInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FrequencyUnitInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keepAtLeastOneBackupInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? KeepAtLeastOneBackupInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retentionPeriodDaysInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RetentionPeriodDaysInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "startTimeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StartTimeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "frequencyInterval", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FrequencyInterval
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "frequencyUnit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FrequencyUnit
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "keepAtLeastOneBackup", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object KeepAtLeastOneBackup
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "retentionPeriodDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RetentionPeriodDays
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartTime
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotBackupSchedule\"}", isOptional: true)]
        public virtual azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotBackupSchedule? InternalValue
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotBackupSchedule?>();
            set => SetInstanceProperty(value);
        }
    }
}
