using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.IotDevice
{
    [JsiiByValue(fqn: "scaleway.iotDevice.IotDeviceMessageFilters")]
    public class IotDeviceMessageFilters : scaleway.IotDevice.IIotDeviceMessageFilters
    {
        /// <summary>publish block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/iot_device#publish IotDevice#publish}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "publish", typeJson: "{\"fqn\":\"scaleway.iotDevice.IotDeviceMessageFiltersPublish\"}", isOptional: true)]
        public scaleway.IotDevice.IIotDeviceMessageFiltersPublish? Publish
        {
            get;
            set;
        }

        /// <summary>subscribe block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/iot_device#subscribe IotDevice#subscribe}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "subscribe", typeJson: "{\"fqn\":\"scaleway.iotDevice.IotDeviceMessageFiltersSubscribe\"}", isOptional: true)]
        public scaleway.IotDevice.IIotDeviceMessageFiltersSubscribe? Subscribe
        {
            get;
            set;
        }
    }
}
