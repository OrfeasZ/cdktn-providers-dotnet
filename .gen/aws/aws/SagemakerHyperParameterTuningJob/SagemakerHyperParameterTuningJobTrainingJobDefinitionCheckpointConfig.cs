using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionCheckpointConfig")]
    public class SagemakerHyperParameterTuningJobTrainingJobDefinitionCheckpointConfig : aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionCheckpointConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#s3_uri SagemakerHyperParameterTuningJob#s3_uri}.</summary>
        [JsiiProperty(name: "s3Uri", typeJson: "{\"primitive\":\"string\"}")]
        public string S3Uri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#local_path SagemakerHyperParameterTuningJob#local_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "localPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LocalPath
        {
            get;
            set;
        }
    }
}
