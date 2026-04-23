using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerLabelingJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerLabelingJobHumanTaskConfigUiConfig), fullyQualifiedName: "aws.sagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigUiConfig")]
    public interface ISagemakerLabelingJobHumanTaskConfigUiConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#human_task_ui_arn SagemakerLabelingJob#human_task_ui_arn}.</summary>
        [JsiiProperty(name: "humanTaskUiArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HumanTaskUiArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#ui_template_s3_uri SagemakerLabelingJob#ui_template_s3_uri}.</summary>
        [JsiiProperty(name: "uiTemplateS3Uri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UiTemplateS3Uri
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerLabelingJobHumanTaskConfigUiConfig), fullyQualifiedName: "aws.sagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigUiConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerLabelingJob.ISagemakerLabelingJobHumanTaskConfigUiConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#human_task_ui_arn SagemakerLabelingJob#human_task_ui_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "humanTaskUiArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HumanTaskUiArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#ui_template_s3_uri SagemakerLabelingJob#ui_template_s3_uri}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "uiTemplateS3Uri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UiTemplateS3Uri
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
