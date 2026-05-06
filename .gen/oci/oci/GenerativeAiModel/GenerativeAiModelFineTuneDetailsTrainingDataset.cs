using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiModel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.generativeAiModel.GenerativeAiModelFineTuneDetailsTrainingDataset")]
    public class GenerativeAiModelFineTuneDetailsTrainingDataset : oci.GenerativeAiModel.IGenerativeAiModelFineTuneDetailsTrainingDataset
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_model#bucket GenerativeAiModel#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public string Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_model#dataset_type GenerativeAiModel#dataset_type}.</summary>
        [JsiiProperty(name: "datasetType", typeJson: "{\"primitive\":\"string\"}")]
        public string DatasetType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_model#namespace GenerativeAiModel#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public string Namespace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_model#object GenerativeAiModel#object}.</summary>
        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        public string Object
        {
            get;
            set;
        }
    }
}
