using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationScimConfig")]
    public class ZeroTrustAccessApplicationScimConfig : cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationScimConfig
    {
        /// <summary>The UID of the IdP to use as the source for SCIM resources to provision to this application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#idp_uid ZeroTrustAccessApplication#idp_uid}
        /// </remarks>
        [JsiiProperty(name: "idpUid", typeJson: "{\"primitive\":\"string\"}")]
        public string IdpUid
        {
            get;
            set;
        }

        /// <summary>The base URI for the application's SCIM-compatible API.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#remote_uri ZeroTrustAccessApplication#remote_uri}
        /// </remarks>
        [JsiiProperty(name: "remoteUri", typeJson: "{\"primitive\":\"string\"}")]
        public string RemoteUri
        {
            get;
            set;
        }

        /// <summary>Attributes for configuring HTTP Basic authentication scheme for SCIM provisioning to an application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#authentication ZeroTrustAccessApplication#authentication}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authentication", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationScimConfigAuthentication\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationScimConfigAuthentication? Authentication
        {
            get;
            set;
        }

        private object? _deactivateOnDelete;

        /// <summary>If false, propagates DELETE requests to the target application for SCIM resources.</summary>
        /// <remarks>
        /// If true, sets 'active' to false on the SCIM resource. Note: Some targets do not support DELETE operations.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#deactivate_on_delete ZeroTrustAccessApplication#deactivate_on_delete}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deactivateOnDelete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? DeactivateOnDelete
        {
            get => _deactivateOnDelete;
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
                _deactivateOnDelete = value;
            }
        }

        private object? _enabled;

        /// <summary>Whether SCIM provisioning is turned on for this application.</summary>
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

        private object? _mappings;

        /// <summary>A list of mappings to apply to SCIM resources before provisioning them in this application.</summary>
        /// <remarks>
        /// These can transform or filter the resources to be provisioned.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#mappings ZeroTrustAccessApplication#mappings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationScimConfigMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Mappings
        {
            get => _mappings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationScimConfigMappings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationScimConfigMappings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _mappings = value;
            }
        }
    }
}
