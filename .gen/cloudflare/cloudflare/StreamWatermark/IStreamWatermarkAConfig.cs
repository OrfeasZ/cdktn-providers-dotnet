using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.StreamWatermark
{
    [JsiiInterface(nativeType: typeof(IStreamWatermarkAConfig), fullyQualifiedName: "cloudflare.streamWatermark.StreamWatermarkAConfig")]
    public interface IStreamWatermarkAConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The account identifier tag.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_watermark#account_id StreamWatermarkA#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        string AccountId
        {
            get;
        }

        /// <summary>The image file to upload.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_watermark#file StreamWatermarkA#file}
        /// </remarks>
        [JsiiProperty(name: "file", typeJson: "{\"primitive\":\"string\"}")]
        string File
        {
            get;
        }

        /// <summary>The unique identifier for a watermark profile.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_watermark#identifier StreamWatermarkA#identifier}
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

        /// <summary>A short description of the watermark profile.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_watermark#name StreamWatermarkA#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>The translucency of the image.</summary>
        /// <remarks>
        /// A value of <c>0.0</c> makes the image completely transparent, and <c>1.0</c> makes the image completely opaque. Note that if the image is already semi-transparent, setting this to <c>1.0</c> will not make the image completely opaque.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_watermark#opacity StreamWatermarkA#opacity}
        /// </remarks>
        [JsiiProperty(name: "opacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Opacity
        {
            get
            {
                return null;
            }
        }

        /// <summary>The whitespace between the adjacent edges (determined by position) of the video and the image.</summary>
        /// <remarks>
        /// <c>0.0</c> indicates no padding, and <c>1.0</c> indicates a fully padded video width or length, as determined by the algorithm.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_watermark#padding StreamWatermarkA#padding}
        /// </remarks>
        [JsiiProperty(name: "padding", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Padding
        {
            get
            {
                return null;
            }
        }

        /// <summary>The location of the image.</summary>
        /// <remarks>
        /// Valid positions are: <c>upperRight</c>, <c>upperLeft</c>, <c>lowerLeft</c>, <c>lowerRight</c>, and <c>center</c>. Note that <c>center</c> ignores the <c>padding</c> parameter.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_watermark#position StreamWatermarkA#position}
        /// </remarks>
        [JsiiProperty(name: "position", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Position
        {
            get
            {
                return null;
            }
        }

        /// <summary>The size of the image relative to the overall size of the video.</summary>
        /// <remarks>
        /// This parameter will adapt to horizontal and vertical videos automatically. <c>0.0</c> indicates no scaling (use the size of the image as-is), and <c>1.0 </c>fills the entire video.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_watermark#scale StreamWatermarkA#scale}
        /// </remarks>
        [JsiiProperty(name: "scale", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Scale
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStreamWatermarkAConfig), fullyQualifiedName: "cloudflare.streamWatermark.StreamWatermarkAConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.StreamWatermark.IStreamWatermarkAConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The account identifier tag.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_watermark#account_id StreamWatermarkA#account_id}
            /// </remarks>
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The image file to upload.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_watermark#file StreamWatermarkA#file}
            /// </remarks>
            [JsiiProperty(name: "file", typeJson: "{\"primitive\":\"string\"}")]
            public string File
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The unique identifier for a watermark profile.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_watermark#identifier StreamWatermarkA#identifier}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Identifier
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A short description of the watermark profile.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_watermark#name StreamWatermarkA#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The translucency of the image.</summary>
            /// <remarks>
            /// A value of <c>0.0</c> makes the image completely transparent, and <c>1.0</c> makes the image completely opaque. Note that if the image is already semi-transparent, setting this to <c>1.0</c> will not make the image completely opaque.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_watermark#opacity StreamWatermarkA#opacity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "opacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Opacity
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The whitespace between the adjacent edges (determined by position) of the video and the image.</summary>
            /// <remarks>
            /// <c>0.0</c> indicates no padding, and <c>1.0</c> indicates a fully padded video width or length, as determined by the algorithm.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_watermark#padding StreamWatermarkA#padding}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "padding", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Padding
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The location of the image.</summary>
            /// <remarks>
            /// Valid positions are: <c>upperRight</c>, <c>upperLeft</c>, <c>lowerLeft</c>, <c>lowerRight</c>, and <c>center</c>. Note that <c>center</c> ignores the <c>padding</c> parameter.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_watermark#position StreamWatermarkA#position}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "position", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Position
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The size of the image relative to the overall size of the video.</summary>
            /// <remarks>
            /// This parameter will adapt to horizontal and vertical videos automatically. <c>0.0</c> indicates no scaling (use the size of the image as-is), and <c>1.0 </c>fills the entire video.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/stream_watermark#scale StreamWatermarkA#scale}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scale", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Scale
            {
                get => GetInstanceProperty<double?>();
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
