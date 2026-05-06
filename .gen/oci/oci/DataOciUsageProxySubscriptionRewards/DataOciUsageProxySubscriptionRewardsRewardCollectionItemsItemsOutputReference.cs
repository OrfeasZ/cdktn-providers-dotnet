using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciUsageProxySubscriptionRewards
{
    [JsiiClass(nativeType: typeof(oci.DataOciUsageProxySubscriptionRewards.DataOciUsageProxySubscriptionRewardsRewardCollectionItemsItemsOutputReference), fullyQualifiedName: "oci.dataOciUsageProxySubscriptionRewards.DataOciUsageProxySubscriptionRewardsRewardCollectionItemsItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciUsageProxySubscriptionRewardsRewardCollectionItemsItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciUsageProxySubscriptionRewardsRewardCollectionItemsItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciUsageProxySubscriptionRewardsRewardCollectionItemsItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciUsageProxySubscriptionRewardsRewardCollectionItemsItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "availableRewards", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AvailableRewards
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "earnedRewards", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EarnedRewards
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "eligibleUsageAmount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EligibleUsageAmount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ineligibleUsageAmount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IneligibleUsageAmount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "isManual", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsManual
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "redeemedRewards", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RedeemedRewards
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "timeRewardsEarned", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeRewardsEarned
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeRewardsExpired", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeRewardsExpired
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUsageEnded", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUsageEnded
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUsageStarted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUsageStarted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "usageAmount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UsageAmount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "usagePeriodKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UsagePeriodKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciUsageProxySubscriptionRewards.DataOciUsageProxySubscriptionRewardsRewardCollectionItemsItems\"}", isOptional: true)]
        public virtual oci.DataOciUsageProxySubscriptionRewards.IDataOciUsageProxySubscriptionRewardsRewardCollectionItemsItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciUsageProxySubscriptionRewards.IDataOciUsageProxySubscriptionRewardsRewardCollectionItemsItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
