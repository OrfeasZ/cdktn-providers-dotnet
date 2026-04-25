using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessPolicy
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequire")]
    public class ZeroTrustAccessPolicyRequire : cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequire
    {
        /// <summary>An empty object which matches on all service tokens.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#any_valid_service_token ZeroTrustAccessPolicy#any_valid_service_token}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "anyValidServiceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireAnyValidServiceToken\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireAnyValidServiceToken? AnyValidServiceToken
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#auth_context ZeroTrustAccessPolicy#auth_context}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authContext", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireAuthContext\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireAuthContext? AuthContext
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#auth_method ZeroTrustAccessPolicy#auth_method}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireAuthMethod\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireAuthMethod? AuthMethod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#azure_ad ZeroTrustAccessPolicy#azure_ad}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "azureAd", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireAzureAd\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireAzureAd? AzureAd
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#certificate ZeroTrustAccessPolicy#certificate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireCertificate\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireCertificate? Certificate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#common_name ZeroTrustAccessPolicy#common_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "commonName", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireCommonName\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireCommonName? CommonName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#device_posture ZeroTrustAccessPolicy#device_posture}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "devicePosture", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireDevicePosture\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireDevicePosture? DevicePosture
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#email ZeroTrustAccessPolicy#email}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "email", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireEmail\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireEmail? Email
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#email_domain ZeroTrustAccessPolicy#email_domain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emailDomain", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireEmailDomain\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireEmailDomain? EmailDomain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#email_list ZeroTrustAccessPolicy#email_list}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emailList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireEmailListStruct\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireEmailListStruct? EmailList
        {
            get;
            set;
        }

        /// <summary>An empty object which matches on all users.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#everyone ZeroTrustAccessPolicy#everyone}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "everyone", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireEveryone\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireEveryone? Everyone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#external_evaluation ZeroTrustAccessPolicy#external_evaluation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "externalEvaluation", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireExternalEvaluation\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireExternalEvaluation? ExternalEvaluation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#geo ZeroTrustAccessPolicy#geo}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "geo", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireGeo\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireGeo? Geo
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#github_organization ZeroTrustAccessPolicy#github_organization}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "githubOrganization", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireGithubOrganization\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireGithubOrganization? GithubOrganization
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#group ZeroTrustAccessPolicy#group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "group", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireGroup\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireGroup? Group
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#gsuite ZeroTrustAccessPolicy#gsuite}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gsuite", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireGsuite\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireGsuite? Gsuite
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#ip ZeroTrustAccessPolicy#ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ip", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireIp\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireIp? Ip
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#ip_list ZeroTrustAccessPolicy#ip_list}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireIpListStruct\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireIpListStruct? IpList
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#linked_app_token ZeroTrustAccessPolicy#linked_app_token}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "linkedAppToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireLinkedAppToken\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireLinkedAppToken? LinkedAppToken
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#login_method ZeroTrustAccessPolicy#login_method}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "loginMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireLoginMethod\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireLoginMethod? LoginMethod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#oidc ZeroTrustAccessPolicy#oidc}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "oidc", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireOidc\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireOidc? Oidc
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#okta ZeroTrustAccessPolicy#okta}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "okta", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireOkta\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireOkta? Okta
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#saml ZeroTrustAccessPolicy#saml}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "saml", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireSaml\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireSaml? Saml
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#service_token ZeroTrustAccessPolicy#service_token}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireServiceToken\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireServiceToken? ServiceToken
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#user_risk_score ZeroTrustAccessPolicy#user_risk_score}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userRiskScore", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireUserRiskScore\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireUserRiskScore? UserRiskScore
        {
            get;
            set;
        }
    }
}
