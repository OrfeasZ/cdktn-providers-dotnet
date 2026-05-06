using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOnesubscriptionSubscribedService
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/onesubscription_subscribed_service oci_onesubscription_subscribed_service}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedService), fullyQualifiedName: "oci.dataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedService", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceConfig\"}}]")]
    public class DataOciOnesubscriptionSubscribedService : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/onesubscription_subscribed_service oci_onesubscription_subscribed_service} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciOnesubscriptionSubscribedService(Constructs.Construct scope, string id, oci.DataOciOnesubscriptionSubscribedService.IDataOciOnesubscriptionSubscribedServiceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciOnesubscriptionSubscribedService.IDataOciOnesubscriptionSubscribedServiceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOnesubscriptionSubscribedService(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOnesubscriptionSubscribedService(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciOnesubscriptionSubscribedService resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciOnesubscriptionSubscribedService to import.</param>
        /// <param name="importFromId">The id of the existing DataOciOnesubscriptionSubscribedService that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciOnesubscriptionSubscribedService to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciOnesubscriptionSubscribedService to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/onesubscription_subscribed_service#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciOnesubscriptionSubscribedService that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciOnesubscriptionSubscribedService to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedService), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetFields")]
        public virtual void ResetFields()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(oci.DataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedService))!;

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

        [JsiiProperty(name: "billToAddress", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceBillToAddressList\"}")]
        public virtual oci.DataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceBillToAddressList BillToAddress
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceBillToAddressList>()!;
        }

        [JsiiProperty(name: "billToContact", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceBillToContactList\"}")]
        public virtual oci.DataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceBillToContactList BillToContact
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceBillToContactList>()!;
        }

        [JsiiProperty(name: "billToCustomer", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceBillToCustomerList\"}")]
        public virtual oci.DataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceBillToCustomerList BillToCustomer
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceBillToCustomerList>()!;
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

        [JsiiProperty(name: "commitmentServices", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceCommitmentServicesList\"}")]
        public virtual oci.DataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceCommitmentServicesList CommitmentServices
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceCommitmentServicesList>()!;
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

        [JsiiProperty(name: "endUserAddress", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceEndUserAddressList\"}")]
        public virtual oci.DataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceEndUserAddressList EndUserAddress
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceEndUserAddressList>()!;
        }

        [JsiiProperty(name: "endUserContact", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceEndUserContactList\"}")]
        public virtual oci.DataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceEndUserContactList EndUserContact
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceEndUserContactList>()!;
        }

        [JsiiProperty(name: "endUserCustomer", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceEndUserCustomerList\"}")]
        public virtual oci.DataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceEndUserCustomerList EndUserCustomer
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceEndUserCustomerList>()!;
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

        [JsiiProperty(name: "paymentTerm", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServicePaymentTermList\"}")]
        public virtual oci.DataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServicePaymentTermList PaymentTerm
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServicePaymentTermList>()!;
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

        [JsiiProperty(name: "product", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceProductList\"}")]
        public virtual oci.DataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceProductList Product
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceProductList>()!;
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

        [JsiiProperty(name: "rateCards", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceRateCardsList\"}")]
        public virtual oci.DataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceRateCardsList RateCards
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceRateCardsList>()!;
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

        [JsiiProperty(name: "resellerAddress", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceResellerAddressList\"}")]
        public virtual oci.DataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceResellerAddressList ResellerAddress
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceResellerAddressList>()!;
        }

        [JsiiProperty(name: "resellerContact", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceResellerContactList\"}")]
        public virtual oci.DataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceResellerContactList ResellerContact
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceResellerContactList>()!;
        }

        [JsiiProperty(name: "resellerCustomer", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceResellerCustomerList\"}")]
        public virtual oci.DataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceResellerCustomerList ResellerCustomer
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceResellerCustomerList>()!;
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

        [JsiiProperty(name: "serviceToAddress", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceServiceToAddressList\"}")]
        public virtual oci.DataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceServiceToAddressList ServiceToAddress
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceServiceToAddressList>()!;
        }

        [JsiiProperty(name: "serviceToContact", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceServiceToContactList\"}")]
        public virtual oci.DataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceServiceToContactList ServiceToContact
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceServiceToContactList>()!;
        }

        [JsiiProperty(name: "serviceToCustomer", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceServiceToCustomerList\"}")]
        public virtual oci.DataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceServiceToCustomerList ServiceToCustomer
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceServiceToCustomerList>()!;
        }

        [JsiiProperty(name: "soldToContact", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceSoldToContactList\"}")]
        public virtual oci.DataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceSoldToContactList SoldToContact
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceSoldToContactList>()!;
        }

        [JsiiProperty(name: "soldToCustomer", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceSoldToCustomerList\"}")]
        public virtual oci.DataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceSoldToCustomerList SoldToCustomer
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionSubscribedService.DataOciOnesubscriptionSubscribedServiceSoldToCustomerList>()!;
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
        [JsiiProperty(name: "fieldsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? FieldsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subscribedServiceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubscribedServiceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "fields", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Fields
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subscribedServiceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubscribedServiceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
