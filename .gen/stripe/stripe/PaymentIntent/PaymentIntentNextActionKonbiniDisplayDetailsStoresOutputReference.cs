using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiClass(nativeType: typeof(stripe.PaymentIntent.PaymentIntentNextActionKonbiniDisplayDetailsStoresOutputReference), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentNextActionKonbiniDisplayDetailsStoresOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PaymentIntentNextActionKonbiniDisplayDetailsStoresOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PaymentIntentNextActionKonbiniDisplayDetailsStoresOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PaymentIntentNextActionKonbiniDisplayDetailsStoresOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentIntentNextActionKonbiniDisplayDetailsStoresOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "familymart", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentNextActionKonbiniDisplayDetailsStoresFamilymartOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentNextActionKonbiniDisplayDetailsStoresFamilymartOutputReference Familymart
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentNextActionKonbiniDisplayDetailsStoresFamilymartOutputReference>()!;
        }

        [JsiiProperty(name: "lawson", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentNextActionKonbiniDisplayDetailsStoresLawsonOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentNextActionKonbiniDisplayDetailsStoresLawsonOutputReference Lawson
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentNextActionKonbiniDisplayDetailsStoresLawsonOutputReference>()!;
        }

        [JsiiProperty(name: "ministop", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentNextActionKonbiniDisplayDetailsStoresMinistopOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentNextActionKonbiniDisplayDetailsStoresMinistopOutputReference Ministop
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentNextActionKonbiniDisplayDetailsStoresMinistopOutputReference>()!;
        }

        [JsiiProperty(name: "seicomart", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentNextActionKonbiniDisplayDetailsStoresSeicomartOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentNextActionKonbiniDisplayDetailsStoresSeicomartOutputReference Seicomart
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentNextActionKonbiniDisplayDetailsStoresSeicomartOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentNextActionKonbiniDisplayDetailsStores\"}", isOptional: true)]
        public virtual stripe.PaymentIntent.IPaymentIntentNextActionKonbiniDisplayDetailsStores? InternalValue
        {
            get => GetInstanceProperty<stripe.PaymentIntent.IPaymentIntentNextActionKonbiniDisplayDetailsStores?>();
            set => SetInstanceProperty(value);
        }
    }
}
