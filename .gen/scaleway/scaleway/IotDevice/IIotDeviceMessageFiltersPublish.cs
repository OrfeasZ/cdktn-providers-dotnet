using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.IotDevice
{
    [JsiiInterface(nativeType: typeof(IIotDeviceMessageFiltersPublish), fullyQualifiedName: "scaleway.iotDevice.IotDeviceMessageFiltersPublish")]
    public interface IIotDeviceMessageFiltersPublish
    {
        /// <summary>Publish message filter policy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/iot_device#policy IotDevice#policy}
        /// </remarks>
        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Policy
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of topics in the set.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/iot_device#topics IotDevice#topics}
        /// </remarks>
        [JsiiProperty(name: "topics", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Topics
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotDeviceMessageFiltersPublish), fullyQualifiedName: "scaleway.iotDevice.IotDeviceMessageFiltersPublish")]
        internal sealed class _Proxy : DeputyBase, scaleway.IotDevice.IIotDeviceMessageFiltersPublish
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Publish message filter policy.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/iot_device#policy IotDevice#policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Policy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>List of topics in the set.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/iot_device#topics IotDevice#topics}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "topics", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Topics
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
