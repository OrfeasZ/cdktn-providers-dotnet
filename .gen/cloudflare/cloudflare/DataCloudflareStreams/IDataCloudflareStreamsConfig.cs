using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareStreams
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareStreamsConfig), fullyQualifiedName: "cloudflare.dataCloudflareStreams.DataCloudflareStreamsConfig")]
    public interface IDataCloudflareStreamsConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The account identifier tag.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/streams#account_id DataCloudflareStreams#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        string AccountId
        {
            get;
        }

        /// <summary>Lists videos in ascending order of creation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/streams#asc DataCloudflareStreams#asc}
        /// </remarks>
        [JsiiProperty(name: "asc", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Asc
        {
            get
            {
                return null;
            }
        }

        /// <summary>A user-defined identifier for the media creator.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/streams#creator DataCloudflareStreams#creator}
        /// </remarks>
        [JsiiProperty(name: "creator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Creator
        {
            get
            {
                return null;
            }
        }

        /// <summary>Lists videos created before the specified date.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/streams#end DataCloudflareStreams#end}
        /// </remarks>
        [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? End
        {
            get
            {
                return null;
            }
        }

        /// <summary>Includes the total number of videos associated with the submitted query parameters.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/streams#include_counts DataCloudflareStreams#include_counts}
        /// </remarks>
        [JsiiProperty(name: "includeCounts", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IncludeCounts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Max items to fetch, default: 1000.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/streams#max_items DataCloudflareStreams#max_items}
        /// </remarks>
        [JsiiProperty(name: "maxItems", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxItems
        {
            get
            {
                return null;
            }
        }

        /// <summary>Provides a partial word match of the `name` key in the `meta` field.</summary>
        /// <remarks>
        /// Slow for medium to large video libraries. May be unavailable for very large libraries.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/streams#search DataCloudflareStreams#search}
        /// </remarks>
        [JsiiProperty(name: "search", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Search
        {
            get
            {
                return null;
            }
        }

        /// <summary>Lists videos created after the specified date.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/streams#start DataCloudflareStreams#start}
        /// </remarks>
        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Start
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the processing status for all quality levels for a video. Available values: "pendingupload", "downloading", "queued", "inprogress", "ready", "error", "live-inprogress".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/streams#status DataCloudflareStreams#status}
        /// </remarks>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Status
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies whether the video is `vod` or `live`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/streams#type DataCloudflareStreams#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        /// <summary>Provides a fast, exact string match on the `name` key in the `meta` field.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/streams#video_name DataCloudflareStreams#video_name}
        /// </remarks>
        [JsiiProperty(name: "videoName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VideoName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareStreamsConfig), fullyQualifiedName: "cloudflare.dataCloudflareStreams.DataCloudflareStreamsConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareStreams.IDataCloudflareStreamsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The account identifier tag.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/streams#account_id DataCloudflareStreams#account_id}
            /// </remarks>
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Lists videos in ascending order of creation.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/streams#asc DataCloudflareStreams#asc}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "asc", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Asc
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>A user-defined identifier for the media creator.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/streams#creator DataCloudflareStreams#creator}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "creator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Creator
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Lists videos created before the specified date.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/streams#end DataCloudflareStreams#end}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? End
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Includes the total number of videos associated with the submitted query parameters.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/streams#include_counts DataCloudflareStreams#include_counts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "includeCounts", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IncludeCounts
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Max items to fetch, default: 1000.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/streams#max_items DataCloudflareStreams#max_items}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxItems", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxItems
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Provides a partial word match of the `name` key in the `meta` field.</summary>
            /// <remarks>
            /// Slow for medium to large video libraries. May be unavailable for very large libraries.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/streams#search DataCloudflareStreams#search}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "search", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Search
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Lists videos created after the specified date.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/streams#start DataCloudflareStreams#start}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Start
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specifies the processing status for all quality levels for a video. Available values: "pendingupload", "downloading", "queued", "inprogress", "ready", "error", "live-inprogress".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/streams#status DataCloudflareStreams#status}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specifies whether the video is `vod` or `live`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/streams#type DataCloudflareStreams#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Provides a fast, exact string match on the `name` key in the `meta` field.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/streams#video_name DataCloudflareStreams#video_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "videoName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VideoName
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
