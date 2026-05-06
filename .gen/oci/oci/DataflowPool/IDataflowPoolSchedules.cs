using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataflowPool
{
    [JsiiInterface(nativeType: typeof(IDataflowPoolSchedules), fullyQualifiedName: "oci.dataflowPool.DataflowPoolSchedules")]
    public interface IDataflowPoolSchedules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_pool#day_of_week DataflowPool#day_of_week}.</summary>
        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DayOfWeek
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_pool#start_time DataflowPool#start_time}.</summary>
        [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StartTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_pool#stop_time DataflowPool#stop_time}.</summary>
        [JsiiProperty(name: "stopTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StopTime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataflowPoolSchedules), fullyQualifiedName: "oci.dataflowPool.DataflowPoolSchedules")]
        internal sealed class _Proxy : DeputyBase, oci.DataflowPool.IDataflowPoolSchedules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_pool#day_of_week DataflowPool#day_of_week}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DayOfWeek
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_pool#start_time DataflowPool#start_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StartTime
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_pool#stop_time DataflowPool#stop_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stopTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StopTime
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
