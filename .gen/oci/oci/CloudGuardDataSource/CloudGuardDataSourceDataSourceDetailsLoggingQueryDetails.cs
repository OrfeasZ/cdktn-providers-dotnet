using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudGuardDataSource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.cloudGuardDataSource.CloudGuardDataSourceDataSourceDetailsLoggingQueryDetails")]
    public class CloudGuardDataSourceDataSourceDetailsLoggingQueryDetails : oci.CloudGuardDataSource.ICloudGuardDataSourceDataSourceDetailsLoggingQueryDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_data_source#logging_query_type CloudGuardDataSource#logging_query_type}.</summary>
        [JsiiProperty(name: "loggingQueryType", typeJson: "{\"primitive\":\"string\"}")]
        public string LoggingQueryType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_data_source#key_entities_count CloudGuardDataSource#key_entities_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyEntitiesCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? KeyEntitiesCount
        {
            get;
            set;
        }
    }
}
