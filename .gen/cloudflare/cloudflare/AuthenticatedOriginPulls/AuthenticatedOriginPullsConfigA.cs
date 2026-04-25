using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AuthenticatedOriginPulls
{
    [JsiiByValue(fqn: "cloudflare.authenticatedOriginPulls.AuthenticatedOriginPullsConfigA")]
    public class AuthenticatedOriginPullsConfigA : cloudflare.AuthenticatedOriginPulls.IAuthenticatedOriginPullsConfigA
    {
        /// <summary>Certificate identifier tag.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/authenticated_origin_pulls#cert_id AuthenticatedOriginPulls#cert_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "certId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertId
        {
            get;
            set;
        }

        private object? _enabled;

        /// <summary>Indicates whether hostname-level authenticated origin pulls is enabled. A null value voids the association.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/authenticated_origin_pulls#enabled AuthenticatedOriginPulls#enabled}
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

        /// <summary>The hostname on the origin for which the client certificate uploaded will be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/authenticated_origin_pulls#hostname AuthenticatedOriginPulls#hostname}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Hostname
        {
            get;
            set;
        }
    }
}
