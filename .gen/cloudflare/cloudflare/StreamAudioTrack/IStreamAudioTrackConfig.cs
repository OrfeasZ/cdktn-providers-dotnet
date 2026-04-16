using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.StreamAudioTrack
{
    [JsiiInterface(nativeType: typeof(IStreamAudioTrackConfig), fullyQualifiedName: "cloudflare.streamAudioTrack.StreamAudioTrackConfig")]
    public interface IStreamAudioTrackConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The account identifier tag.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_audio_track#account_id StreamAudioTrack#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        string AccountId
        {
            get;
        }

        /// <summary>A Cloudflare-generated unique identifier for a media item.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_audio_track#identifier StreamAudioTrack#identifier}
        /// </remarks>
        [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"string\"}")]
        string Identifier
        {
            get;
        }

        /// <summary>The unique identifier for an additional audio track.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_audio_track#audio_identifier StreamAudioTrack#audio_identifier}
        /// </remarks>
        [JsiiProperty(name: "audioIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AudioIdentifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>Denotes whether the audio track will be played by default in a player.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_audio_track#default StreamAudioTrack#default}
        /// </remarks>
        [JsiiProperty(name: "default", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Default
        {
            get
            {
                return null;
            }
        }

        /// <summary>A string to uniquely identify the track amongst other audio track labels for the specified video.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_audio_track#label StreamAudioTrack#label}
        /// </remarks>
        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Label
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStreamAudioTrackConfig), fullyQualifiedName: "cloudflare.streamAudioTrack.StreamAudioTrackConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.StreamAudioTrack.IStreamAudioTrackConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The account identifier tag.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_audio_track#account_id StreamAudioTrack#account_id}
            /// </remarks>
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A Cloudflare-generated unique identifier for a media item.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_audio_track#identifier StreamAudioTrack#identifier}
            /// </remarks>
            [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"string\"}")]
            public string Identifier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The unique identifier for an additional audio track.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_audio_track#audio_identifier StreamAudioTrack#audio_identifier}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "audioIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AudioIdentifier
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Denotes whether the audio track will be played by default in a player.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_audio_track#default StreamAudioTrack#default}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "default", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Default
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>A string to uniquely identify the track amongst other audio track labels for the specified video.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_audio_track#label StreamAudioTrack#label}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Label
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
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
