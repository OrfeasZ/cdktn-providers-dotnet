using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.InferenceDeployment
{
    [JsiiInterface(nativeType: typeof(IInferenceDeploymentConfig), fullyQualifiedName: "scaleway.inferenceDeployment.InferenceDeploymentConfig")]
    public interface IInferenceDeploymentConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The model id used for the deployment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment#model_id InferenceDeployment#model_id}
        /// </remarks>
        [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}")]
        string ModelId
        {
            get;
        }

        /// <summary>The node type to use for the deployment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment#node_type InferenceDeployment#node_type}
        /// </remarks>
        [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}")]
        string NodeType
        {
            get;
        }

        /// <summary>Whether or not the deployment is accepting eula.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment#accept_eula InferenceDeployment#accept_eula}
        /// </remarks>
        [JsiiProperty(name: "acceptEula", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AcceptEula
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment#id InferenceDeployment#id}.</summary>
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

        /// <summary>The maximum size of the pool.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment#max_size InferenceDeployment#max_size}
        /// </remarks>
        [JsiiProperty(name: "maxSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>The minimum size of the pool.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment#min_size InferenceDeployment#min_size}
        /// </remarks>
        [JsiiProperty(name: "minSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>The deployment name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment#name InferenceDeployment#name}
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

        /// <summary>private_endpoint block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment#private_endpoint InferenceDeployment#private_endpoint}
        /// </remarks>
        [JsiiProperty(name: "privateEndpoint", typeJson: "{\"fqn\":\"scaleway.inferenceDeployment.InferenceDeploymentPrivateEndpoint\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.InferenceDeployment.IInferenceDeploymentPrivateEndpoint? PrivateEndpoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>private_ip block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment#private_ip InferenceDeployment#private_ip}
        /// </remarks>
        [JsiiProperty(name: "privateIp", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.inferenceDeployment.InferenceDeploymentPrivateIp\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PrivateIp
        {
            get
            {
                return null;
            }
        }

        /// <summary>The project_id you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment#project_id InferenceDeployment#project_id}
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

        /// <summary>public_endpoint block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment#public_endpoint InferenceDeployment#public_endpoint}
        /// </remarks>
        [JsiiProperty(name: "publicEndpoint", typeJson: "{\"fqn\":\"scaleway.inferenceDeployment.InferenceDeploymentPublicEndpoint\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.InferenceDeployment.IInferenceDeploymentPublicEndpoint? PublicEndpoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>The number of bits each model parameter should be quantized to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment#quantization InferenceDeployment#quantization}
        /// </remarks>
        [JsiiProperty(name: "quantization", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Quantization
        {
            get
            {
                return null;
            }
        }

        /// <summary>The region you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment#region InferenceDeployment#region}
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

        /// <summary>The tags associated with the deployment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment#tags InferenceDeployment#tags}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment#timeouts InferenceDeployment#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.inferenceDeployment.InferenceDeploymentTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.InferenceDeployment.IInferenceDeploymentTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInferenceDeploymentConfig), fullyQualifiedName: "scaleway.inferenceDeployment.InferenceDeploymentConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.InferenceDeployment.IInferenceDeploymentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The model id used for the deployment.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment#model_id InferenceDeployment#model_id}
            /// </remarks>
            [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}")]
            public string ModelId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The node type to use for the deployment.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment#node_type InferenceDeployment#node_type}
            /// </remarks>
            [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}")]
            public string NodeType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Whether or not the deployment is accepting eula.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment#accept_eula InferenceDeployment#accept_eula}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "acceptEula", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AcceptEula
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment#id InferenceDeployment#id}.</summary>
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

            /// <summary>The maximum size of the pool.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment#max_size InferenceDeployment#max_size}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The minimum size of the pool.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment#min_size InferenceDeployment#min_size}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "minSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The deployment name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment#name InferenceDeployment#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>private_endpoint block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment#private_endpoint InferenceDeployment#private_endpoint}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privateEndpoint", typeJson: "{\"fqn\":\"scaleway.inferenceDeployment.InferenceDeploymentPrivateEndpoint\"}", isOptional: true)]
            public scaleway.InferenceDeployment.IInferenceDeploymentPrivateEndpoint? PrivateEndpoint
            {
                get => GetInstanceProperty<scaleway.InferenceDeployment.IInferenceDeploymentPrivateEndpoint?>();
            }

            /// <summary>private_ip block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment#private_ip InferenceDeployment#private_ip}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privateIp", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.inferenceDeployment.InferenceDeploymentPrivateIp\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PrivateIp
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The project_id you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment#project_id InferenceDeployment#project_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProjectId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>public_endpoint block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment#public_endpoint InferenceDeployment#public_endpoint}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "publicEndpoint", typeJson: "{\"fqn\":\"scaleway.inferenceDeployment.InferenceDeploymentPublicEndpoint\"}", isOptional: true)]
            public scaleway.InferenceDeployment.IInferenceDeploymentPublicEndpoint? PublicEndpoint
            {
                get => GetInstanceProperty<scaleway.InferenceDeployment.IInferenceDeploymentPublicEndpoint?>();
            }

            /// <summary>The number of bits each model parameter should be quantized to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment#quantization InferenceDeployment#quantization}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "quantization", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Quantization
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The region you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment#region InferenceDeployment#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The tags associated with the deployment.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment#tags InferenceDeployment#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Tags
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment#timeouts InferenceDeployment#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.inferenceDeployment.InferenceDeploymentTimeouts\"}", isOptional: true)]
            public scaleway.InferenceDeployment.IInferenceDeploymentTimeouts? Timeouts
            {
                get => GetInstanceProperty<scaleway.InferenceDeployment.IInferenceDeploymentTimeouts?>();
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
