using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.StreamLiveInput
{
    [JsiiByValue(fqn: "cloudflare.streamLiveInput.StreamLiveInputRecording")]
    public class StreamLiveInputRecording : cloudflare.StreamLiveInput.IStreamLiveInputRecording
    {
        /// <summary>Lists the origins allowed to display videos created with this input.</summary>
        /// <remarks>
        /// Enter allowed origin domains in an array and use <c>*</c> for wildcard subdomains. An empty array allows videos to be viewed on any origin.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_live_input#allowed_origins StreamLiveInput#allowed_origins}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowedOrigins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowedOrigins
        {
            get;
            set;
        }

        private object? _hideLiveViewerCount;

        /// <summary>Disables reporting the number of live viewers when this property is set to `true`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_live_input#hide_live_viewer_count StreamLiveInput#hide_live_viewer_count}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hideLiveViewerCount", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? HideLiveViewerCount
        {
            get => _hideLiveViewerCount;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _hideLiveViewerCount = value;
            }
        }

        /// <summary>Specifies the recording behavior for the live input.</summary>
        /// <remarks>
        /// Set this value to <c>off</c> to prevent a recording. Set the value to <c>automatic</c> to begin a recording and transition to on-demand after Stream Live stops receiving input.
        /// Available values: "off", "automatic".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_live_input#mode StreamLiveInput#mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Mode
        {
            get;
            set;
        }

        private object? _requireSignedUrls;

        /// <summary>Indicates if a video using the live input has the `requireSignedURLs` property set.</summary>
        /// <remarks>
        /// Also enforces access controls on any video recording of the livestream with the live input.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_live_input#require_signed_urls StreamLiveInput#require_signed_urls}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requireSignedUrls", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? RequireSignedUrls
        {
            get => _requireSignedUrls;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _requireSignedUrls = value;
            }
        }

        /// <summary>Determines the amount of time a live input configured in `automatic` mode should wait before a recording transitions from live to on-demand.</summary>
        /// <remarks>
        /// <c>0</c> is recommended for most use cases and indicates the platform default should be used.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_live_input#timeout_seconds StreamLiveInput#timeout_seconds}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TimeoutSeconds
        {
            get;
            set;
        }
    }
}
