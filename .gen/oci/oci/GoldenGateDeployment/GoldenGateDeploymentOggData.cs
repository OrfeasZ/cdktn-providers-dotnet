using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GoldenGateDeployment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.goldenGateDeployment.GoldenGateDeploymentOggData")]
    public class GoldenGateDeploymentOggData : oci.GoldenGateDeployment.IGoldenGateDeploymentOggData
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#deployment_name GoldenGateDeployment#deployment_name}.</summary>
        [JsiiProperty(name: "deploymentName", typeJson: "{\"primitive\":\"string\"}")]
        public string DeploymentName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#admin_password GoldenGateDeployment#admin_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AdminPassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#admin_username GoldenGateDeployment#admin_username}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "adminUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AdminUsername
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#certificate GoldenGateDeployment#certificate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Certificate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#credential_store GoldenGateDeployment#credential_store}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "credentialStore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CredentialStore
        {
            get;
            set;
        }

        /// <summary>group_to_roles_mapping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#group_to_roles_mapping GoldenGateDeployment#group_to_roles_mapping}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "groupToRolesMapping", typeJson: "{\"fqn\":\"oci.goldenGateDeployment.GoldenGateDeploymentOggDataGroupToRolesMapping\"}", isOptional: true)]
        public oci.GoldenGateDeployment.IGoldenGateDeploymentOggDataGroupToRolesMapping? GroupToRolesMapping
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#identity_domain_id GoldenGateDeployment#identity_domain_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "identityDomainId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IdentityDomainId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#key GoldenGateDeployment#key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#ogg_version GoldenGateDeployment#ogg_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "oggVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OggVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#password_secret_id GoldenGateDeployment#password_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "passwordSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PasswordSecretId
        {
            get;
            set;
        }
    }
}
