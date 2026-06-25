using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciSelfSubscriptions
{
    [JsiiClass(nativeType: typeof(oci.DataOciSelfSubscriptions.DataOciSelfSubscriptionsSubscriptionCollectionItemsSubscriptionDetailsPricingPlanOutputReference), fullyQualifiedName: "oci.dataOciSelfSubscriptions.DataOciSelfSubscriptionsSubscriptionCollectionItemsSubscriptionDetailsPricingPlanOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciSelfSubscriptionsSubscriptionCollectionItemsSubscriptionDetailsPricingPlanOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciSelfSubscriptionsSubscriptionCollectionItemsSubscriptionDetailsPricingPlanOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciSelfSubscriptionsSubscriptionCollectionItemsSubscriptionDetailsPricingPlanOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciSelfSubscriptionsSubscriptionCollectionItemsSubscriptionDetailsPricingPlanOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "billingFrequency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BillingFrequency
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "planDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlanDescription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "planDuration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlanDuration
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "planName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlanName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "planType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlanType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rates", typeJson: "{\"fqn\":\"oci.dataOciSelfSubscriptions.DataOciSelfSubscriptionsSubscriptionCollectionItemsSubscriptionDetailsPricingPlanRatesList\"}")]
        public virtual oci.DataOciSelfSubscriptions.DataOciSelfSubscriptionsSubscriptionCollectionItemsSubscriptionDetailsPricingPlanRatesList Rates
        {
            get => GetInstanceProperty<oci.DataOciSelfSubscriptions.DataOciSelfSubscriptionsSubscriptionCollectionItemsSubscriptionDetailsPricingPlanRatesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciSelfSubscriptions.DataOciSelfSubscriptionsSubscriptionCollectionItemsSubscriptionDetailsPricingPlan\"}", isOptional: true)]
        public virtual oci.DataOciSelfSubscriptions.IDataOciSelfSubscriptionsSubscriptionCollectionItemsSubscriptionDetailsPricingPlan? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciSelfSubscriptions.IDataOciSelfSubscriptionsSubscriptionCollectionItemsSubscriptionDetailsPricingPlan?>();
            set => SetInstanceProperty(value);
        }
    }
}
