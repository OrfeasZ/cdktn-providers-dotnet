using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciSelfSubscriptions
{
    [JsiiClass(nativeType: typeof(oci.DataOciSelfSubscriptions.DataOciSelfSubscriptionsSubscriptionCollectionItemsSubscriptionDetailsOutputReference), fullyQualifiedName: "oci.dataOciSelfSubscriptions.DataOciSelfSubscriptionsSubscriptionCollectionItemsSubscriptionDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciSelfSubscriptionsSubscriptionCollectionItemsSubscriptionDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciSelfSubscriptionsSubscriptionCollectionItemsSubscriptionDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciSelfSubscriptionsSubscriptionCollectionItemsSubscriptionDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciSelfSubscriptionsSubscriptionCollectionItemsSubscriptionDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Amount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "billingDetails", typeJson: "{\"fqn\":\"oci.dataOciSelfSubscriptions.DataOciSelfSubscriptionsSubscriptionCollectionItemsSubscriptionDetailsBillingDetailsList\"}")]
        public virtual oci.DataOciSelfSubscriptions.DataOciSelfSubscriptionsSubscriptionCollectionItemsSubscriptionDetailsBillingDetailsList BillingDetails
        {
            get => GetInstanceProperty<oci.DataOciSelfSubscriptions.DataOciSelfSubscriptionsSubscriptionCollectionItemsSubscriptionDetailsBillingDetailsList>()!;
        }

        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Currency
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isAutoRenew", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAutoRenew
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "partnerRegistrationUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PartnerRegistrationUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pricingPlan", typeJson: "{\"fqn\":\"oci.dataOciSelfSubscriptions.DataOciSelfSubscriptionsSubscriptionCollectionItemsSubscriptionDetailsPricingPlanList\"}")]
        public virtual oci.DataOciSelfSubscriptions.DataOciSelfSubscriptionsSubscriptionCollectionItemsSubscriptionDetailsPricingPlanList PricingPlan
        {
            get => GetInstanceProperty<oci.DataOciSelfSubscriptions.DataOciSelfSubscriptionsSubscriptionCollectionItemsSubscriptionDetailsPricingPlanList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciSelfSubscriptions.DataOciSelfSubscriptionsSubscriptionCollectionItemsSubscriptionDetails\"}", isOptional: true)]
        public virtual oci.DataOciSelfSubscriptions.IDataOciSelfSubscriptionsSubscriptionCollectionItemsSubscriptionDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciSelfSubscriptions.IDataOciSelfSubscriptionsSubscriptionCollectionItemsSubscriptionDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
