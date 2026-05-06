using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciTenantmanagercontrolplaneSubscription
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/tenantmanagercontrolplane_subscription oci_tenantmanagercontrolplane_subscription}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciTenantmanagercontrolplaneSubscription.DataOciTenantmanagercontrolplaneSubscription), fullyQualifiedName: "oci.dataOciTenantmanagercontrolplaneSubscription.DataOciTenantmanagercontrolplaneSubscription", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciTenantmanagercontrolplaneSubscription.DataOciTenantmanagercontrolplaneSubscriptionConfig\"}}]")]
    public class DataOciTenantmanagercontrolplaneSubscription : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/tenantmanagercontrolplane_subscription oci_tenantmanagercontrolplane_subscription} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciTenantmanagercontrolplaneSubscription(Constructs.Construct scope, string id, oci.DataOciTenantmanagercontrolplaneSubscription.IDataOciTenantmanagercontrolplaneSubscriptionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciTenantmanagercontrolplaneSubscription.IDataOciTenantmanagercontrolplaneSubscriptionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciTenantmanagercontrolplaneSubscription(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciTenantmanagercontrolplaneSubscription(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciTenantmanagercontrolplaneSubscription resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciTenantmanagercontrolplaneSubscription to import.</param>
        /// <param name="importFromId">The id of the existing DataOciTenantmanagercontrolplaneSubscription that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciTenantmanagercontrolplaneSubscription to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciTenantmanagercontrolplaneSubscription to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/tenantmanagercontrolplane_subscription#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciTenantmanagercontrolplaneSubscription that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciTenantmanagercontrolplaneSubscription to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciTenantmanagercontrolplaneSubscription.DataOciTenantmanagercontrolplaneSubscription), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciTenantmanagercontrolplaneSubscription.DataOciTenantmanagercontrolplaneSubscription))!;

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

        [JsiiProperty(name: "promotion", typeJson: "{\"fqn\":\"oci.dataOciTenantmanagercontrolplaneSubscription.DataOciTenantmanagercontrolplaneSubscriptionPromotionList\"}")]
        public virtual oci.DataOciTenantmanagercontrolplaneSubscription.DataOciTenantmanagercontrolplaneSubscriptionPromotionList Promotion
        {
            get => GetInstanceProperty<oci.DataOciTenantmanagercontrolplaneSubscription.DataOciTenantmanagercontrolplaneSubscriptionPromotionList>()!;
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

        [JsiiProperty(name: "skus", typeJson: "{\"fqn\":\"oci.dataOciTenantmanagercontrolplaneSubscription.DataOciTenantmanagercontrolplaneSubscriptionSkusList\"}")]
        public virtual oci.DataOciTenantmanagercontrolplaneSubscription.DataOciTenantmanagercontrolplaneSubscriptionSkusList Skus
        {
            get => GetInstanceProperty<oci.DataOciTenantmanagercontrolplaneSubscription.DataOciTenantmanagercontrolplaneSubscriptionSkusList>()!;
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
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subscriptionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubscriptionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
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
