using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.StreamLiveInput
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_live_input cloudflare_stream_live_input}.</summary>
    [JsiiClass(nativeType: typeof(cloudflare.StreamLiveInput.StreamLiveInput), fullyQualifiedName: "cloudflare.streamLiveInput.StreamLiveInput", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"cloudflare.streamLiveInput.StreamLiveInputConfig\"}}]")]
    public class StreamLiveInput : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_live_input cloudflare_stream_live_input} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public StreamLiveInput(Constructs.Construct scope, string id, cloudflare.StreamLiveInput.IStreamLiveInputConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, cloudflare.StreamLiveInput.IStreamLiveInputConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StreamLiveInput(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StreamLiveInput(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a StreamLiveInput resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the StreamLiveInput to import.</param>
        /// <param name="importFromId">The id of the existing StreamLiveInput that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the StreamLiveInput to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the StreamLiveInput to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_live_input#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing StreamLiveInput that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the StreamLiveInput to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(cloudflare.StreamLiveInput.StreamLiveInput), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putRecording", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.streamLiveInput.StreamLiveInputRecording\"}}]")]
        public virtual void PutRecording(cloudflare.StreamLiveInput.IStreamLiveInputRecording @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.StreamLiveInput.IStreamLiveInputRecording)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDefaultCreator")]
        public virtual void ResetDefaultCreator()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeleteRecordingAfterDays")]
        public virtual void ResetDeleteRecordingAfterDays()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnabled")]
        public virtual void ResetEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLiveInputIdentifier")]
        public virtual void ResetLiveInputIdentifier()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMeta")]
        public virtual void ResetMeta()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRecording")]
        public virtual void ResetRecording()
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
        = GetStaticProperty<string>(typeof(cloudflare.StreamLiveInput.StreamLiveInput))!;

        [JsiiProperty(name: "created", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Created
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modified", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Modified
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "recording", typeJson: "{\"fqn\":\"cloudflare.streamLiveInput.StreamLiveInputRecordingOutputReference\"}")]
        public virtual cloudflare.StreamLiveInput.StreamLiveInputRecordingOutputReference Recording
        {
            get => GetInstanceProperty<cloudflare.StreamLiveInput.StreamLiveInputRecordingOutputReference>()!;
        }

        [JsiiProperty(name: "rtmps", typeJson: "{\"fqn\":\"cloudflare.streamLiveInput.StreamLiveInputRtmpsOutputReference\"}")]
        public virtual cloudflare.StreamLiveInput.StreamLiveInputRtmpsOutputReference Rtmps
        {
            get => GetInstanceProperty<cloudflare.StreamLiveInput.StreamLiveInputRtmpsOutputReference>()!;
        }

        [JsiiProperty(name: "rtmpsPlayback", typeJson: "{\"fqn\":\"cloudflare.streamLiveInput.StreamLiveInputRtmpsPlaybackOutputReference\"}")]
        public virtual cloudflare.StreamLiveInput.StreamLiveInputRtmpsPlaybackOutputReference RtmpsPlayback
        {
            get => GetInstanceProperty<cloudflare.StreamLiveInput.StreamLiveInputRtmpsPlaybackOutputReference>()!;
        }

        [JsiiProperty(name: "srt", typeJson: "{\"fqn\":\"cloudflare.streamLiveInput.StreamLiveInputSrtOutputReference\"}")]
        public virtual cloudflare.StreamLiveInput.StreamLiveInputSrtOutputReference Srt
        {
            get => GetInstanceProperty<cloudflare.StreamLiveInput.StreamLiveInputSrtOutputReference>()!;
        }

        [JsiiProperty(name: "srtPlayback", typeJson: "{\"fqn\":\"cloudflare.streamLiveInput.StreamLiveInputSrtPlaybackOutputReference\"}")]
        public virtual cloudflare.StreamLiveInput.StreamLiveInputSrtPlaybackOutputReference SrtPlayback
        {
            get => GetInstanceProperty<cloudflare.StreamLiveInput.StreamLiveInputSrtPlaybackOutputReference>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Uid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "webRtc", typeJson: "{\"fqn\":\"cloudflare.streamLiveInput.StreamLiveInputWebRtcOutputReference\"}")]
        public virtual cloudflare.StreamLiveInput.StreamLiveInputWebRtcOutputReference WebRtc
        {
            get => GetInstanceProperty<cloudflare.StreamLiveInput.StreamLiveInputWebRtcOutputReference>()!;
        }

        [JsiiProperty(name: "webRtcPlayback", typeJson: "{\"fqn\":\"cloudflare.streamLiveInput.StreamLiveInputWebRtcPlaybackOutputReference\"}")]
        public virtual cloudflare.StreamLiveInput.StreamLiveInputWebRtcPlaybackOutputReference WebRtcPlayback
        {
            get => GetInstanceProperty<cloudflare.StreamLiveInput.StreamLiveInputWebRtcPlaybackOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultCreatorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultCreatorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deleteRecordingAfterDaysInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DeleteRecordingAfterDaysInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "liveInputIdentifierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LiveInputIdentifierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metaInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MetaInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "recordingInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.streamLiveInput.StreamLiveInputRecording\"}]}}", isOptional: true)]
        public virtual object? RecordingInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultCreator", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultCreator
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deleteRecordingAfterDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DeleteRecordingAfterDays
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Enabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "liveInputIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LiveInputIdentifier
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "meta", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Meta
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
