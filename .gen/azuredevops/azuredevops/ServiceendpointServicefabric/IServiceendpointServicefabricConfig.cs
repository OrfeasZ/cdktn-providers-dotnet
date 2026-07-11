using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointServicefabric
{
    [JsiiInterface(nativeType: typeof(IServiceendpointServicefabricConfig), fullyQualifiedName: "azuredevops.serviceendpointServicefabric.ServiceendpointServicefabricConfig")]
    public interface IServiceendpointServicefabricConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Client connection endpoint for the cluster. Prefix the value with 'tcp://';. This value overrides the publish profile.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_servicefabric#cluster_endpoint ServiceendpointServicefabric#cluster_endpoint}
        /// </remarks>
        [JsiiProperty(name: "clusterEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        string ClusterEndpoint
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_servicefabric#project_id ServiceendpointServicefabric#project_id}.</summary>
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        string ProjectId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_servicefabric#service_endpoint_name ServiceendpointServicefabric#service_endpoint_name}.</summary>
        [JsiiProperty(name: "serviceEndpointName", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceEndpointName
        {
            get;
        }

        /// <summary>azure_active_directory block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_servicefabric#azure_active_directory ServiceendpointServicefabric#azure_active_directory}
        /// </remarks>
        [JsiiProperty(name: "azureActiveDirectory", typeJson: "{\"fqn\":\"azuredevops.serviceendpointServicefabric.ServiceendpointServicefabricAzureActiveDirectory\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.ServiceendpointServicefabric.IServiceendpointServicefabricAzureActiveDirectory? AzureActiveDirectory
        {
            get
            {
                return null;
            }
        }

        /// <summary>certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_servicefabric#certificate ServiceendpointServicefabric#certificate}
        /// </remarks>
        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"azuredevops.serviceendpointServicefabric.ServiceendpointServicefabricCertificate\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.ServiceendpointServicefabric.IServiceendpointServicefabricCertificate? Certificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_servicefabric#description ServiceendpointServicefabric#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_servicefabric#id ServiceendpointServicefabric#id}.</summary>
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

        /// <summary>none block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_servicefabric#none ServiceendpointServicefabric#none}
        /// </remarks>
        [JsiiProperty(name: "none", typeJson: "{\"fqn\":\"azuredevops.serviceendpointServicefabric.ServiceendpointServicefabricNone\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.ServiceendpointServicefabric.IServiceendpointServicefabricNone? None
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_servicefabric#timeouts ServiceendpointServicefabric#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuredevops.serviceendpointServicefabric.ServiceendpointServicefabricTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.ServiceendpointServicefabric.IServiceendpointServicefabricTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceendpointServicefabricConfig), fullyQualifiedName: "azuredevops.serviceendpointServicefabric.ServiceendpointServicefabricConfig")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServiceendpointServicefabric.IServiceendpointServicefabricConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Client connection endpoint for the cluster. Prefix the value with 'tcp://';. This value overrides the publish profile.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_servicefabric#cluster_endpoint ServiceendpointServicefabric#cluster_endpoint}
            /// </remarks>
            [JsiiProperty(name: "clusterEndpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string ClusterEndpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_servicefabric#project_id ServiceendpointServicefabric#project_id}.</summary>
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
            public string ProjectId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_servicefabric#service_endpoint_name ServiceendpointServicefabric#service_endpoint_name}.</summary>
            [JsiiProperty(name: "serviceEndpointName", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceEndpointName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>azure_active_directory block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_servicefabric#azure_active_directory ServiceendpointServicefabric#azure_active_directory}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "azureActiveDirectory", typeJson: "{\"fqn\":\"azuredevops.serviceendpointServicefabric.ServiceendpointServicefabricAzureActiveDirectory\"}", isOptional: true)]
            public azuredevops.ServiceendpointServicefabric.IServiceendpointServicefabricAzureActiveDirectory? AzureActiveDirectory
            {
                get => GetInstanceProperty<azuredevops.ServiceendpointServicefabric.IServiceendpointServicefabricAzureActiveDirectory?>();
            }

            /// <summary>certificate block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_servicefabric#certificate ServiceendpointServicefabric#certificate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"azuredevops.serviceendpointServicefabric.ServiceendpointServicefabricCertificate\"}", isOptional: true)]
            public azuredevops.ServiceendpointServicefabric.IServiceendpointServicefabricCertificate? Certificate
            {
                get => GetInstanceProperty<azuredevops.ServiceendpointServicefabric.IServiceendpointServicefabricCertificate?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_servicefabric#description ServiceendpointServicefabric#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_servicefabric#id ServiceendpointServicefabric#id}.</summary>
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

            /// <summary>none block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_servicefabric#none ServiceendpointServicefabric#none}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "none", typeJson: "{\"fqn\":\"azuredevops.serviceendpointServicefabric.ServiceendpointServicefabricNone\"}", isOptional: true)]
            public azuredevops.ServiceendpointServicefabric.IServiceendpointServicefabricNone? None
            {
                get => GetInstanceProperty<azuredevops.ServiceendpointServicefabric.IServiceendpointServicefabricNone?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_servicefabric#timeouts ServiceendpointServicefabric#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuredevops.serviceendpointServicefabric.ServiceendpointServicefabricTimeouts\"}", isOptional: true)]
            public azuredevops.ServiceendpointServicefabric.IServiceendpointServicefabricTimeouts? Timeouts
            {
                get => GetInstanceProperty<azuredevops.ServiceendpointServicefabric.IServiceendpointServicefabricTimeouts?>();
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
