using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatasciencePipeline
{
    [JsiiInterface(nativeType: typeof(IDatasciencePipelineStepDetailsStepParameters), fullyQualifiedName: "oci.datasciencePipeline.DatasciencePipelineStepDetailsStepParameters")]
    public interface IDatasciencePipelineStepDetailsStepParameters
    {
        /// <summary>output block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#output DatasciencePipeline#output}
        /// </remarks>
        [JsiiProperty(name: "output", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepParametersOutput\"}")]
        oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepParametersOutput Output
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#parameter_type DatasciencePipeline#parameter_type}.</summary>
        [JsiiProperty(name: "parameterType", typeJson: "{\"primitive\":\"string\"}")]
        string ParameterType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatasciencePipelineStepDetailsStepParameters), fullyQualifiedName: "oci.datasciencePipeline.DatasciencePipelineStepDetailsStepParameters")]
        internal sealed class _Proxy : DeputyBase, oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>output block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#output DatasciencePipeline#output}
            /// </remarks>
            [JsiiProperty(name: "output", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepParametersOutput\"}")]
            public oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepParametersOutput Output
            {
                get => GetInstanceProperty<oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepParametersOutput>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#parameter_type DatasciencePipeline#parameter_type}.</summary>
            [JsiiProperty(name: "parameterType", typeJson: "{\"primitive\":\"string\"}")]
            public string ParameterType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
