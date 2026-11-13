using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionSchedule
{
    [JsiiClass(nativeType: typeof(stripe.SubscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettingsBillForOutputReference), fullyQualifiedName: "stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettingsBillForOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SubscriptionSchedulePauseSchedulesPauseSettingsBillForOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SubscriptionSchedulePauseSchedulesPauseSettingsBillForOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SubscriptionSchedulePauseSchedulesPauseSettingsBillForOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SubscriptionSchedulePauseSchedulesPauseSettingsBillForOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putOutstandingUsageThrough", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettingsBillForOutstandingUsageThrough\"}}]")]
        public virtual void PutOutstandingUsageThrough(stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPauseSettingsBillForOutstandingUsageThrough @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPauseSettingsBillForOutstandingUsageThrough)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUnusedTimeFrom", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettingsBillForUnusedTimeFrom\"}}]")]
        public virtual void PutUnusedTimeFrom(stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPauseSettingsBillForUnusedTimeFrom @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPauseSettingsBillForUnusedTimeFrom)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetOutstandingUsageThrough")]
        public virtual void ResetOutstandingUsageThrough()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUnusedTimeFrom")]
        public virtual void ResetUnusedTimeFrom()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "outstandingUsageThrough", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettingsBillForOutstandingUsageThroughOutputReference\"}")]
        public virtual stripe.SubscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettingsBillForOutstandingUsageThroughOutputReference OutstandingUsageThrough
        {
            get => GetInstanceProperty<stripe.SubscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettingsBillForOutstandingUsageThroughOutputReference>()!;
        }

        [JsiiProperty(name: "unusedTimeFrom", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettingsBillForUnusedTimeFromOutputReference\"}")]
        public virtual stripe.SubscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettingsBillForUnusedTimeFromOutputReference UnusedTimeFrom
        {
            get => GetInstanceProperty<stripe.SubscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettingsBillForUnusedTimeFromOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPauseSettingsBillForOutstandingUsageThrough" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "outstandingUsageThroughInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettingsBillForOutstandingUsageThrough\"}]}}", isOptional: true)]
        public virtual object? OutstandingUsageThroughInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPauseSettingsBillForUnusedTimeFrom" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "unusedTimeFromInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettingsBillForUnusedTimeFrom\"}]}}", isOptional: true)]
        public virtual object? UnusedTimeFromInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPauseSettingsBillFor" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettingsBillFor\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPauseSettingsBillFor cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPauseSettingsBillFor).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
