using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatasciencePipeline
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.datasciencePipeline.DatasciencePipelineStepDetailsStepParameters")]
    public class DatasciencePipelineStepDetailsStepParameters : oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepParameters
    {
        /// <summary>output block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#output DatasciencePipeline#output}
        /// </remarks>
        [JsiiProperty(name: "output", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepParametersOutput\"}")]
        public oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepParametersOutput Output
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#parameter_type DatasciencePipeline#parameter_type}.</summary>
        [JsiiProperty(name: "parameterType", typeJson: "{\"primitive\":\"string\"}")]
        public string ParameterType
        {
            get;
            set;
        }
    }
}
