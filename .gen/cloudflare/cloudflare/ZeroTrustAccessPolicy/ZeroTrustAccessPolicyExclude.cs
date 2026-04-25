using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessPolicy
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExclude")]
    public class ZeroTrustAccessPolicyExclude : cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExclude
    {
        /// <summary>An empty object which matches on all service tokens.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#any_valid_service_token ZeroTrustAccessPolicy#any_valid_service_token}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "anyValidServiceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeAnyValidServiceToken\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeAnyValidServiceToken? AnyValidServiceToken
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#auth_context ZeroTrustAccessPolicy#auth_context}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authContext", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeAuthContext\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeAuthContext? AuthContext
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#auth_method ZeroTrustAccessPolicy#auth_method}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeAuthMethod\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeAuthMethod? AuthMethod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#azure_ad ZeroTrustAccessPolicy#azure_ad}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "azureAd", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeAzureAd\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeAzureAd? AzureAd
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#certificate ZeroTrustAccessPolicy#certificate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeCertificate\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeCertificate? Certificate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#common_name ZeroTrustAccessPolicy#common_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "commonName", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeCommonName\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeCommonName? CommonName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#device_posture ZeroTrustAccessPolicy#device_posture}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "devicePosture", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeDevicePosture\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeDevicePosture? DevicePosture
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#email ZeroTrustAccessPolicy#email}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "email", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeEmail\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeEmail? Email
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#email_domain ZeroTrustAccessPolicy#email_domain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emailDomain", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeEmailDomain\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeEmailDomain? EmailDomain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#email_list ZeroTrustAccessPolicy#email_list}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emailList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeEmailListStruct\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeEmailListStruct? EmailList
        {
            get;
            set;
        }

        /// <summary>An empty object which matches on all users.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#everyone ZeroTrustAccessPolicy#everyone}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "everyone", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeEveryone\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeEveryone? Everyone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#external_evaluation ZeroTrustAccessPolicy#external_evaluation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "externalEvaluation", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeExternalEvaluation\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeExternalEvaluation? ExternalEvaluation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#geo ZeroTrustAccessPolicy#geo}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "geo", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeGeo\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeGeo? Geo
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#github_organization ZeroTrustAccessPolicy#github_organization}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "githubOrganization", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeGithubOrganization\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeGithubOrganization? GithubOrganization
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#group ZeroTrustAccessPolicy#group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "group", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeGroup\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeGroup? Group
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#gsuite ZeroTrustAccessPolicy#gsuite}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gsuite", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeGsuite\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeGsuite? Gsuite
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#ip ZeroTrustAccessPolicy#ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ip", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeIp\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeIp? Ip
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#ip_list ZeroTrustAccessPolicy#ip_list}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeIpListStruct\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeIpListStruct? IpList
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#linked_app_token ZeroTrustAccessPolicy#linked_app_token}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "linkedAppToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeLinkedAppToken\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeLinkedAppToken? LinkedAppToken
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#login_method ZeroTrustAccessPolicy#login_method}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "loginMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeLoginMethod\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeLoginMethod? LoginMethod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#oidc ZeroTrustAccessPolicy#oidc}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "oidc", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeOidc\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeOidc? Oidc
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#okta ZeroTrustAccessPolicy#okta}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "okta", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeOkta\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeOkta? Okta
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#saml ZeroTrustAccessPolicy#saml}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "saml", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeSaml\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeSaml? Saml
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#service_token ZeroTrustAccessPolicy#service_token}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeServiceToken\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeServiceToken? ServiceToken
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#user_risk_score ZeroTrustAccessPolicy#user_risk_score}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userRiskScore", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeUserRiskScore\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeUserRiskScore? UserRiskScore
        {
            get;
            set;
        }
    }
}
