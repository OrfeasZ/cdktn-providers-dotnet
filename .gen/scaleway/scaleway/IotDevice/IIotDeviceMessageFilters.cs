using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.IotDevice
{
    [JsiiInterface(nativeType: typeof(IIotDeviceMessageFilters), fullyQualifiedName: "scaleway.iotDevice.IotDeviceMessageFilters")]
    public interface IIotDeviceMessageFilters
    {
        /// <summary>publish block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/iot_device#publish IotDevice#publish}
        /// </remarks>
        [JsiiProperty(name: "publish", typeJson: "{\"fqn\":\"scaleway.iotDevice.IotDeviceMessageFiltersPublish\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.IotDevice.IIotDeviceMessageFiltersPublish? Publish
        {
            get
            {
                return null;
            }
        }

        /// <summary>subscribe block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/iot_device#subscribe IotDevice#subscribe}
        /// </remarks>
        [JsiiProperty(name: "subscribe", typeJson: "{\"fqn\":\"scaleway.iotDevice.IotDeviceMessageFiltersSubscribe\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.IotDevice.IIotDeviceMessageFiltersSubscribe? Subscribe
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotDeviceMessageFilters), fullyQualifiedName: "scaleway.iotDevice.IotDeviceMessageFilters")]
        internal sealed class _Proxy : DeputyBase, scaleway.IotDevice.IIotDeviceMessageFilters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>publish block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/iot_device#publish IotDevice#publish}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "publish", typeJson: "{\"fqn\":\"scaleway.iotDevice.IotDeviceMessageFiltersPublish\"}", isOptional: true)]
            public scaleway.IotDevice.IIotDeviceMessageFiltersPublish? Publish
            {
                get => GetInstanceProperty<scaleway.IotDevice.IIotDeviceMessageFiltersPublish?>();
            }

            /// <summary>subscribe block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/iot_device#subscribe IotDevice#subscribe}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "subscribe", typeJson: "{\"fqn\":\"scaleway.iotDevice.IotDeviceMessageFiltersSubscribe\"}", isOptional: true)]
            public scaleway.IotDevice.IIotDeviceMessageFiltersSubscribe? Subscribe
            {
                get => GetInstanceProperty<scaleway.IotDevice.IIotDeviceMessageFiltersSubscribe?>();
            }
        }
    }
}
