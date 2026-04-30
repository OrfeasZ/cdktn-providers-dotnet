using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    [JsiiByValue(fqn: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigStrategyConfigHyperbandStrategyConfig")]
    public class SagemakerHyperParameterTuningJobConfigStrategyConfigHyperbandStrategyConfig : aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigStrategyConfigHyperbandStrategyConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#max_resource SagemakerHyperParameterTuningJob#max_resource}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxResource", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxResource
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#min_resource SagemakerHyperParameterTuningJob#min_resource}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minResource", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinResource
        {
            get;
            set;
        }
    }
}
