using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOspGatewaySubscription
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/osp_gateway_subscription oci_osp_gateway_subscription}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciOspGatewaySubscription.DataOciOspGatewaySubscription), fullyQualifiedName: "oci.dataOciOspGatewaySubscription.DataOciOspGatewaySubscription", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciOspGatewaySubscription.DataOciOspGatewaySubscriptionConfig\"}}]")]
    public class DataOciOspGatewaySubscription : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/osp_gateway_subscription oci_osp_gateway_subscription} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciOspGatewaySubscription(Constructs.Construct scope, string id, oci.DataOciOspGatewaySubscription.IDataOciOspGatewaySubscriptionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciOspGatewaySubscription.IDataOciOspGatewaySubscriptionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOspGatewaySubscription(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOspGatewaySubscription(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciOspGatewaySubscription resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciOspGatewaySubscription to import.</param>
        /// <param name="importFromId">The id of the existing DataOciOspGatewaySubscription that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciOspGatewaySubscription to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciOspGatewaySubscription to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/osp_gateway_subscription#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciOspGatewaySubscription that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciOspGatewaySubscription to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciOspGatewaySubscription.DataOciOspGatewaySubscription), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciOspGatewaySubscription.DataOciOspGatewaySubscription))!;

        [JsiiProperty(name: "accountType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "billingAddress", typeJson: "{\"fqn\":\"oci.dataOciOspGatewaySubscription.DataOciOspGatewaySubscriptionBillingAddressList\"}")]
        public virtual oci.DataOciOspGatewaySubscription.DataOciOspGatewaySubscriptionBillingAddressList BillingAddress
        {
            get => GetInstanceProperty<oci.DataOciOspGatewaySubscription.DataOciOspGatewaySubscriptionBillingAddressList>()!;
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

        [JsiiProperty(name: "paymentGateway", typeJson: "{\"fqn\":\"oci.dataOciOspGatewaySubscription.DataOciOspGatewaySubscriptionPaymentGatewayList\"}")]
        public virtual oci.DataOciOspGatewaySubscription.DataOciOspGatewaySubscriptionPaymentGatewayList PaymentGateway
        {
            get => GetInstanceProperty<oci.DataOciOspGatewaySubscription.DataOciOspGatewaySubscriptionPaymentGatewayList>()!;
        }

        [JsiiProperty(name: "paymentOptions", typeJson: "{\"fqn\":\"oci.dataOciOspGatewaySubscription.DataOciOspGatewaySubscriptionPaymentOptionsList\"}")]
        public virtual oci.DataOciOspGatewaySubscription.DataOciOspGatewaySubscriptionPaymentOptionsList PaymentOptions
        {
            get => GetInstanceProperty<oci.DataOciOspGatewaySubscription.DataOciOspGatewaySubscriptionPaymentOptionsList>()!;
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

        [JsiiProperty(name: "subscription", typeJson: "{\"fqn\":\"oci.dataOciOspGatewaySubscription.DataOciOspGatewaySubscriptionSubscriptionList\"}")]
        public virtual oci.DataOciOspGatewaySubscription.DataOciOspGatewaySubscriptionSubscriptionList Subscription
        {
            get => GetInstanceProperty<oci.DataOciOspGatewaySubscription.DataOciOspGatewaySubscriptionSubscriptionList>()!;
        }

        [JsiiProperty(name: "subscriptionPlanNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubscriptionPlanNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "taxInfo", typeJson: "{\"fqn\":\"oci.dataOciOspGatewaySubscription.DataOciOspGatewaySubscriptionTaxInfoList\"}")]
        public virtual oci.DataOciOspGatewaySubscription.DataOciOspGatewaySubscriptionTaxInfoList TaxInfo
        {
            get => GetInstanceProperty<oci.DataOciOspGatewaySubscription.DataOciOspGatewaySubscriptionTaxInfoList>()!;
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
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ospHomeRegionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OspHomeRegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subscriptionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubscriptionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ospHomeRegion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OspHomeRegion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subscriptionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubscriptionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
