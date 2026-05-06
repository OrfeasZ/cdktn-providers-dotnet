using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DnsActionCreateZoneFromZoneFile
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_action_create_zone_from_zone_file oci_dns_action_create_zone_from_zone_file}.</summary>
    [JsiiClass(nativeType: typeof(oci.DnsActionCreateZoneFromZoneFile.DnsActionCreateZoneFromZoneFile), fullyQualifiedName: "oci.dnsActionCreateZoneFromZoneFile.DnsActionCreateZoneFromZoneFile", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dnsActionCreateZoneFromZoneFile.DnsActionCreateZoneFromZoneFileConfig\"}}]")]
    public class DnsActionCreateZoneFromZoneFile : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_action_create_zone_from_zone_file oci_dns_action_create_zone_from_zone_file} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DnsActionCreateZoneFromZoneFile(Constructs.Construct scope, string id, oci.DnsActionCreateZoneFromZoneFile.IDnsActionCreateZoneFromZoneFileConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DnsActionCreateZoneFromZoneFile.IDnsActionCreateZoneFromZoneFileConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DnsActionCreateZoneFromZoneFile(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DnsActionCreateZoneFromZoneFile(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DnsActionCreateZoneFromZoneFile resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DnsActionCreateZoneFromZoneFile to import.</param>
        /// <param name="importFromId">The id of the existing DnsActionCreateZoneFromZoneFile that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DnsActionCreateZoneFromZoneFile to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DnsActionCreateZoneFromZoneFile to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_action_create_zone_from_zone_file#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DnsActionCreateZoneFromZoneFile that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DnsActionCreateZoneFromZoneFile to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DnsActionCreateZoneFromZoneFile.DnsActionCreateZoneFromZoneFile), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dnsActionCreateZoneFromZoneFile.DnsActionCreateZoneFromZoneFileTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DnsActionCreateZoneFromZoneFile.IDnsActionCreateZoneFromZoneFileTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DnsActionCreateZoneFromZoneFile.IDnsActionCreateZoneFromZoneFileTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScope")]
        public virtual void ResetScope()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(oci.DnsActionCreateZoneFromZoneFile.DnsActionCreateZoneFromZoneFile))!;

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "dnssecConfig", typeJson: "{\"fqn\":\"oci.dnsActionCreateZoneFromZoneFile.DnsActionCreateZoneFromZoneFileDnssecConfigList\"}")]
        public virtual oci.DnsActionCreateZoneFromZoneFile.DnsActionCreateZoneFromZoneFileDnssecConfigList DnssecConfig
        {
            get => GetInstanceProperty<oci.DnsActionCreateZoneFromZoneFile.DnsActionCreateZoneFromZoneFileDnssecConfigList>()!;
        }

        [JsiiProperty(name: "dnssecState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DnssecState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "externalDownstreams", typeJson: "{\"fqn\":\"oci.dnsActionCreateZoneFromZoneFile.DnsActionCreateZoneFromZoneFileExternalDownstreamsList\"}")]
        public virtual oci.DnsActionCreateZoneFromZoneFile.DnsActionCreateZoneFromZoneFileExternalDownstreamsList ExternalDownstreams
        {
            get => GetInstanceProperty<oci.DnsActionCreateZoneFromZoneFile.DnsActionCreateZoneFromZoneFileExternalDownstreamsList>()!;
        }

        [JsiiProperty(name: "externalMasters", typeJson: "{\"fqn\":\"oci.dnsActionCreateZoneFromZoneFile.DnsActionCreateZoneFromZoneFileExternalMastersList\"}")]
        public virtual oci.DnsActionCreateZoneFromZoneFile.DnsActionCreateZoneFromZoneFileExternalMastersList ExternalMasters
        {
            get => GetInstanceProperty<oci.DnsActionCreateZoneFromZoneFile.DnsActionCreateZoneFromZoneFileExternalMastersList>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
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

        [JsiiProperty(name: "nameservers", typeJson: "{\"fqn\":\"oci.dnsActionCreateZoneFromZoneFile.DnsActionCreateZoneFromZoneFileNameserversList\"}")]
        public virtual oci.DnsActionCreateZoneFromZoneFile.DnsActionCreateZoneFromZoneFileNameserversList Nameservers
        {
            get => GetInstanceProperty<oci.DnsActionCreateZoneFromZoneFile.DnsActionCreateZoneFromZoneFileNameserversList>()!;
        }

        [JsiiProperty(name: "selfAttribute", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SelfAttribute
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serial", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Serial
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dnsActionCreateZoneFromZoneFile.DnsActionCreateZoneFromZoneFileTimeoutsOutputReference\"}")]
        public virtual oci.DnsActionCreateZoneFromZoneFile.DnsActionCreateZoneFromZoneFileTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DnsActionCreateZoneFromZoneFile.DnsActionCreateZoneFromZoneFileTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "zoneTransferServers", typeJson: "{\"fqn\":\"oci.dnsActionCreateZoneFromZoneFile.DnsActionCreateZoneFromZoneFileZoneTransferServersList\"}")]
        public virtual oci.DnsActionCreateZoneFromZoneFile.DnsActionCreateZoneFromZoneFileZoneTransferServersList ZoneTransferServers
        {
            get => GetInstanceProperty<oci.DnsActionCreateZoneFromZoneFile.DnsActionCreateZoneFromZoneFileZoneTransferServersList>()!;
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
        [JsiiProperty(name: "createZoneFromZoneFileDetailsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CreateZoneFromZoneFileDetailsInput
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
        [JsiiProperty(name: "scopeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScopeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.dnsActionCreateZoneFromZoneFile.DnsActionCreateZoneFromZoneFileTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "viewIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ViewIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "createZoneFromZoneFileDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreateZoneFromZoneFileDetails
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
    }
}
