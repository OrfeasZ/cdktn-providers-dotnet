using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent
{
    [JsiiInterface(nativeType: typeof(INetworkManagerVerifierWorkspaceReachabilityAnalysisIntentTimeouts), fullyQualifiedName: "azurerm.networkManagerVerifierWorkspaceReachabilityAnalysisIntent.NetworkManagerVerifierWorkspaceReachabilityAnalysisIntentTimeouts")]
    public interface INetworkManagerVerifierWorkspaceReachabilityAnalysisIntentTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/network_manager_verifier_workspace_reachability_analysis_intent#create NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/network_manager_verifier_workspace_reachability_analysis_intent#delete NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/network_manager_verifier_workspace_reachability_analysis_intent#read NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkManagerVerifierWorkspaceReachabilityAnalysisIntentTimeouts), fullyQualifiedName: "azurerm.networkManagerVerifierWorkspaceReachabilityAnalysisIntent.NetworkManagerVerifierWorkspaceReachabilityAnalysisIntentTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent.INetworkManagerVerifierWorkspaceReachabilityAnalysisIntentTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/network_manager_verifier_workspace_reachability_analysis_intent#create NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/network_manager_verifier_workspace_reachability_analysis_intent#delete NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/network_manager_verifier_workspace_reachability_analysis_intent#read NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
