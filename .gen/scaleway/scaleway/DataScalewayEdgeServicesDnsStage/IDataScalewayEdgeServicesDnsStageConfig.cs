using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayEdgeServicesDnsStage
{
    [JsiiInterface(nativeType: typeof(IDataScalewayEdgeServicesDnsStageConfig), fullyQualifiedName: "scaleway.dataScalewayEdgeServicesDnsStage.DataScalewayEdgeServicesDnsStageConfig")]
    public interface IDataScalewayEdgeServicesDnsStageConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The ID of the DNS stage.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/edge_services_dns_stage#dns_stage_id DataScalewayEdgeServicesDnsStage#dns_stage_id}
        /// </remarks>
        [JsiiProperty(name: "dnsStageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DnsStageId
        {
            get
            {
                return null;
            }
        }

        /// <summary>FQDN to filter for (in the format subdomain.example.com).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/edge_services_dns_stage#fqdn DataScalewayEdgeServicesDnsStage#fqdn}
        /// </remarks>
        [JsiiProperty(name: "fqdn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Fqdn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/edge_services_dns_stage#id DataScalewayEdgeServicesDnsStage#id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/edge_services_dns_stage#pipeline_id DataScalewayEdgeServicesDnsStage#pipeline_id}
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

        [JsiiTypeProxy(nativeType: typeof(IDataScalewayEdgeServicesDnsStageConfig), fullyQualifiedName: "scaleway.dataScalewayEdgeServicesDnsStage.DataScalewayEdgeServicesDnsStageConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.DataScalewayEdgeServicesDnsStage.IDataScalewayEdgeServicesDnsStageConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of the DNS stage.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/edge_services_dns_stage#dns_stage_id DataScalewayEdgeServicesDnsStage#dns_stage_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dnsStageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DnsStageId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>FQDN to filter for (in the format subdomain.example.com).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/edge_services_dns_stage#fqdn DataScalewayEdgeServicesDnsStage#fqdn}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fqdn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Fqdn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/edge_services_dns_stage#id DataScalewayEdgeServicesDnsStage#id}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/edge_services_dns_stage#pipeline_id DataScalewayEdgeServicesDnsStage#pipeline_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pipelineId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PipelineId
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
