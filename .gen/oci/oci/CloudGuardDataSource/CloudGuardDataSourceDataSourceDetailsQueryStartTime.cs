using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudGuardDataSource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.cloudGuardDataSource.CloudGuardDataSourceDataSourceDetailsQueryStartTime")]
    public class CloudGuardDataSourceDataSourceDetailsQueryStartTime : oci.CloudGuardDataSource.ICloudGuardDataSourceDataSourceDetailsQueryStartTime
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_data_source#start_policy_type CloudGuardDataSource#start_policy_type}.</summary>
        [JsiiProperty(name: "startPolicyType", typeJson: "{\"primitive\":\"string\"}")]
        public string StartPolicyType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_data_source#query_start_time CloudGuardDataSource#query_start_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "queryStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? QueryStartTime
        {
            get;
            set;
        }
    }
}
