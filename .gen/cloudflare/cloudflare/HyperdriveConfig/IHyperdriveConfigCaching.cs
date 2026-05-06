using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.HyperdriveConfig
{
    [JsiiInterface(nativeType: typeof(IHyperdriveConfigCaching), fullyQualifiedName: "cloudflare.hyperdriveConfig.HyperdriveConfigCaching")]
    public interface IHyperdriveConfigCaching
    {
        /// <summary>Set to true to disable caching of SQL responses. Default is false.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/hyperdrive_config#disabled HyperdriveConfig#disabled}
        /// </remarks>
        [JsiiProperty(name: "disabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Disabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specify the maximum duration items should persist in the cache. Not returned if set to the default (60).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/hyperdrive_config#max_age HyperdriveConfig#max_age}
        /// </remarks>
        [JsiiProperty(name: "maxAge", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxAge
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specify the number of seconds the cache may serve a stale response. Omitted if set to the default (15).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/hyperdrive_config#stale_while_revalidate HyperdriveConfig#stale_while_revalidate}
        /// </remarks>
        [JsiiProperty(name: "staleWhileRevalidate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StaleWhileRevalidate
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IHyperdriveConfigCaching), fullyQualifiedName: "cloudflare.hyperdriveConfig.HyperdriveConfigCaching")]
        internal sealed class _Proxy : DeputyBase, cloudflare.HyperdriveConfig.IHyperdriveConfigCaching
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Set to true to disable caching of SQL responses. Default is false.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/hyperdrive_config#disabled HyperdriveConfig#disabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "disabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Disabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Specify the maximum duration items should persist in the cache. Not returned if set to the default (60).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/hyperdrive_config#max_age HyperdriveConfig#max_age}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxAge", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxAge
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Specify the number of seconds the cache may serve a stale response. Omitted if set to the default (15).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/hyperdrive_config#stale_while_revalidate HyperdriveConfig#stale_while_revalidate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "staleWhileRevalidate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StaleWhileRevalidate
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
