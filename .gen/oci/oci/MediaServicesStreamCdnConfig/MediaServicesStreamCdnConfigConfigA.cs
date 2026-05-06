using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MediaServicesStreamCdnConfig
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.mediaServicesStreamCdnConfig.MediaServicesStreamCdnConfigConfigA")]
    public class MediaServicesStreamCdnConfigConfigA : oci.MediaServicesStreamCdnConfig.IMediaServicesStreamCdnConfigConfigA
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/media_services_stream_cdn_config#type MediaServicesStreamCdnConfig#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/media_services_stream_cdn_config#edge_hostname MediaServicesStreamCdnConfig#edge_hostname}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "edgeHostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EdgeHostname
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/media_services_stream_cdn_config#edge_path_prefix MediaServicesStreamCdnConfig#edge_path_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "edgePathPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EdgePathPrefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/media_services_stream_cdn_config#edge_token_key MediaServicesStreamCdnConfig#edge_token_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "edgeTokenKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EdgeTokenKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/media_services_stream_cdn_config#edge_token_salt MediaServicesStreamCdnConfig#edge_token_salt}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "edgeTokenSalt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EdgeTokenSalt
        {
            get;
            set;
        }

        private object? _isEdgeTokenAuth;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/media_services_stream_cdn_config#is_edge_token_auth MediaServicesStreamCdnConfig#is_edge_token_auth}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isEdgeTokenAuth", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsEdgeTokenAuth
        {
            get => _isEdgeTokenAuth;
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
                _isEdgeTokenAuth = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/media_services_stream_cdn_config#origin_auth_secret_key_a MediaServicesStreamCdnConfig#origin_auth_secret_key_a}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "originAuthSecretKeyA", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OriginAuthSecretKeyA
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/media_services_stream_cdn_config#origin_auth_secret_key_b MediaServicesStreamCdnConfig#origin_auth_secret_key_b}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "originAuthSecretKeyB", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OriginAuthSecretKeyB
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/media_services_stream_cdn_config#origin_auth_secret_key_nonce_a MediaServicesStreamCdnConfig#origin_auth_secret_key_nonce_a}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "originAuthSecretKeyNonceA", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OriginAuthSecretKeyNonceA
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/media_services_stream_cdn_config#origin_auth_secret_key_nonce_b MediaServicesStreamCdnConfig#origin_auth_secret_key_nonce_b}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "originAuthSecretKeyNonceB", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OriginAuthSecretKeyNonceB
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/media_services_stream_cdn_config#origin_auth_sign_encryption MediaServicesStreamCdnConfig#origin_auth_sign_encryption}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "originAuthSignEncryption", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OriginAuthSignEncryption
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/media_services_stream_cdn_config#origin_auth_sign_type MediaServicesStreamCdnConfig#origin_auth_sign_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "originAuthSignType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OriginAuthSignType
        {
            get;
            set;
        }
    }
}
