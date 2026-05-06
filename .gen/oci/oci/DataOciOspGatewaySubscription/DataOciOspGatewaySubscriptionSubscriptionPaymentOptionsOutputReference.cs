using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOspGatewaySubscription
{
    [JsiiClass(nativeType: typeof(oci.DataOciOspGatewaySubscription.DataOciOspGatewaySubscriptionSubscriptionPaymentOptionsOutputReference), fullyQualifiedName: "oci.dataOciOspGatewaySubscription.DataOciOspGatewaySubscriptionSubscriptionPaymentOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOspGatewaySubscriptionSubscriptionPaymentOptionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOspGatewaySubscriptionSubscriptionPaymentOptionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOspGatewaySubscriptionSubscriptionPaymentOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOspGatewaySubscriptionSubscriptionPaymentOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "creditCardType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreditCardType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "emailAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmailAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "extBillingAgreementId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExtBillingAgreementId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "firstName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FirstName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastDigits", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastDigits
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nameOnCard", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameOnCard
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "paymentMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PaymentMethod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeExpiration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeExpiration
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "walletInstrumentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WalletInstrumentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "walletTransactionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WalletTransactionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOspGatewaySubscription.DataOciOspGatewaySubscriptionSubscriptionPaymentOptions\"}", isOptional: true)]
        public virtual oci.DataOciOspGatewaySubscription.IDataOciOspGatewaySubscriptionSubscriptionPaymentOptions? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOspGatewaySubscription.IDataOciOspGatewaySubscriptionSubscriptionPaymentOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
