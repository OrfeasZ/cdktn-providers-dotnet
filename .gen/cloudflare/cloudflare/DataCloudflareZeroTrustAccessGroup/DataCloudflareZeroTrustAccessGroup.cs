using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessGroup
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_group cloudflare_zero_trust_access_group}.</summary>
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroup), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroup", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupConfig\"}}]")]
    public class DataCloudflareZeroTrustAccessGroup : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_group cloudflare_zero_trust_access_group} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataCloudflareZeroTrustAccessGroup(Constructs.Construct scope, string id, cloudflare.DataCloudflareZeroTrustAccessGroup.IDataCloudflareZeroTrustAccessGroupConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, cloudflare.DataCloudflareZeroTrustAccessGroup.IDataCloudflareZeroTrustAccessGroupConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustAccessGroup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustAccessGroup(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataCloudflareZeroTrustAccessGroup resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataCloudflareZeroTrustAccessGroup to import.</param>
        /// <param name="importFromId">The id of the existing DataCloudflareZeroTrustAccessGroup that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataCloudflareZeroTrustAccessGroup to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataCloudflareZeroTrustAccessGroup to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_group#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataCloudflareZeroTrustAccessGroup that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataCloudflareZeroTrustAccessGroup to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroup), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupFilter\"}}]")]
        public virtual void PutFilter(cloudflare.DataCloudflareZeroTrustAccessGroup.IDataCloudflareZeroTrustAccessGroupFilter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.DataCloudflareZeroTrustAccessGroup.IDataCloudflareZeroTrustAccessGroupFilter)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccountId")]
        public virtual void ResetAccountId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGroupId")]
        public virtual void ResetGroupId()
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
        = GetStaticProperty<string>(typeof(cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroup))!;

        [JsiiProperty(name: "exclude", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeList\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeList Exclude
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeList>()!;
        }

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupFilterOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupFilterOutputReference Filter
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupFilterOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "include", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIncludeList\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIncludeList Include
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIncludeList>()!;
        }

        [JsiiProperty(name: "isDefault", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultList\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultList IsDefault
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "require", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupRequireList\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupRequireList Require
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupRequireList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupFilter\"}]}}", isOptional: true)]
        public virtual object? FilterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GroupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zoneIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ZoneIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GroupId
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
