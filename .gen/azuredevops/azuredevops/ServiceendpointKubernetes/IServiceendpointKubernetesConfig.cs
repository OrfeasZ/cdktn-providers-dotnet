using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointKubernetes
{
    [JsiiInterface(nativeType: typeof(IServiceendpointKubernetesConfig), fullyQualifiedName: "azuredevops.serviceendpointKubernetes.ServiceendpointKubernetesConfig")]
    public interface IServiceendpointKubernetesConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>URL to Kubernete's API-Server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_kubernetes#apiserver_url ServiceendpointKubernetes#apiserver_url}
        /// </remarks>
        [JsiiProperty(name: "apiserverUrl", typeJson: "{\"primitive\":\"string\"}")]
        string ApiserverUrl
        {
            get;
        }

        /// <summary>Type of credentials to use.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_kubernetes#authorization_type ServiceendpointKubernetes#authorization_type}
        /// </remarks>
        [JsiiProperty(name: "authorizationType", typeJson: "{\"primitive\":\"string\"}")]
        string AuthorizationType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_kubernetes#project_id ServiceendpointKubernetes#project_id}.</summary>
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        string ProjectId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_kubernetes#service_endpoint_name ServiceendpointKubernetes#service_endpoint_name}.</summary>
        [JsiiProperty(name: "serviceEndpointName", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceEndpointName
        {
            get;
        }

        /// <summary>azure_subscription block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_kubernetes#azure_subscription ServiceendpointKubernetes#azure_subscription}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuredevops.ServiceendpointKubernetes.IServiceendpointKubernetesAzureSubscription" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "azureSubscription", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.serviceendpointKubernetes.ServiceendpointKubernetesAzureSubscription\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AzureSubscription
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_kubernetes#description ServiceendpointKubernetes#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_kubernetes#id ServiceendpointKubernetes#id}.</summary>
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

        /// <summary>kubeconfig block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_kubernetes#kubeconfig ServiceendpointKubernetes#kubeconfig}
        /// </remarks>
        [JsiiProperty(name: "kubeconfig", typeJson: "{\"fqn\":\"azuredevops.serviceendpointKubernetes.ServiceendpointKubernetesKubeconfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.ServiceendpointKubernetes.IServiceendpointKubernetesKubeconfig? Kubeconfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>service_account block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_kubernetes#service_account ServiceendpointKubernetes#service_account}
        /// </remarks>
        [JsiiProperty(name: "serviceAccount", typeJson: "{\"fqn\":\"azuredevops.serviceendpointKubernetes.ServiceendpointKubernetesServiceAccount\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.ServiceendpointKubernetes.IServiceendpointKubernetesServiceAccount? ServiceAccount
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_kubernetes#timeouts ServiceendpointKubernetes#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuredevops.serviceendpointKubernetes.ServiceendpointKubernetesTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.ServiceendpointKubernetes.IServiceendpointKubernetesTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceendpointKubernetesConfig), fullyQualifiedName: "azuredevops.serviceendpointKubernetes.ServiceendpointKubernetesConfig")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServiceendpointKubernetes.IServiceendpointKubernetesConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>URL to Kubernete's API-Server.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_kubernetes#apiserver_url ServiceendpointKubernetes#apiserver_url}
            /// </remarks>
            [JsiiProperty(name: "apiserverUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string ApiserverUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Type of credentials to use.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_kubernetes#authorization_type ServiceendpointKubernetes#authorization_type}
            /// </remarks>
            [JsiiProperty(name: "authorizationType", typeJson: "{\"primitive\":\"string\"}")]
            public string AuthorizationType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_kubernetes#project_id ServiceendpointKubernetes#project_id}.</summary>
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
            public string ProjectId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_kubernetes#service_endpoint_name ServiceendpointKubernetes#service_endpoint_name}.</summary>
            [JsiiProperty(name: "serviceEndpointName", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceEndpointName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>azure_subscription block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_kubernetes#azure_subscription ServiceendpointKubernetes#azure_subscription}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuredevops.ServiceendpointKubernetes.IServiceendpointKubernetesAzureSubscription" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "azureSubscription", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.serviceendpointKubernetes.ServiceendpointKubernetesAzureSubscription\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AzureSubscription
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_kubernetes#description ServiceendpointKubernetes#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_kubernetes#id ServiceendpointKubernetes#id}.</summary>
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

            /// <summary>kubeconfig block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_kubernetes#kubeconfig ServiceendpointKubernetes#kubeconfig}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kubeconfig", typeJson: "{\"fqn\":\"azuredevops.serviceendpointKubernetes.ServiceendpointKubernetesKubeconfig\"}", isOptional: true)]
            public azuredevops.ServiceendpointKubernetes.IServiceendpointKubernetesKubeconfig? Kubeconfig
            {
                get => GetInstanceProperty<azuredevops.ServiceendpointKubernetes.IServiceendpointKubernetesKubeconfig?>();
            }

            /// <summary>service_account block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_kubernetes#service_account ServiceendpointKubernetes#service_account}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serviceAccount", typeJson: "{\"fqn\":\"azuredevops.serviceendpointKubernetes.ServiceendpointKubernetesServiceAccount\"}", isOptional: true)]
            public azuredevops.ServiceendpointKubernetes.IServiceendpointKubernetesServiceAccount? ServiceAccount
            {
                get => GetInstanceProperty<azuredevops.ServiceendpointKubernetes.IServiceendpointKubernetesServiceAccount?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_kubernetes#timeouts ServiceendpointKubernetes#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuredevops.serviceendpointKubernetes.ServiceendpointKubernetesTimeouts\"}", isOptional: true)]
            public azuredevops.ServiceendpointKubernetes.IServiceendpointKubernetesTimeouts? Timeouts
            {
                get => GetInstanceProperty<azuredevops.ServiceendpointKubernetes.IServiceendpointKubernetesTimeouts?>();
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
