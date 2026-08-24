using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareSecretsStore
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareSecretsStoreFilter), fullyQualifiedName: "cloudflare.dataCloudflareSecretsStore.DataCloudflareSecretsStoreFilter")]
    public interface IDataCloudflareSecretsStoreFilter
    {
        /// <summary>Direction to sort objects. Available values: "asc", "desc".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/secrets_store#direction DataCloudflareSecretsStore#direction}
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

        /// <summary>Order stores by values in the given field. Available values: "name", "created", "modified".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/secrets_store#order DataCloudflareSecretsStore#order}
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

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareSecretsStoreFilter), fullyQualifiedName: "cloudflare.dataCloudflareSecretsStore.DataCloudflareSecretsStoreFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareSecretsStore.IDataCloudflareSecretsStoreFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Direction to sort objects. Available values: "asc", "desc".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/secrets_store#direction DataCloudflareSecretsStore#direction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Direction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Order stores by values in the given field. Available values: "name", "created", "modified".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/secrets_store#order DataCloudflareSecretsStore#order}
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
