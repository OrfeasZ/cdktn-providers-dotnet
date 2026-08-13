using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingCard
{
    [JsiiClass(nativeType: typeof(stripe.IssuingCard.IssuingCardWalletsOutputReference), fullyQualifiedName: "stripe.issuingCard.IssuingCardWalletsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IssuingCardWalletsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IssuingCardWalletsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected IssuingCardWalletsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IssuingCardWalletsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "applePay", typeJson: "{\"fqn\":\"stripe.issuingCard.IssuingCardWalletsApplePayOutputReference\"}")]
        public virtual stripe.IssuingCard.IssuingCardWalletsApplePayOutputReference ApplePay
        {
            get => GetInstanceProperty<stripe.IssuingCard.IssuingCardWalletsApplePayOutputReference>()!;
        }

        [JsiiProperty(name: "googlePay", typeJson: "{\"fqn\":\"stripe.issuingCard.IssuingCardWalletsGooglePayOutputReference\"}")]
        public virtual stripe.IssuingCard.IssuingCardWalletsGooglePayOutputReference GooglePay
        {
            get => GetInstanceProperty<stripe.IssuingCard.IssuingCardWalletsGooglePayOutputReference>()!;
        }

        [JsiiProperty(name: "primaryAccountIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryAccountIdentifier
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.issuingCard.IssuingCardWallets\"}", isOptional: true)]
        public virtual stripe.IssuingCard.IIssuingCardWallets? InternalValue
        {
            get => GetInstanceProperty<stripe.IssuingCard.IIssuingCardWallets?>();
            set => SetInstanceProperty(value);
        }
    }
}
