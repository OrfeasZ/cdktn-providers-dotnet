using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.InterlinkLink
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/interlink_link scaleway_interlink_link}.</summary>
    [JsiiClass(nativeType: typeof(scaleway.InterlinkLink.InterlinkLink), fullyQualifiedName: "scaleway.interlinkLink.InterlinkLink", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"scaleway.interlinkLink.InterlinkLinkConfig\"}}]")]
    public class InterlinkLink : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/interlink_link scaleway_interlink_link} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public InterlinkLink(Constructs.Construct scope, string id, scaleway.InterlinkLink.IInterlinkLinkConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, scaleway.InterlinkLink.IInterlinkLinkConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected InterlinkLink(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected InterlinkLink(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a InterlinkLink resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the InterlinkLink to import.</param>
        /// <param name="importFromId">The id of the existing InterlinkLink that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the InterlinkLink to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the InterlinkLink to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/interlink_link#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing InterlinkLink that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the InterlinkLink to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(scaleway.InterlinkLink.InterlinkLink), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.interlinkLink.InterlinkLinkTimeouts\"}}]")]
        public virtual void PutTimeouts(scaleway.InterlinkLink.IInterlinkLinkTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.InterlinkLink.IInterlinkLinkTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConnectionId")]
        public virtual void ResetConnectionId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPartnerId")]
        public virtual void ResetPartnerId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPeerAsn")]
        public virtual void ResetPeerAsn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProjectId")]
        public virtual void ResetProjectId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoutingPolicyV4Id")]
        public virtual void ResetRoutingPolicyV4Id()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoutingPolicyV6Id")]
        public virtual void ResetRoutingPolicyV6Id()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVlan")]
        public virtual void ResetVlan()
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
        = GetStaticProperty<string>(typeof(scaleway.InterlinkLink.InterlinkLink))!;

        [JsiiProperty(name: "bgpV4Status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BgpV4Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bgpV6Status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BgpV6Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enableRoutePropagation", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EnableRoutePropagation
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "organizationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OrganizationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pairingKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PairingKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerBgpConfig", typeJson: "{\"fqn\":\"scaleway.interlinkLink.InterlinkLinkPeerBgpConfigList\"}")]
        public virtual scaleway.InterlinkLink.InterlinkLinkPeerBgpConfigList PeerBgpConfig
        {
            get => GetInstanceProperty<scaleway.InterlinkLink.InterlinkLinkPeerBgpConfigList>()!;
        }

        [JsiiProperty(name: "scwBgpConfig", typeJson: "{\"fqn\":\"scaleway.interlinkLink.InterlinkLinkScwBgpConfigList\"}")]
        public virtual scaleway.InterlinkLink.InterlinkLinkScwBgpConfigList ScwBgpConfig
        {
            get => GetInstanceProperty<scaleway.InterlinkLink.InterlinkLinkScwBgpConfigList>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.interlinkLink.InterlinkLinkTimeoutsOutputReference\"}")]
        public virtual scaleway.InterlinkLink.InterlinkLinkTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<scaleway.InterlinkLink.InterlinkLinkTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bandwidthMbpsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BandwidthMbpsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConnectionIdInput
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
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "partnerIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PartnerIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "peerAsnInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PeerAsnInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "popIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PopIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "projectIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProjectIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routingPolicyV4IdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoutingPolicyV4IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routingPolicyV6IdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoutingPolicyV6IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? TagsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"scaleway.interlinkLink.InterlinkLinkTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vlanInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? VlanInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "bandwidthMbps", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BandwidthMbps
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "connectionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionId
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "partnerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PartnerId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "peerAsn", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PeerAsn
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "popId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PopId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "routingPolicyV4Id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoutingPolicyV4Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "routingPolicyV6Id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoutingPolicyV6Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tags
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vlan", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Vlan
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
