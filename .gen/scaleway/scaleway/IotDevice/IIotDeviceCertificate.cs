using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.IotDevice
{
    [JsiiInterface(nativeType: typeof(IIotDeviceCertificate), fullyQualifiedName: "scaleway.iotDevice.IotDeviceCertificate")]
    public interface IIotDeviceCertificate
    {
        /// <summary>X509 PEM encoded certificate of the device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/iot_device#crt IotDevice#crt}
        /// </remarks>
        [JsiiProperty(name: "crt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Crt
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotDeviceCertificate), fullyQualifiedName: "scaleway.iotDevice.IotDeviceCertificate")]
        internal sealed class _Proxy : DeputyBase, scaleway.IotDevice.IIotDeviceCertificate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>X509 PEM encoded certificate of the device.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/iot_device#crt IotDevice#crt}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "crt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Crt
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
