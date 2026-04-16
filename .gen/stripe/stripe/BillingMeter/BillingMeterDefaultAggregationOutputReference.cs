using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingMeter
{
    [JsiiClass(nativeType: typeof(stripe.BillingMeter.BillingMeterDefaultAggregationOutputReference), fullyQualifiedName: "stripe.billingMeter.BillingMeterDefaultAggregationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class BillingMeterDefaultAggregationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public BillingMeterDefaultAggregationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected BillingMeterDefaultAggregationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BillingMeterDefaultAggregationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "formulaInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FormulaInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "formula", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Formula
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.billingMeter.BillingMeterDefaultAggregation\"}", isOptional: true)]
        public virtual stripe.BillingMeter.IBillingMeterDefaultAggregation? InternalValue
        {
            get => GetInstanceProperty<stripe.BillingMeter.IBillingMeterDefaultAggregation?>();
            set => SetInstanceProperty(value);
        }
    }
}
