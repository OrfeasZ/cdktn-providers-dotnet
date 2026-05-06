using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApp
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppApp), fullyQualifiedName: "oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppApp")]
    public interface IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppApp
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#allow_authz_decision_ttl IdentityDomainsApp#allow_authz_decision_ttl}.</summary>
        [JsiiProperty(name: "allowAuthzDecisionTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AllowAuthzDecisionTtl
        {
            get
            {
                return null;
            }
        }

        /// <summary>allow_authz_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#allow_authz_policy IdentityDomainsApp#allow_authz_policy}
        /// </remarks>
        [JsiiProperty(name: "allowAuthzPolicy", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppAppAllowAuthzPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppAppAllowAuthzPolicy? AllowAuthzPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>app_resources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#app_resources IdentityDomainsApp#app_resources}
        /// </remarks>
        [JsiiProperty(name: "appResources", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppAppAppResources\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AppResources
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#deny_authz_decision_ttl IdentityDomainsApp#deny_authz_decision_ttl}.</summary>
        [JsiiProperty(name: "denyAuthzDecisionTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DenyAuthzDecisionTtl
        {
            get
            {
                return null;
            }
        }

        /// <summary>deny_authz_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#deny_authz_policy IdentityDomainsApp#deny_authz_policy}
        /// </remarks>
        [JsiiProperty(name: "denyAuthzPolicy", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppAppDenyAuthzPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppAppDenyAuthzPolicy? DenyAuthzPolicy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppApp), fullyQualifiedName: "oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppApp")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppApp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#allow_authz_decision_ttl IdentityDomainsApp#allow_authz_decision_ttl}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowAuthzDecisionTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AllowAuthzDecisionTtl
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>allow_authz_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#allow_authz_policy IdentityDomainsApp#allow_authz_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowAuthzPolicy", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppAppAllowAuthzPolicy\"}", isOptional: true)]
            public oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppAppAllowAuthzPolicy? AllowAuthzPolicy
            {
                get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppAppAllowAuthzPolicy?>();
            }

            /// <summary>app_resources block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#app_resources IdentityDomainsApp#app_resources}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "appResources", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppAppAppResources\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AppResources
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#deny_authz_decision_ttl IdentityDomainsApp#deny_authz_decision_ttl}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "denyAuthzDecisionTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DenyAuthzDecisionTtl
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>deny_authz_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#deny_authz_policy IdentityDomainsApp#deny_authz_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "denyAuthzPolicy", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppAppDenyAuthzPolicy\"}", isOptional: true)]
            public oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppAppDenyAuthzPolicy? DenyAuthzPolicy
            {
                get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppAppDenyAuthzPolicy?>();
            }
        }
    }
}
