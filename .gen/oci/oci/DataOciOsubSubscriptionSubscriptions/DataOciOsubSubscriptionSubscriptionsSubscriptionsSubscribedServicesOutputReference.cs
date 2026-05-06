using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOsubSubscriptionSubscriptions
{
    [JsiiClass(nativeType: typeof(oci.DataOciOsubSubscriptionSubscriptions.DataOciOsubSubscriptionSubscriptionsSubscriptionsSubscribedServicesOutputReference), fullyQualifiedName: "oci.dataOciOsubSubscriptionSubscriptions.DataOciOsubSubscriptionSubscriptionsSubscriptionsSubscribedServicesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOsubSubscriptionSubscriptionsSubscriptionsSubscribedServicesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOsubSubscriptionSubscriptionsSubscriptionsSubscribedServicesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOsubSubscriptionSubscriptionsSubscriptionsSubscribedServicesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOsubSubscriptionSubscriptionsSubscriptionsSubscribedServicesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "bookingOptyNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BookingOptyNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "commitmentServices", typeJson: "{\"fqn\":\"oci.dataOciOsubSubscriptionSubscriptions.DataOciOsubSubscriptionSubscriptionsSubscriptionsSubscribedServicesCommitmentServicesList\"}")]
        public virtual oci.DataOciOsubSubscriptionSubscriptions.DataOciOsubSubscriptionSubscriptionsSubscriptionsSubscribedServicesCommitmentServicesList CommitmentServices
        {
            get => GetInstanceProperty<oci.DataOciOsubSubscriptionSubscriptions.DataOciOsubSubscriptionSubscriptionsSubscriptionsSubscribedServicesCommitmentServicesList>()!;
        }

        [JsiiProperty(name: "csi", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Csi
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataCenterRegion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataCenterRegion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fundedAllocationValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FundedAllocationValue
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isIntentToPay", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsIntentToPay
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "netUnitPrice", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetUnitPrice
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "operationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OperationType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "orderNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OrderNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "partnerTransactionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PartnerTransactionType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pricingModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PricingModel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "product", typeJson: "{\"fqn\":\"oci.dataOciOsubSubscriptionSubscriptions.DataOciOsubSubscriptionSubscriptionsSubscriptionsSubscribedServicesProductList\"}")]
        public virtual oci.DataOciOsubSubscriptionSubscriptions.DataOciOsubSubscriptionSubscriptionsSubscriptionsSubscribedServicesProductList Product
        {
            get => GetInstanceProperty<oci.DataOciOsubSubscriptionSubscriptions.DataOciOsubSubscriptionSubscriptionsSubscriptionsSubscribedServicesProductList>()!;
        }

        [JsiiProperty(name: "programType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProgramType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "promoType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PromoType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "quantity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Quantity
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "termValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TermValue
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "termValueUom", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TermValueUom
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

        [JsiiProperty(name: "totalValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalValue
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOsubSubscriptionSubscriptions.DataOciOsubSubscriptionSubscriptionsSubscriptionsSubscribedServices\"}", isOptional: true)]
        public virtual oci.DataOciOsubSubscriptionSubscriptions.IDataOciOsubSubscriptionSubscriptionsSubscriptionsSubscribedServices? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOsubSubscriptionSubscriptions.IDataOciOsubSubscriptionSubscriptionsSubscriptionsSubscribedServices?>();
            set => SetInstanceProperty(value);
        }
    }
}
