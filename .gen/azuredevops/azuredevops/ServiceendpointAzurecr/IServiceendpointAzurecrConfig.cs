using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointAzurecr
{
    [JsiiInterface(nativeType: typeof(IServiceendpointAzurecrConfig), fullyQualifiedName: "azuredevops.serviceendpointAzurecr.ServiceendpointAzurecrConfig")]
    public interface IServiceendpointAzurecrConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The AzureContainerRegistry registry which should be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/serviceendpoint_azurecr#azurecr_name ServiceendpointAzurecr#azurecr_name}
        /// </remarks>
        [JsiiProperty(name: "azurecrName", typeJson: "{\"primitive\":\"string\"}")]
        string AzurecrName
        {
            get;
        }

        /// <summary>The service principal tenant id which should be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/serviceendpoint_azurecr#azurecr_spn_tenantid ServiceendpointAzurecr#azurecr_spn_tenantid}
        /// </remarks>
        [JsiiProperty(name: "azurecrSpnTenantid", typeJson: "{\"primitive\":\"string\"}")]
        string AzurecrSpnTenantid
        {
            get;
        }

        /// <summary>The Azure subscription Id which should be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/serviceendpoint_azurecr#azurecr_subscription_id ServiceendpointAzurecr#azurecr_subscription_id}
        /// </remarks>
        [JsiiProperty(name: "azurecrSubscriptionId", typeJson: "{\"primitive\":\"string\"}")]
        string AzurecrSubscriptionId
        {
            get;
        }

        /// <summary>The Azure subscription name which should be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/serviceendpoint_azurecr#azurecr_subscription_name ServiceendpointAzurecr#azurecr_subscription_name}
        /// </remarks>
        [JsiiProperty(name: "azurecrSubscriptionName", typeJson: "{\"primitive\":\"string\"}")]
        string AzurecrSubscriptionName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/serviceendpoint_azurecr#project_id ServiceendpointAzurecr#project_id}.</summary>
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        string ProjectId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/serviceendpoint_azurecr#service_endpoint_name ServiceendpointAzurecr#service_endpoint_name}.</summary>
        [JsiiProperty(name: "serviceEndpointName", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceEndpointName
        {
            get;
        }

        /// <summary>credentials block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/serviceendpoint_azurecr#credentials ServiceendpointAzurecr#credentials}
        /// </remarks>
        [JsiiProperty(name: "credentials", typeJson: "{\"fqn\":\"azuredevops.serviceendpointAzurecr.ServiceendpointAzurecrCredentials\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.ServiceendpointAzurecr.IServiceendpointAzurecrCredentials? Credentials
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/serviceendpoint_azurecr#description ServiceendpointAzurecr#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/serviceendpoint_azurecr#id ServiceendpointAzurecr#id}.</summary>
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

        /// <summary>Scope Resource Group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/serviceendpoint_azurecr#resource_group ServiceendpointAzurecr#resource_group}
        /// </remarks>
        [JsiiProperty(name: "resourceGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>The AzureCR Service Endpoint Authentication Scheme, this can be 'WorkloadIdentityFederation', 'ManagedServiceIdentity' or 'ServicePrincipal'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/serviceendpoint_azurecr#service_endpoint_authentication_scheme ServiceendpointAzurecr#service_endpoint_authentication_scheme}
        /// </remarks>
        [JsiiProperty(name: "serviceEndpointAuthenticationScheme", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceEndpointAuthenticationScheme
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/serviceendpoint_azurecr#timeouts ServiceendpointAzurecr#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuredevops.serviceendpointAzurecr.ServiceendpointAzurecrTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.ServiceendpointAzurecr.IServiceendpointAzurecrTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceendpointAzurecrConfig), fullyQualifiedName: "azuredevops.serviceendpointAzurecr.ServiceendpointAzurecrConfig")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServiceendpointAzurecr.IServiceendpointAzurecrConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The AzureContainerRegistry registry which should be used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/serviceendpoint_azurecr#azurecr_name ServiceendpointAzurecr#azurecr_name}
            /// </remarks>
            [JsiiProperty(name: "azurecrName", typeJson: "{\"primitive\":\"string\"}")]
            public string AzurecrName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The service principal tenant id which should be used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/serviceendpoint_azurecr#azurecr_spn_tenantid ServiceendpointAzurecr#azurecr_spn_tenantid}
            /// </remarks>
            [JsiiProperty(name: "azurecrSpnTenantid", typeJson: "{\"primitive\":\"string\"}")]
            public string AzurecrSpnTenantid
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The Azure subscription Id which should be used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/serviceendpoint_azurecr#azurecr_subscription_id ServiceendpointAzurecr#azurecr_subscription_id}
            /// </remarks>
            [JsiiProperty(name: "azurecrSubscriptionId", typeJson: "{\"primitive\":\"string\"}")]
            public string AzurecrSubscriptionId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The Azure subscription name which should be used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/serviceendpoint_azurecr#azurecr_subscription_name ServiceendpointAzurecr#azurecr_subscription_name}
            /// </remarks>
            [JsiiProperty(name: "azurecrSubscriptionName", typeJson: "{\"primitive\":\"string\"}")]
            public string AzurecrSubscriptionName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/serviceendpoint_azurecr#project_id ServiceendpointAzurecr#project_id}.</summary>
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
            public string ProjectId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/serviceendpoint_azurecr#service_endpoint_name ServiceendpointAzurecr#service_endpoint_name}.</summary>
            [JsiiProperty(name: "serviceEndpointName", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceEndpointName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>credentials block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/serviceendpoint_azurecr#credentials ServiceendpointAzurecr#credentials}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "credentials", typeJson: "{\"fqn\":\"azuredevops.serviceendpointAzurecr.ServiceendpointAzurecrCredentials\"}", isOptional: true)]
            public azuredevops.ServiceendpointAzurecr.IServiceendpointAzurecrCredentials? Credentials
            {
                get => GetInstanceProperty<azuredevops.ServiceendpointAzurecr.IServiceendpointAzurecrCredentials?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/serviceendpoint_azurecr#description ServiceendpointAzurecr#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/serviceendpoint_azurecr#id ServiceendpointAzurecr#id}.</summary>
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

            /// <summary>Scope Resource Group.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/serviceendpoint_azurecr#resource_group ServiceendpointAzurecr#resource_group}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceGroup
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The AzureCR Service Endpoint Authentication Scheme, this can be 'WorkloadIdentityFederation', 'ManagedServiceIdentity' or 'ServicePrincipal'.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/serviceendpoint_azurecr#service_endpoint_authentication_scheme ServiceendpointAzurecr#service_endpoint_authentication_scheme}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serviceEndpointAuthenticationScheme", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceEndpointAuthenticationScheme
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/serviceendpoint_azurecr#timeouts ServiceendpointAzurecr#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuredevops.serviceendpointAzurecr.ServiceendpointAzurecrTimeouts\"}", isOptional: true)]
            public azuredevops.ServiceendpointAzurecr.IServiceendpointAzurecrTimeouts? Timeouts
            {
                get => GetInstanceProperty<azuredevops.ServiceendpointAzurecr.IServiceendpointAzurecrTimeouts?>();
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
