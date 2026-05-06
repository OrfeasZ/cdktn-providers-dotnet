using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataflowPool
{
    [JsiiByValue(fqn: "oci.dataflowPool.DataflowPoolSchedules")]
    public class DataflowPoolSchedules : oci.DataflowPool.IDataflowPoolSchedules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_pool#day_of_week DataflowPool#day_of_week}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DayOfWeek
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_pool#start_time DataflowPool#start_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StartTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_pool#stop_time DataflowPool#stop_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stopTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StopTime
        {
            get;
            set;
        }
    }
}
