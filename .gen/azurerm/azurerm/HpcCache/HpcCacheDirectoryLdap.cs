using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HpcCache
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.hpcCache.HpcCacheDirectoryLdap")]
    public class HpcCacheDirectoryLdap : azurerm.HpcCache.IHpcCacheDirectoryLdap
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/hpc_cache#base_dn HpcCache#base_dn}.</summary>
        [JsiiProperty(name: "baseDn", typeJson: "{\"primitive\":\"string\"}")]
        public string BaseDn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/hpc_cache#server HpcCache#server}.</summary>
        [JsiiProperty(name: "server", typeJson: "{\"primitive\":\"string\"}")]
        public string Server
        {
            get;
            set;
        }

        /// <summary>bind block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/hpc_cache#bind HpcCache#bind}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bind", typeJson: "{\"fqn\":\"azurerm.hpcCache.HpcCacheDirectoryLdapBind\"}", isOptional: true)]
        public azurerm.HpcCache.IHpcCacheDirectoryLdapBind? Bind
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/hpc_cache#certificate_validation_uri HpcCache#certificate_validation_uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificateValidationUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateValidationUri
        {
            get;
            set;
        }

        private object? _downloadCertificateAutomatically;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/hpc_cache#download_certificate_automatically HpcCache#download_certificate_automatically}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "downloadCertificateAutomatically", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? DownloadCertificateAutomatically
        {
            get => _downloadCertificateAutomatically;
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
                _downloadCertificateAutomatically = value;
            }
        }

        private object? _encrypted;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/hpc_cache#encrypted HpcCache#encrypted}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "encrypted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Encrypted
        {
            get => _encrypted;
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
                _encrypted = value;
            }
        }
    }
}
