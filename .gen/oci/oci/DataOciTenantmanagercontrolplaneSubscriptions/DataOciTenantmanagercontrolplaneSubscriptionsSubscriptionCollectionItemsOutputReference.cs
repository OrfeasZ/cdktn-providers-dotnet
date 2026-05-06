using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciTenantmanagercontrolplaneSubscriptions
{
    [JsiiClass(nativeType: typeof(oci.DataOciTenantmanagercontrolplaneSubscriptions.DataOciTenantmanagercontrolplaneSubscriptionsSubscriptionCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciTenantmanagercontrolplaneSubscriptions.DataOciTenantmanagercontrolplaneSubscriptionsSubscriptionCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciTenantmanagercontrolplaneSubscriptionsSubscriptionCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciTenantmanagercontrolplaneSubscriptionsSubscriptionCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciTenantmanagercontrolplaneSubscriptionsSubscriptionCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciTenantmanagercontrolplaneSubscriptionsSubscriptionCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "classicSubscriptionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClassicSubscriptionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cloudAmountCurrency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudAmountCurrency
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "csiNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CsiNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "currencyCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CurrencyCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customerCountryCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerCountryCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "endDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "entityVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EntityVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isClassicSubscription", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsClassicSubscription
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isGovernmentSubscription", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsGovernmentSubscription
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "paymentModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PaymentModel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "programType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProgramType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "promotion", typeJson: "{\"fqn\":\"oci.dataOciTenantmanagercontrolplaneSubscriptions.DataOciTenantmanagercontrolplaneSubscriptionsSubscriptionCollectionItemsPromotionList\"}")]
        public virtual oci.DataOciTenantmanagercontrolplaneSubscriptions.DataOciTenantmanagercontrolplaneSubscriptionsSubscriptionCollectionItemsPromotionList Promotion
        {
            get => GetInstanceProperty<oci.DataOciTenantmanagercontrolplaneSubscriptions.DataOciTenantmanagercontrolplaneSubscriptionsSubscriptionCollectionItemsPromotionList>()!;
        }

        [JsiiProperty(name: "purchaseEntitlementId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PurchaseEntitlementId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "regionAssignment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegionAssignment
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "skus", typeJson: "{\"fqn\":\"oci.dataOciTenantmanagercontrolplaneSubscriptions.DataOciTenantmanagercontrolplaneSubscriptionsSubscriptionCollectionItemsSkusList\"}")]
        public virtual oci.DataOciTenantmanagercontrolplaneSubscriptions.DataOciTenantmanagercontrolplaneSubscriptionsSubscriptionCollectionItemsSkusList Skus
        {
            get => GetInstanceProperty<oci.DataOciTenantmanagercontrolplaneSubscriptions.DataOciTenantmanagercontrolplaneSubscriptionsSubscriptionCollectionItemsSkusList>()!;
        }

        [JsiiProperty(name: "startDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subscriptionNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubscriptionNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subscriptionTier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubscriptionTier
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciTenantmanagercontrolplaneSubscriptions.DataOciTenantmanagercontrolplaneSubscriptionsSubscriptionCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciTenantmanagercontrolplaneSubscriptions.IDataOciTenantmanagercontrolplaneSubscriptionsSubscriptionCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciTenantmanagercontrolplaneSubscriptions.IDataOciTenantmanagercontrolplaneSubscriptionsSubscriptionCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
