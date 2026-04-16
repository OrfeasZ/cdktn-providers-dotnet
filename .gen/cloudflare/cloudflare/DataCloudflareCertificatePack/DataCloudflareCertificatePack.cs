using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareCertificatePack
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/certificate_pack cloudflare_certificate_pack}.</summary>
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareCertificatePack.DataCloudflareCertificatePack), fullyQualifiedName: "cloudflare.dataCloudflareCertificatePack.DataCloudflareCertificatePack", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"cloudflare.dataCloudflareCertificatePack.DataCloudflareCertificatePackConfig\"}}]")]
    public class DataCloudflareCertificatePack : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/certificate_pack cloudflare_certificate_pack} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataCloudflareCertificatePack(Constructs.Construct scope, string id, cloudflare.DataCloudflareCertificatePack.IDataCloudflareCertificatePackConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, cloudflare.DataCloudflareCertificatePack.IDataCloudflareCertificatePackConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareCertificatePack(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareCertificatePack(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataCloudflareCertificatePack resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataCloudflareCertificatePack to import.</param>
        /// <param name="importFromId">The id of the existing DataCloudflareCertificatePack that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataCloudflareCertificatePack to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataCloudflareCertificatePack to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/certificate_pack#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataCloudflareCertificatePack that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataCloudflareCertificatePack to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(cloudflare.DataCloudflareCertificatePack.DataCloudflareCertificatePack), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.dataCloudflareCertificatePack.DataCloudflareCertificatePackFilter\"}}]")]
        public virtual void PutFilter(cloudflare.DataCloudflareCertificatePack.IDataCloudflareCertificatePackFilter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.DataCloudflareCertificatePack.IDataCloudflareCertificatePackFilter)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCertificatePackId")]
        public virtual void ResetCertificatePackId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
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
        = GetStaticProperty<string>(typeof(cloudflare.DataCloudflareCertificatePack.DataCloudflareCertificatePack))!;

        [JsiiProperty(name: "certificateAuthority", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateAuthority
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificates", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareCertificatePack.DataCloudflareCertificatePackCertificatesList\"}")]
        public virtual cloudflare.DataCloudflareCertificatePack.DataCloudflareCertificatePackCertificatesList Certificates
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareCertificatePack.DataCloudflareCertificatePackCertificatesList>()!;
        }

        [JsiiProperty(name: "cloudflareBranding", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable CloudflareBranding
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "dcvDelegationRecords", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareCertificatePack.DataCloudflareCertificatePackDcvDelegationRecordsList\"}")]
        public virtual cloudflare.DataCloudflareCertificatePack.DataCloudflareCertificatePackDcvDelegationRecordsList DcvDelegationRecords
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareCertificatePack.DataCloudflareCertificatePackDcvDelegationRecordsList>()!;
        }

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareCertificatePack.DataCloudflareCertificatePackFilterOutputReference\"}")]
        public virtual cloudflare.DataCloudflareCertificatePack.DataCloudflareCertificatePackFilterOutputReference Filter
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareCertificatePack.DataCloudflareCertificatePackFilterOutputReference>()!;
        }

        [JsiiProperty(name: "hosts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Hosts
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryCertificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryCertificate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "validationErrors", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareCertificatePack.DataCloudflareCertificatePackValidationErrorsList\"}")]
        public virtual cloudflare.DataCloudflareCertificatePack.DataCloudflareCertificatePackValidationErrorsList ValidationErrors
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareCertificatePack.DataCloudflareCertificatePackValidationErrorsList>()!;
        }

        [JsiiProperty(name: "validationMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ValidationMethod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "validationRecords", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareCertificatePack.DataCloudflareCertificatePackValidationRecordsList\"}")]
        public virtual cloudflare.DataCloudflareCertificatePack.DataCloudflareCertificatePackValidationRecordsList ValidationRecords
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareCertificatePack.DataCloudflareCertificatePackValidationRecordsList>()!;
        }

        [JsiiProperty(name: "validityDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ValidityDays
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificatePackIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificatePackIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.dataCloudflareCertificatePack.DataCloudflareCertificatePackFilter\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "certificatePackId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificatePackId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ZoneId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
