using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethodDomain
{
    [JsiiClass(nativeType: typeof(stripe.PaymentMethodDomain.PaymentMethodDomainLinkOutputReference), fullyQualifiedName: "stripe.paymentMethodDomain.PaymentMethodDomainLinkOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PaymentMethodDomainLinkOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PaymentMethodDomainLinkOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PaymentMethodDomainLinkOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentMethodDomainLinkOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "statusDetails", typeJson: "{\"fqn\":\"stripe.paymentMethodDomain.PaymentMethodDomainLinkStatusDetailsOutputReference\"}")]
        public virtual stripe.PaymentMethodDomain.PaymentMethodDomainLinkStatusDetailsOutputReference StatusDetails
        {
            get => GetInstanceProperty<stripe.PaymentMethodDomain.PaymentMethodDomainLinkStatusDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.paymentMethodDomain.PaymentMethodDomainLink\"}", isOptional: true)]
        public virtual stripe.PaymentMethodDomain.IPaymentMethodDomainLink? InternalValue
        {
            get => GetInstanceProperty<stripe.PaymentMethodDomain.IPaymentMethodDomainLink?>();
            set => SetInstanceProperty(value);
        }
    }
}
