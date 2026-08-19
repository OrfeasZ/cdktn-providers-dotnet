using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IotDigitalTwinInstanceInvokeRawCommand
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/iot_digital_twin_instance_invoke_raw_command oci_iot_digital_twin_instance_invoke_raw_command}.</summary>
    [JsiiClass(nativeType: typeof(oci.IotDigitalTwinInstanceInvokeRawCommand.IotDigitalTwinInstanceInvokeRawCommand), fullyQualifiedName: "oci.iotDigitalTwinInstanceInvokeRawCommand.IotDigitalTwinInstanceInvokeRawCommand", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.iotDigitalTwinInstanceInvokeRawCommand.IotDigitalTwinInstanceInvokeRawCommandConfig\"}}]")]
    public class IotDigitalTwinInstanceInvokeRawCommand : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/iot_digital_twin_instance_invoke_raw_command oci_iot_digital_twin_instance_invoke_raw_command} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public IotDigitalTwinInstanceInvokeRawCommand(Constructs.Construct scope, string id, oci.IotDigitalTwinInstanceInvokeRawCommand.IIotDigitalTwinInstanceInvokeRawCommandConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.IotDigitalTwinInstanceInvokeRawCommand.IIotDigitalTwinInstanceInvokeRawCommandConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotDigitalTwinInstanceInvokeRawCommand(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotDigitalTwinInstanceInvokeRawCommand(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a IotDigitalTwinInstanceInvokeRawCommand resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the IotDigitalTwinInstanceInvokeRawCommand to import.</param>
        /// <param name="importFromId">The id of the existing IotDigitalTwinInstanceInvokeRawCommand that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the IotDigitalTwinInstanceInvokeRawCommand to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the IotDigitalTwinInstanceInvokeRawCommand to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/iot_digital_twin_instance_invoke_raw_command#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing IotDigitalTwinInstanceInvokeRawCommand that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the IotDigitalTwinInstanceInvokeRawCommand to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.IotDigitalTwinInstanceInvokeRawCommand.IotDigitalTwinInstanceInvokeRawCommand), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.iotDigitalTwinInstanceInvokeRawCommand.IotDigitalTwinInstanceInvokeRawCommandTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.IotDigitalTwinInstanceInvokeRawCommand.IIotDigitalTwinInstanceInvokeRawCommandTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IotDigitalTwinInstanceInvokeRawCommand.IIotDigitalTwinInstanceInvokeRawCommandTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequestData")]
        public virtual void ResetRequestData()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequestDataContentType")]
        public virtual void ResetRequestDataContentType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequestDuration")]
        public virtual void ResetRequestDuration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResponseDuration")]
        public virtual void ResetResponseDuration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResponseEndpoint")]
        public virtual void ResetResponseEndpoint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(oci.IotDigitalTwinInstanceInvokeRawCommand.IotDigitalTwinInstanceInvokeRawCommand))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.iotDigitalTwinInstanceInvokeRawCommand.IotDigitalTwinInstanceInvokeRawCommandTimeoutsOutputReference\"}")]
        public virtual oci.IotDigitalTwinInstanceInvokeRawCommand.IotDigitalTwinInstanceInvokeRawCommandTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.IotDigitalTwinInstanceInvokeRawCommand.IotDigitalTwinInstanceInvokeRawCommandTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "digitalTwinInstanceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DigitalTwinInstanceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestDataContentTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RequestDataContentTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestDataFormatInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RequestDataFormatInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestDataInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RequestDataInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestDurationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RequestDurationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RequestEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "responseDurationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResponseDurationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "responseEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResponseEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.IotDigitalTwinInstanceInvokeRawCommand.IIotDigitalTwinInstanceInvokeRawCommandTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.iotDigitalTwinInstanceInvokeRawCommand.IotDigitalTwinInstanceInvokeRawCommandTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "digitalTwinInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DigitalTwinInstanceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requestData", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestData
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requestDataContentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestDataContentType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requestDataFormat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestDataFormat
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requestDuration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestDuration
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requestEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "responseDuration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResponseDuration
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "responseEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResponseEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
