using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatasciencePipeline
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.datasciencePipeline.DatasciencePipelineStepDetailsStepInfrastructureConfigurationDetails")]
    public class DatasciencePipelineStepDetailsStepInfrastructureConfigurationDetails : oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepInfrastructureConfigurationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#block_storage_size_in_gbs DatasciencePipeline#block_storage_size_in_gbs}.</summary>
        [JsiiProperty(name: "blockStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public double BlockStorageSizeInGbs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#shape_name DatasciencePipeline#shape_name}.</summary>
        [JsiiProperty(name: "shapeName", typeJson: "{\"primitive\":\"string\"}")]
        public string ShapeName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#block_storage_size_in_gbs_parameterized DatasciencePipeline#block_storage_size_in_gbs_parameterized}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "blockStorageSizeInGbsParameterized", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BlockStorageSizeInGbsParameterized
        {
            get;
            set;
        }

        /// <summary>shape_config_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#shape_config_details DatasciencePipeline#shape_config_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shapeConfigDetails", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepInfrastructureConfigurationDetailsShapeConfigDetails\"}", isOptional: true)]
        public oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepInfrastructureConfigurationDetailsShapeConfigDetails? ShapeConfigDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#subnet_id DatasciencePipeline#subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubnetId
        {
            get;
            set;
        }
    }
}
