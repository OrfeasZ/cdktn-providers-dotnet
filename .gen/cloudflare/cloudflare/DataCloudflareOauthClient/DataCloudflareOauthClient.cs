using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareOauthClient
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/data-sources/oauth_client cloudflare_oauth_client}.</summary>
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareOauthClient.DataCloudflareOauthClient), fullyQualifiedName: "cloudflare.dataCloudflareOauthClient.DataCloudflareOauthClient", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"cloudflare.dataCloudflareOauthClient.DataCloudflareOauthClientConfig\"}}]")]
    public class DataCloudflareOauthClient : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/data-sources/oauth_client cloudflare_oauth_client} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataCloudflareOauthClient(Constructs.Construct scope, string id, cloudflare.DataCloudflareOauthClient.IDataCloudflareOauthClientConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, cloudflare.DataCloudflareOauthClient.IDataCloudflareOauthClientConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareOauthClient(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareOauthClient(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataCloudflareOauthClient resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataCloudflareOauthClient to import.</param>
        /// <param name="importFromId">The id of the existing DataCloudflareOauthClient that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataCloudflareOauthClient to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataCloudflareOauthClient to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/data-sources/oauth_client#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataCloudflareOauthClient that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataCloudflareOauthClient to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(cloudflare.DataCloudflareOauthClient.DataCloudflareOauthClient), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(cloudflare.DataCloudflareOauthClient.DataCloudflareOauthClient))!;

        [JsiiProperty(name: "allowedCorsOrigins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedCorsOrigins
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientUri
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientUriVerification", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareOauthClient.DataCloudflareOauthClientClientUriVerificationOutputReference\"}")]
        public virtual cloudflare.DataCloudflareOauthClient.DataCloudflareOauthClientClientUriVerificationOutputReference ClientUriVerification
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareOauthClient.DataCloudflareOauthClientClientUriVerificationOutputReference>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "grantTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] GrantTypes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "hasRotatedSecret", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable HasRotatedSecret
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "logoUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogoUri
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "policyUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PolicyUri
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "postLogoutRedirectUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PostLogoutRedirectUris
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "promotedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PromotedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "redirectUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RedirectUris
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "responseTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ResponseTypes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "scopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Scopes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "tokenEndpointAuthMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TokenEndpointAuthMethod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tosUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TosUri
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "visibility", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Visibility
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
        [JsiiProperty(name: "oauthClientIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OauthClientIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "oauthClientId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OauthClientId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
