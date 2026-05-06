using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementFleetCredential
{
    [JsiiInterface(nativeType: typeof(IFleetAppsManagementFleetCredentialEntitySpecifics), fullyQualifiedName: "oci.fleetAppsManagementFleetCredential.FleetAppsManagementFleetCredentialEntitySpecifics")]
    public interface IFleetAppsManagementFleetCredentialEntitySpecifics
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet_credential#credential_level FleetAppsManagementFleetCredential#credential_level}.</summary>
        [JsiiProperty(name: "credentialLevel", typeJson: "{\"primitive\":\"string\"}")]
        string CredentialLevel
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet_credential#resource_id FleetAppsManagementFleetCredential#resource_id}.</summary>
        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet_credential#target FleetAppsManagementFleetCredential#target}.</summary>
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Target
        {
            get
            {
                return null;
            }
        }

        /// <summary>variables block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet_credential#variables FleetAppsManagementFleetCredential#variables}
        /// </remarks>
        [JsiiProperty(name: "variables", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementFleetCredential.FleetAppsManagementFleetCredentialEntitySpecificsVariables\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Variables
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetAppsManagementFleetCredentialEntitySpecifics), fullyQualifiedName: "oci.fleetAppsManagementFleetCredential.FleetAppsManagementFleetCredentialEntitySpecifics")]
        internal sealed class _Proxy : DeputyBase, oci.FleetAppsManagementFleetCredential.IFleetAppsManagementFleetCredentialEntitySpecifics
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet_credential#credential_level FleetAppsManagementFleetCredential#credential_level}.</summary>
            [JsiiProperty(name: "credentialLevel", typeJson: "{\"primitive\":\"string\"}")]
            public string CredentialLevel
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet_credential#resource_id FleetAppsManagementFleetCredential#resource_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet_credential#target FleetAppsManagementFleetCredential#target}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Target
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>variables block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet_credential#variables FleetAppsManagementFleetCredential#variables}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "variables", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementFleetCredential.FleetAppsManagementFleetCredentialEntitySpecificsVariables\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Variables
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
