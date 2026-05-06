using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMonitoredResource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.stackMonitoringMonitoredResource.StackMonitoringMonitoredResourceDatabaseConnectionDetails")]
    public class StackMonitoringMonitoredResourceDatabaseConnectionDetails : oci.StackMonitoringMonitoredResource.IStackMonitoringMonitoredResourceDatabaseConnectionDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource#port StackMonitoringMonitoredResource#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public double Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource#protocol StackMonitoringMonitoredResource#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public string Protocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource#service_name StackMonitoringMonitoredResource#service_name}.</summary>
        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
        public string ServiceName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource#connector_id StackMonitoringMonitoredResource#connector_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConnectorId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource#db_id StackMonitoringMonitoredResource#db_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dbId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DbId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource#db_unique_name StackMonitoringMonitoredResource#db_unique_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dbUniqueName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DbUniqueName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource#ssl_secret_id StackMonitoringMonitoredResource#ssl_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sslSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SslSecretId
        {
            get;
            set;
        }
    }
}
