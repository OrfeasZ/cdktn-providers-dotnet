using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatasciencePipeline
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.datasciencePipeline.DatasciencePipelineStepDetailsStepParametersOutput")]
    public class DatasciencePipelineStepDetailsStepParametersOutput : oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepParametersOutput
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#output_file DatasciencePipeline#output_file}.</summary>
        [JsiiProperty(name: "outputFile", typeJson: "{\"primitive\":\"string\"}")]
        public string OutputFile
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#output_parameter_type DatasciencePipeline#output_parameter_type}.</summary>
        [JsiiProperty(name: "outputParameterType", typeJson: "{\"primitive\":\"string\"}")]
        public string OutputParameterType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#parameter_names DatasciencePipeline#parameter_names}.</summary>
        [JsiiProperty(name: "parameterNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] ParameterNames
        {
            get;
            set;
        }
    }
}
