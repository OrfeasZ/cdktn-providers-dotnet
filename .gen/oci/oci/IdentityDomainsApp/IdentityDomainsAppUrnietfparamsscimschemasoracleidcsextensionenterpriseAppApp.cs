using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApp
{
    [JsiiByValue(fqn: "oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppApp")]
    public class IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppApp : oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppApp
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#allow_authz_decision_ttl IdentityDomainsApp#allow_authz_decision_ttl}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowAuthzDecisionTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AllowAuthzDecisionTtl
        {
            get;
            set;
        }

        /// <summary>allow_authz_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#allow_authz_policy IdentityDomainsApp#allow_authz_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowAuthzPolicy", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppAppAllowAuthzPolicy\"}", isOptional: true)]
        public oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppAppAllowAuthzPolicy? AllowAuthzPolicy
        {
            get;
            set;
        }

        private object? _appResources;

        /// <summary>app_resources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#app_resources IdentityDomainsApp#app_resources}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "appResources", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppAppAppResources\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AppResources
        {
            get => _appResources;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppAppAppResources[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppAppAppResources).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _appResources = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#deny_authz_decision_ttl IdentityDomainsApp#deny_authz_decision_ttl}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "denyAuthzDecisionTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DenyAuthzDecisionTtl
        {
            get;
            set;
        }

        /// <summary>deny_authz_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#deny_authz_policy IdentityDomainsApp#deny_authz_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "denyAuthzPolicy", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppAppDenyAuthzPolicy\"}", isOptional: true)]
        public oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppAppDenyAuthzPolicy? DenyAuthzPolicy
        {
            get;
            set;
        }
    }
}
