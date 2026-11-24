using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementWorkspaceApiVersionSet
{
    [JsiiInterface(nativeType: typeof(IApiManagementWorkspaceApiVersionSetConfig), fullyQualifiedName: "azurerm.apiManagementWorkspaceApiVersionSet.ApiManagementWorkspaceApiVersionSetConfig")]
    public interface IApiManagementWorkspaceApiVersionSetConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_workspace_api_version_set#api_management_workspace_id ApiManagementWorkspaceApiVersionSet#api_management_workspace_id}.</summary>
        [JsiiProperty(name: "apiManagementWorkspaceId", typeJson: "{\"primitive\":\"string\"}")]
        string ApiManagementWorkspaceId
        {
            get;
        }

        /// <summary>The display name of the API Management Workspace API Version Set.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_workspace_api_version_set#display_name ApiManagementWorkspaceApiVersionSet#display_name}
        /// </remarks>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>The name of the API Management Workspace API Version Set.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_workspace_api_version_set#name ApiManagementWorkspaceApiVersionSet#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Where in a request that the API Version should be read from.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_workspace_api_version_set#versioning_scheme ApiManagementWorkspaceApiVersionSet#versioning_scheme}
        /// </remarks>
        [JsiiProperty(name: "versioningScheme", typeJson: "{\"primitive\":\"string\"}")]
        string VersioningScheme
        {
            get;
        }

        /// <summary>The description of the API Management Workspace API Version Set.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_workspace_api_version_set#description ApiManagementWorkspaceApiVersionSet#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_workspace_api_version_set#id ApiManagementWorkspaceApiVersionSet#id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_workspace_api_version_set#timeouts ApiManagementWorkspaceApiVersionSet#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.apiManagementWorkspaceApiVersionSet.ApiManagementWorkspaceApiVersionSetTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApiManagementWorkspaceApiVersionSet.IApiManagementWorkspaceApiVersionSetTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>The name of the header to read from inbound requests to determine the API version.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_workspace_api_version_set#version_header_name ApiManagementWorkspaceApiVersionSet#version_header_name}
        /// </remarks>
        [JsiiProperty(name: "versionHeaderName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VersionHeaderName
        {
            get
            {
                return null;
            }
        }

        /// <summary>The name of the query string parameter to read from inbound requests to determine the API version.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_workspace_api_version_set#version_query_name ApiManagementWorkspaceApiVersionSet#version_query_name}
        /// </remarks>
        [JsiiProperty(name: "versionQueryName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VersionQueryName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementWorkspaceApiVersionSetConfig), fullyQualifiedName: "azurerm.apiManagementWorkspaceApiVersionSet.ApiManagementWorkspaceApiVersionSetConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagementWorkspaceApiVersionSet.IApiManagementWorkspaceApiVersionSetConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_workspace_api_version_set#api_management_workspace_id ApiManagementWorkspaceApiVersionSet#api_management_workspace_id}.</summary>
            [JsiiProperty(name: "apiManagementWorkspaceId", typeJson: "{\"primitive\":\"string\"}")]
            public string ApiManagementWorkspaceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The display name of the API Management Workspace API Version Set.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_workspace_api_version_set#display_name ApiManagementWorkspaceApiVersionSet#display_name}
            /// </remarks>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The name of the API Management Workspace API Version Set.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_workspace_api_version_set#name ApiManagementWorkspaceApiVersionSet#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Where in a request that the API Version should be read from.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_workspace_api_version_set#versioning_scheme ApiManagementWorkspaceApiVersionSet#versioning_scheme}
            /// </remarks>
            [JsiiProperty(name: "versioningScheme", typeJson: "{\"primitive\":\"string\"}")]
            public string VersioningScheme
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The description of the API Management Workspace API Version Set.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_workspace_api_version_set#description ApiManagementWorkspaceApiVersionSet#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_workspace_api_version_set#id ApiManagementWorkspaceApiVersionSet#id}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_workspace_api_version_set#timeouts ApiManagementWorkspaceApiVersionSet#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.apiManagementWorkspaceApiVersionSet.ApiManagementWorkspaceApiVersionSetTimeouts\"}", isOptional: true)]
            public azurerm.ApiManagementWorkspaceApiVersionSet.IApiManagementWorkspaceApiVersionSetTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.ApiManagementWorkspaceApiVersionSet.IApiManagementWorkspaceApiVersionSetTimeouts?>();
            }

            /// <summary>The name of the header to read from inbound requests to determine the API version.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_workspace_api_version_set#version_header_name ApiManagementWorkspaceApiVersionSet#version_header_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "versionHeaderName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VersionHeaderName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The name of the query string parameter to read from inbound requests to determine the API version.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_workspace_api_version_set#version_query_name ApiManagementWorkspaceApiVersionSet#version_query_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "versionQueryName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VersionQueryName
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
