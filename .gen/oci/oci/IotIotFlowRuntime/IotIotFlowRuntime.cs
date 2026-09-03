using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IotIotFlowRuntime
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_iot_flow_runtime oci_iot_iot_flow_runtime}.</summary>
    [JsiiClass(nativeType: typeof(oci.IotIotFlowRuntime.IotIotFlowRuntime), fullyQualifiedName: "oci.iotIotFlowRuntime.IotIotFlowRuntime", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.iotIotFlowRuntime.IotIotFlowRuntimeConfig\"}}]")]
    public class IotIotFlowRuntime : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_iot_flow_runtime oci_iot_iot_flow_runtime} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public IotIotFlowRuntime(Constructs.Construct scope, string id, oci.IotIotFlowRuntime.IIotIotFlowRuntimeConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.IotIotFlowRuntime.IIotIotFlowRuntimeConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotIotFlowRuntime(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotIotFlowRuntime(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a IotIotFlowRuntime resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the IotIotFlowRuntime to import.</param>
        /// <param name="importFromId">The id of the existing IotIotFlowRuntime that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the IotIotFlowRuntime to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the IotIotFlowRuntime to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_iot_flow_runtime#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing IotIotFlowRuntime that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the IotIotFlowRuntime to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.IotIotFlowRuntime.IotIotFlowRuntime), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putLogConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.iotIotFlowRuntime.IotIotFlowRuntimeLogConfig\"}}]")]
        public virtual void PutLogConfig(oci.IotIotFlowRuntime.IIotIotFlowRuntimeLogConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IotIotFlowRuntime.IIotIotFlowRuntimeLogConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.iotIotFlowRuntime.IotIotFlowRuntimeNetworkConfig\"}}]")]
        public virtual void PutNetworkConfig(oci.IotIotFlowRuntime.IIotIotFlowRuntimeNetworkConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IotIotFlowRuntime.IIotIotFlowRuntimeNetworkConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.iotIotFlowRuntime.IotIotFlowRuntimeTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.IotIotFlowRuntime.IIotIotFlowRuntimeTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IotIotFlowRuntime.IIotIotFlowRuntimeTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreeformTags")]
        public virtual void ResetFreeformTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogConfig")]
        public virtual void ResetLogConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkConfig")]
        public virtual void ResetNetworkConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScale")]
        public virtual void ResetScale()
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
        = GetStaticProperty<string>(typeof(oci.IotIotFlowRuntime.IotIotFlowRuntime))!;

        [JsiiProperty(name: "flowRuntimeHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FlowRuntimeHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logConfig", typeJson: "{\"fqn\":\"oci.iotIotFlowRuntime.IotIotFlowRuntimeLogConfigOutputReference\"}")]
        public virtual oci.IotIotFlowRuntime.IotIotFlowRuntimeLogConfigOutputReference LogConfig
        {
            get => GetInstanceProperty<oci.IotIotFlowRuntime.IotIotFlowRuntimeLogConfigOutputReference>()!;
        }

        [JsiiProperty(name: "networkConfig", typeJson: "{\"fqn\":\"oci.iotIotFlowRuntime.IotIotFlowRuntimeNetworkConfigOutputReference\"}")]
        public virtual oci.IotIotFlowRuntime.IotIotFlowRuntimeNetworkConfigOutputReference NetworkConfig
        {
            get => GetInstanceProperty<oci.IotIotFlowRuntime.IotIotFlowRuntimeNetworkConfigOutputReference>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.iotIotFlowRuntime.IotIotFlowRuntimeTimeoutsOutputReference\"}")]
        public virtual oci.IotIotFlowRuntime.IotIotFlowRuntimeTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.IotIotFlowRuntime.IotIotFlowRuntimeTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "freeformTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? FreeformTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "iotDomainIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IotDomainIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logConfigInput", typeJson: "{\"fqn\":\"oci.iotIotFlowRuntime.IotIotFlowRuntimeLogConfig\"}", isOptional: true)]
        public virtual oci.IotIotFlowRuntime.IIotIotFlowRuntimeLogConfig? LogConfigInput
        {
            get => GetInstanceProperty<oci.IotIotFlowRuntime.IIotIotFlowRuntimeLogConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkConfigInput", typeJson: "{\"fqn\":\"oci.iotIotFlowRuntime.IotIotFlowRuntimeNetworkConfig\"}", isOptional: true)]
        public virtual oci.IotIotFlowRuntime.IIotIotFlowRuntimeNetworkConfig? NetworkConfigInput
        {
            get => GetInstanceProperty<oci.IotIotFlowRuntime.IIotIotFlowRuntimeNetworkConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scaleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScaleInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.IotIotFlowRuntime.IIotIotFlowRuntimeTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.iotIotFlowRuntime.IotIotFlowRuntimeTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> DefinedTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> FreeformTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "iotDomainId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IotDomainId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scale", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Scale
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
