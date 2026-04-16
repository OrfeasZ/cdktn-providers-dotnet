using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.EdgeServicesTlsStage
{
    [JsiiInterface(nativeType: typeof(IEdgeServicesTlsStageConfig), fullyQualifiedName: "scaleway.edgeServicesTlsStage.EdgeServicesTlsStageConfig")]
    public interface IEdgeServicesTlsStageConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The ID of the pipeline.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_tls_stage#pipeline_id EdgeServicesTlsStage#pipeline_id}
        /// </remarks>
        [JsiiProperty(name: "pipelineId", typeJson: "{\"primitive\":\"string\"}")]
        string PipelineId
        {
            get;
        }

        /// <summary>The backend stage ID the TLS stage will be linked to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_tls_stage#backend_stage_id EdgeServicesTlsStage#backend_stage_id}
        /// </remarks>
        [JsiiProperty(name: "backendStageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BackendStageId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The cache stage ID the TLS stage will be linked to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_tls_stage#cache_stage_id EdgeServicesTlsStage#cache_stage_id}
        /// </remarks>
        [JsiiProperty(name: "cacheStageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CacheStageId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_tls_stage#id EdgeServicesTlsStage#id}.</summary>
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

        /// <summary>Set to true when Scaleway generates and manages a Let's Encrypt certificate for the TLS stage/custom endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_tls_stage#managed_certificate EdgeServicesTlsStage#managed_certificate}
        /// </remarks>
        [JsiiProperty(name: "managedCertificate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ManagedCertificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>The project_id you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_tls_stage#project_id EdgeServicesTlsStage#project_id}
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

        /// <summary>The route stage ID the TLS stage will be linked to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_tls_stage#route_stage_id EdgeServicesTlsStage#route_stage_id}
        /// </remarks>
        [JsiiProperty(name: "routeStageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RouteStageId
        {
            get
            {
                return null;
            }
        }

        /// <summary>secrets block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_tls_stage#secrets EdgeServicesTlsStage#secrets}
        /// </remarks>
        [JsiiProperty(name: "secrets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.edgeServicesTlsStage.EdgeServicesTlsStageSecrets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Secrets
        {
            get
            {
                return null;
            }
        }

        /// <summary>The WAF stage ID the TLS stage will be linked to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_tls_stage#waf_stage_id EdgeServicesTlsStage#waf_stage_id}
        /// </remarks>
        [JsiiProperty(name: "wafStageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WafStageId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEdgeServicesTlsStageConfig), fullyQualifiedName: "scaleway.edgeServicesTlsStage.EdgeServicesTlsStageConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.EdgeServicesTlsStage.IEdgeServicesTlsStageConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of the pipeline.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_tls_stage#pipeline_id EdgeServicesTlsStage#pipeline_id}
            /// </remarks>
            [JsiiProperty(name: "pipelineId", typeJson: "{\"primitive\":\"string\"}")]
            public string PipelineId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The backend stage ID the TLS stage will be linked to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_tls_stage#backend_stage_id EdgeServicesTlsStage#backend_stage_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backendStageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BackendStageId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The cache stage ID the TLS stage will be linked to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_tls_stage#cache_stage_id EdgeServicesTlsStage#cache_stage_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cacheStageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CacheStageId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_tls_stage#id EdgeServicesTlsStage#id}.</summary>
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

            /// <summary>Set to true when Scaleway generates and manages a Let's Encrypt certificate for the TLS stage/custom endpoint.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_tls_stage#managed_certificate EdgeServicesTlsStage#managed_certificate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "managedCertificate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ManagedCertificate
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The project_id you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_tls_stage#project_id EdgeServicesTlsStage#project_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProjectId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The route stage ID the TLS stage will be linked to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_tls_stage#route_stage_id EdgeServicesTlsStage#route_stage_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "routeStageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RouteStageId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>secrets block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_tls_stage#secrets EdgeServicesTlsStage#secrets}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secrets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.edgeServicesTlsStage.EdgeServicesTlsStageSecrets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Secrets
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The WAF stage ID the TLS stage will be linked to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_tls_stage#waf_stage_id EdgeServicesTlsStage#waf_stage_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "wafStageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WafStageId
            {
                get => GetInstanceProperty<string?>();
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
