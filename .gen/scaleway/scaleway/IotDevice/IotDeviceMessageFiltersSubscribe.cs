using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.IotDevice
{
    [JsiiByValue(fqn: "scaleway.iotDevice.IotDeviceMessageFiltersSubscribe")]
    public class IotDeviceMessageFiltersSubscribe : scaleway.IotDevice.IIotDeviceMessageFiltersSubscribe
    {
        /// <summary>Subscribe message filter policy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/iot_device#policy IotDevice#policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Policy
        {
            get;
            set;
        }

        /// <summary>List of topics in the set.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/iot_device#topics IotDevice#topics}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "topics", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Topics
        {
            get;
            set;
        }
    }
}
