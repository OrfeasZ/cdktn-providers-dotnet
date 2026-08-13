using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiClass(nativeType: typeof(stripe.PaymentMethod.PaymentMethodSepaDebitGeneratedFromOutputReference), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodSepaDebitGeneratedFromOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PaymentMethodSepaDebitGeneratedFromOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PaymentMethodSepaDebitGeneratedFromOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PaymentMethodSepaDebitGeneratedFromOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentMethodSepaDebitGeneratedFromOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "charge", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Charge
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "setupAttempt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SetupAttempt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodSepaDebitGeneratedFrom\"}", isOptional: true)]
        public virtual stripe.PaymentMethod.IPaymentMethodSepaDebitGeneratedFrom? InternalValue
        {
            get => GetInstanceProperty<stripe.PaymentMethod.IPaymentMethodSepaDebitGeneratedFrom?>();
            set => SetInstanceProperty(value);
        }
    }
}
