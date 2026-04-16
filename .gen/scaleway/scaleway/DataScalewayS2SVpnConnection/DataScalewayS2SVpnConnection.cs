using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayS2SVpnConnection
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/s2s_vpn_connection scaleway_s2s_vpn_connection}.</summary>
    [JsiiClass(nativeType: typeof(scaleway.DataScalewayS2SVpnConnection.DataScalewayS2SVpnConnection), fullyQualifiedName: "scaleway.dataScalewayS2SVpnConnection.DataScalewayS2SVpnConnection", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"scaleway.dataScalewayS2SVpnConnection.DataScalewayS2SVpnConnectionConfig\"}}]")]
    public class DataScalewayS2SVpnConnection : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/s2s_vpn_connection scaleway_s2s_vpn_connection} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataScalewayS2SVpnConnection(Constructs.Construct scope, string id, scaleway.DataScalewayS2SVpnConnection.IDataScalewayS2SVpnConnectionConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, scaleway.DataScalewayS2SVpnConnection.IDataScalewayS2SVpnConnectionConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayS2SVpnConnection(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayS2SVpnConnection(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataScalewayS2SVpnConnection resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataScalewayS2SVpnConnection to import.</param>
        /// <param name="importFromId">The id of the existing DataScalewayS2SVpnConnection that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataScalewayS2SVpnConnection to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataScalewayS2SVpnConnection to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/s2s_vpn_connection#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataScalewayS2SVpnConnection that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataScalewayS2SVpnConnection to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(scaleway.DataScalewayS2SVpnConnection.DataScalewayS2SVpnConnection), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetConnectionId")]
        public virtual void ResetConnectionId()
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

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
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
        = GetStaticProperty<string>(typeof(scaleway.DataScalewayS2SVpnConnection.DataScalewayS2SVpnConnection))!;

        [JsiiProperty(name: "bgpConfigIpv4", typeJson: "{\"fqn\":\"scaleway.dataScalewayS2SVpnConnection.DataScalewayS2SVpnConnectionBgpConfigIpv4List\"}")]
        public virtual scaleway.DataScalewayS2SVpnConnection.DataScalewayS2SVpnConnectionBgpConfigIpv4List BgpConfigIpv4
        {
            get => GetInstanceProperty<scaleway.DataScalewayS2SVpnConnection.DataScalewayS2SVpnConnectionBgpConfigIpv4List>()!;
        }

        [JsiiProperty(name: "bgpConfigIpv6", typeJson: "{\"fqn\":\"scaleway.dataScalewayS2SVpnConnection.DataScalewayS2SVpnConnectionBgpConfigIpv6List\"}")]
        public virtual scaleway.DataScalewayS2SVpnConnection.DataScalewayS2SVpnConnectionBgpConfigIpv6List BgpConfigIpv6
        {
            get => GetInstanceProperty<scaleway.DataScalewayS2SVpnConnection.DataScalewayS2SVpnConnectionBgpConfigIpv6List>()!;
        }

        [JsiiProperty(name: "bgpSessionIpv4", typeJson: "{\"fqn\":\"scaleway.dataScalewayS2SVpnConnection.DataScalewayS2SVpnConnectionBgpSessionIpv4List\"}")]
        public virtual scaleway.DataScalewayS2SVpnConnection.DataScalewayS2SVpnConnectionBgpSessionIpv4List BgpSessionIpv4
        {
            get => GetInstanceProperty<scaleway.DataScalewayS2SVpnConnection.DataScalewayS2SVpnConnectionBgpSessionIpv4List>()!;
        }

        [JsiiProperty(name: "bgpSessionIpv6", typeJson: "{\"fqn\":\"scaleway.dataScalewayS2SVpnConnection.DataScalewayS2SVpnConnectionBgpSessionIpv6List\"}")]
        public virtual scaleway.DataScalewayS2SVpnConnection.DataScalewayS2SVpnConnectionBgpSessionIpv6List BgpSessionIpv6
        {
            get => GetInstanceProperty<scaleway.DataScalewayS2SVpnConnection.DataScalewayS2SVpnConnectionBgpSessionIpv6List>()!;
        }

        [JsiiProperty(name: "bgpStatusIpv4", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BgpStatusIpv4
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bgpStatusIpv6", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BgpStatusIpv6
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customerGatewayId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerGatewayId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enableRoutePropagation", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EnableRoutePropagation
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "espCiphers", typeJson: "{\"fqn\":\"scaleway.dataScalewayS2SVpnConnection.DataScalewayS2SVpnConnectionEspCiphersList\"}")]
        public virtual scaleway.DataScalewayS2SVpnConnection.DataScalewayS2SVpnConnectionEspCiphersList EspCiphers
        {
            get => GetInstanceProperty<scaleway.DataScalewayS2SVpnConnection.DataScalewayS2SVpnConnectionEspCiphersList>()!;
        }

        [JsiiProperty(name: "ikev2Ciphers", typeJson: "{\"fqn\":\"scaleway.dataScalewayS2SVpnConnection.DataScalewayS2SVpnConnectionIkev2CiphersList\"}")]
        public virtual scaleway.DataScalewayS2SVpnConnection.DataScalewayS2SVpnConnectionIkev2CiphersList Ikev2Ciphers
        {
            get => GetInstanceProperty<scaleway.DataScalewayS2SVpnConnection.DataScalewayS2SVpnConnectionIkev2CiphersList>()!;
        }

        [JsiiProperty(name: "initiationPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InitiationPolicy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isIpv6", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsIpv6
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "organizationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OrganizationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "routePropagationEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable RoutePropagationEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecretId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secretVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SecretVersion
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tags
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "tunnelStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TunnelStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpnGatewayId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpnGatewayId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConnectionIdInput
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
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "connectionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionId
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

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
