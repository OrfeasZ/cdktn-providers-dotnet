using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayEdgeServicesTlsStage
{
    [JsiiInterface(nativeType: typeof(IDataScalewayEdgeServicesTlsStageConfig), fullyQualifiedName: "scaleway.dataScalewayEdgeServicesTlsStage.DataScalewayEdgeServicesTlsStageConfig")]
    public interface IDataScalewayEdgeServicesTlsStageConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/edge_services_tls_stage#id DataScalewayEdgeServicesTlsStage#id}.</summary>
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

        /// <summary>The ID of the pipeline.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/edge_services_tls_stage#pipeline_id DataScalewayEdgeServicesTlsStage#pipeline_id}
        /// </remarks>
        [JsiiProperty(name: "pipelineId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PipelineId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Secret ID to filter for. Only TLS stages with this Secret ID will be returned.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/edge_services_tls_stage#secret_id DataScalewayEdgeServicesTlsStage#secret_id}
        /// </remarks>
        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecretId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Secret region to filter for. Only TLS stages with a Secret in this region will be returned.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/edge_services_tls_stage#secret_region DataScalewayEdgeServicesTlsStage#secret_region}
        /// </remarks>
        [JsiiProperty(name: "secretRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecretRegion
        {
            get
            {
                return null;
            }
        }

        /// <summary>The ID of the TLS stage.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/edge_services_tls_stage#tls_stage_id DataScalewayEdgeServicesTlsStage#tls_stage_id}
        /// </remarks>
        [JsiiProperty(name: "tlsStageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TlsStageId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataScalewayEdgeServicesTlsStageConfig), fullyQualifiedName: "scaleway.dataScalewayEdgeServicesTlsStage.DataScalewayEdgeServicesTlsStageConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.DataScalewayEdgeServicesTlsStage.IDataScalewayEdgeServicesTlsStageConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/edge_services_tls_stage#id DataScalewayEdgeServicesTlsStage#id}.</summary>
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

            /// <summary>The ID of the pipeline.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/edge_services_tls_stage#pipeline_id DataScalewayEdgeServicesTlsStage#pipeline_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pipelineId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PipelineId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Secret ID to filter for. Only TLS stages with this Secret ID will be returned.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/edge_services_tls_stage#secret_id DataScalewayEdgeServicesTlsStage#secret_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecretId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Secret region to filter for. Only TLS stages with a Secret in this region will be returned.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/edge_services_tls_stage#secret_region DataScalewayEdgeServicesTlsStage#secret_region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secretRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecretRegion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The ID of the TLS stage.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/edge_services_tls_stage#tls_stage_id DataScalewayEdgeServicesTlsStage#tls_stage_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tlsStageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TlsStageId
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
