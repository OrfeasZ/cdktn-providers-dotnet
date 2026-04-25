using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Stream
{
    [JsiiInterface(nativeType: typeof(IStreamConfig), fullyQualifiedName: "cloudflare.stream.StreamConfig")]
    public interface IStreamConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The account identifier tag.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/stream#account_id Stream#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccountId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Lists the origins allowed to display the video.</summary>
        /// <remarks>
        /// Enter allowed origin domains in an array and use <c>*</c> for wildcard subdomains. Empty arrays allow the video to be viewed on any origin.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/stream#allowed_origins Stream#allowed_origins}
        /// </remarks>
        [JsiiProperty(name: "allowedOrigins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedOrigins
        {
            get
            {
                return null;
            }
        }

        /// <summary>A user-defined identifier for the media creator.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/stream#creator Stream#creator}
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

        /// <summary>A Cloudflare-generated unique identifier for a media item.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/stream#identifier Stream#identifier}
        /// </remarks>
        [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Identifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>The maximum duration in seconds for a video upload.</summary>
        /// <remarks>
        /// Can be set for a video that is not yet uploaded to limit its duration. Uploads that exceed the specified duration will fail during processing. A value of <c>-1</c> means the value is unknown.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/stream#max_duration_seconds Stream#max_duration_seconds}
        /// </remarks>
        [JsiiProperty(name: "maxDurationSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxDurationSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>A user modifiable key-value store used to reference other systems of record for managing videos.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/stream#meta Stream#meta}
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

        /// <summary>Public details for the video including title, share link, channel link, and logo.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/stream#public_details Stream#public_details}
        /// </remarks>
        [JsiiProperty(name: "publicDetails", typeJson: "{\"fqn\":\"cloudflare.stream.StreamPublicDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.Stream.IStreamPublicDetails? PublicDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicates whether the video can be a accessed using the UID.</summary>
        /// <remarks>
        /// When set to <c>true</c>, a signed token must be generated with a signing key to view the video.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/stream#require_signed_urls Stream#require_signed_urls}
        /// </remarks>
        [JsiiProperty(name: "requireSignedUrls", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequireSignedUrls
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicates the date and time at which the video will be deleted.</summary>
        /// <remarks>
        /// Omit the field to indicate no change, or include with a <c>null</c> value to remove an existing scheduled deletion. If specified, must be at least 30 days from upload time.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/stream#scheduled_deletion Stream#scheduled_deletion}
        /// </remarks>
        [JsiiProperty(name: "scheduledDeletion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScheduledDeletion
        {
            get
            {
                return null;
            }
        }

        /// <summary>The timestamp for a thumbnail image calculated as a percentage value of the video's duration.</summary>
        /// <remarks>
        /// To convert from a second-wise timestamp to a percentage, divide the desired timestamp by the total duration of the video.  If this value is not set, the default thumbnail image is taken from 0s of the video.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/stream#thumbnail_timestamp_pct Stream#thumbnail_timestamp_pct}
        /// </remarks>
        [JsiiProperty(name: "thumbnailTimestampPct", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ThumbnailTimestampPct
        {
            get
            {
                return null;
            }
        }

        /// <summary>The unique identifier for the video. Can be used to verify the video being updated.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/stream#uid Stream#uid}
        /// </remarks>
        [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Uid
        {
            get
            {
                return null;
            }
        }

        /// <summary>The date and time when the video upload URL is no longer valid for direct user uploads.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/stream#upload_expiry Stream#upload_expiry}
        /// </remarks>
        [JsiiProperty(name: "uploadExpiry", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UploadExpiry
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStreamConfig), fullyQualifiedName: "cloudflare.stream.StreamConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Stream.IStreamConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The account identifier tag.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/stream#account_id Stream#account_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Lists the origins allowed to display the video.</summary>
            /// <remarks>
            /// Enter allowed origin domains in an array and use <c>*</c> for wildcard subdomains. Empty arrays allow the video to be viewed on any origin.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/stream#allowed_origins Stream#allowed_origins}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowedOrigins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedOrigins
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>A user-defined identifier for the media creator.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/stream#creator Stream#creator}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "creator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Creator
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A Cloudflare-generated unique identifier for a media item.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/stream#identifier Stream#identifier}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Identifier
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The maximum duration in seconds for a video upload.</summary>
            /// <remarks>
            /// Can be set for a video that is not yet uploaded to limit its duration. Uploads that exceed the specified duration will fail during processing. A value of <c>-1</c> means the value is unknown.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/stream#max_duration_seconds Stream#max_duration_seconds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxDurationSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxDurationSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>A user modifiable key-value store used to reference other systems of record for managing videos.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/stream#meta Stream#meta}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "meta", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Meta
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Public details for the video including title, share link, channel link, and logo.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/stream#public_details Stream#public_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "publicDetails", typeJson: "{\"fqn\":\"cloudflare.stream.StreamPublicDetails\"}", isOptional: true)]
            public cloudflare.Stream.IStreamPublicDetails? PublicDetails
            {
                get => GetInstanceProperty<cloudflare.Stream.IStreamPublicDetails?>();
            }

            /// <summary>Indicates whether the video can be a accessed using the UID.</summary>
            /// <remarks>
            /// When set to <c>true</c>, a signed token must be generated with a signing key to view the video.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/stream#require_signed_urls Stream#require_signed_urls}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requireSignedUrls", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? RequireSignedUrls
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Indicates the date and time at which the video will be deleted.</summary>
            /// <remarks>
            /// Omit the field to indicate no change, or include with a <c>null</c> value to remove an existing scheduled deletion. If specified, must be at least 30 days from upload time.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/stream#scheduled_deletion Stream#scheduled_deletion}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scheduledDeletion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScheduledDeletion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The timestamp for a thumbnail image calculated as a percentage value of the video's duration.</summary>
            /// <remarks>
            /// To convert from a second-wise timestamp to a percentage, divide the desired timestamp by the total duration of the video.  If this value is not set, the default thumbnail image is taken from 0s of the video.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/stream#thumbnail_timestamp_pct Stream#thumbnail_timestamp_pct}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "thumbnailTimestampPct", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ThumbnailTimestampPct
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The unique identifier for the video. Can be used to verify the video being updated.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/stream#uid Stream#uid}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Uid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The date and time when the video upload URL is no longer valid for direct user uploads.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/stream#upload_expiry Stream#upload_expiry}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "uploadExpiry", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UploadExpiry
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
