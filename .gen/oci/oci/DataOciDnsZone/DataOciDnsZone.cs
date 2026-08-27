using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDnsZone
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/dns_zone oci_dns_zone}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDnsZone.DataOciDnsZone), fullyQualifiedName: "oci.dataOciDnsZone.DataOciDnsZone", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDnsZone.DataOciDnsZoneConfig\"}}]")]
    public class DataOciDnsZone : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/dns_zone oci_dns_zone} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDnsZone(Constructs.Construct scope, string id, oci.DataOciDnsZone.IDataOciDnsZoneConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDnsZone.IDataOciDnsZoneConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDnsZone(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDnsZone(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDnsZone resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDnsZone to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDnsZone that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDnsZone to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDnsZone to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/dns_zone#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDnsZone that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDnsZone to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDnsZone.DataOciDnsZone), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetCompartmentId")]
        public virtual void ResetCompartmentId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScope")]
        public virtual void ResetScope()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetViewId")]
        public virtual void ResetViewId()
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
        = GetStaticProperty<string>(typeof(oci.DataOciDnsZone.DataOciDnsZone))!;

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "dnssecConfig", typeJson: "{\"fqn\":\"oci.dataOciDnsZone.DataOciDnsZoneDnssecConfigList\"}")]
        public virtual oci.DataOciDnsZone.DataOciDnsZoneDnssecConfigList DnssecConfig
        {
            get => GetInstanceProperty<oci.DataOciDnsZone.DataOciDnsZoneDnssecConfigList>()!;
        }

        [JsiiProperty(name: "dnssecState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DnssecState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "externalDownstreams", typeJson: "{\"fqn\":\"oci.dataOciDnsZone.DataOciDnsZoneExternalDownstreamsList\"}")]
        public virtual oci.DataOciDnsZone.DataOciDnsZoneExternalDownstreamsList ExternalDownstreams
        {
            get => GetInstanceProperty<oci.DataOciDnsZone.DataOciDnsZoneExternalDownstreamsList>()!;
        }

        [JsiiProperty(name: "externalMasters", typeJson: "{\"fqn\":\"oci.dataOciDnsZone.DataOciDnsZoneExternalMastersList\"}")]
        public virtual oci.DataOciDnsZone.DataOciDnsZoneExternalMastersList ExternalMasters
        {
            get => GetInstanceProperty<oci.DataOciDnsZone.DataOciDnsZoneExternalMastersList>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isProtected", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsProtected
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nameservers", typeJson: "{\"fqn\":\"oci.dataOciDnsZone.DataOciDnsZoneNameserversList\"}")]
        public virtual oci.DataOciDnsZone.DataOciDnsZoneNameserversList Nameservers
        {
            get => GetInstanceProperty<oci.DataOciDnsZone.DataOciDnsZoneNameserversList>()!;
        }

        [JsiiProperty(name: "resolutionMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResolutionMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "selfAttribute", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SelfAttribute
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serial", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Serial
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "zoneTransferServers", typeJson: "{\"fqn\":\"oci.dataOciDnsZone.DataOciDnsZoneZoneTransferServersList\"}")]
        public virtual oci.DataOciDnsZone.DataOciDnsZoneZoneTransferServersList ZoneTransferServers
        {
            get => GetInstanceProperty<oci.DataOciDnsZone.DataOciDnsZoneZoneTransferServersList>()!;
        }

        [JsiiProperty(name: "zoneType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ZoneType
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
        [JsiiProperty(name: "scopeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScopeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "viewIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ViewIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zoneNameOrIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ZoneNameOrIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Scope
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "viewId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ViewId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "zoneNameOrId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ZoneNameOrId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
