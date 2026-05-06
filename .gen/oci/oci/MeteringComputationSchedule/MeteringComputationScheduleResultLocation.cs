using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MeteringComputationSchedule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.meteringComputationSchedule.MeteringComputationScheduleResultLocation")]
    public class MeteringComputationScheduleResultLocation : oci.MeteringComputationSchedule.IMeteringComputationScheduleResultLocation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_schedule#bucket MeteringComputationSchedule#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public string Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_schedule#location_type MeteringComputationSchedule#location_type}.</summary>
        [JsiiProperty(name: "locationType", typeJson: "{\"primitive\":\"string\"}")]
        public string LocationType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_schedule#namespace MeteringComputationSchedule#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public string Namespace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_schedule#region MeteringComputationSchedule#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public string Region
        {
            get;
            set;
        }
    }
}
