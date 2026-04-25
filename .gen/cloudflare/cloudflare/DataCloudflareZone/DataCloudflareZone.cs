using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZone
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zone cloudflare_zone}.</summary>
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZone.DataCloudflareZone), fullyQualifiedName: "cloudflare.dataCloudflareZone.DataCloudflareZone", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"cloudflare.dataCloudflareZone.DataCloudflareZoneConfig\"}}]")]
    public class DataCloudflareZone : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zone cloudflare_zone} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataCloudflareZone(Constructs.Construct scope, string id, cloudflare.DataCloudflareZone.IDataCloudflareZoneConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, cloudflare.DataCloudflareZone.IDataCloudflareZoneConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZone(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZone(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataCloudflareZone resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataCloudflareZone to import.</param>
        /// <param name="importFromId">The id of the existing DataCloudflareZone that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataCloudflareZone to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataCloudflareZone to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zone#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataCloudflareZone that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataCloudflareZone to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(cloudflare.DataCloudflareZone.DataCloudflareZone), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.dataCloudflareZone.DataCloudflareZoneFilter\"}}]")]
        public virtual void PutFilter(cloudflare.DataCloudflareZone.IDataCloudflareZoneFilter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.DataCloudflareZone.IDataCloudflareZoneFilter)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetZoneId")]
        public virtual void ResetZoneId()
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
        = GetStaticProperty<string>(typeof(cloudflare.DataCloudflareZone.DataCloudflareZone))!;

        [JsiiProperty(name: "account", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZone.DataCloudflareZoneAccountOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZone.DataCloudflareZoneAccountOutputReference Account
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZone.DataCloudflareZoneAccountOutputReference>()!;
        }

        [JsiiProperty(name: "activatedOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActivatedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cnameSuffix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CnameSuffix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "developmentMode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DevelopmentMode
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZone.DataCloudflareZoneFilterOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZone.DataCloudflareZoneFilterOutputReference Filter
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZone.DataCloudflareZoneFilterOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZone.DataCloudflareZoneMetaOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZone.DataCloudflareZoneMetaOutputReference Meta
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZone.DataCloudflareZoneMetaOutputReference>()!;
        }

        [JsiiProperty(name: "modifiedOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModifiedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nameServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NameServers
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "originalDnshost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OriginalDnshost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "originalNameServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] OriginalNameServers
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "originalRegistrar", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OriginalRegistrar
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "owner", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZone.DataCloudflareZoneOwnerOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZone.DataCloudflareZoneOwnerOutputReference Owner
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZone.DataCloudflareZoneOwnerOutputReference>()!;
        }

        [JsiiProperty(name: "paused", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Paused
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "permissions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Permissions
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "plan", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZone.DataCloudflareZonePlanOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZone.DataCloudflareZonePlanOutputReference Plan
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZone.DataCloudflareZonePlanOutputReference>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tenant", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZone.DataCloudflareZoneTenantOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZone.DataCloudflareZoneTenantOutputReference Tenant
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZone.DataCloudflareZoneTenantOutputReference>()!;
        }

        [JsiiProperty(name: "tenantUnit", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZone.DataCloudflareZoneTenantUnitOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZone.DataCloudflareZoneTenantUnitOutputReference TenantUnit
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZone.DataCloudflareZoneTenantUnitOutputReference>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vanityNameServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] VanityNameServers
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "verificationKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VerificationKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.dataCloudflareZone.DataCloudflareZoneFilter\"}]}}", isOptional: true)]
        public virtual object? FilterInput
        {
            get => GetInstanceProperty<object?>();
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
