using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciTenantmanagercontrolplaneAssignedSubscriptions
{
    [JsiiClass(nativeType: typeof(oci.DataOciTenantmanagercontrolplaneAssignedSubscriptions.DataOciTenantmanagercontrolplaneAssignedSubscriptionsAssignedSubscriptionCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciTenantmanagercontrolplaneAssignedSubscriptions.DataOciTenantmanagercontrolplaneAssignedSubscriptionsAssignedSubscriptionCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciTenantmanagercontrolplaneAssignedSubscriptionsAssignedSubscriptionCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciTenantmanagercontrolplaneAssignedSubscriptionsAssignedSubscriptionCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciTenantmanagercontrolplaneAssignedSubscriptionsAssignedSubscriptionCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciTenantmanagercontrolplaneAssignedSubscriptionsAssignedSubscriptionCollectionItemsOutputReference(DeputyProps props): base(props)
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

        [JsiiProperty(name: "managedBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "orderIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] OrderIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "programType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProgramType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "promotion", typeJson: "{\"fqn\":\"oci.dataOciTenantmanagercontrolplaneAssignedSubscriptions.DataOciTenantmanagercontrolplaneAssignedSubscriptionsAssignedSubscriptionCollectionItemsPromotionList\"}")]
        public virtual oci.DataOciTenantmanagercontrolplaneAssignedSubscriptions.DataOciTenantmanagercontrolplaneAssignedSubscriptionsAssignedSubscriptionCollectionItemsPromotionList Promotion
        {
            get => GetInstanceProperty<oci.DataOciTenantmanagercontrolplaneAssignedSubscriptions.DataOciTenantmanagercontrolplaneAssignedSubscriptionsAssignedSubscriptionCollectionItemsPromotionList>()!;
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

        [JsiiProperty(name: "skus", typeJson: "{\"fqn\":\"oci.dataOciTenantmanagercontrolplaneAssignedSubscriptions.DataOciTenantmanagercontrolplaneAssignedSubscriptionsAssignedSubscriptionCollectionItemsSkusList\"}")]
        public virtual oci.DataOciTenantmanagercontrolplaneAssignedSubscriptions.DataOciTenantmanagercontrolplaneAssignedSubscriptionsAssignedSubscriptionCollectionItemsSkusList Skus
        {
            get => GetInstanceProperty<oci.DataOciTenantmanagercontrolplaneAssignedSubscriptions.DataOciTenantmanagercontrolplaneAssignedSubscriptionsAssignedSubscriptionCollectionItemsSkusList>()!;
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciTenantmanagercontrolplaneAssignedSubscriptions.DataOciTenantmanagercontrolplaneAssignedSubscriptionsAssignedSubscriptionCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciTenantmanagercontrolplaneAssignedSubscriptions.IDataOciTenantmanagercontrolplaneAssignedSubscriptionsAssignedSubscriptionCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciTenantmanagercontrolplaneAssignedSubscriptions.IDataOciTenantmanagercontrolplaneAssignedSubscriptionsAssignedSubscriptionCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
