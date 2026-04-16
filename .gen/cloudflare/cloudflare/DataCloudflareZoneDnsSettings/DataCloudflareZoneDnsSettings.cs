using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZoneDnsSettings
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zone_dns_settings cloudflare_zone_dns_settings}.</summary>
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZoneDnsSettings.DataCloudflareZoneDnsSettings), fullyQualifiedName: "cloudflare.dataCloudflareZoneDnsSettings.DataCloudflareZoneDnsSettings", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"cloudflare.dataCloudflareZoneDnsSettings.DataCloudflareZoneDnsSettingsConfig\"}}]")]
    public class DataCloudflareZoneDnsSettings : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zone_dns_settings cloudflare_zone_dns_settings} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataCloudflareZoneDnsSettings(Constructs.Construct scope, string id, cloudflare.DataCloudflareZoneDnsSettings.IDataCloudflareZoneDnsSettingsConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, cloudflare.DataCloudflareZoneDnsSettings.IDataCloudflareZoneDnsSettingsConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZoneDnsSettings(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZoneDnsSettings(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataCloudflareZoneDnsSettings resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataCloudflareZoneDnsSettings to import.</param>
        /// <param name="importFromId">The id of the existing DataCloudflareZoneDnsSettings that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataCloudflareZoneDnsSettings to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataCloudflareZoneDnsSettings to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zone_dns_settings#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataCloudflareZoneDnsSettings that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataCloudflareZoneDnsSettings to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(cloudflare.DataCloudflareZoneDnsSettings.DataCloudflareZoneDnsSettings), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(cloudflare.DataCloudflareZoneDnsSettings.DataCloudflareZoneDnsSettings))!;

        [JsiiProperty(name: "flattenAllCnames", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable FlattenAllCnames
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "foundationDns", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable FoundationDns
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "internalDns", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZoneDnsSettings.DataCloudflareZoneDnsSettingsInternalDnsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZoneDnsSettings.DataCloudflareZoneDnsSettingsInternalDnsOutputReference InternalDns
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZoneDnsSettings.DataCloudflareZoneDnsSettingsInternalDnsOutputReference>()!;
        }

        [JsiiProperty(name: "multiProvider", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable MultiProvider
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "nameservers", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZoneDnsSettings.DataCloudflareZoneDnsSettingsNameserversOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZoneDnsSettings.DataCloudflareZoneDnsSettingsNameserversOutputReference Nameservers
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZoneDnsSettings.DataCloudflareZoneDnsSettingsNameserversOutputReference>()!;
        }

        [JsiiProperty(name: "nsTtl", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NsTtl
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "secondaryOverrides", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable SecondaryOverrides
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "soa", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZoneDnsSettings.DataCloudflareZoneDnsSettingsSoaOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZoneDnsSettings.DataCloudflareZoneDnsSettingsSoaOutputReference Soa
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZoneDnsSettings.DataCloudflareZoneDnsSettingsSoaOutputReference>()!;
        }

        [JsiiProperty(name: "zoneMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ZoneMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "zoneIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ZoneIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ZoneId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
