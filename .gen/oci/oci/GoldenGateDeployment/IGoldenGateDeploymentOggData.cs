using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GoldenGateDeployment
{
    [JsiiInterface(nativeType: typeof(IGoldenGateDeploymentOggData), fullyQualifiedName: "oci.goldenGateDeployment.GoldenGateDeploymentOggData")]
    public interface IGoldenGateDeploymentOggData
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#deployment_name GoldenGateDeployment#deployment_name}.</summary>
        [JsiiProperty(name: "deploymentName", typeJson: "{\"primitive\":\"string\"}")]
        string DeploymentName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#admin_password GoldenGateDeployment#admin_password}.</summary>
        [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AdminPassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#admin_username GoldenGateDeployment#admin_username}.</summary>
        [JsiiProperty(name: "adminUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AdminUsername
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#certificate GoldenGateDeployment#certificate}.</summary>
        [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Certificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#credential_store GoldenGateDeployment#credential_store}.</summary>
        [JsiiProperty(name: "credentialStore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CredentialStore
        {
            get
            {
                return null;
            }
        }

        /// <summary>group_to_roles_mapping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#group_to_roles_mapping GoldenGateDeployment#group_to_roles_mapping}
        /// </remarks>
        [JsiiProperty(name: "groupToRolesMapping", typeJson: "{\"fqn\":\"oci.goldenGateDeployment.GoldenGateDeploymentOggDataGroupToRolesMapping\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.GoldenGateDeployment.IGoldenGateDeploymentOggDataGroupToRolesMapping? GroupToRolesMapping
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#identity_domain_id GoldenGateDeployment#identity_domain_id}.</summary>
        [JsiiProperty(name: "identityDomainId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IdentityDomainId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#key GoldenGateDeployment#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Key
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#ogg_version GoldenGateDeployment#ogg_version}.</summary>
        [JsiiProperty(name: "oggVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OggVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#password_secret_id GoldenGateDeployment#password_secret_id}.</summary>
        [JsiiProperty(name: "passwordSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PasswordSecretId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGoldenGateDeploymentOggData), fullyQualifiedName: "oci.goldenGateDeployment.GoldenGateDeploymentOggData")]
        internal sealed class _Proxy : DeputyBase, oci.GoldenGateDeployment.IGoldenGateDeploymentOggData
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#deployment_name GoldenGateDeployment#deployment_name}.</summary>
            [JsiiProperty(name: "deploymentName", typeJson: "{\"primitive\":\"string\"}")]
            public string DeploymentName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#admin_password GoldenGateDeployment#admin_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AdminPassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#admin_username GoldenGateDeployment#admin_username}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "adminUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AdminUsername
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#certificate GoldenGateDeployment#certificate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Certificate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#credential_store GoldenGateDeployment#credential_store}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "credentialStore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CredentialStore
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>group_to_roles_mapping block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#group_to_roles_mapping GoldenGateDeployment#group_to_roles_mapping}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "groupToRolesMapping", typeJson: "{\"fqn\":\"oci.goldenGateDeployment.GoldenGateDeploymentOggDataGroupToRolesMapping\"}", isOptional: true)]
            public oci.GoldenGateDeployment.IGoldenGateDeploymentOggDataGroupToRolesMapping? GroupToRolesMapping
            {
                get => GetInstanceProperty<oci.GoldenGateDeployment.IGoldenGateDeploymentOggDataGroupToRolesMapping?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#identity_domain_id GoldenGateDeployment#identity_domain_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "identityDomainId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IdentityDomainId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#key GoldenGateDeployment#key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Key
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#ogg_version GoldenGateDeployment#ogg_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "oggVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OggVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#password_secret_id GoldenGateDeployment#password_secret_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "passwordSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PasswordSecretId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
