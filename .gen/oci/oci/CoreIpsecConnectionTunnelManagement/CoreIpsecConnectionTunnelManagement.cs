using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreIpsecConnectionTunnelManagement
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management oci_core_ipsec_connection_tunnel_management}.</summary>
    [JsiiClass(nativeType: typeof(oci.CoreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagement), fullyQualifiedName: "oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagement", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementConfig\"}}]")]
    public class CoreIpsecConnectionTunnelManagement : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management oci_core_ipsec_connection_tunnel_management} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CoreIpsecConnectionTunnelManagement(Constructs.Construct scope, string id, oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreIpsecConnectionTunnelManagement(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreIpsecConnectionTunnelManagement(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a CoreIpsecConnectionTunnelManagement resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the CoreIpsecConnectionTunnelManagement to import.</param>
        /// <param name="importFromId">The id of the existing CoreIpsecConnectionTunnelManagement that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the CoreIpsecConnectionTunnelManagement to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the CoreIpsecConnectionTunnelManagement to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing CoreIpsecConnectionTunnelManagement that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the CoreIpsecConnectionTunnelManagement to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.CoreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagement), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putBgpSessionInfo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementBgpSessionInfo\"}}]")]
        public virtual void PutBgpSessionInfo(oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementBgpSessionInfo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementBgpSessionInfo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDpdConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementDpdConfig\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDpdConfig(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementDpdConfig[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementDpdConfig).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementDpdConfig).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEncryptionDomainConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementEncryptionDomainConfig\"}}]")]
        public virtual void PutEncryptionDomainConfig(oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementEncryptionDomainConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementEncryptionDomainConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPhaseOneDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementPhaseOneDetails\"}}]")]
        public virtual void PutPhaseOneDetails(oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementPhaseOneDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementPhaseOneDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPhaseTwoDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementPhaseTwoDetails\"}}]")]
        public virtual void PutPhaseTwoDetails(oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementPhaseTwoDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementPhaseTwoDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBgpSessionInfo")]
        public virtual void ResetBgpSessionInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDpdConfig")]
        public virtual void ResetDpdConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncryptionDomainConfig")]
        public virtual void ResetEncryptionDomainConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIkeVersion")]
        public virtual void ResetIkeVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNatTranslationEnabled")]
        public virtual void ResetNatTranslationEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOracleCanInitiate")]
        public virtual void ResetOracleCanInitiate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPhaseOneDetails")]
        public virtual void ResetPhaseOneDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPhaseTwoDetails")]
        public virtual void ResetPhaseTwoDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRouting")]
        public virtual void ResetRouting()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSharedSecret")]
        public virtual void ResetSharedSecret()
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
        = GetStaticProperty<string>(typeof(oci.CoreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagement))!;

        [JsiiProperty(name: "associatedVirtualCircuits", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AssociatedVirtualCircuits
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "bgpSessionInfo", typeJson: "{\"fqn\":\"oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementBgpSessionInfoOutputReference\"}")]
        public virtual oci.CoreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementBgpSessionInfoOutputReference BgpSessionInfo
        {
            get => GetInstanceProperty<oci.CoreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementBgpSessionInfoOutputReference>()!;
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

        [JsiiProperty(name: "dpdConfig", typeJson: "{\"fqn\":\"oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementDpdConfigList\"}")]
        public virtual oci.CoreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementDpdConfigList DpdConfig
        {
            get => GetInstanceProperty<oci.CoreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementDpdConfigList>()!;
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

        [JsiiProperty(name: "encryptionDomainConfig", typeJson: "{\"fqn\":\"oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementEncryptionDomainConfigOutputReference\"}")]
        public virtual oci.CoreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementEncryptionDomainConfigOutputReference EncryptionDomainConfig
        {
            get => GetInstanceProperty<oci.CoreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementEncryptionDomainConfigOutputReference>()!;
        }

        [JsiiProperty(name: "phaseOneDetails", typeJson: "{\"fqn\":\"oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementPhaseOneDetailsOutputReference\"}")]
        public virtual oci.CoreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementPhaseOneDetailsOutputReference PhaseOneDetails
        {
            get => GetInstanceProperty<oci.CoreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementPhaseOneDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "phaseTwoDetails", typeJson: "{\"fqn\":\"oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementPhaseTwoDetailsOutputReference\"}")]
        public virtual oci.CoreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementPhaseTwoDetailsOutputReference PhaseTwoDetails
        {
            get => GetInstanceProperty<oci.CoreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementPhaseTwoDetailsOutputReference>()!;
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

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementTimeoutsOutputReference\"}")]
        public virtual oci.CoreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.CoreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementTimeoutsOutputReference>()!;
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
        [JsiiProperty(name: "bgpSessionInfoInput", typeJson: "{\"fqn\":\"oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementBgpSessionInfo\"}", isOptional: true)]
        public virtual oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementBgpSessionInfo? BgpSessionInfoInput
        {
            get => GetInstanceProperty<oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementBgpSessionInfo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dpdConfigInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementDpdConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DpdConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionDomainConfigInput", typeJson: "{\"fqn\":\"oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementEncryptionDomainConfig\"}", isOptional: true)]
        public virtual oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementEncryptionDomainConfig? EncryptionDomainConfigInput
        {
            get => GetInstanceProperty<oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementEncryptionDomainConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ikeVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IkeVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipsecIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IpsecIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "natTranslationEnabledInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NatTranslationEnabledInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oracleCanInitiateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OracleCanInitiateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "phaseOneDetailsInput", typeJson: "{\"fqn\":\"oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementPhaseOneDetails\"}", isOptional: true)]
        public virtual oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementPhaseOneDetails? PhaseOneDetailsInput
        {
            get => GetInstanceProperty<oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementPhaseOneDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "phaseTwoDetailsInput", typeJson: "{\"fqn\":\"oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementPhaseTwoDetails\"}", isOptional: true)]
        public virtual oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementPhaseTwoDetails? PhaseTwoDetailsInput
        {
            get => GetInstanceProperty<oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementPhaseTwoDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routingInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoutingInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sharedSecretInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SharedSecretInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnelIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TunnelIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
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

        [JsiiProperty(name: "ikeVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IkeVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ipsecId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpsecId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "natTranslationEnabled", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NatTranslationEnabled
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "oracleCanInitiate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OracleCanInitiate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "routing", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Routing
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sharedSecret", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SharedSecret
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
