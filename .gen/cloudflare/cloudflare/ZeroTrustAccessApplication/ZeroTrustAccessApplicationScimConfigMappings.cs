using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationScimConfigMappings")]
    public class ZeroTrustAccessApplicationScimConfigMappings : cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationScimConfigMappings
    {
        /// <summary>Which SCIM resource type this mapping applies to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#schema ZeroTrustAccessApplication#schema}
        /// </remarks>
        [JsiiProperty(name: "schema", typeJson: "{\"primitive\":\"string\"}")]
        public string Schema
        {
            get;
            set;
        }

        private object? _enabled;

        /// <summary>Whether or not this mapping is enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#enabled ZeroTrustAccessApplication#enabled}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Enabled
        {
            get => _enabled;
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
                _enabled = value;
            }
        }

        /// <summary>A [SCIM filter expression](https://datatracker.ietf.org/doc/html/rfc7644#section-3.4.2.2) that matches resources that should be provisioned to this application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#filter ZeroTrustAccessApplication#filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Filter
        {
            get;
            set;
        }

        /// <summary>Whether or not this mapping applies to creates, updates, or deletes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#operations ZeroTrustAccessApplication#operations}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "operations", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationScimConfigMappingsOperations\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationScimConfigMappingsOperations? Operations
        {
            get;
            set;
        }

        /// <summary>The level of adherence to outbound resource schemas when provisioning to this mapping.</summary>
        /// <remarks>
        /// ‘Strict’ removes unknown values, while ‘passthrough’ passes unknown values to the target.
        /// Available values: "strict", "passthrough".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#strictness ZeroTrustAccessApplication#strictness}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "strictness", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Strictness
        {
            get;
            set;
        }

        /// <summary>A [JSONata](https://jsonata.org/) expression that transforms the resource before provisioning it in the application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#transform_jsonata ZeroTrustAccessApplication#transform_jsonata}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "transformJsonata", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TransformJsonata
        {
            get;
            set;
        }
    }
}
