using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.StreamLiveInput
{
    [JsiiInterface(nativeType: typeof(IStreamLiveInputConfig), fullyQualifiedName: "cloudflare.streamLiveInput.StreamLiveInputConfig")]
    public interface IStreamLiveInputConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_live_input#account_id StreamLiveInput#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        string AccountId
        {
            get;
        }

        /// <summary>Sets the creator ID asssociated with this live input.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_live_input#default_creator StreamLiveInput#default_creator}
        /// </remarks>
        [JsiiProperty(name: "defaultCreator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultCreator
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicates the number of days after which the live inputs recordings will be deleted.</summary>
        /// <remarks>
        /// When a stream completes and the recording is ready, the value is used to calculate a scheduled deletion date for that recording. Omit the field to indicate no change, or include with a <c>null</c> value to remove an existing scheduled deletion.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_live_input#delete_recording_after_days StreamLiveInput#delete_recording_after_days}
        /// </remarks>
        [JsiiProperty(name: "deleteRecordingAfterDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DeleteRecordingAfterDays
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicates whether the live input is enabled and can accept streams.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_live_input#enabled StreamLiveInput#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>A unique identifier for a live input.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_live_input#live_input_identifier StreamLiveInput#live_input_identifier}
        /// </remarks>
        [JsiiProperty(name: "liveInputIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LiveInputIdentifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>A user modifiable key-value store used to reference other systems of record for managing live inputs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_live_input#meta StreamLiveInput#meta}
        /// </remarks>
        [JsiiProperty(name: "meta", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Meta
        {
            get
            {
                return null;
            }
        }

        /// <summary>Records the input to a Cloudflare Stream video.</summary>
        /// <remarks>
        /// Behavior depends on the mode. In most cases, the video will initially be viewable as a live video and transition to on-demand after a condition is satisfied.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_live_input#recording StreamLiveInput#recording}
        /// </remarks>
        [JsiiProperty(name: "recording", typeJson: "{\"fqn\":\"cloudflare.streamLiveInput.StreamLiveInputRecording\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.StreamLiveInput.IStreamLiveInputRecording? Recording
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStreamLiveInputConfig), fullyQualifiedName: "cloudflare.streamLiveInput.StreamLiveInputConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.StreamLiveInput.IStreamLiveInputConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_live_input#account_id StreamLiveInput#account_id}
            /// </remarks>
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Sets the creator ID asssociated with this live input.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_live_input#default_creator StreamLiveInput#default_creator}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultCreator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultCreator
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Indicates the number of days after which the live inputs recordings will be deleted.</summary>
            /// <remarks>
            /// When a stream completes and the recording is ready, the value is used to calculate a scheduled deletion date for that recording. Omit the field to indicate no change, or include with a <c>null</c> value to remove an existing scheduled deletion.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_live_input#delete_recording_after_days StreamLiveInput#delete_recording_after_days}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deleteRecordingAfterDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DeleteRecordingAfterDays
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Indicates whether the live input is enabled and can accept streams.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_live_input#enabled StreamLiveInput#enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>A unique identifier for a live input.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_live_input#live_input_identifier StreamLiveInput#live_input_identifier}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "liveInputIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LiveInputIdentifier
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A user modifiable key-value store used to reference other systems of record for managing live inputs.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_live_input#meta StreamLiveInput#meta}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "meta", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Meta
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Records the input to a Cloudflare Stream video.</summary>
            /// <remarks>
            /// Behavior depends on the mode. In most cases, the video will initially be viewable as a live video and transition to on-demand after a condition is satisfied.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_live_input#recording StreamLiveInput#recording}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "recording", typeJson: "{\"fqn\":\"cloudflare.streamLiveInput.StreamLiveInputRecording\"}", isOptional: true)]
            public cloudflare.StreamLiveInput.IStreamLiveInputRecording? Recording
            {
                get => GetInstanceProperty<cloudflare.StreamLiveInput.IStreamLiveInputRecording?>();
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
