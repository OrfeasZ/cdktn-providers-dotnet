using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAlgorithm
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerAlgorithm.SagemakerAlgorithmInferenceSpecificationContainersAdditionalS3DataSource")]
    public class SagemakerAlgorithmInferenceSpecificationContainersAdditionalS3DataSource : aws.SagemakerAlgorithm.ISagemakerAlgorithmInferenceSpecificationContainersAdditionalS3DataSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#s3_data_type SagemakerAlgorithm#s3_data_type}.</summary>
        [JsiiProperty(name: "s3DataType", typeJson: "{\"primitive\":\"string\"}")]
        public string S3DataType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#s3_uri SagemakerAlgorithm#s3_uri}.</summary>
        [JsiiProperty(name: "s3Uri", typeJson: "{\"primitive\":\"string\"}")]
        public string S3Uri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#compression_type SagemakerAlgorithm#compression_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "compressionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CompressionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#etag SagemakerAlgorithm#etag}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "etag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Etag
        {
            get;
            set;
        }
    }
}
