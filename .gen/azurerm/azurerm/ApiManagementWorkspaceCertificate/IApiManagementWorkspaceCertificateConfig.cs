using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementWorkspaceCertificate
{
    [JsiiInterface(nativeType: typeof(IApiManagementWorkspaceCertificateConfig), fullyQualifiedName: "azurerm.apiManagementWorkspaceCertificate.ApiManagementWorkspaceCertificateConfig")]
    public interface IApiManagementWorkspaceCertificateConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_workspace_certificate#api_management_workspace_id ApiManagementWorkspaceCertificate#api_management_workspace_id}.</summary>
        [JsiiProperty(name: "apiManagementWorkspaceId", typeJson: "{\"primitive\":\"string\"}")]
        string ApiManagementWorkspaceId
        {
            get;
        }

        /// <summary>The name of the API Management Workspace Certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_workspace_certificate#name ApiManagementWorkspaceCertificate#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>The base64-encoded string containing the certificate in PKCS#12 (.pfx) format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_workspace_certificate#certificate_data_base64 ApiManagementWorkspaceCertificate#certificate_data_base64}
        /// </remarks>
        [JsiiProperty(name: "certificateDataBase64", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateDataBase64
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_workspace_certificate#id ApiManagementWorkspaceCertificate#id}.</summary>
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

        /// <summary>The ID of the Key Vault Secret.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_workspace_certificate#key_vault_secret_id ApiManagementWorkspaceCertificate#key_vault_secret_id}
        /// </remarks>
        [JsiiProperty(name: "keyVaultSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeyVaultSecretId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The password used to access the `certificate_data_base64`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_workspace_certificate#password ApiManagementWorkspaceCertificate#password}
        /// </remarks>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Password
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_workspace_certificate#timeouts ApiManagementWorkspaceCertificate#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.apiManagementWorkspaceCertificate.ApiManagementWorkspaceCertificateTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApiManagementWorkspaceCertificate.IApiManagementWorkspaceCertificateTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>The client ID of user-assigned identity to be used for accessing the `key_vault_secret_id`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_workspace_certificate#user_assigned_identity_client_id ApiManagementWorkspaceCertificate#user_assigned_identity_client_id}
        /// </remarks>
        [JsiiProperty(name: "userAssignedIdentityClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserAssignedIdentityClientId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementWorkspaceCertificateConfig), fullyQualifiedName: "azurerm.apiManagementWorkspaceCertificate.ApiManagementWorkspaceCertificateConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagementWorkspaceCertificate.IApiManagementWorkspaceCertificateConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_workspace_certificate#api_management_workspace_id ApiManagementWorkspaceCertificate#api_management_workspace_id}.</summary>
            [JsiiProperty(name: "apiManagementWorkspaceId", typeJson: "{\"primitive\":\"string\"}")]
            public string ApiManagementWorkspaceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The name of the API Management Workspace Certificate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_workspace_certificate#name ApiManagementWorkspaceCertificate#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The base64-encoded string containing the certificate in PKCS#12 (.pfx) format.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_workspace_certificate#certificate_data_base64 ApiManagementWorkspaceCertificate#certificate_data_base64}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "certificateDataBase64", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateDataBase64
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_workspace_certificate#id ApiManagementWorkspaceCertificate#id}.</summary>
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

            /// <summary>The ID of the Key Vault Secret.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_workspace_certificate#key_vault_secret_id ApiManagementWorkspaceCertificate#key_vault_secret_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keyVaultSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeyVaultSecretId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The password used to access the `certificate_data_base64`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_workspace_certificate#password ApiManagementWorkspaceCertificate#password}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Password
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_workspace_certificate#timeouts ApiManagementWorkspaceCertificate#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.apiManagementWorkspaceCertificate.ApiManagementWorkspaceCertificateTimeouts\"}", isOptional: true)]
            public azurerm.ApiManagementWorkspaceCertificate.IApiManagementWorkspaceCertificateTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.ApiManagementWorkspaceCertificate.IApiManagementWorkspaceCertificateTimeouts?>();
            }

            /// <summary>The client ID of user-assigned identity to be used for accessing the `key_vault_secret_id`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_workspace_certificate#user_assigned_identity_client_id ApiManagementWorkspaceCertificate#user_assigned_identity_client_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "userAssignedIdentityClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserAssignedIdentityClientId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
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
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
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
