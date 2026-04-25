using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareStreamLiveInput
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/stream_live_input cloudflare_stream_live_input}.</summary>
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareStreamLiveInput.DataCloudflareStreamLiveInput), fullyQualifiedName: "cloudflare.dataCloudflareStreamLiveInput.DataCloudflareStreamLiveInput", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"cloudflare.dataCloudflareStreamLiveInput.DataCloudflareStreamLiveInputConfig\"}}]")]
    public class DataCloudflareStreamLiveInput : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/stream_live_input cloudflare_stream_live_input} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataCloudflareStreamLiveInput(Constructs.Construct scope, string id, cloudflare.DataCloudflareStreamLiveInput.IDataCloudflareStreamLiveInputConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, cloudflare.DataCloudflareStreamLiveInput.IDataCloudflareStreamLiveInputConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareStreamLiveInput(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareStreamLiveInput(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataCloudflareStreamLiveInput resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataCloudflareStreamLiveInput to import.</param>
        /// <param name="importFromId">The id of the existing DataCloudflareStreamLiveInput that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataCloudflareStreamLiveInput to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataCloudflareStreamLiveInput to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/stream_live_input#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataCloudflareStreamLiveInput that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataCloudflareStreamLiveInput to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(cloudflare.DataCloudflareStreamLiveInput.DataCloudflareStreamLiveInput), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetAccountId")]
        public virtual void ResetAccountId()
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
        = GetStaticProperty<string>(typeof(cloudflare.DataCloudflareStreamLiveInput.DataCloudflareStreamLiveInput))!;

        [JsiiProperty(name: "created", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Created
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deleteRecordingAfterDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DeleteRecordingAfterDays
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Enabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Meta
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modified", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Modified
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "recording", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareStreamLiveInput.DataCloudflareStreamLiveInputRecordingOutputReference\"}")]
        public virtual cloudflare.DataCloudflareStreamLiveInput.DataCloudflareStreamLiveInputRecordingOutputReference Recording
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareStreamLiveInput.DataCloudflareStreamLiveInputRecordingOutputReference>()!;
        }

        [JsiiProperty(name: "rtmps", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareStreamLiveInput.DataCloudflareStreamLiveInputRtmpsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareStreamLiveInput.DataCloudflareStreamLiveInputRtmpsOutputReference Rtmps
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareStreamLiveInput.DataCloudflareStreamLiveInputRtmpsOutputReference>()!;
        }

        [JsiiProperty(name: "rtmpsPlayback", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareStreamLiveInput.DataCloudflareStreamLiveInputRtmpsPlaybackOutputReference\"}")]
        public virtual cloudflare.DataCloudflareStreamLiveInput.DataCloudflareStreamLiveInputRtmpsPlaybackOutputReference RtmpsPlayback
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareStreamLiveInput.DataCloudflareStreamLiveInputRtmpsPlaybackOutputReference>()!;
        }

        [JsiiProperty(name: "srt", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareStreamLiveInput.DataCloudflareStreamLiveInputSrtOutputReference\"}")]
        public virtual cloudflare.DataCloudflareStreamLiveInput.DataCloudflareStreamLiveInputSrtOutputReference Srt
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareStreamLiveInput.DataCloudflareStreamLiveInputSrtOutputReference>()!;
        }

        [JsiiProperty(name: "srtPlayback", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareStreamLiveInput.DataCloudflareStreamLiveInputSrtPlaybackOutputReference\"}")]
        public virtual cloudflare.DataCloudflareStreamLiveInput.DataCloudflareStreamLiveInputSrtPlaybackOutputReference SrtPlayback
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareStreamLiveInput.DataCloudflareStreamLiveInputSrtPlaybackOutputReference>()!;
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

        [JsiiProperty(name: "webRtc", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareStreamLiveInput.DataCloudflareStreamLiveInputWebRtcOutputReference\"}")]
        public virtual cloudflare.DataCloudflareStreamLiveInput.DataCloudflareStreamLiveInputWebRtcOutputReference WebRtc
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareStreamLiveInput.DataCloudflareStreamLiveInputWebRtcOutputReference>()!;
        }

        [JsiiProperty(name: "webRtcPlayback", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareStreamLiveInput.DataCloudflareStreamLiveInputWebRtcPlaybackOutputReference\"}")]
        public virtual cloudflare.DataCloudflareStreamLiveInput.DataCloudflareStreamLiveInputWebRtcPlaybackOutputReference WebRtcPlayback
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareStreamLiveInput.DataCloudflareStreamLiveInputWebRtcPlaybackOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "liveInputIdentifierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LiveInputIdentifierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "liveInputIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LiveInputIdentifier
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
