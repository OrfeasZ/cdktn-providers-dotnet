using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListStruct")]
    public class DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListStruct : oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListStruct
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#name DatascienceJob#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>job_configuration_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#job_configuration_details DatascienceJob#job_configuration_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jobConfigurationDetails", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobConfigurationDetails\"}", isOptional: true)]
        public oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobConfigurationDetails? JobConfigurationDetails
        {
            get;
            set;
        }

        /// <summary>job_environment_configuration_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#job_environment_configuration_details DatascienceJob#job_environment_configuration_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jobEnvironmentConfigurationDetails", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobEnvironmentConfigurationDetails\"}", isOptional: true)]
        public oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobEnvironmentConfigurationDetails? JobEnvironmentConfigurationDetails
        {
            get;
            set;
        }

        /// <summary>job_infrastructure_configuration_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#job_infrastructure_configuration_details DatascienceJob#job_infrastructure_configuration_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jobInfrastructureConfigurationDetails", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetails\"}", isOptional: true)]
        public oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetails? JobInfrastructureConfigurationDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#minimum_success_replicas DatascienceJob#minimum_success_replicas}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minimumSuccessReplicas", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinimumSuccessReplicas
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#replicas DatascienceJob#replicas}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replicas", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Replicas
        {
            get;
            set;
        }
    }
}
