using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiModel
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiModelFineTuneDetailsTrainingDataset), fullyQualifiedName: "oci.generativeAiModel.GenerativeAiModelFineTuneDetailsTrainingDataset")]
    public interface IGenerativeAiModelFineTuneDetailsTrainingDataset
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_model#bucket GenerativeAiModel#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        string Bucket
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_model#dataset_type GenerativeAiModel#dataset_type}.</summary>
        [JsiiProperty(name: "datasetType", typeJson: "{\"primitive\":\"string\"}")]
        string DatasetType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_model#namespace GenerativeAiModel#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        string Namespace
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_model#object GenerativeAiModel#object}.</summary>
        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        string Object
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiModelFineTuneDetailsTrainingDataset), fullyQualifiedName: "oci.generativeAiModel.GenerativeAiModelFineTuneDetailsTrainingDataset")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiModel.IGenerativeAiModelFineTuneDetailsTrainingDataset
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_model#bucket GenerativeAiModel#bucket}.</summary>
            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
            public string Bucket
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_model#dataset_type GenerativeAiModel#dataset_type}.</summary>
            [JsiiProperty(name: "datasetType", typeJson: "{\"primitive\":\"string\"}")]
            public string DatasetType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_model#namespace GenerativeAiModel#namespace}.</summary>
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
            public string Namespace
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_model#object GenerativeAiModel#object}.</summary>
            [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
            public string Object
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
