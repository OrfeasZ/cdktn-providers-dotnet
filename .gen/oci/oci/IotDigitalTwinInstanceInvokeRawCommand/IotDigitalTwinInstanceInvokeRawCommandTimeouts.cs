using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IotDigitalTwinInstanceInvokeRawCommand
{
    [JsiiByValue(fqn: "oci.iotDigitalTwinInstanceInvokeRawCommand.IotDigitalTwinInstanceInvokeRawCommandTimeouts")]
    public class IotDigitalTwinInstanceInvokeRawCommandTimeouts : oci.IotDigitalTwinInstanceInvokeRawCommand.IIotDigitalTwinInstanceInvokeRawCommandTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/iot_digital_twin_instance_invoke_raw_command#create IotDigitalTwinInstanceInvokeRawCommand#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/iot_digital_twin_instance_invoke_raw_command#delete IotDigitalTwinInstanceInvokeRawCommand#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/iot_digital_twin_instance_invoke_raw_command#update IotDigitalTwinInstanceInvokeRawCommand#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
