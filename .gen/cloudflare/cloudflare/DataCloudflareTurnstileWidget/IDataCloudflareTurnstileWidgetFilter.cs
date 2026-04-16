using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareTurnstileWidget
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareTurnstileWidgetFilter), fullyQualifiedName: "cloudflare.dataCloudflareTurnstileWidget.DataCloudflareTurnstileWidgetFilter")]
    public interface IDataCloudflareTurnstileWidgetFilter
    {
        /// <summary>Direction to order widgets. Available values: "asc", "desc".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/turnstile_widget#direction DataCloudflareTurnstileWidget#direction}
        /// </remarks>
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Direction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Filter widgets by field using case-insensitive substring matching. Format: `field:value`.</summary>
        /// <remarks>
        /// Supported fields:
        ///
        /// <list type="bullet">
        /// <description><c>name</c> - Filter by widget name (e.g., <c>filter=name:login-form</c>)</description>
        /// <description><c>sitekey</c> - Filter by sitekey (e.g., <c>filter=sitekey:0x4AAA</c>)</description>
        /// </list>
        ///
        /// Returns 400 Bad Request if the field is unsupported or format is invalid.
        /// An empty filter value returns all results.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/turnstile_widget#filter DataCloudflareTurnstileWidget#filter}
        /// </remarks>
        [JsiiProperty(name: "filter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Filter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Field to order widgets by. Available values: "id", "sitekey", "name", "created_on", "modified_on".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/turnstile_widget#order DataCloudflareTurnstileWidget#order}
        /// </remarks>
        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Order
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareTurnstileWidgetFilter), fullyQualifiedName: "cloudflare.dataCloudflareTurnstileWidget.DataCloudflareTurnstileWidgetFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareTurnstileWidget.IDataCloudflareTurnstileWidgetFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Direction to order widgets. Available values: "asc", "desc".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/turnstile_widget#direction DataCloudflareTurnstileWidget#direction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Direction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Filter widgets by field using case-insensitive substring matching. Format: `field:value`.</summary>
            /// <remarks>
            /// Supported fields:
            ///
            /// <list type="bullet">
            /// <description><c>name</c> - Filter by widget name (e.g., <c>filter=name:login-form</c>)</description>
            /// <description><c>sitekey</c> - Filter by sitekey (e.g., <c>filter=sitekey:0x4AAA</c>)</description>
            /// </list>
            ///
            /// Returns 400 Bad Request if the field is unsupported or format is invalid.
            /// An empty filter value returns all results.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/turnstile_widget#filter DataCloudflareTurnstileWidget#filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Filter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Field to order widgets by. Available values: "id", "sitekey", "name", "created_on", "modified_on".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/turnstile_widget#order DataCloudflareTurnstileWidget#order}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Order
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
