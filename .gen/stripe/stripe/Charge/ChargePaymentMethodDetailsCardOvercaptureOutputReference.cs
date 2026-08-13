using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Charge
{
    [JsiiClass(nativeType: typeof(stripe.Charge.ChargePaymentMethodDetailsCardOvercaptureOutputReference), fullyQualifiedName: "stripe.charge.ChargePaymentMethodDetailsCardOvercaptureOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ChargePaymentMethodDetailsCardOvercaptureOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ChargePaymentMethodDetailsCardOvercaptureOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ChargePaymentMethodDetailsCardOvercaptureOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ChargePaymentMethodDetailsCardOvercaptureOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "maximumAmountCapturable", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumAmountCapturable
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsCardOvercapture\"}", isOptional: true)]
        public virtual stripe.Charge.IChargePaymentMethodDetailsCardOvercapture? InternalValue
        {
            get => GetInstanceProperty<stripe.Charge.IChargePaymentMethodDetailsCardOvercapture?>();
            set => SetInstanceProperty(value);
        }
    }
}
