using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionsInputDataConfigShuffleConfig")]
    public class SagemakerHyperParameterTuningJobTrainingJobDefinitionsInputDataConfigShuffleConfig : aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionsInputDataConfigShuffleConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#seed SagemakerHyperParameterTuningJob#seed}.</summary>
        [JsiiProperty(name: "seed", typeJson: "{\"primitive\":\"number\"}")]
        public double Seed
        {
            get;
            set;
        }
    }
}
