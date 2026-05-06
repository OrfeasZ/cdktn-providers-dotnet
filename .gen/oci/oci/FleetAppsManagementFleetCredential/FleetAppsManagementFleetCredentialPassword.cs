using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementFleetCredential
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.fleetAppsManagementFleetCredential.FleetAppsManagementFleetCredentialPassword")]
    public class FleetAppsManagementFleetCredentialPassword : oci.FleetAppsManagementFleetCredential.IFleetAppsManagementFleetCredentialPassword
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet_credential#credential_type FleetAppsManagementFleetCredential#credential_type}.</summary>
        [JsiiProperty(name: "credentialType", typeJson: "{\"primitive\":\"string\"}")]
        public string CredentialType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet_credential#key_id FleetAppsManagementFleetCredential#key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet_credential#key_version FleetAppsManagementFleetCredential#key_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet_credential#secret_id FleetAppsManagementFleetCredential#secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet_credential#secret_version FleetAppsManagementFleetCredential#secret_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secretVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet_credential#value FleetAppsManagementFleetCredential#value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet_credential#vault_id FleetAppsManagementFleetCredential#vault_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vaultId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VaultId
        {
            get;
            set;
        }
    }
}
