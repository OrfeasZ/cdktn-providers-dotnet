using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ShippingRate
{
    [JsiiClass(nativeType: typeof(stripe.ShippingRate.ShippingRateDeliveryEstimateOutputReference), fullyQualifiedName: "stripe.shippingRate.ShippingRateDeliveryEstimateOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ShippingRateDeliveryEstimateOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ShippingRateDeliveryEstimateOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ShippingRateDeliveryEstimateOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ShippingRateDeliveryEstimateOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putMaximum", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.shippingRate.ShippingRateDeliveryEstimateMaximum\"}}]")]
        public virtual void PutMaximum(stripe.ShippingRate.IShippingRateDeliveryEstimateMaximum @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.ShippingRate.IShippingRateDeliveryEstimateMaximum)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMinimum", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.shippingRate.ShippingRateDeliveryEstimateMinimum\"}}]")]
        public virtual void PutMinimum(stripe.ShippingRate.IShippingRateDeliveryEstimateMinimum @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.ShippingRate.IShippingRateDeliveryEstimateMinimum)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMaximum")]
        public virtual void ResetMaximum()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinimum")]
        public virtual void ResetMinimum()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "maximum", typeJson: "{\"fqn\":\"stripe.shippingRate.ShippingRateDeliveryEstimateMaximumOutputReference\"}")]
        public virtual stripe.ShippingRate.ShippingRateDeliveryEstimateMaximumOutputReference Maximum
        {
            get => GetInstanceProperty<stripe.ShippingRate.ShippingRateDeliveryEstimateMaximumOutputReference>()!;
        }

        [JsiiProperty(name: "minimum", typeJson: "{\"fqn\":\"stripe.shippingRate.ShippingRateDeliveryEstimateMinimumOutputReference\"}")]
        public virtual stripe.ShippingRate.ShippingRateDeliveryEstimateMinimumOutputReference Minimum
        {
            get => GetInstanceProperty<stripe.ShippingRate.ShippingRateDeliveryEstimateMinimumOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumInput", typeJson: "{\"fqn\":\"stripe.shippingRate.ShippingRateDeliveryEstimateMaximum\"}", isOptional: true)]
        public virtual stripe.ShippingRate.IShippingRateDeliveryEstimateMaximum? MaximumInput
        {
            get => GetInstanceProperty<stripe.ShippingRate.IShippingRateDeliveryEstimateMaximum?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minimumInput", typeJson: "{\"fqn\":\"stripe.shippingRate.ShippingRateDeliveryEstimateMinimum\"}", isOptional: true)]
        public virtual stripe.ShippingRate.IShippingRateDeliveryEstimateMinimum? MinimumInput
        {
            get => GetInstanceProperty<stripe.ShippingRate.IShippingRateDeliveryEstimateMinimum?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.shippingRate.ShippingRateDeliveryEstimate\"}", isOptional: true)]
        public virtual stripe.ShippingRate.IShippingRateDeliveryEstimate? InternalValue
        {
            get => GetInstanceProperty<stripe.ShippingRate.IShippingRateDeliveryEstimate?>();
            set => SetInstanceProperty(value);
        }
    }
}
