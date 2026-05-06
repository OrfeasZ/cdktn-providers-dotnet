using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOnesubscriptionSubscribedServices
{
    [JsiiClass(nativeType: typeof(oci.DataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesOutputReference), fullyQualifiedName: "oci.dataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOnesubscriptionSubscribedServicesSubscribedServicesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOnesubscriptionSubscribedServicesSubscribedServicesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOnesubscriptionSubscribedServicesSubscribedServicesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOnesubscriptionSubscribedServicesSubscribedServicesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "adminEmail", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminEmail
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "agreementId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgreementId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "agreementName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgreementName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "agreementType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgreementType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "availableAmount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailableAmount
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "billingFrequency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BillingFrequency
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "billToAddress", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesBillToAddressList\"}")]
        public virtual oci.DataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesBillToAddressList BillToAddress
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesBillToAddressList>()!;
        }

        [JsiiProperty(name: "billToContact", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesBillToContactList\"}")]
        public virtual oci.DataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesBillToContactList BillToContact
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesBillToContactList>()!;
        }

        [JsiiProperty(name: "billToCustomer", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesBillToCustomerList\"}")]
        public virtual oci.DataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesBillToCustomerList BillToCustomer
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesBillToCustomerList>()!;
        }

        [JsiiProperty(name: "bookingOptyNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BookingOptyNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "buyerEmail", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BuyerEmail
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "commitmentScheduleId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CommitmentScheduleId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "commitmentServices", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesCommitmentServicesList\"}")]
        public virtual oci.DataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesCommitmentServicesList CommitmentServices
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesCommitmentServicesList>()!;
        }

        [JsiiProperty(name: "createdBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "creditPercentage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreditPercentage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "csi", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Csi
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customerTransactionReference", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerTransactionReference
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataCenter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataCenter
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataCenterRegion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataCenterRegion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "eligibleToRenew", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EligibleToRenew
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endUserAddress", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesEndUserAddressList\"}")]
        public virtual oci.DataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesEndUserAddressList EndUserAddress
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesEndUserAddressList>()!;
        }

        [JsiiProperty(name: "endUserContact", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesEndUserContactList\"}")]
        public virtual oci.DataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesEndUserContactList EndUserContact
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesEndUserContactList>()!;
        }

        [JsiiProperty(name: "endUserCustomer", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesEndUserCustomerList\"}")]
        public virtual oci.DataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesEndUserCustomerList EndUserCustomer
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesEndUserCustomerList>()!;
        }

        [JsiiProperty(name: "fulfillmentSet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FulfillmentSet
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

        [JsiiProperty(name: "isAllowance", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAllowance
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isCapToPriceList", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsCapToPriceList
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isCreditEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsCreditEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isHavingUsage", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsHavingUsage
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isIntentToPay", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsIntentToPay
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isPayg", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsPayg
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isSingleRateCard", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSingleRateCard
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isVariableCommitment", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsVariableCommitment
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lineNetAmount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LineNetAmount
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "majorSet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MajorSet
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "orderHeaderId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OrderHeaderId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "orderLineId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OrderLineId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "orderLineNumber", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OrderLineNumber
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "orderNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OrderNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "orderType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OrderType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "originalPromoAmount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OriginalPromoAmount
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "overageBillTo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OverageBillTo
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "overageDiscountPercentage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OverageDiscountPercentage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "overagePolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OveragePolicy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "partnerCreditAmount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PartnerCreditAmount
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "partnerTransactionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PartnerTransactionType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "paygPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PaygPolicy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "paymentMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PaymentMethod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "paymentNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PaymentNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "paymentTerm", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesPaymentTermList\"}")]
        public virtual oci.DataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesPaymentTermList PaymentTerm
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesPaymentTermList>()!;
        }

        [JsiiProperty(name: "pricePeriod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PricePeriod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pricingModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PricingModel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "product", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesProductList\"}")]
        public virtual oci.DataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesProductList Product
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesProductList>()!;
        }

        [JsiiProperty(name: "programType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProgramType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "promoOrderLineId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PromoOrderLineId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "promotionPricingType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PromotionPricingType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "promoType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PromoType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "provisioningSource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProvisioningSource
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "quantity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Quantity
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rateCardDiscountPercentage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RateCardDiscountPercentage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rateCards", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesRateCardsList\"}")]
        public virtual oci.DataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesRateCardsList RateCards
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesRateCardsList>()!;
        }

        [JsiiProperty(name: "ratecardType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RatecardType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "renewalOptyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RenewalOptyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "renewalOptyNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RenewalOptyNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "renewalOptyType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RenewalOptyType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "renewedSubscribedServiceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RenewedSubscribedServiceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resellerAddress", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesResellerAddressList\"}")]
        public virtual oci.DataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesResellerAddressList ResellerAddress
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesResellerAddressList>()!;
        }

        [JsiiProperty(name: "resellerContact", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesResellerContactList\"}")]
        public virtual oci.DataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesResellerContactList ResellerContact
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesResellerContactList>()!;
        }

        [JsiiProperty(name: "resellerCustomer", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesResellerCustomerList\"}")]
        public virtual oci.DataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesResellerCustomerList ResellerCustomer
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesResellerCustomerList>()!;
        }

        [JsiiProperty(name: "revenueLineId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RevenueLineId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "revenueLineNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RevenueLineNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "revisedArrInLc", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RevisedArrInLc
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "revisedArrInSc", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RevisedArrInSc
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "salesAccountPartyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SalesAccountPartyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "salesChannel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SalesChannel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serialNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SerialNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceToAddress", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesServiceToAddressList\"}")]
        public virtual oci.DataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesServiceToAddressList ServiceToAddress
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesServiceToAddressList>()!;
        }

        [JsiiProperty(name: "serviceToContact", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesServiceToContactList\"}")]
        public virtual oci.DataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesServiceToContactList ServiceToContact
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesServiceToContactList>()!;
        }

        [JsiiProperty(name: "serviceToCustomer", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesServiceToCustomerList\"}")]
        public virtual oci.DataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesServiceToCustomerList ServiceToCustomer
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesServiceToCustomerList>()!;
        }

        [JsiiProperty(name: "soldToContact", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesSoldToContactList\"}")]
        public virtual oci.DataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesSoldToContactList SoldToContact
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesSoldToContactList>()!;
        }

        [JsiiProperty(name: "soldToCustomer", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesSoldToCustomerList\"}")]
        public virtual oci.DataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesSoldToCustomerList SoldToCustomer
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServicesSoldToCustomerList>()!;
        }

        [JsiiProperty(name: "startDateType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartDateType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subscriptionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubscriptionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subscriptionSource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubscriptionSource
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemArrInLc", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SystemArrInLc
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemArrInSc", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SystemArrInSc
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemAtrArrInLc", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SystemAtrArrInLc
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemAtrArrInSc", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SystemAtrArrInSc
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

        [JsiiProperty(name: "timeAgreementEnd", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeAgreementEnd
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCustomerConfig", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCustomerConfig
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeEnd", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeEnd
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeMajorsetEnd", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeMajorsetEnd
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeMajorsetStart", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeMajorsetStart
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timePaymentExpiry", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimePaymentExpiry
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeProvisioned", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeProvisioned
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeServiceConfigurationEmailSent", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeServiceConfigurationEmailSent
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeStart", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStart
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeWelcomeEmailSent", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeWelcomeEmailSent
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalValue
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "transactionExtensionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransactionExtensionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updatedBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "usedAmount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UsedAmount
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionSubscribedServices.DataOciOnesubscriptionSubscribedServicesSubscribedServices\"}", isOptional: true)]
        public virtual oci.DataOciOnesubscriptionSubscribedServices.IDataOciOnesubscriptionSubscribedServicesSubscribedServices? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionSubscribedServices.IDataOciOnesubscriptionSubscribedServicesSubscribedServices?>();
            set => SetInstanceProperty(value);
        }
    }
}
