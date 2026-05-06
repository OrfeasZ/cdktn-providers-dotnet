using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmTracesScheduledQuery
{
    [JsiiByValue(fqn: "oci.apmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfigurationObjectStorage")]
    public class ApmTracesScheduledQueryScheduledQueryProcessingConfigurationObjectStorage : oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfigurationObjectStorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#bucket ApmTracesScheduledQuery#bucket}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#name_space ApmTracesScheduledQuery#name_space}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nameSpace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NameSpace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#object_name_prefix ApmTracesScheduledQuery#object_name_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "objectNamePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ObjectNamePrefix
        {
            get;
            set;
        }
    }
}
