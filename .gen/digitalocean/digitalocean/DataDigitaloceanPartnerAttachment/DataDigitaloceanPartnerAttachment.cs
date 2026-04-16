using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanPartnerAttachment
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/partner_attachment digitalocean_partner_attachment}.</summary>
    [JsiiClass(nativeType: typeof(digitalocean.DataDigitaloceanPartnerAttachment.DataDigitaloceanPartnerAttachment), fullyQualifiedName: "digitalocean.dataDigitaloceanPartnerAttachment.DataDigitaloceanPartnerAttachment", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"digitalocean.dataDigitaloceanPartnerAttachment.DataDigitaloceanPartnerAttachmentConfig\"}}]")]
    public class DataDigitaloceanPartnerAttachment : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/partner_attachment digitalocean_partner_attachment} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataDigitaloceanPartnerAttachment(Constructs.Construct scope, string id, digitalocean.DataDigitaloceanPartnerAttachment.IDataDigitaloceanPartnerAttachmentConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, digitalocean.DataDigitaloceanPartnerAttachment.IDataDigitaloceanPartnerAttachmentConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanPartnerAttachment(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanPartnerAttachment(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataDigitaloceanPartnerAttachment resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataDigitaloceanPartnerAttachment to import.</param>
        /// <param name="importFromId">The id of the existing DataDigitaloceanPartnerAttachment that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataDigitaloceanPartnerAttachment to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataDigitaloceanPartnerAttachment to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/partner_attachment#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataDigitaloceanPartnerAttachment that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataDigitaloceanPartnerAttachment to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(digitalocean.DataDigitaloceanPartnerAttachment.DataDigitaloceanPartnerAttachment), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putBgp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.dataDigitaloceanPartnerAttachment.DataDigitaloceanPartnerAttachmentBgp\"}}]")]
        public virtual void PutBgp(digitalocean.DataDigitaloceanPartnerAttachment.IDataDigitaloceanPartnerAttachmentBgp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.DataDigitaloceanPartnerAttachment.IDataDigitaloceanPartnerAttachmentBgp)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBgp")]
        public virtual void ResetBgp()
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

        [JsiiMethod(name: "resetRedundancyZone")]
        public virtual void ResetRedundancyZone()
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
        = GetStaticProperty<string>(typeof(digitalocean.DataDigitaloceanPartnerAttachment.DataDigitaloceanPartnerAttachment))!;

        [JsiiProperty(name: "bgp", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanPartnerAttachment.DataDigitaloceanPartnerAttachmentBgpOutputReference\"}")]
        public virtual digitalocean.DataDigitaloceanPartnerAttachment.DataDigitaloceanPartnerAttachmentBgpOutputReference Bgp
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanPartnerAttachment.DataDigitaloceanPartnerAttachmentBgpOutputReference>()!;
        }

        [JsiiProperty(name: "children", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Children
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "connectionBandwidthInMbps", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConnectionBandwidthInMbps
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "naasProvider", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NaasProvider
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parentUuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentUuid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpcIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] VpcIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bgpInput", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanPartnerAttachment.DataDigitaloceanPartnerAttachmentBgp\"}", isOptional: true)]
        public virtual digitalocean.DataDigitaloceanPartnerAttachment.IDataDigitaloceanPartnerAttachmentBgp? BgpInput
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanPartnerAttachment.IDataDigitaloceanPartnerAttachmentBgp?>();
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
        [JsiiProperty(name: "redundancyZoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RedundancyZoneInput
        {
            get => GetInstanceProperty<string?>();
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

        [JsiiProperty(name: "redundancyZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RedundancyZone
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
