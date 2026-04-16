using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustDlpPredefinedEntry
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_dlp_predefined_entry cloudflare_zero_trust_dlp_predefined_entry}.</summary>
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustDlpPredefinedEntry.DataCloudflareZeroTrustDlpPredefinedEntry), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustDlpPredefinedEntry.DataCloudflareZeroTrustDlpPredefinedEntry", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDlpPredefinedEntry.DataCloudflareZeroTrustDlpPredefinedEntryConfig\"}}]")]
    public class DataCloudflareZeroTrustDlpPredefinedEntry : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_dlp_predefined_entry cloudflare_zero_trust_dlp_predefined_entry} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataCloudflareZeroTrustDlpPredefinedEntry(Constructs.Construct scope, string id, cloudflare.DataCloudflareZeroTrustDlpPredefinedEntry.IDataCloudflareZeroTrustDlpPredefinedEntryConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, cloudflare.DataCloudflareZeroTrustDlpPredefinedEntry.IDataCloudflareZeroTrustDlpPredefinedEntryConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustDlpPredefinedEntry(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustDlpPredefinedEntry(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataCloudflareZeroTrustDlpPredefinedEntry resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataCloudflareZeroTrustDlpPredefinedEntry to import.</param>
        /// <param name="importFromId">The id of the existing DataCloudflareZeroTrustDlpPredefinedEntry that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataCloudflareZeroTrustDlpPredefinedEntry to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataCloudflareZeroTrustDlpPredefinedEntry to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_dlp_predefined_entry#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataCloudflareZeroTrustDlpPredefinedEntry that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataCloudflareZeroTrustDlpPredefinedEntry to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(cloudflare.DataCloudflareZeroTrustDlpPredefinedEntry.DataCloudflareZeroTrustDlpPredefinedEntry), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(cloudflare.DataCloudflareZeroTrustDlpPredefinedEntry.DataCloudflareZeroTrustDlpPredefinedEntry))!;

        [JsiiProperty(name: "caseSensitive", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable CaseSensitive
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "confidence", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDlpPredefinedEntry.DataCloudflareZeroTrustDlpPredefinedEntryConfidenceOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustDlpPredefinedEntry.DataCloudflareZeroTrustDlpPredefinedEntryConfidenceOutputReference Confidence
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDlpPredefinedEntry.DataCloudflareZeroTrustDlpPredefinedEntryConfidenceOutputReference>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Enabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
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

        [JsiiProperty(name: "pattern", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDlpPredefinedEntry.DataCloudflareZeroTrustDlpPredefinedEntryPatternOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustDlpPredefinedEntry.DataCloudflareZeroTrustDlpPredefinedEntryPatternOutputReference Pattern
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDlpPredefinedEntry.DataCloudflareZeroTrustDlpPredefinedEntryPatternOutputReference>()!;
        }

        [JsiiProperty(name: "profileId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProfileId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "profiles", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDlpPredefinedEntry.DataCloudflareZeroTrustDlpPredefinedEntryProfilesList\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustDlpPredefinedEntry.DataCloudflareZeroTrustDlpPredefinedEntryProfilesList Profiles
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDlpPredefinedEntry.DataCloudflareZeroTrustDlpPredefinedEntryProfilesList>()!;
        }

        [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Secret
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "uploadStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UploadStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "variant", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDlpPredefinedEntry.DataCloudflareZeroTrustDlpPredefinedEntryVariantOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustDlpPredefinedEntry.DataCloudflareZeroTrustDlpPredefinedEntryVariantOutputReference Variant
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDlpPredefinedEntry.DataCloudflareZeroTrustDlpPredefinedEntryVariantOutputReference>()!;
        }

        [JsiiProperty(name: "wordList", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WordList
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "entryIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EntryIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "entryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EntryId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
