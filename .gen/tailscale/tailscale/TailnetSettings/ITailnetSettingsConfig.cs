using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace tailscale.TailnetSettings
{
    [JsiiInterface(nativeType: typeof(ITailnetSettingsConfig), fullyQualifiedName: "tailscale.tailnetSettings.TailnetSettingsConfig")]
    public interface ITailnetSettingsConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Link to your external ACL definition or management system. Must be a valid URL.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/tailnet_settings#acls_external_link TailnetSettings#acls_external_link}
        /// </remarks>
        [JsiiProperty(name: "aclsExternalLink", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AclsExternalLink
        {
            get
            {
                return null;
            }
        }

        /// <summary>Prevent users from editing policies in the admin console to avoid conflicts with external management workflows like GitOps or Terraform.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/tailnet_settings#acls_externally_managed_on TailnetSettings#acls_externally_managed_on}
        /// </remarks>
        [JsiiProperty(name: "aclsExternallyManagedOn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AclsExternallyManagedOn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether device approval is enabled for the tailnet.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/tailnet_settings#devices_approval_on TailnetSettings#devices_approval_on}
        /// </remarks>
        [JsiiProperty(name: "devicesApprovalOn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DevicesApprovalOn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether auto updates are enabled for devices that belong to this tailnet.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/tailnet_settings#devices_auto_updates_on TailnetSettings#devices_auto_updates_on}
        /// </remarks>
        [JsiiProperty(name: "devicesAutoUpdatesOn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DevicesAutoUpdatesOn
        {
            get
            {
                return null;
            }
        }

        /// <summary>The key expiry duration for devices on this tailnet.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/tailnet_settings#devices_key_duration_days TailnetSettings#devices_key_duration_days}
        /// </remarks>
        [JsiiProperty(name: "devicesKeyDurationDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DevicesKeyDurationDays
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether provisioning of HTTPS certificates is enabled for the tailnet.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/tailnet_settings#https_enabled TailnetSettings#https_enabled}
        /// </remarks>
        [JsiiProperty(name: "httpsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HttpsEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether network flow logs are enabled for the tailnet.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/tailnet_settings#network_flow_logging_on TailnetSettings#network_flow_logging_on}
        /// </remarks>
        [JsiiProperty(name: "networkFlowLoggingOn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NetworkFlowLoggingOn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether identity collection is enabled for device posture integrations for the tailnet.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/tailnet_settings#posture_identity_collection_on TailnetSettings#posture_identity_collection_on}
        /// </remarks>
        [JsiiProperty(name: "postureIdentityCollectionOn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PostureIdentityCollectionOn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether regional routing is enabled for the tailnet.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/tailnet_settings#regional_routing_on TailnetSettings#regional_routing_on}
        /// </remarks>
        [JsiiProperty(name: "regionalRoutingOn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RegionalRoutingOn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether user approval is enabled for this tailnet.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/tailnet_settings#users_approval_on TailnetSettings#users_approval_on}
        /// </remarks>
        [JsiiProperty(name: "usersApprovalOn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UsersApprovalOn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Which user roles are allowed to join external tailnets.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/tailnet_settings#users_role_allowed_to_join_external_tailnet TailnetSettings#users_role_allowed_to_join_external_tailnet}
        /// </remarks>
        [JsiiProperty(name: "usersRoleAllowedToJoinExternalTailnet", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UsersRoleAllowedToJoinExternalTailnet
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITailnetSettingsConfig), fullyQualifiedName: "tailscale.tailnetSettings.TailnetSettingsConfig")]
        internal sealed class _Proxy : DeputyBase, tailscale.TailnetSettings.ITailnetSettingsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Link to your external ACL definition or management system. Must be a valid URL.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/tailnet_settings#acls_external_link TailnetSettings#acls_external_link}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "aclsExternalLink", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AclsExternalLink
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Prevent users from editing policies in the admin console to avoid conflicts with external management workflows like GitOps or Terraform.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/tailnet_settings#acls_externally_managed_on TailnetSettings#acls_externally_managed_on}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "aclsExternallyManagedOn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AclsExternallyManagedOn
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether device approval is enabled for the tailnet.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/tailnet_settings#devices_approval_on TailnetSettings#devices_approval_on}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "devicesApprovalOn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DevicesApprovalOn
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether auto updates are enabled for devices that belong to this tailnet.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/tailnet_settings#devices_auto_updates_on TailnetSettings#devices_auto_updates_on}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "devicesAutoUpdatesOn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DevicesAutoUpdatesOn
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The key expiry duration for devices on this tailnet.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/tailnet_settings#devices_key_duration_days TailnetSettings#devices_key_duration_days}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "devicesKeyDurationDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DevicesKeyDurationDays
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Whether provisioning of HTTPS certificates is enabled for the tailnet.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/tailnet_settings#https_enabled TailnetSettings#https_enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? HttpsEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether network flow logs are enabled for the tailnet.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/tailnet_settings#network_flow_logging_on TailnetSettings#network_flow_logging_on}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkFlowLoggingOn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? NetworkFlowLoggingOn
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether identity collection is enabled for device posture integrations for the tailnet.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/tailnet_settings#posture_identity_collection_on TailnetSettings#posture_identity_collection_on}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "postureIdentityCollectionOn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PostureIdentityCollectionOn
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether regional routing is enabled for the tailnet.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/tailnet_settings#regional_routing_on TailnetSettings#regional_routing_on}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "regionalRoutingOn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? RegionalRoutingOn
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether user approval is enabled for this tailnet.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/tailnet_settings#users_approval_on TailnetSettings#users_approval_on}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "usersApprovalOn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? UsersApprovalOn
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Which user roles are allowed to join external tailnets.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/tailnet_settings#users_role_allowed_to_join_external_tailnet TailnetSettings#users_role_allowed_to_join_external_tailnet}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "usersRoleAllowedToJoinExternalTailnet", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UsersRoleAllowedToJoinExternalTailnet
            {
                get => GetInstanceProperty<string?>();
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
