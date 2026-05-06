using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GoldenGatePipeline
{
    [JsiiInterface(nativeType: typeof(IGoldenGatePipelineProcessOptionsReplicateSchemaChange), fullyQualifiedName: "oci.goldenGatePipeline.GoldenGatePipelineProcessOptionsReplicateSchemaChange")]
    public interface IGoldenGatePipelineProcessOptionsReplicateSchemaChange
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_pipeline#can_replicate_schema_change GoldenGatePipeline#can_replicate_schema_change}.</summary>
        [JsiiProperty(name: "canReplicateSchemaChange", typeJson: "{\"primitive\":\"string\"}")]
        string CanReplicateSchemaChange
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_pipeline#action_on_ddl_error GoldenGatePipeline#action_on_ddl_error}.</summary>
        [JsiiProperty(name: "actionOnDdlError", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ActionOnDdlError
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_pipeline#action_on_dml_error GoldenGatePipeline#action_on_dml_error}.</summary>
        [JsiiProperty(name: "actionOnDmlError", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ActionOnDmlError
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGoldenGatePipelineProcessOptionsReplicateSchemaChange), fullyQualifiedName: "oci.goldenGatePipeline.GoldenGatePipelineProcessOptionsReplicateSchemaChange")]
        internal sealed class _Proxy : DeputyBase, oci.GoldenGatePipeline.IGoldenGatePipelineProcessOptionsReplicateSchemaChange
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_pipeline#can_replicate_schema_change GoldenGatePipeline#can_replicate_schema_change}.</summary>
            [JsiiProperty(name: "canReplicateSchemaChange", typeJson: "{\"primitive\":\"string\"}")]
            public string CanReplicateSchemaChange
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_pipeline#action_on_ddl_error GoldenGatePipeline#action_on_ddl_error}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "actionOnDdlError", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ActionOnDdlError
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_pipeline#action_on_dml_error GoldenGatePipeline#action_on_dml_error}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "actionOnDmlError", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ActionOnDmlError
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
