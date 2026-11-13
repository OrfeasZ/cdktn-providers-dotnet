using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementPayoutIntent
{
    [JsiiClass(nativeType: typeof(stripe.V2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentRecipientVerificationMatchResultDetailsOutputReference), fullyQualifiedName: "stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentRecipientVerificationMatchResultDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class V2MoneyManagementPayoutIntentRecipientVerificationMatchResultDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public V2MoneyManagementPayoutIntentRecipientVerificationMatchResultDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected V2MoneyManagementPayoutIntentRecipientVerificationMatchResultDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected V2MoneyManagementPayoutIntentRecipientVerificationMatchResultDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "matchedBusinessType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MatchedBusinessType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "matchedName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MatchedName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Message
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "providedBusinessType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProvidedBusinessType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "providedName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProvidedName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentRecipientVerificationMatchResultDetails\"}", isOptional: true)]
        public virtual stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentRecipientVerificationMatchResultDetails? InternalValue
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentRecipientVerificationMatchResultDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
