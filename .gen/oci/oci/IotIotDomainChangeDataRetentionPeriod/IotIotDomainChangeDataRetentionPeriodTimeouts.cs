using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IotIotDomainChangeDataRetentionPeriod
{
    [JsiiByValue(fqn: "oci.iotIotDomainChangeDataRetentionPeriod.IotIotDomainChangeDataRetentionPeriodTimeouts")]
    public class IotIotDomainChangeDataRetentionPeriodTimeouts : oci.IotIotDomainChangeDataRetentionPeriod.IIotIotDomainChangeDataRetentionPeriodTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/iot_iot_domain_change_data_retention_period#create IotIotDomainChangeDataRetentionPeriod#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/iot_iot_domain_change_data_retention_period#delete IotIotDomainChangeDataRetentionPeriod#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/iot_iot_domain_change_data_retention_period#update IotIotDomainChangeDataRetentionPeriod#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
