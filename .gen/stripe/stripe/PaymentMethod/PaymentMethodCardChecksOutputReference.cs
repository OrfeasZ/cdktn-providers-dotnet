using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiClass(nativeType: typeof(stripe.PaymentMethod.PaymentMethodCardChecksOutputReference), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodCardChecksOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PaymentMethodCardChecksOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PaymentMethodCardChecksOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PaymentMethodCardChecksOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentMethodCardChecksOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "addressLine1Check", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AddressLine1Check
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "addressPostalCodeCheck", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AddressPostalCodeCheck
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cvcCheck", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CvcCheck
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodCardChecks\"}", isOptional: true)]
        public virtual stripe.PaymentMethod.IPaymentMethodCardChecks? InternalValue
        {
            get => GetInstanceProperty<stripe.PaymentMethod.IPaymentMethodCardChecks?>();
            set => SetInstanceProperty(value);
        }
    }
}
