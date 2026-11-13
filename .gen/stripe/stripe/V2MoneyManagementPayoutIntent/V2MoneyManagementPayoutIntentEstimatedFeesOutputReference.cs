using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementPayoutIntent
{
    [JsiiClass(nativeType: typeof(stripe.V2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentEstimatedFeesOutputReference), fullyQualifiedName: "stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentEstimatedFeesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class V2MoneyManagementPayoutIntentEstimatedFeesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public V2MoneyManagementPayoutIntentEstimatedFeesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected V2MoneyManagementPayoutIntentEstimatedFeesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected V2MoneyManagementPayoutIntentEstimatedFeesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "amount", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentEstimatedFeesAmountOutputReference\"}")]
        public virtual stripe.V2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentEstimatedFeesAmountOutputReference Amount
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentEstimatedFeesAmountOutputReference>()!;
        }

        [JsiiProperty(name: "networkFeeDetails", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentEstimatedFeesNetworkFeeDetailsOutputReference\"}")]
        public virtual stripe.V2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentEstimatedFeesNetworkFeeDetailsOutputReference NetworkFeeDetails
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentEstimatedFeesNetworkFeeDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "taxAmount", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentEstimatedFeesTaxAmountOutputReference\"}")]
        public virtual stripe.V2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentEstimatedFeesTaxAmountOutputReference TaxAmount
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentEstimatedFeesTaxAmountOutputReference>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentEstimatedFees\"}", isOptional: true)]
        public virtual stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentEstimatedFees? InternalValue
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentEstimatedFees?>();
            set => SetInstanceProperty(value);
        }
    }
}
