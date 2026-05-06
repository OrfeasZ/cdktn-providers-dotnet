using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOsubUsageComputedUsageAggregateds
{
    [JsiiClass(nativeType: typeof(oci.DataOciOsubUsageComputedUsageAggregateds.DataOciOsubUsageComputedUsageAggregatedsComputedUsageAggregatedsAggregatedComputedUsagesOutputReference), fullyQualifiedName: "oci.dataOciOsubUsageComputedUsageAggregateds.DataOciOsubUsageComputedUsageAggregatedsComputedUsageAggregatedsAggregatedComputedUsagesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOsubUsageComputedUsageAggregatedsComputedUsageAggregatedsAggregatedComputedUsagesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOsubUsageComputedUsageAggregatedsComputedUsageAggregatedsAggregatedComputedUsagesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOsubUsageComputedUsageAggregatedsComputedUsageAggregatedsAggregatedComputedUsagesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOsubUsageComputedUsageAggregatedsComputedUsageAggregatedsAggregatedComputedUsagesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "cost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Cost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "costUnrounded", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CostUnrounded
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataCenter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataCenter
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "netUnitPrice", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetUnitPrice
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "product", typeJson: "{\"fqn\":\"oci.dataOciOsubUsageComputedUsageAggregateds.DataOciOsubUsageComputedUsageAggregatedsComputedUsageAggregatedsAggregatedComputedUsagesProductList\"}")]
        public virtual oci.DataOciOsubUsageComputedUsageAggregateds.DataOciOsubUsageComputedUsageAggregatedsComputedUsageAggregatedsAggregatedComputedUsagesProductList Product
        {
            get => GetInstanceProperty<oci.DataOciOsubUsageComputedUsageAggregateds.DataOciOsubUsageComputedUsageAggregatedsComputedUsageAggregatedsAggregatedComputedUsagesProductList>()!;
        }

        [JsiiProperty(name: "quantity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Quantity
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeMeteredOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeMeteredOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOsubUsageComputedUsageAggregateds.DataOciOsubUsageComputedUsageAggregatedsComputedUsageAggregatedsAggregatedComputedUsages\"}", isOptional: true)]
        public virtual oci.DataOciOsubUsageComputedUsageAggregateds.IDataOciOsubUsageComputedUsageAggregatedsComputedUsageAggregatedsAggregatedComputedUsages? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOsubUsageComputedUsageAggregateds.IDataOciOsubUsageComputedUsageAggregatedsComputedUsageAggregatedsAggregatedComputedUsages?>();
            set => SetInstanceProperty(value);
        }
    }
}
