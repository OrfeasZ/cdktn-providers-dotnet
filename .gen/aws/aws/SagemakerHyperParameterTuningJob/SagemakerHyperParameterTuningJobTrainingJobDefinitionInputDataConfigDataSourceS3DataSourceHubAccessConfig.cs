using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionInputDataConfigDataSourceS3DataSourceHubAccessConfig")]
    public class SagemakerHyperParameterTuningJobTrainingJobDefinitionInputDataConfigDataSourceS3DataSourceHubAccessConfig : aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionInputDataConfigDataSourceS3DataSourceHubAccessConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#hub_content_arn SagemakerHyperParameterTuningJob#hub_content_arn}.</summary>
        [JsiiProperty(name: "hubContentArn", typeJson: "{\"primitive\":\"string\"}")]
        public string HubContentArn
        {
            get;
            set;
        }
    }
}
