using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ImageVariant
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.imageVariant.ImageVariantOptions")]
    public class ImageVariantOptions : cloudflare.ImageVariant.IImageVariantOptions
    {
        /// <summary>The fit property describes how the width and height dimensions should be interpreted. Available values: "scale-down", "contain", "cover", "crop", "pad".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/image_variant#fit ImageVariant#fit}
        /// </remarks>
        [JsiiProperty(name: "fit", typeJson: "{\"primitive\":\"string\"}")]
        public string Fit
        {
            get;
            set;
        }

        /// <summary>Maximum height in image pixels.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/image_variant#height ImageVariant#height}
        /// </remarks>
        [JsiiProperty(name: "height", typeJson: "{\"primitive\":\"number\"}")]
        public double Height
        {
            get;
            set;
        }

        /// <summary>What EXIF data should be preserved in the output image. Available values: "keep", "copyright", "none".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/image_variant#metadata ImageVariant#metadata}
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"primitive\":\"string\"}")]
        public string Metadata
        {
            get;
            set;
        }

        /// <summary>Maximum width in image pixels.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/image_variant#width ImageVariant#width}
        /// </remarks>
        [JsiiProperty(name: "width", typeJson: "{\"primitive\":\"number\"}")]
        public double Width
        {
            get;
            set;
        }
    }
}
