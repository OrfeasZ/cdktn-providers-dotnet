using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementBackend
{
    [JsiiInterface(nativeType: typeof(IApiManagementBackendConfig), fullyQualifiedName: "azurerm.apiManagementBackend.ApiManagementBackendConfig")]
    public interface IApiManagementBackendConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#api_management_name ApiManagementBackend#api_management_name}.</summary>
        [JsiiProperty(name: "apiManagementName", typeJson: "{\"primitive\":\"string\"}")]
        string ApiManagementName
        {
            get;
        }

        /// <summary>The name of the API Management backend.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#name ApiManagementBackend#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>The protocol used by the backend host.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#protocol ApiManagementBackend#protocol}
        /// </remarks>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        string Protocol
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#resource_group_name ApiManagementBackend#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>The backend host URL should be specified in the format `"https://backend.com/api"`, avoiding trailing slashes (/) to minimize misconfiguration risks. Azure API Management instance will append the backend resource name to this URL. This URL typically serves as the `base-url` in the [`set-backend-service`](https://learn.microsoft.com/azure/api-management/set-backend-service-policy) policy, enabling seamless transitions from frontend to backend.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#url ApiManagementBackend#url}
        /// </remarks>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        string Url
        {
            get;
        }

        /// <summary>circuit_breaker_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#circuit_breaker_rule ApiManagementBackend#circuit_breaker_rule}
        /// </remarks>
        [JsiiProperty(name: "circuitBreakerRule", typeJson: "{\"fqn\":\"azurerm.apiManagementBackend.ApiManagementBackendCircuitBreakerRule\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApiManagementBackend.IApiManagementBackendCircuitBreakerRule? CircuitBreakerRule
        {
            get
            {
                return null;
            }
        }

        /// <summary>credentials block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#credentials ApiManagementBackend#credentials}
        /// </remarks>
        [JsiiProperty(name: "credentials", typeJson: "{\"fqn\":\"azurerm.apiManagementBackend.ApiManagementBackendCredentials\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApiManagementBackend.IApiManagementBackendCredentials? Credentials
        {
            get
            {
                return null;
            }
        }

        /// <summary>The description of the backend.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#description ApiManagementBackend#description}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#id ApiManagementBackend#id}.</summary>
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

        /// <summary>proxy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#proxy ApiManagementBackend#proxy}
        /// </remarks>
        [JsiiProperty(name: "proxy", typeJson: "{\"fqn\":\"azurerm.apiManagementBackend.ApiManagementBackendProxy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApiManagementBackend.IApiManagementBackendProxy? Proxy
        {
            get
            {
                return null;
            }
        }

        /// <summary>The management URI of the backend host in an external system.</summary>
        /// <remarks>
        /// This URI can be the ARM Resource ID of Logic Apps, Function Apps or API Apps, or the management endpoint of a Service Fabric Cluster.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#resource_id ApiManagementBackend#resource_id}
        /// </remarks>
        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceId
        {
            get
            {
                return null;
            }
        }

        /// <summary>service_fabric_cluster block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#service_fabric_cluster ApiManagementBackend#service_fabric_cluster}
        /// </remarks>
        [JsiiProperty(name: "serviceFabricCluster", typeJson: "{\"fqn\":\"azurerm.apiManagementBackend.ApiManagementBackendServiceFabricCluster\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApiManagementBackend.IApiManagementBackendServiceFabricCluster? ServiceFabricCluster
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#timeouts ApiManagementBackend#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.apiManagementBackend.ApiManagementBackendTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApiManagementBackend.IApiManagementBackendTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>The title of the backend.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#title ApiManagementBackend#title}
        /// </remarks>
        [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Title
        {
            get
            {
                return null;
            }
        }

        /// <summary>tls block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#tls ApiManagementBackend#tls}
        /// </remarks>
        [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"azurerm.apiManagementBackend.ApiManagementBackendTls\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApiManagementBackend.IApiManagementBackendTls? Tls
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementBackendConfig), fullyQualifiedName: "azurerm.apiManagementBackend.ApiManagementBackendConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagementBackend.IApiManagementBackendConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#api_management_name ApiManagementBackend#api_management_name}.</summary>
            [JsiiProperty(name: "apiManagementName", typeJson: "{\"primitive\":\"string\"}")]
            public string ApiManagementName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The name of the API Management backend.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#name ApiManagementBackend#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The protocol used by the backend host.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#protocol ApiManagementBackend#protocol}
            /// </remarks>
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
            public string Protocol
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#resource_group_name ApiManagementBackend#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The backend host URL should be specified in the format `"https://backend.com/api"`, avoiding trailing slashes (/) to minimize misconfiguration risks. Azure API Management instance will append the backend resource name to this URL. This URL typically serves as the `base-url` in the [`set-backend-service`](https://learn.microsoft.com/azure/api-management/set-backend-service-policy) policy, enabling seamless transitions from frontend to backend.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#url ApiManagementBackend#url}
            /// </remarks>
            [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
            public string Url
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>circuit_breaker_rule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#circuit_breaker_rule ApiManagementBackend#circuit_breaker_rule}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "circuitBreakerRule", typeJson: "{\"fqn\":\"azurerm.apiManagementBackend.ApiManagementBackendCircuitBreakerRule\"}", isOptional: true)]
            public azurerm.ApiManagementBackend.IApiManagementBackendCircuitBreakerRule? CircuitBreakerRule
            {
                get => GetInstanceProperty<azurerm.ApiManagementBackend.IApiManagementBackendCircuitBreakerRule?>();
            }

            /// <summary>credentials block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#credentials ApiManagementBackend#credentials}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "credentials", typeJson: "{\"fqn\":\"azurerm.apiManagementBackend.ApiManagementBackendCredentials\"}", isOptional: true)]
            public azurerm.ApiManagementBackend.IApiManagementBackendCredentials? Credentials
            {
                get => GetInstanceProperty<azurerm.ApiManagementBackend.IApiManagementBackendCredentials?>();
            }

            /// <summary>The description of the backend.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#description ApiManagementBackend#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#id ApiManagementBackend#id}.</summary>
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

            /// <summary>proxy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#proxy ApiManagementBackend#proxy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "proxy", typeJson: "{\"fqn\":\"azurerm.apiManagementBackend.ApiManagementBackendProxy\"}", isOptional: true)]
            public azurerm.ApiManagementBackend.IApiManagementBackendProxy? Proxy
            {
                get => GetInstanceProperty<azurerm.ApiManagementBackend.IApiManagementBackendProxy?>();
            }

            /// <summary>The management URI of the backend host in an external system.</summary>
            /// <remarks>
            /// This URI can be the ARM Resource ID of Logic Apps, Function Apps or API Apps, or the management endpoint of a Service Fabric Cluster.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#resource_id ApiManagementBackend#resource_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>service_fabric_cluster block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#service_fabric_cluster ApiManagementBackend#service_fabric_cluster}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serviceFabricCluster", typeJson: "{\"fqn\":\"azurerm.apiManagementBackend.ApiManagementBackendServiceFabricCluster\"}", isOptional: true)]
            public azurerm.ApiManagementBackend.IApiManagementBackendServiceFabricCluster? ServiceFabricCluster
            {
                get => GetInstanceProperty<azurerm.ApiManagementBackend.IApiManagementBackendServiceFabricCluster?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#timeouts ApiManagementBackend#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.apiManagementBackend.ApiManagementBackendTimeouts\"}", isOptional: true)]
            public azurerm.ApiManagementBackend.IApiManagementBackendTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.ApiManagementBackend.IApiManagementBackendTimeouts?>();
            }

            /// <summary>The title of the backend.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#title ApiManagementBackend#title}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Title
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>tls block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#tls ApiManagementBackend#tls}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"azurerm.apiManagementBackend.ApiManagementBackendTls\"}", isOptional: true)]
            public azurerm.ApiManagementBackend.IApiManagementBackendTls? Tls
            {
                get => GetInstanceProperty<azurerm.ApiManagementBackend.IApiManagementBackendTls?>();
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
