using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IotDigitalTwinInstanceInvokeRawCommand
{
    [JsiiInterface(nativeType: typeof(IIotDigitalTwinInstanceInvokeRawCommandTimeouts), fullyQualifiedName: "oci.iotDigitalTwinInstanceInvokeRawCommand.IotDigitalTwinInstanceInvokeRawCommandTimeouts")]
    public interface IIotDigitalTwinInstanceInvokeRawCommandTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/iot_digital_twin_instance_invoke_raw_command#create IotDigitalTwinInstanceInvokeRawCommand#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/iot_digital_twin_instance_invoke_raw_command#delete IotDigitalTwinInstanceInvokeRawCommand#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/iot_digital_twin_instance_invoke_raw_command#update IotDigitalTwinInstanceInvokeRawCommand#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotDigitalTwinInstanceInvokeRawCommandTimeouts), fullyQualifiedName: "oci.iotDigitalTwinInstanceInvokeRawCommand.IotDigitalTwinInstanceInvokeRawCommandTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.IotDigitalTwinInstanceInvokeRawCommand.IIotDigitalTwinInstanceInvokeRawCommandTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/iot_digital_twin_instance_invoke_raw_command#create IotDigitalTwinInstanceInvokeRawCommand#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/iot_digital_twin_instance_invoke_raw_command#delete IotDigitalTwinInstanceInvokeRawCommand#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/iot_digital_twin_instance_invoke_raw_command#update IotDigitalTwinInstanceInvokeRawCommand#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
