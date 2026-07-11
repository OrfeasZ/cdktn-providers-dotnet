using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorAlertProcessingRuleSuppression
{
    [JsiiClass(nativeType: typeof(azurerm.MonitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionScheduleRecurrenceOutputReference), fullyQualifiedName: "azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionScheduleRecurrenceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MonitorAlertProcessingRuleSuppressionScheduleRecurrenceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MonitorAlertProcessingRuleSuppressionScheduleRecurrenceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MonitorAlertProcessingRuleSuppressionScheduleRecurrenceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MonitorAlertProcessingRuleSuppressionScheduleRecurrenceOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionScheduleRecurrenceDaily" />)[]</param>
        [JsiiMethod(name: "putDaily", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionScheduleRecurrenceDaily\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDaily(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionScheduleRecurrenceDaily[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionScheduleRecurrenceDaily).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionScheduleRecurrenceDaily).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionScheduleRecurrenceMonthly" />)[]</param>
        [JsiiMethod(name: "putMonthly", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionScheduleRecurrenceMonthly\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutMonthly(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionScheduleRecurrenceMonthly[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionScheduleRecurrenceMonthly).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionScheduleRecurrenceMonthly).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionScheduleRecurrenceWeekly" />)[]</param>
        [JsiiMethod(name: "putWeekly", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionScheduleRecurrenceWeekly\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutWeekly(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionScheduleRecurrenceWeekly[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionScheduleRecurrenceWeekly).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionScheduleRecurrenceWeekly).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDaily")]
        public virtual void ResetDaily()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMonthly")]
        public virtual void ResetMonthly()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWeekly")]
        public virtual void ResetWeekly()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "daily", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionScheduleRecurrenceDailyList\"}")]
        public virtual azurerm.MonitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionScheduleRecurrenceDailyList Daily
        {
            get => GetInstanceProperty<azurerm.MonitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionScheduleRecurrenceDailyList>()!;
        }

        [JsiiProperty(name: "monthly", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionScheduleRecurrenceMonthlyList\"}")]
        public virtual azurerm.MonitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionScheduleRecurrenceMonthlyList Monthly
        {
            get => GetInstanceProperty<azurerm.MonitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionScheduleRecurrenceMonthlyList>()!;
        }

        [JsiiProperty(name: "weekly", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionScheduleRecurrenceWeeklyList\"}")]
        public virtual azurerm.MonitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionScheduleRecurrenceWeeklyList Weekly
        {
            get => GetInstanceProperty<azurerm.MonitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionScheduleRecurrenceWeeklyList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionScheduleRecurrenceDaily" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dailyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionScheduleRecurrenceDaily\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DailyInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionScheduleRecurrenceMonthly" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "monthlyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionScheduleRecurrenceMonthly\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? MonthlyInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionScheduleRecurrenceWeekly" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "weeklyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionScheduleRecurrenceWeekly\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? WeeklyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionScheduleRecurrence\"}", isOptional: true)]
        public virtual azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionScheduleRecurrence? InternalValue
        {
            get => GetInstanceProperty<azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionScheduleRecurrence?>();
            set => SetInstanceProperty(value);
        }
    }
}
