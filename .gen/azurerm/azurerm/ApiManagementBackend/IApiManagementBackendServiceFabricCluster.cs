using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementBackend
{
    [JsiiInterface(nativeType: typeof(IApiManagementBackendServiceFabricCluster), fullyQualifiedName: "azurerm.apiManagementBackend.ApiManagementBackendServiceFabricCluster")]
    public interface IApiManagementBackendServiceFabricCluster
    {
        /// <summary>A list of cluster management endpoints.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#management_endpoints ApiManagementBackend#management_endpoints}
        /// </remarks>
        [JsiiProperty(name: "managementEndpoints", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] ManagementEndpoints
        {
            get;
        }

        /// <summary>The maximum number of retries when attempting resolve the partition.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#max_partition_resolution_retries ApiManagementBackend#max_partition_resolution_retries}
        /// </remarks>
        [JsiiProperty(name: "maxPartitionResolutionRetries", typeJson: "{\"primitive\":\"number\"}")]
        double MaxPartitionResolutionRetries
        {
            get;
        }

        /// <summary>The client certificate resource ID for the management endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#client_certificate_id ApiManagementBackend#client_certificate_id}
        /// </remarks>
        [JsiiProperty(name: "clientCertificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientCertificateId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The client certificate thumbprint for the management endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#client_certificate_thumbprint ApiManagementBackend#client_certificate_thumbprint}
        /// </remarks>
        [JsiiProperty(name: "clientCertificateThumbprint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientCertificateThumbprint
        {
            get
            {
                return null;
            }
        }

        /// <summary>A list of thumbprints of the server certificates of the Service Fabric Cluster.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#server_certificate_thumbprints ApiManagementBackend#server_certificate_thumbprints}
        /// </remarks>
        [JsiiProperty(name: "serverCertificateThumbprints", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ServerCertificateThumbprints
        {
            get
            {
                return null;
            }
        }

        /// <summary>server_x509_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#server_x509_name ApiManagementBackend#server_x509_name}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApiManagementBackend.IApiManagementBackendServiceFabricClusterServerX509Name" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "serverX509Name", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagementBackend.ApiManagementBackendServiceFabricClusterServerX509Name\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ServerX509Name
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementBackendServiceFabricCluster), fullyQualifiedName: "azurerm.apiManagementBackend.ApiManagementBackendServiceFabricCluster")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagementBackend.IApiManagementBackendServiceFabricCluster
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A list of cluster management endpoints.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#management_endpoints ApiManagementBackend#management_endpoints}
            /// </remarks>
            [JsiiProperty(name: "managementEndpoints", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] ManagementEndpoints
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>The maximum number of retries when attempting resolve the partition.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#max_partition_resolution_retries ApiManagementBackend#max_partition_resolution_retries}
            /// </remarks>
            [JsiiProperty(name: "maxPartitionResolutionRetries", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxPartitionResolutionRetries
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>The client certificate resource ID for the management endpoint.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#client_certificate_id ApiManagementBackend#client_certificate_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientCertificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientCertificateId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The client certificate thumbprint for the management endpoint.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#client_certificate_thumbprint ApiManagementBackend#client_certificate_thumbprint}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientCertificateThumbprint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientCertificateThumbprint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A list of thumbprints of the server certificates of the Service Fabric Cluster.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#server_certificate_thumbprints ApiManagementBackend#server_certificate_thumbprints}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serverCertificateThumbprints", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ServerCertificateThumbprints
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>server_x509_name block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#server_x509_name ApiManagementBackend#server_x509_name}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApiManagementBackend.IApiManagementBackendServiceFabricClusterServerX509Name" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serverX509Name", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagementBackend.ApiManagementBackendServiceFabricClusterServerX509Name\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ServerX509Name
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
