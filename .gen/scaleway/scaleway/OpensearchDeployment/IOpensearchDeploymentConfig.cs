using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.OpensearchDeployment
{
    [JsiiInterface(nativeType: typeof(IOpensearchDeploymentConfig), fullyQualifiedName: "scaleway.opensearchDeployment.OpensearchDeploymentConfig")]
    public interface IOpensearchDeploymentConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Number of nodes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/opensearch_deployment#node_amount OpensearchDeployment#node_amount}
        /// </remarks>
        [JsiiProperty(name: "nodeAmount", typeJson: "{\"primitive\":\"number\"}")]
        double NodeAmount
        {
            get;
        }

        /// <summary>Type of node.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/opensearch_deployment#node_type OpensearchDeployment#node_type}
        /// </remarks>
        [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}")]
        string NodeType
        {
            get;
        }

        /// <summary>OpenSearch version to use.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/opensearch_deployment#version OpensearchDeployment#version}
        /// </remarks>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        string Version
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/opensearch_deployment#id OpensearchDeployment#id}.</summary>
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

        /// <summary>Name of the OpenSearch deployment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/opensearch_deployment#name OpensearchDeployment#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Password for the deployment user.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/opensearch_deployment#password OpensearchDeployment#password}
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

        /// <summary>private_network block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/opensearch_deployment#private_network OpensearchDeployment#private_network}
        /// </remarks>
        [JsiiProperty(name: "privateNetwork", typeJson: "{\"fqn\":\"scaleway.opensearchDeployment.OpensearchDeploymentPrivateNetwork\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.OpensearchDeployment.IOpensearchDeploymentPrivateNetwork? PrivateNetwork
        {
            get
            {
                return null;
            }
        }

        /// <summary>The project_id you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/opensearch_deployment#project_id OpensearchDeployment#project_id}
        /// </remarks>
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProjectId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The region you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/opensearch_deployment#region OpensearchDeployment#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of tags to apply.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/opensearch_deployment#tags OpensearchDeployment#tags}
        /// </remarks>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/opensearch_deployment#timeouts OpensearchDeployment#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.opensearchDeployment.OpensearchDeploymentTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.OpensearchDeployment.IOpensearchDeploymentTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Username for the deployment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/opensearch_deployment#user_name OpensearchDeployment#user_name}
        /// </remarks>
        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserName
        {
            get
            {
                return null;
            }
        }

        /// <summary>volume block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/opensearch_deployment#volume OpensearchDeployment#volume}
        /// </remarks>
        [JsiiProperty(name: "volume", typeJson: "{\"fqn\":\"scaleway.opensearchDeployment.OpensearchDeploymentVolume\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.OpensearchDeployment.IOpensearchDeploymentVolume? Volume
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchDeploymentConfig), fullyQualifiedName: "scaleway.opensearchDeployment.OpensearchDeploymentConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.OpensearchDeployment.IOpensearchDeploymentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Number of nodes.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/opensearch_deployment#node_amount OpensearchDeployment#node_amount}
            /// </remarks>
            [JsiiProperty(name: "nodeAmount", typeJson: "{\"primitive\":\"number\"}")]
            public double NodeAmount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Type of node.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/opensearch_deployment#node_type OpensearchDeployment#node_type}
            /// </remarks>
            [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}")]
            public string NodeType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>OpenSearch version to use.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/opensearch_deployment#version OpensearchDeployment#version}
            /// </remarks>
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
            public string Version
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/opensearch_deployment#id OpensearchDeployment#id}.</summary>
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

            /// <summary>Name of the OpenSearch deployment.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/opensearch_deployment#name OpensearchDeployment#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Password for the deployment user.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/opensearch_deployment#password OpensearchDeployment#password}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Password
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>private_network block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/opensearch_deployment#private_network OpensearchDeployment#private_network}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privateNetwork", typeJson: "{\"fqn\":\"scaleway.opensearchDeployment.OpensearchDeploymentPrivateNetwork\"}", isOptional: true)]
            public scaleway.OpensearchDeployment.IOpensearchDeploymentPrivateNetwork? PrivateNetwork
            {
                get => GetInstanceProperty<scaleway.OpensearchDeployment.IOpensearchDeploymentPrivateNetwork?>();
            }

            /// <summary>The project_id you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/opensearch_deployment#project_id OpensearchDeployment#project_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProjectId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The region you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/opensearch_deployment#region OpensearchDeployment#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>List of tags to apply.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/opensearch_deployment#tags OpensearchDeployment#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Tags
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/opensearch_deployment#timeouts OpensearchDeployment#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.opensearchDeployment.OpensearchDeploymentTimeouts\"}", isOptional: true)]
            public scaleway.OpensearchDeployment.IOpensearchDeploymentTimeouts? Timeouts
            {
                get => GetInstanceProperty<scaleway.OpensearchDeployment.IOpensearchDeploymentTimeouts?>();
            }

            /// <summary>Username for the deployment.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/opensearch_deployment#user_name OpensearchDeployment#user_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>volume block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/opensearch_deployment#volume OpensearchDeployment#volume}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "volume", typeJson: "{\"fqn\":\"scaleway.opensearchDeployment.OpensearchDeploymentVolume\"}", isOptional: true)]
            public scaleway.OpensearchDeployment.IOpensearchDeploymentVolume? Volume
            {
                get => GetInstanceProperty<scaleway.OpensearchDeployment.IOpensearchDeploymentVolume?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
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
