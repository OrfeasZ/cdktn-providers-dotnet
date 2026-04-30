using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerModelCardExportJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerModelCardExportJobOutputConfig), fullyQualifiedName: "aws.sagemakerModelCardExportJob.SagemakerModelCardExportJobOutputConfig")]
    public interface ISagemakerModelCardExportJobOutputConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_model_card_export_job#s3_output_path SagemakerModelCardExportJob#s3_output_path}.</summary>
        [JsiiProperty(name: "s3OutputPath", typeJson: "{\"primitive\":\"string\"}")]
        string S3OutputPath
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerModelCardExportJobOutputConfig), fullyQualifiedName: "aws.sagemakerModelCardExportJob.SagemakerModelCardExportJobOutputConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerModelCardExportJob.ISagemakerModelCardExportJobOutputConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_model_card_export_job#s3_output_path SagemakerModelCardExportJob#s3_output_path}.</summary>
            [JsiiProperty(name: "s3OutputPath", typeJson: "{\"primitive\":\"string\"}")]
            public string S3OutputPath
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
