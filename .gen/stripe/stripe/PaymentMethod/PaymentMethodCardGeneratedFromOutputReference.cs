using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiClass(nativeType: typeof(stripe.PaymentMethod.PaymentMethodCardGeneratedFromOutputReference), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodCardGeneratedFromOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PaymentMethodCardGeneratedFromOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PaymentMethodCardGeneratedFromOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PaymentMethodCardGeneratedFromOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentMethodCardGeneratedFromOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "charge", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Charge
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "paymentMethodDetails", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodCardGeneratedFromPaymentMethodDetailsOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodCardGeneratedFromPaymentMethodDetailsOutputReference PaymentMethodDetails
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodCardGeneratedFromPaymentMethodDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "setupAttempt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SetupAttempt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodCardGeneratedFrom\"}", isOptional: true)]
        public virtual stripe.PaymentMethod.IPaymentMethodCardGeneratedFrom? InternalValue
        {
            get => GetInstanceProperty<stripe.PaymentMethod.IPaymentMethodCardGeneratedFrom?>();
            set => SetInstanceProperty(value);
        }
    }
}
