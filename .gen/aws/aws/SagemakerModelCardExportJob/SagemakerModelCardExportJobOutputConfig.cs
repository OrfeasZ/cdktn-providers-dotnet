using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerModelCardExportJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerModelCardExportJob.SagemakerModelCardExportJobOutputConfig")]
    public class SagemakerModelCardExportJobOutputConfig : aws.SagemakerModelCardExportJob.ISagemakerModelCardExportJobOutputConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_model_card_export_job#s3_output_path SagemakerModelCardExportJob#s3_output_path}.</summary>
        [JsiiProperty(name: "s3OutputPath", typeJson: "{\"primitive\":\"string\"}")]
        public string S3OutputPath
        {
            get;
            set;
        }
    }
}
