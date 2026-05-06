using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseSchedulingPolicySchedulingWindow
{
    [JsiiClass(nativeType: typeof(oci.DatabaseSchedulingPolicySchedulingWindow.DatabaseSchedulingPolicySchedulingWindowWindowPreferenceOutputReference), fullyQualifiedName: "oci.databaseSchedulingPolicySchedulingWindow.DatabaseSchedulingPolicySchedulingWindowWindowPreferenceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatabaseSchedulingPolicySchedulingWindowWindowPreferenceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatabaseSchedulingPolicySchedulingWindowWindowPreferenceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatabaseSchedulingPolicySchedulingWindowWindowPreferenceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseSchedulingPolicySchedulingWindowWindowPreferenceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDaysOfWeek", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseSchedulingPolicySchedulingWindow.DatabaseSchedulingPolicySchedulingWindowWindowPreferenceDaysOfWeek\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDaysOfWeek(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DatabaseSchedulingPolicySchedulingWindow.IDatabaseSchedulingPolicySchedulingWindowWindowPreferenceDaysOfWeek[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseSchedulingPolicySchedulingWindow.IDatabaseSchedulingPolicySchedulingWindowWindowPreferenceDaysOfWeek).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseSchedulingPolicySchedulingWindow.IDatabaseSchedulingPolicySchedulingWindowWindowPreferenceDaysOfWeek).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMonths", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseSchedulingPolicySchedulingWindow.DatabaseSchedulingPolicySchedulingWindowWindowPreferenceMonths\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutMonths(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DatabaseSchedulingPolicySchedulingWindow.IDatabaseSchedulingPolicySchedulingWindowWindowPreferenceMonths[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseSchedulingPolicySchedulingWindow.IDatabaseSchedulingPolicySchedulingWindowWindowPreferenceMonths).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseSchedulingPolicySchedulingWindow.IDatabaseSchedulingPolicySchedulingWindowWindowPreferenceMonths).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiProperty(name: "daysOfWeek", typeJson: "{\"fqn\":\"oci.databaseSchedulingPolicySchedulingWindow.DatabaseSchedulingPolicySchedulingWindowWindowPreferenceDaysOfWeekList\"}")]
        public virtual oci.DatabaseSchedulingPolicySchedulingWindow.DatabaseSchedulingPolicySchedulingWindowWindowPreferenceDaysOfWeekList DaysOfWeek
        {
            get => GetInstanceProperty<oci.DatabaseSchedulingPolicySchedulingWindow.DatabaseSchedulingPolicySchedulingWindowWindowPreferenceDaysOfWeekList>()!;
        }

        [JsiiProperty(name: "months", typeJson: "{\"fqn\":\"oci.databaseSchedulingPolicySchedulingWindow.DatabaseSchedulingPolicySchedulingWindowWindowPreferenceMonthsList\"}")]
        public virtual oci.DatabaseSchedulingPolicySchedulingWindow.DatabaseSchedulingPolicySchedulingWindowWindowPreferenceMonthsList Months
        {
            get => GetInstanceProperty<oci.DatabaseSchedulingPolicySchedulingWindow.DatabaseSchedulingPolicySchedulingWindowWindowPreferenceMonthsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "daysOfWeekInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseSchedulingPolicySchedulingWindow.DatabaseSchedulingPolicySchedulingWindowWindowPreferenceDaysOfWeek\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DaysOfWeekInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "durationInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DurationInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isEnforcedDurationInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsEnforcedDurationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "monthsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseSchedulingPolicySchedulingWindow.DatabaseSchedulingPolicySchedulingWindowWindowPreferenceMonths\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? MonthsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "startTimeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StartTimeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "weeksOfMonthInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual double[]? WeeksOfMonthInput
        {
            get => GetInstanceProperty<double[]?>();
        }

        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Duration
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isEnforcedDuration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsEnforcedDuration
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

        [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartTime
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "weeksOfMonth", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public virtual double[] WeeksOfMonth
        {
            get => GetInstanceProperty<double[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.databaseSchedulingPolicySchedulingWindow.DatabaseSchedulingPolicySchedulingWindowWindowPreference\"}", isOptional: true)]
        public virtual oci.DatabaseSchedulingPolicySchedulingWindow.IDatabaseSchedulingPolicySchedulingWindowWindowPreference? InternalValue
        {
            get => GetInstanceProperty<oci.DatabaseSchedulingPolicySchedulingWindow.IDatabaseSchedulingPolicySchedulingWindowWindowPreference?>();
            set => SetInstanceProperty(value);
        }
    }
}
