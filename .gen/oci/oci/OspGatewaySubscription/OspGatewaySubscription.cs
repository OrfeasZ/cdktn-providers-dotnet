using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OspGatewaySubscription
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription oci_osp_gateway_subscription}.</summary>
    [JsiiClass(nativeType: typeof(oci.OspGatewaySubscription.OspGatewaySubscription), fullyQualifiedName: "oci.ospGatewaySubscription.OspGatewaySubscription", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.ospGatewaySubscription.OspGatewaySubscriptionConfig\"}}]")]
    public class OspGatewaySubscription : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription oci_osp_gateway_subscription} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public OspGatewaySubscription(Constructs.Construct scope, string id, oci.OspGatewaySubscription.IOspGatewaySubscriptionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.OspGatewaySubscription.IOspGatewaySubscriptionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OspGatewaySubscription(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OspGatewaySubscription(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a OspGatewaySubscription resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the OspGatewaySubscription to import.</param>
        /// <param name="importFromId">The id of the existing OspGatewaySubscription that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the OspGatewaySubscription to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the OspGatewaySubscription to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing OspGatewaySubscription that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the OspGatewaySubscription to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.OspGatewaySubscription.OspGatewaySubscription), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putSubscription", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.ospGatewaySubscription.OspGatewaySubscriptionSubscription\"}}]")]
        public virtual void PutSubscription(oci.OspGatewaySubscription.IOspGatewaySubscriptionSubscription @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OspGatewaySubscription.IOspGatewaySubscriptionSubscription)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.ospGatewaySubscription.OspGatewaySubscriptionTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.OspGatewaySubscription.IOspGatewaySubscriptionTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OspGatewaySubscription.IOspGatewaySubscriptionTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(oci.OspGatewaySubscription.OspGatewaySubscription))!;

        [JsiiProperty(name: "accountType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "billingAddress", typeJson: "{\"fqn\":\"oci.ospGatewaySubscription.OspGatewaySubscriptionBillingAddressList\"}")]
        public virtual oci.OspGatewaySubscription.OspGatewaySubscriptionBillingAddressList BillingAddress
        {
            get => GetInstanceProperty<oci.OspGatewaySubscription.OspGatewaySubscriptionBillingAddressList>()!;
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

        [JsiiProperty(name: "paymentGateway", typeJson: "{\"fqn\":\"oci.ospGatewaySubscription.OspGatewaySubscriptionPaymentGatewayList\"}")]
        public virtual oci.OspGatewaySubscription.OspGatewaySubscriptionPaymentGatewayList PaymentGateway
        {
            get => GetInstanceProperty<oci.OspGatewaySubscription.OspGatewaySubscriptionPaymentGatewayList>()!;
        }

        [JsiiProperty(name: "paymentOptions", typeJson: "{\"fqn\":\"oci.ospGatewaySubscription.OspGatewaySubscriptionPaymentOptionsList\"}")]
        public virtual oci.OspGatewaySubscription.OspGatewaySubscriptionPaymentOptionsList PaymentOptions
        {
            get => GetInstanceProperty<oci.OspGatewaySubscription.OspGatewaySubscriptionPaymentOptionsList>()!;
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

        [JsiiProperty(name: "subscription", typeJson: "{\"fqn\":\"oci.ospGatewaySubscription.OspGatewaySubscriptionSubscriptionOutputReference\"}")]
        public virtual oci.OspGatewaySubscription.OspGatewaySubscriptionSubscriptionOutputReference Subscription
        {
            get => GetInstanceProperty<oci.OspGatewaySubscription.OspGatewaySubscriptionSubscriptionOutputReference>()!;
        }

        [JsiiProperty(name: "subscriptionPlanNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubscriptionPlanNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "taxInfo", typeJson: "{\"fqn\":\"oci.ospGatewaySubscription.OspGatewaySubscriptionTaxInfoList\"}")]
        public virtual oci.OspGatewaySubscription.OspGatewaySubscriptionTaxInfoList TaxInfo
        {
            get => GetInstanceProperty<oci.OspGatewaySubscription.OspGatewaySubscriptionTaxInfoList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.ospGatewaySubscription.OspGatewaySubscriptionTimeoutsOutputReference\"}")]
        public virtual oci.OspGatewaySubscription.OspGatewaySubscriptionTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.OspGatewaySubscription.OspGatewaySubscriptionTimeoutsOutputReference>()!;
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
        [JsiiProperty(name: "emailInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EmailInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
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

        [JsiiOptional]
        [JsiiProperty(name: "subscriptionInput", typeJson: "{\"fqn\":\"oci.ospGatewaySubscription.OspGatewaySubscriptionSubscription\"}", isOptional: true)]
        public virtual oci.OspGatewaySubscription.IOspGatewaySubscriptionSubscription? SubscriptionInput
        {
            get => GetInstanceProperty<oci.OspGatewaySubscription.IOspGatewaySubscriptionSubscription?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.ospGatewaySubscription.OspGatewaySubscriptionTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Email
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
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
