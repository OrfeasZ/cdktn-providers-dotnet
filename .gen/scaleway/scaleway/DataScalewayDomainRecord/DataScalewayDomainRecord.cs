using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayDomainRecord
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/domain_record scaleway_domain_record}.</summary>
    [JsiiClass(nativeType: typeof(scaleway.DataScalewayDomainRecord.DataScalewayDomainRecord), fullyQualifiedName: "scaleway.dataScalewayDomainRecord.DataScalewayDomainRecord", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"scaleway.dataScalewayDomainRecord.DataScalewayDomainRecordConfig\"}}]")]
    public class DataScalewayDomainRecord : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/domain_record scaleway_domain_record} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataScalewayDomainRecord(Constructs.Construct scope, string id, scaleway.DataScalewayDomainRecord.IDataScalewayDomainRecordConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, scaleway.DataScalewayDomainRecord.IDataScalewayDomainRecordConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayDomainRecord(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayDomainRecord(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataScalewayDomainRecord resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataScalewayDomainRecord to import.</param>
        /// <param name="importFromId">The id of the existing DataScalewayDomainRecord that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataScalewayDomainRecord to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataScalewayDomainRecord to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/domain_record#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataScalewayDomainRecord that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataScalewayDomainRecord to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(scaleway.DataScalewayDomainRecord.DataScalewayDomainRecord), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetData")]
        public virtual void ResetData()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDnsZone")]
        public virtual void ResetDnsZone()
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

        [JsiiMethod(name: "resetProjectId")]
        public virtual void ResetProjectId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRecordId")]
        public virtual void ResetRecordId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetType")]
        public virtual void ResetType()
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
        = GetStaticProperty<string>(typeof(scaleway.DataScalewayDomainRecord.DataScalewayDomainRecord))!;

        [JsiiProperty(name: "fqdn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Fqdn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "geoIp", typeJson: "{\"fqn\":\"scaleway.dataScalewayDomainRecord.DataScalewayDomainRecordGeoIpList\"}")]
        public virtual scaleway.DataScalewayDomainRecord.DataScalewayDomainRecordGeoIpList GeoIp
        {
            get => GetInstanceProperty<scaleway.DataScalewayDomainRecord.DataScalewayDomainRecordGeoIpList>()!;
        }

        [JsiiProperty(name: "httpService", typeJson: "{\"fqn\":\"scaleway.dataScalewayDomainRecord.DataScalewayDomainRecordHttpServiceList\"}")]
        public virtual scaleway.DataScalewayDomainRecord.DataScalewayDomainRecordHttpServiceList HttpService
        {
            get => GetInstanceProperty<scaleway.DataScalewayDomainRecord.DataScalewayDomainRecordHttpServiceList>()!;
        }

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Priority
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "rootZone", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable RootZone
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Ttl
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "view", typeJson: "{\"fqn\":\"scaleway.dataScalewayDomainRecord.DataScalewayDomainRecordViewList\"}")]
        public virtual scaleway.DataScalewayDomainRecord.DataScalewayDomainRecordViewList View
        {
            get => GetInstanceProperty<scaleway.DataScalewayDomainRecord.DataScalewayDomainRecordViewList>()!;
        }

        [JsiiProperty(name: "weighted", typeJson: "{\"fqn\":\"scaleway.dataScalewayDomainRecord.DataScalewayDomainRecordWeightedList\"}")]
        public virtual scaleway.DataScalewayDomainRecord.DataScalewayDomainRecordWeightedList Weighted
        {
            get => GetInstanceProperty<scaleway.DataScalewayDomainRecord.DataScalewayDomainRecordWeightedList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DataInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dnsZoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DnsZoneInput
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
        [JsiiProperty(name: "projectIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProjectIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "recordIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RecordIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "data", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Data
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dnsZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DnsZone
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

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "recordId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RecordId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
