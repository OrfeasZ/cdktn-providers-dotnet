using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequire")]
    public class ZeroTrustAccessApplicationPoliciesRequire : cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequire
    {
        /// <summary>An empty object which matches on all service tokens.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#any_valid_service_token ZeroTrustAccessApplication#any_valid_service_token}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "anyValidServiceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireAnyValidServiceToken\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireAnyValidServiceToken? AnyValidServiceToken
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#auth_context ZeroTrustAccessApplication#auth_context}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authContext", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireAuthContext\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireAuthContext? AuthContext
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#auth_method ZeroTrustAccessApplication#auth_method}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireAuthMethod\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireAuthMethod? AuthMethod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#azure_ad ZeroTrustAccessApplication#azure_ad}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "azureAd", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireAzureAd\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireAzureAd? AzureAd
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#certificate ZeroTrustAccessApplication#certificate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireCertificate\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireCertificate? Certificate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#common_name ZeroTrustAccessApplication#common_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "commonName", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireCommonName\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireCommonName? CommonName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#device_posture ZeroTrustAccessApplication#device_posture}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "devicePosture", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireDevicePosture\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireDevicePosture? DevicePosture
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#email ZeroTrustAccessApplication#email}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "email", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireEmail\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireEmail? Email
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#email_domain ZeroTrustAccessApplication#email_domain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emailDomain", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireEmailDomain\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireEmailDomain? EmailDomain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#email_list ZeroTrustAccessApplication#email_list}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emailList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireEmailListStruct\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireEmailListStruct? EmailList
        {
            get;
            set;
        }

        /// <summary>An empty object which matches on all users.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#everyone ZeroTrustAccessApplication#everyone}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "everyone", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireEveryone\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireEveryone? Everyone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#external_evaluation ZeroTrustAccessApplication#external_evaluation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "externalEvaluation", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireExternalEvaluation\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireExternalEvaluation? ExternalEvaluation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#geo ZeroTrustAccessApplication#geo}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "geo", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireGeo\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireGeo? Geo
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#github_organization ZeroTrustAccessApplication#github_organization}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "githubOrganization", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireGithubOrganization\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireGithubOrganization? GithubOrganization
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#group ZeroTrustAccessApplication#group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "group", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireGroup\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireGroup? Group
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#gsuite ZeroTrustAccessApplication#gsuite}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gsuite", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireGsuite\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireGsuite? Gsuite
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#ip ZeroTrustAccessApplication#ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ip", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireIp\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireIp? Ip
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#ip_list ZeroTrustAccessApplication#ip_list}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireIpListStruct\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireIpListStruct? IpList
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#linked_app_token ZeroTrustAccessApplication#linked_app_token}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "linkedAppToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireLinkedAppToken\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireLinkedAppToken? LinkedAppToken
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#login_method ZeroTrustAccessApplication#login_method}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "loginMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireLoginMethod\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireLoginMethod? LoginMethod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#oidc ZeroTrustAccessApplication#oidc}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "oidc", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireOidc\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireOidc? Oidc
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#okta ZeroTrustAccessApplication#okta}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "okta", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireOkta\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireOkta? Okta
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#saml ZeroTrustAccessApplication#saml}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "saml", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireSaml\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireSaml? Saml
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#service_token ZeroTrustAccessApplication#service_token}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireServiceToken\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireServiceToken? ServiceToken
        {
            get;
            set;
        }
    }
}
