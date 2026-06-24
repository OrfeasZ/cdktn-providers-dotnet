using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ObservabilityadminS3TableIntegration
{
    [JsiiInterface(nativeType: typeof(IObservabilityadminS3TableIntegrationEncryption), fullyQualifiedName: "aws.observabilityadminS3TableIntegration.ObservabilityadminS3TableIntegrationEncryption")]
    public interface IObservabilityadminS3TableIntegrationEncryption
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/observabilityadmin_s3_table_integration#sse_algorithm ObservabilityadminS3TableIntegration#sse_algorithm}.</summary>
        [JsiiProperty(name: "sseAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        string SseAlgorithm
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/observabilityadmin_s3_table_integration#kms_key_arn ObservabilityadminS3TableIntegration#kms_key_arn}.</summary>
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IObservabilityadminS3TableIntegrationEncryption), fullyQualifiedName: "aws.observabilityadminS3TableIntegration.ObservabilityadminS3TableIntegrationEncryption")]
        internal sealed class _Proxy : DeputyBase, aws.ObservabilityadminS3TableIntegration.IObservabilityadminS3TableIntegrationEncryption
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/observabilityadmin_s3_table_integration#sse_algorithm ObservabilityadminS3TableIntegration#sse_algorithm}.</summary>
            [JsiiProperty(name: "sseAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
            public string SseAlgorithm
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/observabilityadmin_s3_table_integration#kms_key_arn ObservabilityadminS3TableIntegration#kms_key_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
