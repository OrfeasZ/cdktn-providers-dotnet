using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCoreIpsecConnectionTunnel
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/core_ipsec_connection_tunnel oci_core_ipsec_connection_tunnel}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciCoreIpsecConnectionTunnel.DataOciCoreIpsecConnectionTunnel), fullyQualifiedName: "oci.dataOciCoreIpsecConnectionTunnel.DataOciCoreIpsecConnectionTunnel", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciCoreIpsecConnectionTunnel.DataOciCoreIpsecConnectionTunnelConfig\"}}]")]
    public class DataOciCoreIpsecConnectionTunnel : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/core_ipsec_connection_tunnel oci_core_ipsec_connection_tunnel} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciCoreIpsecConnectionTunnel(Constructs.Construct scope, string id, oci.DataOciCoreIpsecConnectionTunnel.IDataOciCoreIpsecConnectionTunnelConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciCoreIpsecConnectionTunnel.IDataOciCoreIpsecConnectionTunnelConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreIpsecConnectionTunnel(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreIpsecConnectionTunnel(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciCoreIpsecConnectionTunnel resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciCoreIpsecConnectionTunnel to import.</param>
        /// <param name="importFromId">The id of the existing DataOciCoreIpsecConnectionTunnel that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciCoreIpsecConnectionTunnel to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciCoreIpsecConnectionTunnel to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/core_ipsec_connection_tunnel#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciCoreIpsecConnectionTunnel that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciCoreIpsecConnectionTunnel to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciCoreIpsecConnectionTunnel.DataOciCoreIpsecConnectionTunnel), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciCoreIpsecConnectionTunnel.DataOciCoreIpsecConnectionTunnel))!;

        [JsiiProperty(name: "associatedVirtualCircuits", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AssociatedVirtualCircuits
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "bgpSessionInfo", typeJson: "{\"fqn\":\"oci.dataOciCoreIpsecConnectionTunnel.DataOciCoreIpsecConnectionTunnelBgpSessionInfoList\"}")]
        public virtual oci.DataOciCoreIpsecConnectionTunnel.DataOciCoreIpsecConnectionTunnelBgpSessionInfoList BgpSessionInfo
        {
            get => GetInstanceProperty<oci.DataOciCoreIpsecConnectionTunnel.DataOciCoreIpsecConnectionTunnelBgpSessionInfoList>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cpeIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CpeIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dpdConfig", typeJson: "{\"fqn\":\"oci.dataOciCoreIpsecConnectionTunnel.DataOciCoreIpsecConnectionTunnelDpdConfigList\"}")]
        public virtual oci.DataOciCoreIpsecConnectionTunnel.DataOciCoreIpsecConnectionTunnelDpdConfigList DpdConfig
        {
            get => GetInstanceProperty<oci.DataOciCoreIpsecConnectionTunnel.DataOciCoreIpsecConnectionTunnelDpdConfigList>()!;
        }

        [JsiiProperty(name: "dpdMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DpdMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dpdTimeoutInSec", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DpdTimeoutInSec
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "encryptionDomainConfig", typeJson: "{\"fqn\":\"oci.dataOciCoreIpsecConnectionTunnel.DataOciCoreIpsecConnectionTunnelEncryptionDomainConfigList\"}")]
        public virtual oci.DataOciCoreIpsecConnectionTunnel.DataOciCoreIpsecConnectionTunnelEncryptionDomainConfigList EncryptionDomainConfig
        {
            get => GetInstanceProperty<oci.DataOciCoreIpsecConnectionTunnel.DataOciCoreIpsecConnectionTunnelEncryptionDomainConfigList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ikeVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IkeVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "natTranslationEnabled", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NatTranslationEnabled
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "oracleCanInitiate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OracleCanInitiate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "phaseOneDetails", typeJson: "{\"fqn\":\"oci.dataOciCoreIpsecConnectionTunnel.DataOciCoreIpsecConnectionTunnelPhaseOneDetailsList\"}")]
        public virtual oci.DataOciCoreIpsecConnectionTunnel.DataOciCoreIpsecConnectionTunnelPhaseOneDetailsList PhaseOneDetails
        {
            get => GetInstanceProperty<oci.DataOciCoreIpsecConnectionTunnel.DataOciCoreIpsecConnectionTunnelPhaseOneDetailsList>()!;
        }

        [JsiiProperty(name: "phaseTwoDetails", typeJson: "{\"fqn\":\"oci.dataOciCoreIpsecConnectionTunnel.DataOciCoreIpsecConnectionTunnelPhaseTwoDetailsList\"}")]
        public virtual oci.DataOciCoreIpsecConnectionTunnel.DataOciCoreIpsecConnectionTunnelPhaseTwoDetailsList PhaseTwoDetails
        {
            get => GetInstanceProperty<oci.DataOciCoreIpsecConnectionTunnel.DataOciCoreIpsecConnectionTunnelPhaseTwoDetailsList>()!;
        }

        [JsiiProperty(name: "routing", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Routing
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sharedSecret", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SharedSecret
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeStatusUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStatusUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpnIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpnIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipsecIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IpsecIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnelIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TunnelIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "ipsecId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpsecId
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
