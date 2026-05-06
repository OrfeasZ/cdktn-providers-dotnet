using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApp
{
    [JsiiByValue(fqn: "oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappApp")]
    public class IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappApp : oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappApp
    {
        private object? _adminConsentGranted;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#admin_consent_granted IdentityDomainsApp#admin_consent_granted}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "adminConsentGranted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AdminConsentGranted
        {
            get => _adminConsentGranted;
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
                _adminConsentGranted = value;
            }
        }

        private object? _bundleConfigurationProperties;

        /// <summary>bundle_configuration_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#bundle_configuration_properties IdentityDomainsApp#bundle_configuration_properties}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bundleConfigurationProperties", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppBundleConfigurationProperties\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? BundleConfigurationProperties
        {
            get => _bundleConfigurationProperties;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppBundleConfigurationProperties[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppBundleConfigurationProperties).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _bundleConfigurationProperties = value;
            }
        }

        /// <summary>bundle_pool_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#bundle_pool_configuration IdentityDomainsApp#bundle_pool_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bundlePoolConfiguration", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppBundlePoolConfiguration\"}", isOptional: true)]
        public oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppBundlePoolConfiguration? BundlePoolConfiguration
        {
            get;
            set;
        }

        private object? _connected;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#connected IdentityDomainsApp#connected}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connected", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Connected
        {
            get => _connected;
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
                _connected = value;
            }
        }

        private object? _enableAuthSyncNewUserNotification;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#enable_auth_sync_new_user_notification IdentityDomainsApp#enable_auth_sync_new_user_notification}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableAuthSyncNewUserNotification", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? EnableAuthSyncNewUserNotification
        {
            get => _enableAuthSyncNewUserNotification;
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
                _enableAuthSyncNewUserNotification = value;
            }
        }

        private object? _enableSync;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#enable_sync IdentityDomainsApp#enable_sync}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableSync", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? EnableSync
        {
            get => _enableSync;
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
                _enableSync = value;
            }
        }

        private object? _enableSyncSummaryReportNotification;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#enable_sync_summary_report_notification IdentityDomainsApp#enable_sync_summary_report_notification}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableSyncSummaryReportNotification", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? EnableSyncSummaryReportNotification
        {
            get => _enableSyncSummaryReportNotification;
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
                _enableSyncSummaryReportNotification = value;
            }
        }

        private object? _flatFileBundleConfigurationProperties;

        /// <summary>flat_file_bundle_configuration_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#flat_file_bundle_configuration_properties IdentityDomainsApp#flat_file_bundle_configuration_properties}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "flatFileBundleConfigurationProperties", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppFlatFileBundleConfigurationProperties\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FlatFileBundleConfigurationProperties
        {
            get => _flatFileBundleConfigurationProperties;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppFlatFileBundleConfigurationProperties[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppFlatFileBundleConfigurationProperties).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _flatFileBundleConfigurationProperties = value;
            }
        }

        /// <summary>flat_file_connector_bundle block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#flat_file_connector_bundle IdentityDomainsApp#flat_file_connector_bundle}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "flatFileConnectorBundle", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppFlatFileConnectorBundle\"}", isOptional: true)]
        public oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppFlatFileConnectorBundle? FlatFileConnectorBundle
        {
            get;
            set;
        }

        private object? _isAuthoritative;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#is_authoritative IdentityDomainsApp#is_authoritative}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isAuthoritative", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsAuthoritative
        {
            get => _isAuthoritative;
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
                _isAuthoritative = value;
            }
        }

        /// <summary>three_legged_oauth_credential block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#three_legged_oauth_credential IdentityDomainsApp#three_legged_oauth_credential}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "threeLeggedOauthCredential", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppThreeLeggedOauthCredential\"}", isOptional: true)]
        public oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppThreeLeggedOauthCredential? ThreeLeggedOauthCredential
        {
            get;
            set;
        }
    }
}
