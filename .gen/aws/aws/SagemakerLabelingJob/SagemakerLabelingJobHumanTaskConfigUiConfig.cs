using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerLabelingJob
{
    [JsiiByValue(fqn: "aws.sagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigUiConfig")]
    public class SagemakerLabelingJobHumanTaskConfigUiConfig : aws.SagemakerLabelingJob.ISagemakerLabelingJobHumanTaskConfigUiConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_labeling_job#human_task_ui_arn SagemakerLabelingJob#human_task_ui_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "humanTaskUiArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HumanTaskUiArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_labeling_job#ui_template_s3_uri SagemakerLabelingJob#ui_template_s3_uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "uiTemplateS3Uri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UiTemplateS3Uri
        {
            get;
            set;
        }
    }
}
