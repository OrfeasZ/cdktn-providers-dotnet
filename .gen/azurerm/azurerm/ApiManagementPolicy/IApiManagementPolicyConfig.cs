using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementPolicy
{
    [JsiiInterface(nativeType: typeof(IApiManagementPolicyConfig), fullyQualifiedName: "azurerm.apiManagementPolicy.ApiManagementPolicyConfig")]
    public interface IApiManagementPolicyConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The ID of the API Management service.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_policy#api_management_id ApiManagementPolicy#api_management_id}
        /// </remarks>
        [JsiiProperty(name: "apiManagementId", typeJson: "{\"primitive\":\"string\"}")]
        string ApiManagementId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_policy#id ApiManagementPolicy#id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_policy#timeouts ApiManagementPolicy#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.apiManagementPolicy.ApiManagementPolicyTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApiManagementPolicy.IApiManagementPolicyTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>The XML Content for this Policy as a string.</summary>
        /// <remarks>
        /// An XML file can be used here with Terraform's <a href="https://developer.hashicorp.com/terraform/language/functions/file">file function</a> that is similar to Microsoft's <c>PolicyFilePath</c> option. To integrate frontend and backend services in Azure API Management, utilize the <a href="https://learn.microsoft.com/azure/api-management/set-backend-service-policy"><c>set-backend-service</c></a> policy, specifying the <c>base-url</c> value. Typically, this value corresponds to the <c>url</c> property defined in the <a href="https://registry.terraform.io/providers/hashicorp/azurerm/latest/docs/resources/api_management_backend"><c>azurerm_api_management_backend</c></a> configuration.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_policy#xml_content ApiManagementPolicy#xml_content}
        /// </remarks>
        [JsiiProperty(name: "xmlContent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? XmlContent
        {
            get
            {
                return null;
            }
        }

        /// <summary>A link to a Policy XML Document, which must be publicly available.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_policy#xml_link ApiManagementPolicy#xml_link}
        /// </remarks>
        [JsiiProperty(name: "xmlLink", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? XmlLink
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementPolicyConfig), fullyQualifiedName: "azurerm.apiManagementPolicy.ApiManagementPolicyConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagementPolicy.IApiManagementPolicyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of the API Management service.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_policy#api_management_id ApiManagementPolicy#api_management_id}
            /// </remarks>
            [JsiiProperty(name: "apiManagementId", typeJson: "{\"primitive\":\"string\"}")]
            public string ApiManagementId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_policy#id ApiManagementPolicy#id}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_policy#timeouts ApiManagementPolicy#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.apiManagementPolicy.ApiManagementPolicyTimeouts\"}", isOptional: true)]
            public azurerm.ApiManagementPolicy.IApiManagementPolicyTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.ApiManagementPolicy.IApiManagementPolicyTimeouts?>();
            }

            /// <summary>The XML Content for this Policy as a string.</summary>
            /// <remarks>
            /// An XML file can be used here with Terraform's <a href="https://developer.hashicorp.com/terraform/language/functions/file">file function</a> that is similar to Microsoft's <c>PolicyFilePath</c> option. To integrate frontend and backend services in Azure API Management, utilize the <a href="https://learn.microsoft.com/azure/api-management/set-backend-service-policy"><c>set-backend-service</c></a> policy, specifying the <c>base-url</c> value. Typically, this value corresponds to the <c>url</c> property defined in the <a href="https://registry.terraform.io/providers/hashicorp/azurerm/latest/docs/resources/api_management_backend"><c>azurerm_api_management_backend</c></a> configuration.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_policy#xml_content ApiManagementPolicy#xml_content}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "xmlContent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? XmlContent
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A link to a Policy XML Document, which must be publicly available.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_policy#xml_link ApiManagementPolicy#xml_link}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "xmlLink", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? XmlLink
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
