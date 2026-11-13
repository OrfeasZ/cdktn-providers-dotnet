using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementPayoutIntent
{
    [JsiiClass(nativeType: typeof(stripe.V2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentFxQuoteOutputReference), fullyQualifiedName: "stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentFxQuoteOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class V2MoneyManagementPayoutIntentFxQuoteOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public V2MoneyManagementPayoutIntentFxQuoteOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected V2MoneyManagementPayoutIntentFxQuoteOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected V2MoneyManagementPayoutIntentFxQuoteOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "lockDuration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LockDuration
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lockExpiresAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LockExpiresAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lockStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LockStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rates", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentFxQuoteRatesMap\"}")]
        public virtual stripe.V2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentFxQuoteRatesMap Rates
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentFxQuoteRatesMap>()!;
        }

        [JsiiProperty(name: "toCurrency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ToCurrency
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentFxQuote\"}", isOptional: true)]
        public virtual stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentFxQuote? InternalValue
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentFxQuote?>();
            set => SetInstanceProperty(value);
        }
    }
}
