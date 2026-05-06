using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareTurnstileWidget
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareTurnstileWidgetFilter), fullyQualifiedName: "cloudflare.dataCloudflareTurnstileWidget.DataCloudflareTurnstileWidgetFilter")]
    public interface IDataCloudflareTurnstileWidgetFilter
    {
        /// <summary>Direction to order widgets. Available values: "asc", "desc".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/data-sources/turnstile_widget#direction DataCloudflareTurnstileWidget#direction}
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

        /// <summary>Field to order widgets by. Available values: "id", "sitekey", "name", "created_on", "modified_on".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/data-sources/turnstile_widget#order DataCloudflareTurnstileWidget#order}
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/data-sources/turnstile_widget#direction DataCloudflareTurnstileWidget#direction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Direction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Field to order widgets by. Available values: "id", "sitekey", "name", "created_on", "modified_on".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/data-sources/turnstile_widget#order DataCloudflareTurnstileWidget#order}
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
