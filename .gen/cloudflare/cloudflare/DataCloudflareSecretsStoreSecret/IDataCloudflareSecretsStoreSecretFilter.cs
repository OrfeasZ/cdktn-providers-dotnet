using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareSecretsStoreSecret
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareSecretsStoreSecretFilter), fullyQualifiedName: "cloudflare.dataCloudflareSecretsStoreSecret.DataCloudflareSecretsStoreSecretFilter")]
    public interface IDataCloudflareSecretsStoreSecretFilter
    {
        /// <summary>Direction to sort objects. Available values: "asc", "desc".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/data-sources/secrets_store_secret#direction DataCloudflareSecretsStoreSecret#direction}
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

        /// <summary>Order secrets by values in the given field. Available values: "name", "comment", "created", "modified", "status".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/data-sources/secrets_store_secret#order DataCloudflareSecretsStoreSecret#order}
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

        /// <summary>Only secrets with the given scopes will be returned.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/data-sources/secrets_store_secret#scopes DataCloudflareSecretsStoreSecret#scopes}
        /// </remarks>
        [JsiiProperty(name: "scopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Scopes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Search secrets using a filter string, filtering across name and comment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/data-sources/secrets_store_secret#search DataCloudflareSecretsStoreSecret#search}
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

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareSecretsStoreSecretFilter), fullyQualifiedName: "cloudflare.dataCloudflareSecretsStoreSecret.DataCloudflareSecretsStoreSecretFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareSecretsStoreSecret.IDataCloudflareSecretsStoreSecretFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Direction to sort objects. Available values: "asc", "desc".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/data-sources/secrets_store_secret#direction DataCloudflareSecretsStoreSecret#direction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Direction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Order secrets by values in the given field. Available values: "name", "comment", "created", "modified", "status".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/data-sources/secrets_store_secret#order DataCloudflareSecretsStoreSecret#order}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Order
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Only secrets with the given scopes will be returned.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/data-sources/secrets_store_secret#scopes DataCloudflareSecretsStoreSecret#scopes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Scopes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Search secrets using a filter string, filtering across name and comment.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/data-sources/secrets_store_secret#search DataCloudflareSecretsStoreSecret#search}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "search", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Search
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
