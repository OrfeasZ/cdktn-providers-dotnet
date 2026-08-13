using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiClass(nativeType: typeof(stripe.Subscription.SubscriptionBillingSchedulesBillUntilOutputReference), fullyQualifiedName: "stripe.subscription.SubscriptionBillingSchedulesBillUntilOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SubscriptionBillingSchedulesBillUntilOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SubscriptionBillingSchedulesBillUntilOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SubscriptionBillingSchedulesBillUntilOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SubscriptionBillingSchedulesBillUntilOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDuration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.subscription.SubscriptionBillingSchedulesBillUntilDuration\"}}]")]
        public virtual void PutDuration(stripe.Subscription.ISubscriptionBillingSchedulesBillUntilDuration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Subscription.ISubscriptionBillingSchedulesBillUntilDuration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDuration")]
        public virtual void ResetDuration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimestamp")]
        public virtual void ResetTimestamp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "computedTimestamp", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ComputedTimestamp
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "duration", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionBillingSchedulesBillUntilDurationOutputReference\"}")]
        public virtual stripe.Subscription.SubscriptionBillingSchedulesBillUntilDurationOutputReference Duration
        {
            get => GetInstanceProperty<stripe.Subscription.SubscriptionBillingSchedulesBillUntilDurationOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Subscription.ISubscriptionBillingSchedulesBillUntilDuration" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "durationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.subscription.SubscriptionBillingSchedulesBillUntilDuration\"}]}}", isOptional: true)]
        public virtual object? DurationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timestampInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TimestampInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "timestamp", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Timestamp
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionBillingSchedulesBillUntil\"}", isOptional: true)]
        public virtual stripe.Subscription.ISubscriptionBillingSchedulesBillUntil? InternalValue
        {
            get => GetInstanceProperty<stripe.Subscription.ISubscriptionBillingSchedulesBillUntil?>();
            set => SetInstanceProperty(value);
        }
    }
}
