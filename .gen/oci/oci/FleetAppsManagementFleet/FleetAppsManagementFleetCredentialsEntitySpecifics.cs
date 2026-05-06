using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementFleet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.fleetAppsManagementFleet.FleetAppsManagementFleetCredentialsEntitySpecifics")]
    public class FleetAppsManagementFleetCredentialsEntitySpecifics : oci.FleetAppsManagementFleet.IFleetAppsManagementFleetCredentialsEntitySpecifics
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#credential_level FleetAppsManagementFleet#credential_level}.</summary>
        [JsiiProperty(name: "credentialLevel", typeJson: "{\"primitive\":\"string\"}")]
        public string CredentialLevel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#resource_id FleetAppsManagementFleet#resource_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#target FleetAppsManagementFleet#target}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Target
        {
            get;
            set;
        }

        private object? _variables;

        /// <summary>variables block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#variables FleetAppsManagementFleet#variables}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "variables", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetCredentialsEntitySpecificsVariables\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Variables
        {
            get => _variables;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.FleetAppsManagementFleet.IFleetAppsManagementFleetCredentialsEntitySpecificsVariables[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementFleet.IFleetAppsManagementFleetCredentialsEntitySpecificsVariables).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _variables = value;
            }
        }
    }
}
