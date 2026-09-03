using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent
{
    [JsiiInterface(nativeType: typeof(INetworkManagerVerifierWorkspaceReachabilityAnalysisIntentConfig), fullyQualifiedName: "azurerm.networkManagerVerifierWorkspaceReachabilityAnalysisIntent.NetworkManagerVerifierWorkspaceReachabilityAnalysisIntentConfig")]
    public interface INetworkManagerVerifierWorkspaceReachabilityAnalysisIntentConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/network_manager_verifier_workspace_reachability_analysis_intent#destination_resource_id NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent#destination_resource_id}.</summary>
        [JsiiProperty(name: "destinationResourceId", typeJson: "{\"primitive\":\"string\"}")]
        string DestinationResourceId
        {
            get;
        }

        /// <summary>ip_traffic block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/network_manager_verifier_workspace_reachability_analysis_intent#ip_traffic NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent#ip_traffic}
        /// </remarks>
        [JsiiProperty(name: "ipTraffic", typeJson: "{\"fqn\":\"azurerm.networkManagerVerifierWorkspaceReachabilityAnalysisIntent.NetworkManagerVerifierWorkspaceReachabilityAnalysisIntentIpTraffic\"}")]
        azurerm.NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent.INetworkManagerVerifierWorkspaceReachabilityAnalysisIntentIpTraffic IpTraffic
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/network_manager_verifier_workspace_reachability_analysis_intent#name NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/network_manager_verifier_workspace_reachability_analysis_intent#source_resource_id NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent#source_resource_id}.</summary>
        [JsiiProperty(name: "sourceResourceId", typeJson: "{\"primitive\":\"string\"}")]
        string SourceResourceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/network_manager_verifier_workspace_reachability_analysis_intent#verifier_workspace_id NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent#verifier_workspace_id}.</summary>
        [JsiiProperty(name: "verifierWorkspaceId", typeJson: "{\"primitive\":\"string\"}")]
        string VerifierWorkspaceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/network_manager_verifier_workspace_reachability_analysis_intent#description NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/network_manager_verifier_workspace_reachability_analysis_intent#id NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent#id}.</summary>
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

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/network_manager_verifier_workspace_reachability_analysis_intent#timeouts NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.networkManagerVerifierWorkspaceReachabilityAnalysisIntent.NetworkManagerVerifierWorkspaceReachabilityAnalysisIntentTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent.INetworkManagerVerifierWorkspaceReachabilityAnalysisIntentTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkManagerVerifierWorkspaceReachabilityAnalysisIntentConfig), fullyQualifiedName: "azurerm.networkManagerVerifierWorkspaceReachabilityAnalysisIntent.NetworkManagerVerifierWorkspaceReachabilityAnalysisIntentConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent.INetworkManagerVerifierWorkspaceReachabilityAnalysisIntentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/network_manager_verifier_workspace_reachability_analysis_intent#destination_resource_id NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent#destination_resource_id}.</summary>
            [JsiiProperty(name: "destinationResourceId", typeJson: "{\"primitive\":\"string\"}")]
            public string DestinationResourceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>ip_traffic block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/network_manager_verifier_workspace_reachability_analysis_intent#ip_traffic NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent#ip_traffic}
            /// </remarks>
            [JsiiProperty(name: "ipTraffic", typeJson: "{\"fqn\":\"azurerm.networkManagerVerifierWorkspaceReachabilityAnalysisIntent.NetworkManagerVerifierWorkspaceReachabilityAnalysisIntentIpTraffic\"}")]
            public azurerm.NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent.INetworkManagerVerifierWorkspaceReachabilityAnalysisIntentIpTraffic IpTraffic
            {
                get => GetInstanceProperty<azurerm.NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent.INetworkManagerVerifierWorkspaceReachabilityAnalysisIntentIpTraffic>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/network_manager_verifier_workspace_reachability_analysis_intent#name NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/network_manager_verifier_workspace_reachability_analysis_intent#source_resource_id NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent#source_resource_id}.</summary>
            [JsiiProperty(name: "sourceResourceId", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceResourceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/network_manager_verifier_workspace_reachability_analysis_intent#verifier_workspace_id NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent#verifier_workspace_id}.</summary>
            [JsiiProperty(name: "verifierWorkspaceId", typeJson: "{\"primitive\":\"string\"}")]
            public string VerifierWorkspaceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/network_manager_verifier_workspace_reachability_analysis_intent#description NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/network_manager_verifier_workspace_reachability_analysis_intent#id NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent#id}.</summary>
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

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/network_manager_verifier_workspace_reachability_analysis_intent#timeouts NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.networkManagerVerifierWorkspaceReachabilityAnalysisIntent.NetworkManagerVerifierWorkspaceReachabilityAnalysisIntentTimeouts\"}", isOptional: true)]
            public azurerm.NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent.INetworkManagerVerifierWorkspaceReachabilityAnalysisIntentTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent.INetworkManagerVerifierWorkspaceReachabilityAnalysisIntentTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
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
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
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
