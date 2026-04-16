using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.PartnerAttachment
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/partner_attachment digitalocean_partner_attachment}.</summary>
    [JsiiClass(nativeType: typeof(digitalocean.PartnerAttachment.PartnerAttachment), fullyQualifiedName: "digitalocean.partnerAttachment.PartnerAttachment", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"digitalocean.partnerAttachment.PartnerAttachmentConfig\"}}]")]
    public class PartnerAttachment : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/partner_attachment digitalocean_partner_attachment} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public PartnerAttachment(Constructs.Construct scope, string id, digitalocean.PartnerAttachment.IPartnerAttachmentConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, digitalocean.PartnerAttachment.IPartnerAttachmentConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PartnerAttachment(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PartnerAttachment(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a PartnerAttachment resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the PartnerAttachment to import.</param>
        /// <param name="importFromId">The id of the existing PartnerAttachment that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the PartnerAttachment to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the PartnerAttachment to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/partner_attachment#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing PartnerAttachment that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the PartnerAttachment to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(digitalocean.PartnerAttachment.PartnerAttachment), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putBgp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.partnerAttachment.PartnerAttachmentBgp\"}}]")]
        public virtual void PutBgp(digitalocean.PartnerAttachment.IPartnerAttachmentBgp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.PartnerAttachment.IPartnerAttachmentBgp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.partnerAttachment.PartnerAttachmentTimeouts\"}}]")]
        public virtual void PutTimeouts(digitalocean.PartnerAttachment.IPartnerAttachmentTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.PartnerAttachment.IPartnerAttachmentTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBgp")]
        public virtual void ResetBgp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParentUuid")]
        public virtual void ResetParentUuid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRedundancyZone")]
        public virtual void ResetRedundancyZone()
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
        = GetStaticProperty<string>(typeof(digitalocean.PartnerAttachment.PartnerAttachment))!;

        [JsiiProperty(name: "bgp", typeJson: "{\"fqn\":\"digitalocean.partnerAttachment.PartnerAttachmentBgpOutputReference\"}")]
        public virtual digitalocean.PartnerAttachment.PartnerAttachmentBgpOutputReference Bgp
        {
            get => GetInstanceProperty<digitalocean.PartnerAttachment.PartnerAttachmentBgpOutputReference>()!;
        }

        [JsiiProperty(name: "children", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Children
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"digitalocean.partnerAttachment.PartnerAttachmentTimeoutsOutputReference\"}")]
        public virtual digitalocean.PartnerAttachment.PartnerAttachmentTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<digitalocean.PartnerAttachment.PartnerAttachmentTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bgpInput", typeJson: "{\"fqn\":\"digitalocean.partnerAttachment.PartnerAttachmentBgp\"}", isOptional: true)]
        public virtual digitalocean.PartnerAttachment.IPartnerAttachmentBgp? BgpInput
        {
            get => GetInstanceProperty<digitalocean.PartnerAttachment.IPartnerAttachmentBgp?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionBandwidthInMbpsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ConnectionBandwidthInMbpsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "naasProviderInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NaasProviderInput
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
        [JsiiProperty(name: "parentUuidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ParentUuidInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "redundancyZoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RedundancyZoneInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"digitalocean.partnerAttachment.PartnerAttachmentTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? VpcIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "connectionBandwidthInMbps", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConnectionBandwidthInMbps
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "naasProvider", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NaasProvider
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

        [JsiiProperty(name: "parentUuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentUuid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "redundancyZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RedundancyZone
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

        [JsiiProperty(name: "vpcIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] VpcIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
