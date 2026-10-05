using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustCasbIntegration
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/data-sources/zero_trust_casb_integration cloudflare_zero_trust_casb_integration}.</summary>
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustCasbIntegration.DataCloudflareZeroTrustCasbIntegration), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustCasbIntegration.DataCloudflareZeroTrustCasbIntegration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"cloudflare.dataCloudflareZeroTrustCasbIntegration.DataCloudflareZeroTrustCasbIntegrationConfig\"}}]")]
    public class DataCloudflareZeroTrustCasbIntegration : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/data-sources/zero_trust_casb_integration cloudflare_zero_trust_casb_integration} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataCloudflareZeroTrustCasbIntegration(Constructs.Construct scope, string id, cloudflare.DataCloudflareZeroTrustCasbIntegration.IDataCloudflareZeroTrustCasbIntegrationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, cloudflare.DataCloudflareZeroTrustCasbIntegration.IDataCloudflareZeroTrustCasbIntegrationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustCasbIntegration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustCasbIntegration(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataCloudflareZeroTrustCasbIntegration resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataCloudflareZeroTrustCasbIntegration to import.</param>
        /// <param name="importFromId">The id of the existing DataCloudflareZeroTrustCasbIntegration that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataCloudflareZeroTrustCasbIntegration to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataCloudflareZeroTrustCasbIntegration to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/data-sources/zero_trust_casb_integration#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataCloudflareZeroTrustCasbIntegration that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataCloudflareZeroTrustCasbIntegration to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(cloudflare.DataCloudflareZeroTrustCasbIntegration.DataCloudflareZeroTrustCasbIntegration), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.dataCloudflareZeroTrustCasbIntegration.DataCloudflareZeroTrustCasbIntegrationFilter\"}}]")]
        public virtual void PutFilter(cloudflare.DataCloudflareZeroTrustCasbIntegration.IDataCloudflareZeroTrustCasbIntegrationFilter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.DataCloudflareZeroTrustCasbIntegration.IDataCloudflareZeroTrustCasbIntegrationFilter)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(cloudflare.DataCloudflareZeroTrustCasbIntegration.DataCloudflareZeroTrustCasbIntegration))!;

        [JsiiProperty(name: "application", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Application
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "authMethod", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap AuthMethod
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "authorizationLink", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustCasbIntegration.DataCloudflareZeroTrustCasbIntegrationAuthorizationLinkOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustCasbIntegration.DataCloudflareZeroTrustCasbIntegrationAuthorizationLinkOutputReference AuthorizationLink
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustCasbIntegration.DataCloudflareZeroTrustCasbIntegrationAuthorizationLinkOutputReference>()!;
        }

        [JsiiProperty(name: "created", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Created
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "credentialsExpiry", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CredentialsExpiry
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dlpProfiles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DlpProfiles
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustCasbIntegration.DataCloudflareZeroTrustCasbIntegrationFilterOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustCasbIntegration.DataCloudflareZeroTrustCasbIntegrationFilterOutputReference Filter
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustCasbIntegration.DataCloudflareZeroTrustCasbIntegrationFilterOutputReference>()!;
        }

        [JsiiProperty(name: "healthDetails", typeJson: "{\"fqn\":\"cdktn.StringMapList\"}")]
        public virtual Io.Cdktn.StringMapList HealthDetails
        {
            get => GetInstanceProperty<Io.Cdktn.StringMapList>()!;
        }

        [JsiiProperty(name: "isPaused", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsPaused
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lastHydrated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastHydrated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Updated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "useCases", typeJson: "{\"fqn\":\"cdktn.StringMapList\"}")]
        public virtual Io.Cdktn.StringMapList UseCases
        {
            get => GetInstanceProperty<Io.Cdktn.StringMapList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="cloudflare.DataCloudflareZeroTrustCasbIntegration.IDataCloudflareZeroTrustCasbIntegrationFilter" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.dataCloudflareZeroTrustCasbIntegration.DataCloudflareZeroTrustCasbIntegrationFilter\"}]}}", isOptional: true)]
        public virtual object? FilterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
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
    }
}
