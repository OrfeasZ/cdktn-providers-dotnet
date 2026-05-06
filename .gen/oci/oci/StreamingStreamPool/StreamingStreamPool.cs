using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StreamingStreamPool
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/streaming_stream_pool oci_streaming_stream_pool}.</summary>
    [JsiiClass(nativeType: typeof(oci.StreamingStreamPool.StreamingStreamPool), fullyQualifiedName: "oci.streamingStreamPool.StreamingStreamPool", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.streamingStreamPool.StreamingStreamPoolConfig\"}}]")]
    public class StreamingStreamPool : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/streaming_stream_pool oci_streaming_stream_pool} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public StreamingStreamPool(Constructs.Construct scope, string id, oci.StreamingStreamPool.IStreamingStreamPoolConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.StreamingStreamPool.IStreamingStreamPoolConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StreamingStreamPool(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StreamingStreamPool(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a StreamingStreamPool resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the StreamingStreamPool to import.</param>
        /// <param name="importFromId">The id of the existing StreamingStreamPool that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the StreamingStreamPool to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the StreamingStreamPool to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/streaming_stream_pool#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing StreamingStreamPool that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the StreamingStreamPool to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.StreamingStreamPool.StreamingStreamPool), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCustomEncryptionKey", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.streamingStreamPool.StreamingStreamPoolCustomEncryptionKey\"}}]")]
        public virtual void PutCustomEncryptionKey(oci.StreamingStreamPool.IStreamingStreamPoolCustomEncryptionKey @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.StreamingStreamPool.IStreamingStreamPoolCustomEncryptionKey)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKafkaSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.streamingStreamPool.StreamingStreamPoolKafkaSettings\"}}]")]
        public virtual void PutKafkaSettings(oci.StreamingStreamPool.IStreamingStreamPoolKafkaSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.StreamingStreamPool.IStreamingStreamPoolKafkaSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPrivateEndpointSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.streamingStreamPool.StreamingStreamPoolPrivateEndpointSettings\"}}]")]
        public virtual void PutPrivateEndpointSettings(oci.StreamingStreamPool.IStreamingStreamPoolPrivateEndpointSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.StreamingStreamPool.IStreamingStreamPoolPrivateEndpointSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.streamingStreamPool.StreamingStreamPoolTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.StreamingStreamPool.IStreamingStreamPoolTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.StreamingStreamPool.IStreamingStreamPoolTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCustomEncryptionKey")]
        public virtual void ResetCustomEncryptionKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
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

        [JsiiMethod(name: "resetKafkaSettings")]
        public virtual void ResetKafkaSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivateEndpointSettings")]
        public virtual void ResetPrivateEndpointSettings()
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
        = GetStaticProperty<string>(typeof(oci.StreamingStreamPool.StreamingStreamPool))!;

        [JsiiProperty(name: "customEncryptionKey", typeJson: "{\"fqn\":\"oci.streamingStreamPool.StreamingStreamPoolCustomEncryptionKeyOutputReference\"}")]
        public virtual oci.StreamingStreamPool.StreamingStreamPoolCustomEncryptionKeyOutputReference CustomEncryptionKey
        {
            get => GetInstanceProperty<oci.StreamingStreamPool.StreamingStreamPoolCustomEncryptionKeyOutputReference>()!;
        }

        [JsiiProperty(name: "endpointFqdn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndpointFqdn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isPrivate", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsPrivate
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "kafkaSettings", typeJson: "{\"fqn\":\"oci.streamingStreamPool.StreamingStreamPoolKafkaSettingsOutputReference\"}")]
        public virtual oci.StreamingStreamPool.StreamingStreamPoolKafkaSettingsOutputReference KafkaSettings
        {
            get => GetInstanceProperty<oci.StreamingStreamPool.StreamingStreamPoolKafkaSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "lifecycleStateDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleStateDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateEndpointSettings", typeJson: "{\"fqn\":\"oci.streamingStreamPool.StreamingStreamPoolPrivateEndpointSettingsOutputReference\"}")]
        public virtual oci.StreamingStreamPool.StreamingStreamPoolPrivateEndpointSettingsOutputReference PrivateEndpointSettings
        {
            get => GetInstanceProperty<oci.StreamingStreamPool.StreamingStreamPoolPrivateEndpointSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.streamingStreamPool.StreamingStreamPoolTimeoutsOutputReference\"}")]
        public virtual oci.StreamingStreamPool.StreamingStreamPoolTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.StreamingStreamPool.StreamingStreamPoolTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customEncryptionKeyInput", typeJson: "{\"fqn\":\"oci.streamingStreamPool.StreamingStreamPoolCustomEncryptionKey\"}", isOptional: true)]
        public virtual oci.StreamingStreamPool.IStreamingStreamPoolCustomEncryptionKey? CustomEncryptionKeyInput
        {
            get => GetInstanceProperty<oci.StreamingStreamPool.IStreamingStreamPoolCustomEncryptionKey?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
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
        [JsiiProperty(name: "kafkaSettingsInput", typeJson: "{\"fqn\":\"oci.streamingStreamPool.StreamingStreamPoolKafkaSettings\"}", isOptional: true)]
        public virtual oci.StreamingStreamPool.IStreamingStreamPoolKafkaSettings? KafkaSettingsInput
        {
            get => GetInstanceProperty<oci.StreamingStreamPool.IStreamingStreamPoolKafkaSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateEndpointSettingsInput", typeJson: "{\"fqn\":\"oci.streamingStreamPool.StreamingStreamPoolPrivateEndpointSettings\"}", isOptional: true)]
        public virtual oci.StreamingStreamPool.IStreamingStreamPoolPrivateEndpointSettings? PrivateEndpointSettingsInput
        {
            get => GetInstanceProperty<oci.StreamingStreamPool.IStreamingStreamPoolPrivateEndpointSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.streamingStreamPool.StreamingStreamPoolTimeouts\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
