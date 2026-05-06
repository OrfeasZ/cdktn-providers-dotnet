using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MeteringComputationSchedule
{
    [JsiiInterface(nativeType: typeof(IMeteringComputationScheduleResultLocation), fullyQualifiedName: "oci.meteringComputationSchedule.MeteringComputationScheduleResultLocation")]
    public interface IMeteringComputationScheduleResultLocation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_schedule#bucket MeteringComputationSchedule#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        string Bucket
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_schedule#location_type MeteringComputationSchedule#location_type}.</summary>
        [JsiiProperty(name: "locationType", typeJson: "{\"primitive\":\"string\"}")]
        string LocationType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_schedule#namespace MeteringComputationSchedule#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        string Namespace
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_schedule#region MeteringComputationSchedule#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        string Region
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMeteringComputationScheduleResultLocation), fullyQualifiedName: "oci.meteringComputationSchedule.MeteringComputationScheduleResultLocation")]
        internal sealed class _Proxy : DeputyBase, oci.MeteringComputationSchedule.IMeteringComputationScheduleResultLocation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_schedule#bucket MeteringComputationSchedule#bucket}.</summary>
            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
            public string Bucket
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_schedule#location_type MeteringComputationSchedule#location_type}.</summary>
            [JsiiProperty(name: "locationType", typeJson: "{\"primitive\":\"string\"}")]
            public string LocationType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_schedule#namespace MeteringComputationSchedule#namespace}.</summary>
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
            public string Namespace
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_schedule#region MeteringComputationSchedule#region}.</summary>
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
            public string Region
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
