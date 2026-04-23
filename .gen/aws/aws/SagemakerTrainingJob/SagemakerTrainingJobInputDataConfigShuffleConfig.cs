using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    [JsiiByValue(fqn: "aws.sagemakerTrainingJob.SagemakerTrainingJobInputDataConfigShuffleConfig")]
    public class SagemakerTrainingJobInputDataConfigShuffleConfig : aws.SagemakerTrainingJob.ISagemakerTrainingJobInputDataConfigShuffleConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#seed SagemakerTrainingJob#seed}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "seed", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Seed
        {
            get;
            set;
        }
    }
}
