using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareMagicTransitSiteWan
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/magic_transit_site_wan cloudflare_magic_transit_site_wan}.</summary>
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareMagicTransitSiteWan.DataCloudflareMagicTransitSiteWan), fullyQualifiedName: "cloudflare.dataCloudflareMagicTransitSiteWan.DataCloudflareMagicTransitSiteWan", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"cloudflare.dataCloudflareMagicTransitSiteWan.DataCloudflareMagicTransitSiteWanConfig\"}}]")]
    public class DataCloudflareMagicTransitSiteWan : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/magic_transit_site_wan cloudflare_magic_transit_site_wan} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataCloudflareMagicTransitSiteWan(Constructs.Construct scope, string id, cloudflare.DataCloudflareMagicTransitSiteWan.IDataCloudflareMagicTransitSiteWanConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, cloudflare.DataCloudflareMagicTransitSiteWan.IDataCloudflareMagicTransitSiteWanConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareMagicTransitSiteWan(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareMagicTransitSiteWan(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataCloudflareMagicTransitSiteWan resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataCloudflareMagicTransitSiteWan to import.</param>
        /// <param name="importFromId">The id of the existing DataCloudflareMagicTransitSiteWan that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataCloudflareMagicTransitSiteWan to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataCloudflareMagicTransitSiteWan to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/magic_transit_site_wan#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataCloudflareMagicTransitSiteWan that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataCloudflareMagicTransitSiteWan to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(cloudflare.DataCloudflareMagicTransitSiteWan.DataCloudflareMagicTransitSiteWan), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(cloudflare.DataCloudflareMagicTransitSiteWan.DataCloudflareMagicTransitSiteWan))!;

        [JsiiProperty(name: "healthCheckRate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HealthCheckRate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "physport", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Physport
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Priority
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "staticAddressing", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareMagicTransitSiteWan.DataCloudflareMagicTransitSiteWanStaticAddressingOutputReference\"}")]
        public virtual cloudflare.DataCloudflareMagicTransitSiteWan.DataCloudflareMagicTransitSiteWanStaticAddressingOutputReference StaticAddressing
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareMagicTransitSiteWan.DataCloudflareMagicTransitSiteWanStaticAddressingOutputReference>()!;
        }

        [JsiiProperty(name: "vlanTag", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double VlanTag
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "siteIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SiteIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "wanIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WanIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "siteId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SiteId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "wanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WanId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
