using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.HyperdriveConfig
{
    [JsiiByValue(fqn: "cloudflare.hyperdriveConfig.HyperdriveConfigCaching")]
    public class HyperdriveConfigCaching : cloudflare.HyperdriveConfig.IHyperdriveConfigCaching
    {
        private object? _disabled;

        /// <summary>Set to true to disable caching of SQL responses. Default is false.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/hyperdrive_config#disabled HyperdriveConfig#disabled}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "disabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Disabled
        {
            get => _disabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _disabled = value;
            }
        }

        /// <summary>Specify the maximum duration (in seconds) items should persist in the cache. Defaults to 60 seconds if not specified.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/hyperdrive_config#max_age HyperdriveConfig#max_age}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maxAge", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxAge
        {
            get;
            set;
        }

        /// <summary>Specify the number of seconds the cache may serve a stale response. Defaults to 15 seconds if not specified.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/hyperdrive_config#stale_while_revalidate HyperdriveConfig#stale_while_revalidate}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "staleWhileRevalidate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StaleWhileRevalidate
        {
            get;
            set;
        }
    }
}
