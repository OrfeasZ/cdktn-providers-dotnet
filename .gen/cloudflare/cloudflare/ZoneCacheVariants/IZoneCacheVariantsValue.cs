using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZoneCacheVariants
{
    [JsiiInterface(nativeType: typeof(IZoneCacheVariantsValue), fullyQualifiedName: "cloudflare.zoneCacheVariants.ZoneCacheVariantsValue")]
    public interface IZoneCacheVariantsValue
    {
        /// <summary>List of strings with the MIME types of all the variants that should be served for avif.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_cache_variants#avif ZoneCacheVariants#avif}
        /// </remarks>
        [JsiiProperty(name: "avif", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Avif
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of strings with the MIME types of all the variants that should be served for bmp.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_cache_variants#bmp ZoneCacheVariants#bmp}
        /// </remarks>
        [JsiiProperty(name: "bmp", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Bmp
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of strings with the MIME types of all the variants that should be served for gif.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_cache_variants#gif ZoneCacheVariants#gif}
        /// </remarks>
        [JsiiProperty(name: "gif", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Gif
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of strings with the MIME types of all the variants that should be served for jp2.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_cache_variants#jp2 ZoneCacheVariants#jp2}
        /// </remarks>
        [JsiiProperty(name: "jp2", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Jp2
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of strings with the MIME types of all the variants that should be served for jpeg.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_cache_variants#jpeg ZoneCacheVariants#jpeg}
        /// </remarks>
        [JsiiProperty(name: "jpeg", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Jpeg
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of strings with the MIME types of all the variants that should be served for jpg.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_cache_variants#jpg ZoneCacheVariants#jpg}
        /// </remarks>
        [JsiiProperty(name: "jpg", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Jpg
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of strings with the MIME types of all the variants that should be served for jpg2.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_cache_variants#jpg2 ZoneCacheVariants#jpg2}
        /// </remarks>
        [JsiiProperty(name: "jpg2", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Jpg2
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of strings with the MIME types of all the variants that should be served for png.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_cache_variants#png ZoneCacheVariants#png}
        /// </remarks>
        [JsiiProperty(name: "png", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Png
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of strings with the MIME types of all the variants that should be served for tif.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_cache_variants#tif ZoneCacheVariants#tif}
        /// </remarks>
        [JsiiProperty(name: "tif", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Tif
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of strings with the MIME types of all the variants that should be served for tiff.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_cache_variants#tiff ZoneCacheVariants#tiff}
        /// </remarks>
        [JsiiProperty(name: "tiff", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Tiff
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of strings with the MIME types of all the variants that should be served for webp.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_cache_variants#webp ZoneCacheVariants#webp}
        /// </remarks>
        [JsiiProperty(name: "webp", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Webp
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZoneCacheVariantsValue), fullyQualifiedName: "cloudflare.zoneCacheVariants.ZoneCacheVariantsValue")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZoneCacheVariants.IZoneCacheVariantsValue
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>List of strings with the MIME types of all the variants that should be served for avif.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_cache_variants#avif ZoneCacheVariants#avif}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "avif", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Avif
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>List of strings with the MIME types of all the variants that should be served for bmp.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_cache_variants#bmp ZoneCacheVariants#bmp}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bmp", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Bmp
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>List of strings with the MIME types of all the variants that should be served for gif.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_cache_variants#gif ZoneCacheVariants#gif}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "gif", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Gif
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>List of strings with the MIME types of all the variants that should be served for jp2.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_cache_variants#jp2 ZoneCacheVariants#jp2}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jp2", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Jp2
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>List of strings with the MIME types of all the variants that should be served for jpeg.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_cache_variants#jpeg ZoneCacheVariants#jpeg}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jpeg", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Jpeg
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>List of strings with the MIME types of all the variants that should be served for jpg.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_cache_variants#jpg ZoneCacheVariants#jpg}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jpg", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Jpg
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>List of strings with the MIME types of all the variants that should be served for jpg2.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_cache_variants#jpg2 ZoneCacheVariants#jpg2}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jpg2", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Jpg2
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>List of strings with the MIME types of all the variants that should be served for png.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_cache_variants#png ZoneCacheVariants#png}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "png", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Png
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>List of strings with the MIME types of all the variants that should be served for tif.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_cache_variants#tif ZoneCacheVariants#tif}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tif", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Tif
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>List of strings with the MIME types of all the variants that should be served for tiff.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_cache_variants#tiff ZoneCacheVariants#tiff}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tiff", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Tiff
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>List of strings with the MIME types of all the variants that should be served for webp.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_cache_variants#webp ZoneCacheVariants#webp}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "webp", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Webp
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
