using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingCard
{
    [JsiiClass(nativeType: typeof(stripe.IssuingCard.IssuingCardLifecycleControlsCancelAfterOutputReference), fullyQualifiedName: "stripe.issuingCard.IssuingCardLifecycleControlsCancelAfterOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IssuingCardLifecycleControlsCancelAfterOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IssuingCardLifecycleControlsCancelAfterOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected IssuingCardLifecycleControlsCancelAfterOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IssuingCardLifecycleControlsCancelAfterOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "paymentCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PaymentCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "paymentCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PaymentCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.issuingCard.IssuingCardLifecycleControlsCancelAfter\"}", isOptional: true)]
        public virtual stripe.IssuingCard.IIssuingCardLifecycleControlsCancelAfter? InternalValue
        {
            get => GetInstanceProperty<stripe.IssuingCard.IIssuingCardLifecycleControlsCancelAfter?>();
            set => SetInstanceProperty(value);
        }
    }
}
