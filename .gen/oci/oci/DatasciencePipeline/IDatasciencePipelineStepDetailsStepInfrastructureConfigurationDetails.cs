using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatasciencePipeline
{
    [JsiiInterface(nativeType: typeof(IDatasciencePipelineStepDetailsStepInfrastructureConfigurationDetails), fullyQualifiedName: "oci.datasciencePipeline.DatasciencePipelineStepDetailsStepInfrastructureConfigurationDetails")]
    public interface IDatasciencePipelineStepDetailsStepInfrastructureConfigurationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#block_storage_size_in_gbs DatasciencePipeline#block_storage_size_in_gbs}.</summary>
        [JsiiProperty(name: "blockStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        double BlockStorageSizeInGbs
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#shape_name DatasciencePipeline#shape_name}.</summary>
        [JsiiProperty(name: "shapeName", typeJson: "{\"primitive\":\"string\"}")]
        string ShapeName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#block_storage_size_in_gbs_parameterized DatasciencePipeline#block_storage_size_in_gbs_parameterized}.</summary>
        [JsiiProperty(name: "blockStorageSizeInGbsParameterized", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BlockStorageSizeInGbsParameterized
        {
            get
            {
                return null;
            }
        }

        /// <summary>shape_config_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#shape_config_details DatasciencePipeline#shape_config_details}
        /// </remarks>
        [JsiiProperty(name: "shapeConfigDetails", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepInfrastructureConfigurationDetailsShapeConfigDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepInfrastructureConfigurationDetailsShapeConfigDetails? ShapeConfigDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#subnet_id DatasciencePipeline#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubnetId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatasciencePipelineStepDetailsStepInfrastructureConfigurationDetails), fullyQualifiedName: "oci.datasciencePipeline.DatasciencePipelineStepDetailsStepInfrastructureConfigurationDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepInfrastructureConfigurationDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#block_storage_size_in_gbs DatasciencePipeline#block_storage_size_in_gbs}.</summary>
            [JsiiProperty(name: "blockStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
            public double BlockStorageSizeInGbs
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#shape_name DatasciencePipeline#shape_name}.</summary>
            [JsiiProperty(name: "shapeName", typeJson: "{\"primitive\":\"string\"}")]
            public string ShapeName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#block_storage_size_in_gbs_parameterized DatasciencePipeline#block_storage_size_in_gbs_parameterized}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "blockStorageSizeInGbsParameterized", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BlockStorageSizeInGbsParameterized
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>shape_config_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#shape_config_details DatasciencePipeline#shape_config_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shapeConfigDetails", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepInfrastructureConfigurationDetailsShapeConfigDetails\"}", isOptional: true)]
            public oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepInfrastructureConfigurationDetailsShapeConfigDetails? ShapeConfigDetails
            {
                get => GetInstanceProperty<oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepInfrastructureConfigurationDetailsShapeConfigDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#subnet_id DatasciencePipeline#subnet_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubnetId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
