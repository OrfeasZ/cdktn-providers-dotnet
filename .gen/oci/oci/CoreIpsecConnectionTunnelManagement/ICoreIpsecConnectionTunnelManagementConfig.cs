using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreIpsecConnectionTunnelManagement
{
    [JsiiInterface(nativeType: typeof(ICoreIpsecConnectionTunnelManagementConfig), fullyQualifiedName: "oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementConfig")]
    public interface ICoreIpsecConnectionTunnelManagementConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#ipsec_id CoreIpsecConnectionTunnelManagement#ipsec_id}.</summary>
        [JsiiProperty(name: "ipsecId", typeJson: "{\"primitive\":\"string\"}")]
        string IpsecId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#tunnel_id CoreIpsecConnectionTunnelManagement#tunnel_id}.</summary>
        [JsiiProperty(name: "tunnelId", typeJson: "{\"primitive\":\"string\"}")]
        string TunnelId
        {
            get;
        }

        /// <summary>bgp_session_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#bgp_session_info CoreIpsecConnectionTunnelManagement#bgp_session_info}
        /// </remarks>
        [JsiiProperty(name: "bgpSessionInfo", typeJson: "{\"fqn\":\"oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementBgpSessionInfo\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementBgpSessionInfo? BgpSessionInfo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#display_name CoreIpsecConnectionTunnelManagement#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>dpd_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#dpd_config CoreIpsecConnectionTunnelManagement#dpd_config}
        /// </remarks>
        [JsiiProperty(name: "dpdConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementDpdConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DpdConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>encryption_domain_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#encryption_domain_config CoreIpsecConnectionTunnelManagement#encryption_domain_config}
        /// </remarks>
        [JsiiProperty(name: "encryptionDomainConfig", typeJson: "{\"fqn\":\"oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementEncryptionDomainConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementEncryptionDomainConfig? EncryptionDomainConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#id CoreIpsecConnectionTunnelManagement#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#ike_version CoreIpsecConnectionTunnelManagement#ike_version}.</summary>
        [JsiiProperty(name: "ikeVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IkeVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#nat_translation_enabled CoreIpsecConnectionTunnelManagement#nat_translation_enabled}.</summary>
        [JsiiProperty(name: "natTranslationEnabled", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NatTranslationEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#oracle_can_initiate CoreIpsecConnectionTunnelManagement#oracle_can_initiate}.</summary>
        [JsiiProperty(name: "oracleCanInitiate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OracleCanInitiate
        {
            get
            {
                return null;
            }
        }

        /// <summary>phase_one_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#phase_one_details CoreIpsecConnectionTunnelManagement#phase_one_details}
        /// </remarks>
        [JsiiProperty(name: "phaseOneDetails", typeJson: "{\"fqn\":\"oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementPhaseOneDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementPhaseOneDetails? PhaseOneDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>phase_two_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#phase_two_details CoreIpsecConnectionTunnelManagement#phase_two_details}
        /// </remarks>
        [JsiiProperty(name: "phaseTwoDetails", typeJson: "{\"fqn\":\"oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementPhaseTwoDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementPhaseTwoDetails? PhaseTwoDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#routing CoreIpsecConnectionTunnelManagement#routing}.</summary>
        [JsiiProperty(name: "routing", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Routing
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#shared_secret CoreIpsecConnectionTunnelManagement#shared_secret}.</summary>
        [JsiiProperty(name: "sharedSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SharedSecret
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#timeouts CoreIpsecConnectionTunnelManagement#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreIpsecConnectionTunnelManagementConfig), fullyQualifiedName: "oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementConfig")]
        internal sealed class _Proxy : DeputyBase, oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#ipsec_id CoreIpsecConnectionTunnelManagement#ipsec_id}.</summary>
            [JsiiProperty(name: "ipsecId", typeJson: "{\"primitive\":\"string\"}")]
            public string IpsecId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#tunnel_id CoreIpsecConnectionTunnelManagement#tunnel_id}.</summary>
            [JsiiProperty(name: "tunnelId", typeJson: "{\"primitive\":\"string\"}")]
            public string TunnelId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>bgp_session_info block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#bgp_session_info CoreIpsecConnectionTunnelManagement#bgp_session_info}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bgpSessionInfo", typeJson: "{\"fqn\":\"oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementBgpSessionInfo\"}", isOptional: true)]
            public oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementBgpSessionInfo? BgpSessionInfo
            {
                get => GetInstanceProperty<oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementBgpSessionInfo?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#display_name CoreIpsecConnectionTunnelManagement#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>dpd_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#dpd_config CoreIpsecConnectionTunnelManagement#dpd_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dpdConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementDpdConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DpdConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>encryption_domain_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#encryption_domain_config CoreIpsecConnectionTunnelManagement#encryption_domain_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionDomainConfig", typeJson: "{\"fqn\":\"oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementEncryptionDomainConfig\"}", isOptional: true)]
            public oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementEncryptionDomainConfig? EncryptionDomainConfig
            {
                get => GetInstanceProperty<oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementEncryptionDomainConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#id CoreIpsecConnectionTunnelManagement#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#ike_version CoreIpsecConnectionTunnelManagement#ike_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ikeVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IkeVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#nat_translation_enabled CoreIpsecConnectionTunnelManagement#nat_translation_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "natTranslationEnabled", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NatTranslationEnabled
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#oracle_can_initiate CoreIpsecConnectionTunnelManagement#oracle_can_initiate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "oracleCanInitiate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OracleCanInitiate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>phase_one_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#phase_one_details CoreIpsecConnectionTunnelManagement#phase_one_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "phaseOneDetails", typeJson: "{\"fqn\":\"oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementPhaseOneDetails\"}", isOptional: true)]
            public oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementPhaseOneDetails? PhaseOneDetails
            {
                get => GetInstanceProperty<oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementPhaseOneDetails?>();
            }

            /// <summary>phase_two_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#phase_two_details CoreIpsecConnectionTunnelManagement#phase_two_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "phaseTwoDetails", typeJson: "{\"fqn\":\"oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementPhaseTwoDetails\"}", isOptional: true)]
            public oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementPhaseTwoDetails? PhaseTwoDetails
            {
                get => GetInstanceProperty<oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementPhaseTwoDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#routing CoreIpsecConnectionTunnelManagement#routing}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "routing", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Routing
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#shared_secret CoreIpsecConnectionTunnelManagement#shared_secret}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sharedSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SharedSecret
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#timeouts CoreIpsecConnectionTunnelManagement#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementTimeouts\"}", isOptional: true)]
            public oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
