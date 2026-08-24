using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAccountToken
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareAccountTokenFilter), fullyQualifiedName: "cloudflare.dataCloudflareAccountToken.DataCloudflareAccountTokenFilter")]
    public interface IDataCloudflareAccountTokenFilter
    {
        /// <summary>Direction to order results. Available values: "asc", "desc".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/account_token#direction DataCloudflareAccountToken#direction}
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

        /// <summary>When true, includes recently-expired tokens in the response.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/account_token#include_expired DataCloudflareAccountToken#include_expired}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "includeExpired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IncludeExpired
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareAccountTokenFilter), fullyQualifiedName: "cloudflare.dataCloudflareAccountToken.DataCloudflareAccountTokenFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareAccountToken.IDataCloudflareAccountTokenFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Direction to order results. Available values: "asc", "desc".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/account_token#direction DataCloudflareAccountToken#direction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Direction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>When true, includes recently-expired tokens in the response.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/account_token#include_expired DataCloudflareAccountToken#include_expired}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "includeExpired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IncludeExpired
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
