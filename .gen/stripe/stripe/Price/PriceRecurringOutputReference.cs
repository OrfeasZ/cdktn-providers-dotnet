using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Price
{
    [JsiiClass(nativeType: typeof(stripe.Price.PriceRecurringOutputReference), fullyQualifiedName: "stripe.price.PriceRecurringOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PriceRecurringOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PriceRecurringOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PriceRecurringOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PriceRecurringOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetIntervalCount")]
        public virtual void ResetIntervalCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMeter")]
        public virtual void ResetMeter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTrialPeriodDays")]
        public virtual void ResetTrialPeriodDays()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUsageType")]
        public virtual void ResetUsageType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "intervalCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? IntervalCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "intervalInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IntervalInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "meterInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MeterInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trialPeriodDaysInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TrialPeriodDaysInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "usageTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UsageTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Interval
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "intervalCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IntervalCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "meter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Meter
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "trialPeriodDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TrialPeriodDays
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "usageType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UsageType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.price.PriceRecurring\"}", isOptional: true)]
        public virtual stripe.Price.IPriceRecurring? InternalValue
        {
            get => GetInstanceProperty<stripe.Price.IPriceRecurring?>();
            set => SetInstanceProperty(value);
        }
    }
}
