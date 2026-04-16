using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessPolicy
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyInclude")]
    public class ZeroTrustAccessPolicyInclude : cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyInclude
    {
        /// <summary>An empty object which matches on all service tokens.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#any_valid_service_token ZeroTrustAccessPolicy#any_valid_service_token}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "anyValidServiceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeAnyValidServiceToken\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeAnyValidServiceToken? AnyValidServiceToken
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#auth_context ZeroTrustAccessPolicy#auth_context}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authContext", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeAuthContext\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeAuthContext? AuthContext
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#auth_method ZeroTrustAccessPolicy#auth_method}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeAuthMethod\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeAuthMethod? AuthMethod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#azure_ad ZeroTrustAccessPolicy#azure_ad}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "azureAd", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeAzureAd\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeAzureAd? AzureAd
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#certificate ZeroTrustAccessPolicy#certificate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeCertificate\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeCertificate? Certificate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#common_name ZeroTrustAccessPolicy#common_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "commonName", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeCommonName\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeCommonName? CommonName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#device_posture ZeroTrustAccessPolicy#device_posture}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "devicePosture", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeDevicePosture\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeDevicePosture? DevicePosture
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#email ZeroTrustAccessPolicy#email}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "email", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeEmail\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeEmail? Email
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#email_domain ZeroTrustAccessPolicy#email_domain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emailDomain", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeEmailDomain\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeEmailDomain? EmailDomain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#email_list ZeroTrustAccessPolicy#email_list}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emailList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeEmailListStruct\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeEmailListStruct? EmailList
        {
            get;
            set;
        }

        /// <summary>An empty object which matches on all users.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#everyone ZeroTrustAccessPolicy#everyone}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "everyone", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeEveryone\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeEveryone? Everyone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#external_evaluation ZeroTrustAccessPolicy#external_evaluation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "externalEvaluation", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeExternalEvaluation\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeExternalEvaluation? ExternalEvaluation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#geo ZeroTrustAccessPolicy#geo}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "geo", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeGeo\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeGeo? Geo
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#github_organization ZeroTrustAccessPolicy#github_organization}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "githubOrganization", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeGithubOrganization\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeGithubOrganization? GithubOrganization
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#group ZeroTrustAccessPolicy#group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "group", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeGroup\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeGroup? Group
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#gsuite ZeroTrustAccessPolicy#gsuite}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gsuite", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeGsuite\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeGsuite? Gsuite
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#ip ZeroTrustAccessPolicy#ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ip", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeIp\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeIp? Ip
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#ip_list ZeroTrustAccessPolicy#ip_list}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeIpListStruct\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeIpListStruct? IpList
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#linked_app_token ZeroTrustAccessPolicy#linked_app_token}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "linkedAppToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeLinkedAppToken\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeLinkedAppToken? LinkedAppToken
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#login_method ZeroTrustAccessPolicy#login_method}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "loginMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeLoginMethod\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeLoginMethod? LoginMethod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#oidc ZeroTrustAccessPolicy#oidc}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "oidc", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeOidc\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeOidc? Oidc
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#okta ZeroTrustAccessPolicy#okta}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "okta", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeOkta\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeOkta? Okta
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#saml ZeroTrustAccessPolicy#saml}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "saml", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeSaml\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeSaml? Saml
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#service_token ZeroTrustAccessPolicy#service_token}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeServiceToken\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeServiceToken? ServiceToken
        {
            get;
            set;
        }
    }
}
