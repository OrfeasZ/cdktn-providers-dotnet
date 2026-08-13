using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiClass(nativeType: typeof(stripe.PaymentIntent.PaymentIntentNextActionKonbiniDisplayDetailsOutputReference), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentNextActionKonbiniDisplayDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PaymentIntentNextActionKonbiniDisplayDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PaymentIntentNextActionKonbiniDisplayDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PaymentIntentNextActionKonbiniDisplayDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentIntentNextActionKonbiniDisplayDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "expiresAt", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ExpiresAt
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "hostedVoucherUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostedVoucherUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stores", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentNextActionKonbiniDisplayDetailsStoresOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentNextActionKonbiniDisplayDetailsStoresOutputReference Stores
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentNextActionKonbiniDisplayDetailsStoresOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentNextActionKonbiniDisplayDetails\"}", isOptional: true)]
        public virtual stripe.PaymentIntent.IPaymentIntentNextActionKonbiniDisplayDetails? InternalValue
        {
            get => GetInstanceProperty<stripe.PaymentIntent.IPaymentIntentNextActionKonbiniDisplayDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
