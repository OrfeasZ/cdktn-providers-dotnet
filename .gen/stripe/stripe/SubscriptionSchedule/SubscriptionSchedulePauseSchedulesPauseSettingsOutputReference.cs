using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionSchedule
{
    [JsiiClass(nativeType: typeof(stripe.SubscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettingsOutputReference), fullyQualifiedName: "stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SubscriptionSchedulePauseSchedulesPauseSettingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SubscriptionSchedulePauseSchedulesPauseSettingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SubscriptionSchedulePauseSchedulesPauseSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SubscriptionSchedulePauseSchedulesPauseSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBillFor", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettingsBillFor\"}}]")]
        public virtual void PutBillFor(stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPauseSettingsBillFor @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPauseSettingsBillFor)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBillFor")]
        public virtual void ResetBillFor()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInvoicingBehavior")]
        public virtual void ResetInvoicingBehavior()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetType")]
        public virtual void ResetType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "billFor", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettingsBillForOutputReference\"}")]
        public virtual stripe.SubscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettingsBillForOutputReference BillFor
        {
            get => GetInstanceProperty<stripe.SubscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettingsBillForOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPauseSettingsBillFor" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "billForInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettingsBillFor\"}]}}", isOptional: true)]
        public virtual object? BillForInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "invoicingBehaviorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InvoicingBehaviorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "invoicingBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InvoicingBehavior
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPauseSettings" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesPauseSettings\"}]}}", isOptional: true)]
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
                        case stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPauseSettings cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesPauseSettings).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
