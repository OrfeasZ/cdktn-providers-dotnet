using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OcvpManagementAppliance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.ocvpManagementAppliance.OcvpManagementApplianceConnections")]
    public class OcvpManagementApplianceConnections : oci.OcvpManagementAppliance.IOcvpManagementApplianceConnections
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/ocvp_management_appliance#credentials_secret_id OcvpManagementAppliance#credentials_secret_id}.</summary>
        [JsiiProperty(name: "credentialsSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public string CredentialsSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/ocvp_management_appliance#type OcvpManagementAppliance#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
