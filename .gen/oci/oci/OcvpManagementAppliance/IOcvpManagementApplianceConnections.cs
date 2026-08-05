using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OcvpManagementAppliance
{
    [JsiiInterface(nativeType: typeof(IOcvpManagementApplianceConnections), fullyQualifiedName: "oci.ocvpManagementAppliance.OcvpManagementApplianceConnections")]
    public interface IOcvpManagementApplianceConnections
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/ocvp_management_appliance#credentials_secret_id OcvpManagementAppliance#credentials_secret_id}.</summary>
        [JsiiProperty(name: "credentialsSecretId", typeJson: "{\"primitive\":\"string\"}")]
        string CredentialsSecretId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/ocvp_management_appliance#type OcvpManagementAppliance#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IOcvpManagementApplianceConnections), fullyQualifiedName: "oci.ocvpManagementAppliance.OcvpManagementApplianceConnections")]
        internal sealed class _Proxy : DeputyBase, oci.OcvpManagementAppliance.IOcvpManagementApplianceConnections
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/ocvp_management_appliance#credentials_secret_id OcvpManagementAppliance#credentials_secret_id}.</summary>
            [JsiiProperty(name: "credentialsSecretId", typeJson: "{\"primitive\":\"string\"}")]
            public string CredentialsSecretId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/ocvp_management_appliance#type OcvpManagementAppliance#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
