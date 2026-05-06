using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciUsageProxySubscriptionRedemptions
{
    [JsiiClass(nativeType: typeof(oci.DataOciUsageProxySubscriptionRedemptions.DataOciUsageProxySubscriptionRedemptionsRedemptionCollectionItemsItemsOutputReference), fullyQualifiedName: "oci.dataOciUsageProxySubscriptionRedemptions.DataOciUsageProxySubscriptionRedemptionsRedemptionCollectionItemsItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciUsageProxySubscriptionRedemptionsRedemptionCollectionItemsItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciUsageProxySubscriptionRedemptionsRedemptionCollectionItemsItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciUsageProxySubscriptionRedemptionsRedemptionCollectionItemsItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciUsageProxySubscriptionRedemptionsRedemptionCollectionItemsItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "baseRewards", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BaseRewards
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "fxRate", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FxRate
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "invoiceCurrency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InvoiceCurrency
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "invoiceNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InvoiceNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "invoiceTotalAmount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InvoiceTotalAmount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "redeemedRewards", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RedeemedRewards
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "redemptionCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RedemptionCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "redemptionEmail", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RedemptionEmail
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeInvoiced", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeInvoiced
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeRedeemed", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeRedeemed
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciUsageProxySubscriptionRedemptions.DataOciUsageProxySubscriptionRedemptionsRedemptionCollectionItemsItems\"}", isOptional: true)]
        public virtual oci.DataOciUsageProxySubscriptionRedemptions.IDataOciUsageProxySubscriptionRedemptionsRedemptionCollectionItemsItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciUsageProxySubscriptionRedemptions.IDataOciUsageProxySubscriptionRedemptionsRedemptionCollectionItemsItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
