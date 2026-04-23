using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionResourceConfigInstancePlacementConfigPlacementSpecifications")]
    public class SagemakerHyperParameterTuningJobTrainingJobDefinitionResourceConfigInstancePlacementConfigPlacementSpecifications : aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionResourceConfigInstancePlacementConfigPlacementSpecifications
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#instance_count SagemakerHyperParameterTuningJob#instance_count}.</summary>
        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public double InstanceCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#ultra_server_id SagemakerHyperParameterTuningJob#ultra_server_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ultraServerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UltraServerId
        {
            get;
            set;
        }
    }
}
