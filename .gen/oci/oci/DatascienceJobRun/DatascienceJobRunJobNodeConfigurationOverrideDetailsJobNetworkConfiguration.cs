using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceJobRun
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.datascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNetworkConfiguration")]
    public class DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNetworkConfiguration : oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNetworkConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#job_network_type DatascienceJobRun#job_network_type}.</summary>
        [JsiiProperty(name: "jobNetworkType", typeJson: "{\"primitive\":\"string\"}")]
        public string JobNetworkType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#subnet_id DatascienceJobRun#subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubnetId
        {
            get;
            set;
        }
    }
}
