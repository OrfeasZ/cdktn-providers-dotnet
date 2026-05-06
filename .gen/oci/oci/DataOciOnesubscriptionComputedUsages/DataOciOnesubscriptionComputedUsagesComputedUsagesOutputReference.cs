using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOnesubscriptionComputedUsages
{
    [JsiiClass(nativeType: typeof(oci.DataOciOnesubscriptionComputedUsages.DataOciOnesubscriptionComputedUsagesComputedUsagesOutputReference), fullyQualifiedName: "oci.dataOciOnesubscriptionComputedUsages.DataOciOnesubscriptionComputedUsagesComputedUsagesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOnesubscriptionComputedUsagesComputedUsagesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOnesubscriptionComputedUsagesComputedUsagesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOnesubscriptionComputedUsagesComputedUsagesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOnesubscriptionComputedUsagesComputedUsagesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "commitmentServiceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CommitmentServiceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "computedUsageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputedUsageId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "computeSource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeSource
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Cost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "costRounded", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CostRounded
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "currencyCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CurrencyCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataCenter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataCenter
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isInvoiced", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsInvoiced
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "mqsMessageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MqsMessageId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "netUnitPrice", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetUnitPrice
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "originalUsageNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OriginalUsageNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parentProduct", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionComputedUsages.DataOciOnesubscriptionComputedUsagesComputedUsagesParentProductList\"}")]
        public virtual oci.DataOciOnesubscriptionComputedUsages.DataOciOnesubscriptionComputedUsagesComputedUsagesParentProductList ParentProduct
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionComputedUsages.DataOciOnesubscriptionComputedUsagesComputedUsagesParentProductList>()!;
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

        [JsiiProperty(name: "product", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionComputedUsages.DataOciOnesubscriptionComputedUsagesComputedUsagesProductList\"}")]
        public virtual oci.DataOciOnesubscriptionComputedUsages.DataOciOnesubscriptionComputedUsagesComputedUsagesProductList Product
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionComputedUsages.DataOciOnesubscriptionComputedUsagesComputedUsagesProductList>()!;
        }

        [JsiiProperty(name: "quantity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Quantity
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rateCardId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RateCardId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rateCardTierdId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RateCardTierdId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeMeteredOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeMeteredOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeOfArrival", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOfArrival
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "unitOfMeasure", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UnitOfMeasure
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "usageNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UsageNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionComputedUsages.DataOciOnesubscriptionComputedUsagesComputedUsages\"}", isOptional: true)]
        public virtual oci.DataOciOnesubscriptionComputedUsages.IDataOciOnesubscriptionComputedUsagesComputedUsages? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionComputedUsages.IDataOciOnesubscriptionComputedUsagesComputedUsages?>();
            set => SetInstanceProperty(value);
        }
    }
}
