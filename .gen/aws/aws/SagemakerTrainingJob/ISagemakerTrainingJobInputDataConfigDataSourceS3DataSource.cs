using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerTrainingJobInputDataConfigDataSourceS3DataSource), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobInputDataConfigDataSourceS3DataSource")]
    public interface ISagemakerTrainingJobInputDataConfigDataSourceS3DataSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#s3_data_type SagemakerTrainingJob#s3_data_type}.</summary>
        [JsiiProperty(name: "s3DataType", typeJson: "{\"primitive\":\"string\"}")]
        string S3DataType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#s3_uri SagemakerTrainingJob#s3_uri}.</summary>
        [JsiiProperty(name: "s3Uri", typeJson: "{\"primitive\":\"string\"}")]
        string S3Uri
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#attribute_names SagemakerTrainingJob#attribute_names}.</summary>
        [JsiiProperty(name: "attributeNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AttributeNames
        {
            get
            {
                return null;
            }
        }

        /// <summary>hub_access_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#hub_access_config SagemakerTrainingJob#hub_access_config}
        /// </remarks>
        [JsiiProperty(name: "hubAccessConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerTrainingJob.SagemakerTrainingJobInputDataConfigDataSourceS3DataSourceHubAccessConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HubAccessConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#instance_group_names SagemakerTrainingJob#instance_group_names}.</summary>
        [JsiiProperty(name: "instanceGroupNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? InstanceGroupNames
        {
            get
            {
                return null;
            }
        }

        /// <summary>model_access_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#model_access_config SagemakerTrainingJob#model_access_config}
        /// </remarks>
        [JsiiProperty(name: "modelAccessConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerTrainingJob.SagemakerTrainingJobInputDataConfigDataSourceS3DataSourceModelAccessConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ModelAccessConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#s3_data_distribution_type SagemakerTrainingJob#s3_data_distribution_type}.</summary>
        [JsiiProperty(name: "s3DataDistributionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? S3DataDistributionType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerTrainingJobInputDataConfigDataSourceS3DataSource), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobInputDataConfigDataSourceS3DataSource")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerTrainingJob.ISagemakerTrainingJobInputDataConfigDataSourceS3DataSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#s3_data_type SagemakerTrainingJob#s3_data_type}.</summary>
            [JsiiProperty(name: "s3DataType", typeJson: "{\"primitive\":\"string\"}")]
            public string S3DataType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#s3_uri SagemakerTrainingJob#s3_uri}.</summary>
            [JsiiProperty(name: "s3Uri", typeJson: "{\"primitive\":\"string\"}")]
            public string S3Uri
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#attribute_names SagemakerTrainingJob#attribute_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "attributeNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AttributeNames
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>hub_access_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#hub_access_config SagemakerTrainingJob#hub_access_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hubAccessConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerTrainingJob.SagemakerTrainingJobInputDataConfigDataSourceS3DataSourceHubAccessConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? HubAccessConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#instance_group_names SagemakerTrainingJob#instance_group_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceGroupNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? InstanceGroupNames
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>model_access_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#model_access_config SagemakerTrainingJob#model_access_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "modelAccessConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerTrainingJob.SagemakerTrainingJobInputDataConfigDataSourceS3DataSourceModelAccessConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ModelAccessConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#s3_data_distribution_type SagemakerTrainingJob#s3_data_distribution_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "s3DataDistributionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3DataDistributionType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
