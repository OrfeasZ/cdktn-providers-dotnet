using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOspGatewaySubscription
{
    [JsiiClass(nativeType: typeof(oci.DataOciOspGatewaySubscription.DataOciOspGatewaySubscriptionSubscriptionOutputReference), fullyQualifiedName: "oci.dataOciOspGatewaySubscription.DataOciOspGatewaySubscriptionSubscriptionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOspGatewaySubscriptionSubscriptionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOspGatewaySubscriptionSubscriptionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOspGatewaySubscriptionSubscriptionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOspGatewaySubscriptionSubscriptionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accountType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "billingAddress", typeJson: "{\"fqn\":\"oci.dataOciOspGatewaySubscription.DataOciOspGatewaySubscriptionSubscriptionBillingAddressList\"}")]
        public virtual oci.DataOciOspGatewaySubscription.DataOciOspGatewaySubscriptionSubscriptionBillingAddressList BillingAddress
        {
            get => GetInstanceProperty<oci.DataOciOspGatewaySubscription.DataOciOspGatewaySubscriptionSubscriptionBillingAddressList>()!;
        }

        [JsiiProperty(name: "billToCustAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BillToCustAccountId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "currencyCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CurrencyCode
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

        [JsiiProperty(name: "paymentGateway", typeJson: "{\"fqn\":\"oci.dataOciOspGatewaySubscription.DataOciOspGatewaySubscriptionSubscriptionPaymentGatewayList\"}")]
        public virtual oci.DataOciOspGatewaySubscription.DataOciOspGatewaySubscriptionSubscriptionPaymentGatewayList PaymentGateway
        {
            get => GetInstanceProperty<oci.DataOciOspGatewaySubscription.DataOciOspGatewaySubscriptionSubscriptionPaymentGatewayList>()!;
        }

        [JsiiProperty(name: "paymentOptions", typeJson: "{\"fqn\":\"oci.dataOciOspGatewaySubscription.DataOciOspGatewaySubscriptionSubscriptionPaymentOptionsList\"}")]
        public virtual oci.DataOciOspGatewaySubscription.DataOciOspGatewaySubscriptionSubscriptionPaymentOptionsList PaymentOptions
        {
            get => GetInstanceProperty<oci.DataOciOspGatewaySubscription.DataOciOspGatewaySubscriptionSubscriptionPaymentOptionsList>()!;
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

        [JsiiProperty(name: "subscriptionPlanNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubscriptionPlanNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "taxInfo", typeJson: "{\"fqn\":\"oci.dataOciOspGatewaySubscription.DataOciOspGatewaySubscriptionSubscriptionTaxInfoList\"}")]
        public virtual oci.DataOciOspGatewaySubscription.DataOciOspGatewaySubscriptionSubscriptionTaxInfoList TaxInfo
        {
            get => GetInstanceProperty<oci.DataOciOspGatewaySubscription.DataOciOspGatewaySubscriptionSubscriptionTaxInfoList>()!;
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOspGatewaySubscription.DataOciOspGatewaySubscriptionSubscription\"}", isOptional: true)]
        public virtual oci.DataOciOspGatewaySubscription.IDataOciOspGatewaySubscriptionSubscription? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOspGatewaySubscription.IDataOciOspGatewaySubscriptionSubscription?>();
            set => SetInstanceProperty(value);
        }
    }
}
