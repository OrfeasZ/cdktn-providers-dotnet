using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessGroup
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupRequire")]
    public class ZeroTrustAccessGroupRequire : cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupRequire
    {
        /// <summary>An empty object which matches on all service tokens.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_group#any_valid_service_token ZeroTrustAccessGroup#any_valid_service_token}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "anyValidServiceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupRequireAnyValidServiceToken\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupRequireAnyValidServiceToken? AnyValidServiceToken
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_group#auth_context ZeroTrustAccessGroup#auth_context}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authContext", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupRequireAuthContext\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupRequireAuthContext? AuthContext
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_group#auth_method ZeroTrustAccessGroup#auth_method}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupRequireAuthMethod\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupRequireAuthMethod? AuthMethod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_group#azure_ad ZeroTrustAccessGroup#azure_ad}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "azureAd", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupRequireAzureAd\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupRequireAzureAd? AzureAd
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_group#certificate ZeroTrustAccessGroup#certificate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupRequireCertificate\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupRequireCertificate? Certificate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_group#common_name ZeroTrustAccessGroup#common_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "commonName", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupRequireCommonName\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupRequireCommonName? CommonName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_group#device_posture ZeroTrustAccessGroup#device_posture}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "devicePosture", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupRequireDevicePosture\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupRequireDevicePosture? DevicePosture
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_group#email ZeroTrustAccessGroup#email}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "email", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupRequireEmail\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupRequireEmail? Email
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_group#email_domain ZeroTrustAccessGroup#email_domain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emailDomain", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupRequireEmailDomain\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupRequireEmailDomain? EmailDomain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_group#email_list ZeroTrustAccessGroup#email_list}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emailList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupRequireEmailListStruct\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupRequireEmailListStruct? EmailList
        {
            get;
            set;
        }

        /// <summary>An empty object which matches on all users.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_group#everyone ZeroTrustAccessGroup#everyone}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "everyone", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupRequireEveryone\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupRequireEveryone? Everyone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_group#external_evaluation ZeroTrustAccessGroup#external_evaluation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "externalEvaluation", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupRequireExternalEvaluation\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupRequireExternalEvaluation? ExternalEvaluation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_group#geo ZeroTrustAccessGroup#geo}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "geo", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupRequireGeo\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupRequireGeo? Geo
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_group#github_organization ZeroTrustAccessGroup#github_organization}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "githubOrganization", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupRequireGithubOrganization\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupRequireGithubOrganization? GithubOrganization
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_group#group ZeroTrustAccessGroup#group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "group", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupRequireGroup\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupRequireGroup? Group
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_group#gsuite ZeroTrustAccessGroup#gsuite}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gsuite", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupRequireGsuite\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupRequireGsuite? Gsuite
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_group#ip ZeroTrustAccessGroup#ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ip", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupRequireIp\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupRequireIp? Ip
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_group#ip_list ZeroTrustAccessGroup#ip_list}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupRequireIpListStruct\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupRequireIpListStruct? IpList
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_group#linked_app_token ZeroTrustAccessGroup#linked_app_token}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "linkedAppToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupRequireLinkedAppToken\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupRequireLinkedAppToken? LinkedAppToken
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_group#login_method ZeroTrustAccessGroup#login_method}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "loginMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupRequireLoginMethod\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupRequireLoginMethod? LoginMethod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_group#oidc ZeroTrustAccessGroup#oidc}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "oidc", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupRequireOidc\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupRequireOidc? Oidc
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_group#okta ZeroTrustAccessGroup#okta}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "okta", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupRequireOkta\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupRequireOkta? Okta
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_group#saml ZeroTrustAccessGroup#saml}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "saml", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupRequireSaml\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupRequireSaml? Saml
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_group#service_token ZeroTrustAccessGroup#service_token}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupRequireServiceToken\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupRequireServiceToken? ServiceToken
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_group#user_risk_score ZeroTrustAccessGroup#user_risk_score}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userRiskScore", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupRequireUserRiskScore\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupRequireUserRiskScore? UserRiskScore
        {
            get;
            set;
        }
    }
}
