using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOspGatewaySubscriptions
{
    [JsiiClass(nativeType: typeof(oci.DataOciOspGatewaySubscriptions.DataOciOspGatewaySubscriptionsSubscriptionCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciOspGatewaySubscriptions.DataOciOspGatewaySubscriptionsSubscriptionCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOspGatewaySubscriptionsSubscriptionCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOspGatewaySubscriptionsSubscriptionCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOspGatewaySubscriptionsSubscriptionCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOspGatewaySubscriptionsSubscriptionCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accountType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "billingAddress", typeJson: "{\"fqn\":\"oci.dataOciOspGatewaySubscriptions.DataOciOspGatewaySubscriptionsSubscriptionCollectionItemsBillingAddressList\"}")]
        public virtual oci.DataOciOspGatewaySubscriptions.DataOciOspGatewaySubscriptionsSubscriptionCollectionItemsBillingAddressList BillingAddress
        {
            get => GetInstanceProperty<oci.DataOciOspGatewaySubscriptions.DataOciOspGatewaySubscriptionsSubscriptionCollectionItemsBillingAddressList>()!;
        }

        [JsiiProperty(name: "billToCustAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BillToCustAccountId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "currencyCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CurrencyCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Email
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "gsiOrgCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GsiOrgCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isCorporateConversionAllowed", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsCorporateConversionAllowed
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isIntentToPay", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsIntentToPay
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "languageCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LanguageCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "organizationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OrganizationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ospHomeRegion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OspHomeRegion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "paymentGateway", typeJson: "{\"fqn\":\"oci.dataOciOspGatewaySubscriptions.DataOciOspGatewaySubscriptionsSubscriptionCollectionItemsPaymentGatewayList\"}")]
        public virtual oci.DataOciOspGatewaySubscriptions.DataOciOspGatewaySubscriptionsSubscriptionCollectionItemsPaymentGatewayList PaymentGateway
        {
            get => GetInstanceProperty<oci.DataOciOspGatewaySubscriptions.DataOciOspGatewaySubscriptionsSubscriptionCollectionItemsPaymentGatewayList>()!;
        }

        [JsiiProperty(name: "paymentOptions", typeJson: "{\"fqn\":\"oci.dataOciOspGatewaySubscriptions.DataOciOspGatewaySubscriptionsSubscriptionCollectionItemsPaymentOptionsList\"}")]
        public virtual oci.DataOciOspGatewaySubscriptions.DataOciOspGatewaySubscriptionsSubscriptionCollectionItemsPaymentOptionsList PaymentOptions
        {
            get => GetInstanceProperty<oci.DataOciOspGatewaySubscriptions.DataOciOspGatewaySubscriptionsSubscriptionCollectionItemsPaymentOptionsList>()!;
        }

        [JsiiProperty(name: "planType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlanType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shipToCustAcctRoleId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShipToCustAcctRoleId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shipToCustAcctSiteId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShipToCustAcctSiteId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subscription", typeJson: "{\"fqn\":\"oci.dataOciOspGatewaySubscriptions.DataOciOspGatewaySubscriptionsSubscriptionCollectionItemsSubscriptionList\"}")]
        public virtual oci.DataOciOspGatewaySubscriptions.DataOciOspGatewaySubscriptionsSubscriptionCollectionItemsSubscriptionList Subscription
        {
            get => GetInstanceProperty<oci.DataOciOspGatewaySubscriptions.DataOciOspGatewaySubscriptionsSubscriptionCollectionItemsSubscriptionList>()!;
        }

        [JsiiProperty(name: "subscriptionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubscriptionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subscriptionPlanNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubscriptionPlanNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "taxInfo", typeJson: "{\"fqn\":\"oci.dataOciOspGatewaySubscriptions.DataOciOspGatewaySubscriptionsSubscriptionCollectionItemsTaxInfoList\"}")]
        public virtual oci.DataOciOspGatewaySubscriptions.DataOciOspGatewaySubscriptionsSubscriptionCollectionItemsTaxInfoList TaxInfo
        {
            get => GetInstanceProperty<oci.DataOciOspGatewaySubscriptions.DataOciOspGatewaySubscriptionsSubscriptionCollectionItemsTaxInfoList>()!;
        }

        [JsiiProperty(name: "timePersonalToCorporateConv", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimePersonalToCorporateConv
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timePlanUpgrade", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimePlanUpgrade
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeStart", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStart
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "upgradeState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpgradeState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "upgradeStateDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpgradeStateDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOspGatewaySubscriptions.DataOciOspGatewaySubscriptionsSubscriptionCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciOspGatewaySubscriptions.IDataOciOspGatewaySubscriptionsSubscriptionCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOspGatewaySubscriptions.IDataOciOspGatewaySubscriptionsSubscriptionCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
