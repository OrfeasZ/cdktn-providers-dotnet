using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.IotDevice
{
    [JsiiByValue(fqn: "scaleway.iotDevice.IotDeviceCertificate")]
    public class IotDeviceCertificate : scaleway.IotDevice.IIotDeviceCertificate
    {
        /// <summary>X509 PEM encoded certificate of the device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/iot_device#crt IotDevice#crt}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "crt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Crt
        {
            get;
            set;
        }
    }
}
