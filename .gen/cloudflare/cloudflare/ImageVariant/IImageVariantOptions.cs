using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ImageVariant
{
    [JsiiInterface(nativeType: typeof(IImageVariantOptions), fullyQualifiedName: "cloudflare.imageVariant.ImageVariantOptions")]
    public interface IImageVariantOptions
    {
        /// <summary>The fit property describes how the width and height dimensions should be interpreted. Available values: "scale-down", "contain", "cover", "crop", "pad".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/image_variant#fit ImageVariant#fit}
        /// </remarks>
        [JsiiProperty(name: "fit", typeJson: "{\"primitive\":\"string\"}")]
        string Fit
        {
            get;
        }

        /// <summary>Maximum height in image pixels.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/image_variant#height ImageVariant#height}
        /// </remarks>
        [JsiiProperty(name: "height", typeJson: "{\"primitive\":\"number\"}")]
        double Height
        {
            get;
        }

        /// <summary>What EXIF data should be preserved in the output image. Available values: "keep", "copyright", "none".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/image_variant#metadata ImageVariant#metadata}
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"primitive\":\"string\"}")]
        string Metadata
        {
            get;
        }

        /// <summary>Maximum width in image pixels.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/image_variant#width ImageVariant#width}
        /// </remarks>
        [JsiiProperty(name: "width", typeJson: "{\"primitive\":\"number\"}")]
        double Width
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IImageVariantOptions), fullyQualifiedName: "cloudflare.imageVariant.ImageVariantOptions")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ImageVariant.IImageVariantOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The fit property describes how the width and height dimensions should be interpreted. Available values: "scale-down", "contain", "cover", "crop", "pad".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/image_variant#fit ImageVariant#fit}
            /// </remarks>
            [JsiiProperty(name: "fit", typeJson: "{\"primitive\":\"string\"}")]
            public string Fit
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Maximum height in image pixels.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/image_variant#height ImageVariant#height}
            /// </remarks>
            [JsiiProperty(name: "height", typeJson: "{\"primitive\":\"number\"}")]
            public double Height
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>What EXIF data should be preserved in the output image. Available values: "keep", "copyright", "none".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/image_variant#metadata ImageVariant#metadata}
            /// </remarks>
            [JsiiProperty(name: "metadata", typeJson: "{\"primitive\":\"string\"}")]
            public string Metadata
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Maximum width in image pixels.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/image_variant#width ImageVariant#width}
            /// </remarks>
            [JsiiProperty(name: "width", typeJson: "{\"primitive\":\"number\"}")]
            public double Width
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
