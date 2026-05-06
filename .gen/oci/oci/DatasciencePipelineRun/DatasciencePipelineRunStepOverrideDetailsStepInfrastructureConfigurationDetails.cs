using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatasciencePipelineRun
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepInfrastructureConfigurationDetails")]
    public class DatasciencePipelineRunStepOverrideDetailsStepInfrastructureConfigurationDetails : oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepInfrastructureConfigurationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#block_storage_size_in_gbs DatasciencePipelineRun#block_storage_size_in_gbs}.</summary>
        [JsiiProperty(name: "blockStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public double BlockStorageSizeInGbs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#shape_name DatasciencePipelineRun#shape_name}.</summary>
        [JsiiProperty(name: "shapeName", typeJson: "{\"primitive\":\"string\"}")]
        public string ShapeName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#block_storage_size_in_gbs_parameterized DatasciencePipelineRun#block_storage_size_in_gbs_parameterized}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "blockStorageSizeInGbsParameterized", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BlockStorageSizeInGbsParameterized
        {
            get;
            set;
        }

        /// <summary>shape_config_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#shape_config_details DatasciencePipelineRun#shape_config_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shapeConfigDetails", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepInfrastructureConfigurationDetailsShapeConfigDetails\"}", isOptional: true)]
        public oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepInfrastructureConfigurationDetailsShapeConfigDetails? ShapeConfigDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#subnet_id DatasciencePipelineRun#subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubnetId
        {
            get;
            set;
        }
    }
}
