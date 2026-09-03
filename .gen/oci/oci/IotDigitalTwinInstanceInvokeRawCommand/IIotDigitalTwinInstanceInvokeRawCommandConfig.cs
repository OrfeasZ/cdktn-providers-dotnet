using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IotDigitalTwinInstanceInvokeRawCommand
{
    [JsiiInterface(nativeType: typeof(IIotDigitalTwinInstanceInvokeRawCommandConfig), fullyQualifiedName: "oci.iotDigitalTwinInstanceInvokeRawCommand.IotDigitalTwinInstanceInvokeRawCommandConfig")]
    public interface IIotDigitalTwinInstanceInvokeRawCommandConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_digital_twin_instance_invoke_raw_command#digital_twin_instance_id IotDigitalTwinInstanceInvokeRawCommand#digital_twin_instance_id}.</summary>
        [JsiiProperty(name: "digitalTwinInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        string DigitalTwinInstanceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_digital_twin_instance_invoke_raw_command#request_data_format IotDigitalTwinInstanceInvokeRawCommand#request_data_format}.</summary>
        [JsiiProperty(name: "requestDataFormat", typeJson: "{\"primitive\":\"string\"}")]
        string RequestDataFormat
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_digital_twin_instance_invoke_raw_command#request_endpoint IotDigitalTwinInstanceInvokeRawCommand#request_endpoint}.</summary>
        [JsiiProperty(name: "requestEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        string RequestEndpoint
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_digital_twin_instance_invoke_raw_command#id IotDigitalTwinInstanceInvokeRawCommand#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_digital_twin_instance_invoke_raw_command#request_data IotDigitalTwinInstanceInvokeRawCommand#request_data}.</summary>
        [JsiiProperty(name: "requestData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RequestData
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_digital_twin_instance_invoke_raw_command#request_data_content_type IotDigitalTwinInstanceInvokeRawCommand#request_data_content_type}.</summary>
        [JsiiProperty(name: "requestDataContentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RequestDataContentType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_digital_twin_instance_invoke_raw_command#request_duration IotDigitalTwinInstanceInvokeRawCommand#request_duration}.</summary>
        [JsiiProperty(name: "requestDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RequestDuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_digital_twin_instance_invoke_raw_command#response_duration IotDigitalTwinInstanceInvokeRawCommand#response_duration}.</summary>
        [JsiiProperty(name: "responseDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResponseDuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_digital_twin_instance_invoke_raw_command#response_endpoint IotDigitalTwinInstanceInvokeRawCommand#response_endpoint}.</summary>
        [JsiiProperty(name: "responseEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResponseEndpoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_digital_twin_instance_invoke_raw_command#timeouts IotDigitalTwinInstanceInvokeRawCommand#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.iotDigitalTwinInstanceInvokeRawCommand.IotDigitalTwinInstanceInvokeRawCommandTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IotDigitalTwinInstanceInvokeRawCommand.IIotDigitalTwinInstanceInvokeRawCommandTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotDigitalTwinInstanceInvokeRawCommandConfig), fullyQualifiedName: "oci.iotDigitalTwinInstanceInvokeRawCommand.IotDigitalTwinInstanceInvokeRawCommandConfig")]
        internal sealed class _Proxy : DeputyBase, oci.IotDigitalTwinInstanceInvokeRawCommand.IIotDigitalTwinInstanceInvokeRawCommandConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_digital_twin_instance_invoke_raw_command#digital_twin_instance_id IotDigitalTwinInstanceInvokeRawCommand#digital_twin_instance_id}.</summary>
            [JsiiProperty(name: "digitalTwinInstanceId", typeJson: "{\"primitive\":\"string\"}")]
            public string DigitalTwinInstanceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_digital_twin_instance_invoke_raw_command#request_data_format IotDigitalTwinInstanceInvokeRawCommand#request_data_format}.</summary>
            [JsiiProperty(name: "requestDataFormat", typeJson: "{\"primitive\":\"string\"}")]
            public string RequestDataFormat
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_digital_twin_instance_invoke_raw_command#request_endpoint IotDigitalTwinInstanceInvokeRawCommand#request_endpoint}.</summary>
            [JsiiProperty(name: "requestEndpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string RequestEndpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_digital_twin_instance_invoke_raw_command#id IotDigitalTwinInstanceInvokeRawCommand#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_digital_twin_instance_invoke_raw_command#request_data IotDigitalTwinInstanceInvokeRawCommand#request_data}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requestData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RequestData
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_digital_twin_instance_invoke_raw_command#request_data_content_type IotDigitalTwinInstanceInvokeRawCommand#request_data_content_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requestDataContentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RequestDataContentType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_digital_twin_instance_invoke_raw_command#request_duration IotDigitalTwinInstanceInvokeRawCommand#request_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requestDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RequestDuration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_digital_twin_instance_invoke_raw_command#response_duration IotDigitalTwinInstanceInvokeRawCommand#response_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "responseDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResponseDuration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_digital_twin_instance_invoke_raw_command#response_endpoint IotDigitalTwinInstanceInvokeRawCommand#response_endpoint}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "responseEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResponseEndpoint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_digital_twin_instance_invoke_raw_command#timeouts IotDigitalTwinInstanceInvokeRawCommand#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.iotDigitalTwinInstanceInvokeRawCommand.IotDigitalTwinInstanceInvokeRawCommandTimeouts\"}", isOptional: true)]
            public oci.IotDigitalTwinInstanceInvokeRawCommand.IIotDigitalTwinInstanceInvokeRawCommandTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.IotDigitalTwinInstanceInvokeRawCommand.IIotDigitalTwinInstanceInvokeRawCommandTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
