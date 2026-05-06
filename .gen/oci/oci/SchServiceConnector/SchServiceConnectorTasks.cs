using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.SchServiceConnector
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.schServiceConnector.SchServiceConnectorTasks")]
    public class SchServiceConnectorTasks : oci.SchServiceConnector.ISchServiceConnectorTasks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#kind SchServiceConnector#kind}.</summary>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public string Kind
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#batch_size_in_kbs SchServiceConnector#batch_size_in_kbs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "batchSizeInKbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BatchSizeInKbs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#batch_time_in_sec SchServiceConnector#batch_time_in_sec}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "batchTimeInSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BatchTimeInSec
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#condition SchServiceConnector#condition}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "condition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Condition
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#function_id SchServiceConnector#function_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "functionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FunctionId
        {
            get;
            set;
        }
    }
}
