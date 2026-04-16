using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace neon.Provider
{
    [JsiiInterface(nativeType: typeof(INeonProviderConfig), fullyQualifiedName: "neon.provider.NeonProviderConfig")]
    public interface INeonProviderConfig
    {
        /// <summary>Alias name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs#alias NeonProvider#alias}
        /// </remarks>
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Alias
        {
            get
            {
                return null;
            }
        }

        /// <summary>API access key. Default is read from the environment variable `NEON_API_KEY`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs#api_key NeonProvider#api_key}
        /// </remarks>
        [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ApiKey
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INeonProviderConfig), fullyQualifiedName: "neon.provider.NeonProviderConfig")]
        internal sealed class _Proxy : DeputyBase, neon.Provider.INeonProviderConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Alias name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs#alias NeonProvider#alias}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Alias
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>API access key. Default is read from the environment variable `NEON_API_KEY`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs#api_key NeonProvider#api_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApiKey
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
