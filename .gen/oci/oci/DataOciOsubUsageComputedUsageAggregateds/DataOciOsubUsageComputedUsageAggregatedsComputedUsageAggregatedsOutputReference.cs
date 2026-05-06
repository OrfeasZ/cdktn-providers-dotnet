using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOsubUsageComputedUsageAggregateds
{
    [JsiiClass(nativeType: typeof(oci.DataOciOsubUsageComputedUsageAggregateds.DataOciOsubUsageComputedUsageAggregatedsComputedUsageAggregatedsOutputReference), fullyQualifiedName: "oci.dataOciOsubUsageComputedUsageAggregateds.DataOciOsubUsageComputedUsageAggregatedsComputedUsageAggregatedsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOsubUsageComputedUsageAggregatedsComputedUsageAggregatedsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOsubUsageComputedUsageAggregatedsComputedUsageAggregatedsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOsubUsageComputedUsageAggregatedsComputedUsageAggregatedsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOsubUsageComputedUsageAggregatedsComputedUsageAggregatedsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "aggregatedComputedUsages", typeJson: "{\"fqn\":\"oci.dataOciOsubUsageComputedUsageAggregateds.DataOciOsubUsageComputedUsageAggregatedsComputedUsageAggregatedsAggregatedComputedUsagesList\"}")]
        public virtual oci.DataOciOsubUsageComputedUsageAggregateds.DataOciOsubUsageComputedUsageAggregatedsComputedUsageAggregatedsAggregatedComputedUsagesList AggregatedComputedUsages
        {
            get => GetInstanceProperty<oci.DataOciOsubUsageComputedUsageAggregateds.DataOciOsubUsageComputedUsageAggregatedsComputedUsageAggregatedsAggregatedComputedUsagesList>()!;
        }

        [JsiiProperty(name: "currencyCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CurrencyCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parentProduct", typeJson: "{\"fqn\":\"oci.dataOciOsubUsageComputedUsageAggregateds.DataOciOsubUsageComputedUsageAggregatedsComputedUsageAggregatedsParentProductList\"}")]
        public virtual oci.DataOciOsubUsageComputedUsageAggregateds.DataOciOsubUsageComputedUsageAggregatedsComputedUsageAggregatedsParentProductList ParentProduct
        {
            get => GetInstanceProperty<oci.DataOciOsubUsageComputedUsageAggregateds.DataOciOsubUsageComputedUsageAggregatedsComputedUsageAggregatedsParentProductList>()!;
        }

        [JsiiProperty(name: "parentSubscribedServiceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentSubscribedServiceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "planNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlanNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pricingModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PricingModel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rateCardId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RateCardId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subscriptionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubscriptionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeEnd", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeEnd
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeStart", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStart
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOsubUsageComputedUsageAggregateds.DataOciOsubUsageComputedUsageAggregatedsComputedUsageAggregateds\"}", isOptional: true)]
        public virtual oci.DataOciOsubUsageComputedUsageAggregateds.IDataOciOsubUsageComputedUsageAggregatedsComputedUsageAggregateds? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOsubUsageComputedUsageAggregateds.IDataOciOsubUsageComputedUsageAggregatedsComputedUsageAggregateds?>();
            set => SetInstanceProperty(value);
        }
    }
}
