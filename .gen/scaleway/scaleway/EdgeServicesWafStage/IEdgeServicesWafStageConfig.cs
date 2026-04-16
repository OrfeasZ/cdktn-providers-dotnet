using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.EdgeServicesWafStage
{
    [JsiiInterface(nativeType: typeof(IEdgeServicesWafStageConfig), fullyQualifiedName: "scaleway.edgeServicesWafStage.EdgeServicesWafStageConfig")]
    public interface IEdgeServicesWafStageConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The sensitivity level (`1`,`2`,`3`,`4`) to use when classifying requests as malicious.</summary>
        /// <remarks>
        /// With a high level, requests are more likely to be classed as malicious, and false positives are expected. With a lower level, requests are more likely to be classed as benign
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_waf_stage#paranoia_level EdgeServicesWafStage#paranoia_level}
        /// </remarks>
        [JsiiProperty(name: "paranoiaLevel", typeJson: "{\"primitive\":\"number\"}")]
        double ParanoiaLevel
        {
            get;
        }

        /// <summary>The ID of the pipeline.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_waf_stage#pipeline_id EdgeServicesWafStage#pipeline_id}
        /// </remarks>
        [JsiiProperty(name: "pipelineId", typeJson: "{\"primitive\":\"string\"}")]
        string PipelineId
        {
            get;
        }

        /// <summary>The ID of the backend stage to forward requests to after the WAF stage.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_waf_stage#backend_stage_id EdgeServicesWafStage#backend_stage_id}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_waf_stage#id EdgeServicesWafStage#id}.</summary>
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

        /// <summary>Mode defining WAF behavior (`disable`/`log_only`/`enable`).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_waf_stage#mode EdgeServicesWafStage#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Mode
        {
            get
            {
                return null;
            }
        }

        /// <summary>The project_id you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_waf_stage#project_id EdgeServicesWafStage#project_id}
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

        [JsiiTypeProxy(nativeType: typeof(IEdgeServicesWafStageConfig), fullyQualifiedName: "scaleway.edgeServicesWafStage.EdgeServicesWafStageConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.EdgeServicesWafStage.IEdgeServicesWafStageConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The sensitivity level (`1`,`2`,`3`,`4`) to use when classifying requests as malicious.</summary>
            /// <remarks>
            /// With a high level, requests are more likely to be classed as malicious, and false positives are expected. With a lower level, requests are more likely to be classed as benign
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_waf_stage#paranoia_level EdgeServicesWafStage#paranoia_level}
            /// </remarks>
            [JsiiProperty(name: "paranoiaLevel", typeJson: "{\"primitive\":\"number\"}")]
            public double ParanoiaLevel
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>The ID of the pipeline.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_waf_stage#pipeline_id EdgeServicesWafStage#pipeline_id}
            /// </remarks>
            [JsiiProperty(name: "pipelineId", typeJson: "{\"primitive\":\"string\"}")]
            public string PipelineId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The ID of the backend stage to forward requests to after the WAF stage.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_waf_stage#backend_stage_id EdgeServicesWafStage#backend_stage_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backendStageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BackendStageId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_waf_stage#id EdgeServicesWafStage#id}.</summary>
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

            /// <summary>Mode defining WAF behavior (`disable`/`log_only`/`enable`).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_waf_stage#mode EdgeServicesWafStage#mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Mode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The project_id you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_waf_stage#project_id EdgeServicesWafStage#project_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProjectId
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
