using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementFleetCredential
{
    [JsiiInterface(nativeType: typeof(IFleetAppsManagementFleetCredentialConfig), fullyQualifiedName: "oci.fleetAppsManagementFleetCredential.FleetAppsManagementFleetCredentialConfig")]
    public interface IFleetAppsManagementFleetCredentialConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet_credential#compartment_id FleetAppsManagementFleetCredential#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet_credential#display_name FleetAppsManagementFleetCredential#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>entity_specifics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet_credential#entity_specifics FleetAppsManagementFleetCredential#entity_specifics}
        /// </remarks>
        [JsiiProperty(name: "entitySpecifics", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleetCredential.FleetAppsManagementFleetCredentialEntitySpecifics\"}")]
        oci.FleetAppsManagementFleetCredential.IFleetAppsManagementFleetCredentialEntitySpecifics EntitySpecifics
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet_credential#fleet_id FleetAppsManagementFleetCredential#fleet_id}.</summary>
        [JsiiProperty(name: "fleetId", typeJson: "{\"primitive\":\"string\"}")]
        string FleetId
        {
            get;
        }

        /// <summary>password block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet_credential#password FleetAppsManagementFleetCredential#password}
        /// </remarks>
        [JsiiProperty(name: "password", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleetCredential.FleetAppsManagementFleetCredentialPassword\"}")]
        oci.FleetAppsManagementFleetCredential.IFleetAppsManagementFleetCredentialPassword Password
        {
            get;
        }

        /// <summary>user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet_credential#user FleetAppsManagementFleetCredential#user}
        /// </remarks>
        [JsiiProperty(name: "user", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleetCredential.FleetAppsManagementFleetCredentialUser\"}")]
        oci.FleetAppsManagementFleetCredential.IFleetAppsManagementFleetCredentialUser User
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet_credential#id FleetAppsManagementFleetCredential#id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet_credential#timeouts FleetAppsManagementFleetCredential#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleetCredential.FleetAppsManagementFleetCredentialTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.FleetAppsManagementFleetCredential.IFleetAppsManagementFleetCredentialTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetAppsManagementFleetCredentialConfig), fullyQualifiedName: "oci.fleetAppsManagementFleetCredential.FleetAppsManagementFleetCredentialConfig")]
        internal sealed class _Proxy : DeputyBase, oci.FleetAppsManagementFleetCredential.IFleetAppsManagementFleetCredentialConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet_credential#compartment_id FleetAppsManagementFleetCredential#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet_credential#display_name FleetAppsManagementFleetCredential#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>entity_specifics block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet_credential#entity_specifics FleetAppsManagementFleetCredential#entity_specifics}
            /// </remarks>
            [JsiiProperty(name: "entitySpecifics", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleetCredential.FleetAppsManagementFleetCredentialEntitySpecifics\"}")]
            public oci.FleetAppsManagementFleetCredential.IFleetAppsManagementFleetCredentialEntitySpecifics EntitySpecifics
            {
                get => GetInstanceProperty<oci.FleetAppsManagementFleetCredential.IFleetAppsManagementFleetCredentialEntitySpecifics>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet_credential#fleet_id FleetAppsManagementFleetCredential#fleet_id}.</summary>
            [JsiiProperty(name: "fleetId", typeJson: "{\"primitive\":\"string\"}")]
            public string FleetId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>password block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet_credential#password FleetAppsManagementFleetCredential#password}
            /// </remarks>
            [JsiiProperty(name: "password", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleetCredential.FleetAppsManagementFleetCredentialPassword\"}")]
            public oci.FleetAppsManagementFleetCredential.IFleetAppsManagementFleetCredentialPassword Password
            {
                get => GetInstanceProperty<oci.FleetAppsManagementFleetCredential.IFleetAppsManagementFleetCredentialPassword>()!;
            }

            /// <summary>user block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet_credential#user FleetAppsManagementFleetCredential#user}
            /// </remarks>
            [JsiiProperty(name: "user", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleetCredential.FleetAppsManagementFleetCredentialUser\"}")]
            public oci.FleetAppsManagementFleetCredential.IFleetAppsManagementFleetCredentialUser User
            {
                get => GetInstanceProperty<oci.FleetAppsManagementFleetCredential.IFleetAppsManagementFleetCredentialUser>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet_credential#id FleetAppsManagementFleetCredential#id}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet_credential#timeouts FleetAppsManagementFleetCredential#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleetCredential.FleetAppsManagementFleetCredentialTimeouts\"}", isOptional: true)]
            public oci.FleetAppsManagementFleetCredential.IFleetAppsManagementFleetCredentialTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.FleetAppsManagementFleetCredential.IFleetAppsManagementFleetCredentialTimeouts?>();
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
