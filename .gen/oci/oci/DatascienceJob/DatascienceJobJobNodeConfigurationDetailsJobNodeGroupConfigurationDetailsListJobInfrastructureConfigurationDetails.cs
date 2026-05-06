using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetails")]
    public class DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetails : oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#job_infrastructure_type DatascienceJob#job_infrastructure_type}.</summary>
        [JsiiProperty(name: "jobInfrastructureType", typeJson: "{\"primitive\":\"string\"}")]
        public string JobInfrastructureType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#block_storage_size_in_gbs DatascienceJob#block_storage_size_in_gbs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "blockStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BlockStorageSizeInGbs
        {
            get;
            set;
        }

        /// <summary>job_shape_config_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#job_shape_config_details DatascienceJob#job_shape_config_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jobShapeConfigDetails", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsJobShapeConfigDetails\"}", isOptional: true)]
        public oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsJobShapeConfigDetails? JobShapeConfigDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#shape_name DatascienceJob#shape_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "shapeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ShapeName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#subnet_id DatascienceJob#subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubnetId
        {
            get;
            set;
        }
    }
}
