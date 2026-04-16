using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustTunnelWarpConnector
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_tunnel_warp_connector cloudflare_zero_trust_tunnel_warp_connector}.</summary>
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustTunnelWarpConnector.DataCloudflareZeroTrustTunnelWarpConnector), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustTunnelWarpConnector.DataCloudflareZeroTrustTunnelWarpConnector", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"cloudflare.dataCloudflareZeroTrustTunnelWarpConnector.DataCloudflareZeroTrustTunnelWarpConnectorConfig\"}}]")]
    public class DataCloudflareZeroTrustTunnelWarpConnector : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_tunnel_warp_connector cloudflare_zero_trust_tunnel_warp_connector} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataCloudflareZeroTrustTunnelWarpConnector(Constructs.Construct scope, string id, cloudflare.DataCloudflareZeroTrustTunnelWarpConnector.IDataCloudflareZeroTrustTunnelWarpConnectorConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, cloudflare.DataCloudflareZeroTrustTunnelWarpConnector.IDataCloudflareZeroTrustTunnelWarpConnectorConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustTunnelWarpConnector(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustTunnelWarpConnector(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataCloudflareZeroTrustTunnelWarpConnector resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataCloudflareZeroTrustTunnelWarpConnector to import.</param>
        /// <param name="importFromId">The id of the existing DataCloudflareZeroTrustTunnelWarpConnector that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataCloudflareZeroTrustTunnelWarpConnector to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataCloudflareZeroTrustTunnelWarpConnector to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_tunnel_warp_connector#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataCloudflareZeroTrustTunnelWarpConnector that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataCloudflareZeroTrustTunnelWarpConnector to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(cloudflare.DataCloudflareZeroTrustTunnelWarpConnector.DataCloudflareZeroTrustTunnelWarpConnector), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.dataCloudflareZeroTrustTunnelWarpConnector.DataCloudflareZeroTrustTunnelWarpConnectorFilter\"}}]")]
        public virtual void PutFilter(cloudflare.DataCloudflareZeroTrustTunnelWarpConnector.IDataCloudflareZeroTrustTunnelWarpConnectorFilter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.DataCloudflareZeroTrustTunnelWarpConnector.IDataCloudflareZeroTrustTunnelWarpConnectorFilter)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnelId")]
        public virtual void ResetTunnelId()
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
        = GetStaticProperty<string>(typeof(cloudflare.DataCloudflareZeroTrustTunnelWarpConnector.DataCloudflareZeroTrustTunnelWarpConnector))!;

        [JsiiProperty(name: "accountTag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountTag
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connections", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustTunnelWarpConnector.DataCloudflareZeroTrustTunnelWarpConnectorConnectionsList\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustTunnelWarpConnector.DataCloudflareZeroTrustTunnelWarpConnectorConnectionsList Connections
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustTunnelWarpConnector.DataCloudflareZeroTrustTunnelWarpConnectorConnectionsList>()!;
        }

        [JsiiProperty(name: "connsActiveAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnsActiveAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connsInactiveAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnsInactiveAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deletedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeletedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustTunnelWarpConnector.DataCloudflareZeroTrustTunnelWarpConnectorFilterOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustTunnelWarpConnector.DataCloudflareZeroTrustTunnelWarpConnectorFilterOutputReference Filter
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustTunnelWarpConnector.DataCloudflareZeroTrustTunnelWarpConnectorFilterOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Metadata
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

        [JsiiProperty(name: "tunType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TunType
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
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.dataCloudflareZeroTrustTunnelWarpConnector.DataCloudflareZeroTrustTunnelWarpConnectorFilter\"}]}}", isOptional: true)]
        public virtual object? FilterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnelIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TunnelIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnelId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TunnelId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
