using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareCustomHostname
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/custom_hostname cloudflare_custom_hostname}.</summary>
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareCustomHostname.DataCloudflareCustomHostname), fullyQualifiedName: "cloudflare.dataCloudflareCustomHostname.DataCloudflareCustomHostname", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"cloudflare.dataCloudflareCustomHostname.DataCloudflareCustomHostnameConfig\"}}]")]
    public class DataCloudflareCustomHostname : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/custom_hostname cloudflare_custom_hostname} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataCloudflareCustomHostname(Constructs.Construct scope, string id, cloudflare.DataCloudflareCustomHostname.IDataCloudflareCustomHostnameConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, cloudflare.DataCloudflareCustomHostname.IDataCloudflareCustomHostnameConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareCustomHostname(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareCustomHostname(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataCloudflareCustomHostname resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataCloudflareCustomHostname to import.</param>
        /// <param name="importFromId">The id of the existing DataCloudflareCustomHostname that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataCloudflareCustomHostname to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataCloudflareCustomHostname to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/custom_hostname#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataCloudflareCustomHostname that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataCloudflareCustomHostname to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(cloudflare.DataCloudflareCustomHostname.DataCloudflareCustomHostname), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.dataCloudflareCustomHostname.DataCloudflareCustomHostnameFilter\"}}]")]
        public virtual void PutFilter(cloudflare.DataCloudflareCustomHostname.IDataCloudflareCustomHostnameFilter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.DataCloudflareCustomHostname.IDataCloudflareCustomHostnameFilter)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCustomHostnameId")]
        public virtual void ResetCustomHostnameId()
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
        = GetStaticProperty<string>(typeof(cloudflare.DataCloudflareCustomHostname.DataCloudflareCustomHostname))!;

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customMetadata", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap CustomMetadata
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "customOriginServer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomOriginServer
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customOriginSni", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomOriginSni
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareCustomHostname.DataCloudflareCustomHostnameFilterOutputReference\"}")]
        public virtual cloudflare.DataCloudflareCustomHostname.DataCloudflareCustomHostnameFilterOutputReference Filter
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareCustomHostname.DataCloudflareCustomHostnameFilterOutputReference>()!;
        }

        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Hostname
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ownershipVerification", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareCustomHostname.DataCloudflareCustomHostnameOwnershipVerificationOutputReference\"}")]
        public virtual cloudflare.DataCloudflareCustomHostname.DataCloudflareCustomHostnameOwnershipVerificationOutputReference OwnershipVerification
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareCustomHostname.DataCloudflareCustomHostnameOwnershipVerificationOutputReference>()!;
        }

        [JsiiProperty(name: "ownershipVerificationHttp", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareCustomHostname.DataCloudflareCustomHostnameOwnershipVerificationHttpOutputReference\"}")]
        public virtual cloudflare.DataCloudflareCustomHostname.DataCloudflareCustomHostnameOwnershipVerificationHttpOutputReference OwnershipVerificationHttp
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareCustomHostname.DataCloudflareCustomHostnameOwnershipVerificationHttpOutputReference>()!;
        }

        [JsiiProperty(name: "ssl", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareCustomHostname.DataCloudflareCustomHostnameSslOutputReference\"}")]
        public virtual cloudflare.DataCloudflareCustomHostname.DataCloudflareCustomHostnameSslOutputReference Ssl
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareCustomHostname.DataCloudflareCustomHostnameSslOutputReference>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "verificationErrors", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] VerificationErrors
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "customHostnameIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomHostnameIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.dataCloudflareCustomHostname.DataCloudflareCustomHostnameFilter\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "customHostnameId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomHostnameId
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
