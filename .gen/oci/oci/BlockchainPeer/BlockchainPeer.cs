using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BlockchainPeer
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_peer oci_blockchain_peer}.</summary>
    [JsiiClass(nativeType: typeof(oci.BlockchainPeer.BlockchainPeer), fullyQualifiedName: "oci.blockchainPeer.BlockchainPeer", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.blockchainPeer.BlockchainPeerConfig\"}}]")]
    public class BlockchainPeer : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_peer oci_blockchain_peer} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public BlockchainPeer(Constructs.Construct scope, string id, oci.BlockchainPeer.IBlockchainPeerConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.BlockchainPeer.IBlockchainPeerConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BlockchainPeer(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BlockchainPeer(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a BlockchainPeer resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the BlockchainPeer to import.</param>
        /// <param name="importFromId">The id of the existing BlockchainPeer that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the BlockchainPeer to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the BlockchainPeer to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_peer#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing BlockchainPeer that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the BlockchainPeer to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.BlockchainPeer.BlockchainPeer), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putOcpuAllocationParam", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.blockchainPeer.BlockchainPeerOcpuAllocationParam\"}}]")]
        public virtual void PutOcpuAllocationParam(oci.BlockchainPeer.IBlockchainPeerOcpuAllocationParam @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.BlockchainPeer.IBlockchainPeerOcpuAllocationParam)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.blockchainPeer.BlockchainPeerTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.BlockchainPeer.IBlockchainPeerTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.BlockchainPeer.IBlockchainPeerTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAlias")]
        public virtual void ResetAlias()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(oci.BlockchainPeer.BlockchainPeer))!;

        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Host
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ocpuAllocationParam", typeJson: "{\"fqn\":\"oci.blockchainPeer.BlockchainPeerOcpuAllocationParamOutputReference\"}")]
        public virtual oci.BlockchainPeer.BlockchainPeerOcpuAllocationParamOutputReference OcpuAllocationParam
        {
            get => GetInstanceProperty<oci.BlockchainPeer.BlockchainPeerOcpuAllocationParamOutputReference>()!;
        }

        [JsiiProperty(name: "peerKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.blockchainPeer.BlockchainPeerTimeoutsOutputReference\"}")]
        public virtual oci.BlockchainPeer.BlockchainPeerTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.BlockchainPeer.BlockchainPeerTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "adInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "aliasInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AliasInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "blockchainPlatformIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BlockchainPlatformIdInput
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
        [JsiiProperty(name: "ocpuAllocationParamInput", typeJson: "{\"fqn\":\"oci.blockchainPeer.BlockchainPeerOcpuAllocationParam\"}", isOptional: true)]
        public virtual oci.BlockchainPeer.IBlockchainPeerOcpuAllocationParam? OcpuAllocationParamInput
        {
            get => GetInstanceProperty<oci.BlockchainPeer.IBlockchainPeerOcpuAllocationParam?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.blockchainPeer.BlockchainPeerTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "ad", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ad
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Alias
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "blockchainPlatformId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BlockchainPlatformId
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

        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Role
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
