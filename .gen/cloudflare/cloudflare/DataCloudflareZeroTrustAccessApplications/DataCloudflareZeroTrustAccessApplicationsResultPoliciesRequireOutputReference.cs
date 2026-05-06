using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessApplications
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "anyValidServiceToken", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireAnyValidServiceTokenOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireAnyValidServiceTokenOutputReference AnyValidServiceToken
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireAnyValidServiceTokenOutputReference>()!;
        }

        [JsiiProperty(name: "authContext", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireAuthContextOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireAuthContextOutputReference AuthContext
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireAuthContextOutputReference>()!;
        }

        [JsiiProperty(name: "authMethod", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireAuthMethodOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireAuthMethodOutputReference AuthMethod
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireAuthMethodOutputReference>()!;
        }

        [JsiiProperty(name: "azureAd", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireAzureAdOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireAzureAdOutputReference AzureAd
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireAzureAdOutputReference>()!;
        }

        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireCertificateOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireCertificateOutputReference Certificate
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireCertificateOutputReference>()!;
        }

        [JsiiProperty(name: "commonName", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireCommonNameOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireCommonNameOutputReference CommonName
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireCommonNameOutputReference>()!;
        }

        [JsiiProperty(name: "devicePosture", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireDevicePostureOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireDevicePostureOutputReference DevicePosture
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireDevicePostureOutputReference>()!;
        }

        [JsiiProperty(name: "email", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireEmailOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireEmailOutputReference Email
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireEmailOutputReference>()!;
        }

        [JsiiProperty(name: "emailDomain", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireEmailDomainOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireEmailDomainOutputReference EmailDomain
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireEmailDomainOutputReference>()!;
        }

        [JsiiProperty(name: "emailList", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireEmailListStructOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireEmailListStructOutputReference EmailList
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireEmailListStructOutputReference>()!;
        }

        [JsiiProperty(name: "everyone", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireEveryoneOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireEveryoneOutputReference Everyone
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireEveryoneOutputReference>()!;
        }

        [JsiiProperty(name: "externalEvaluation", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireExternalEvaluationOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireExternalEvaluationOutputReference ExternalEvaluation
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireExternalEvaluationOutputReference>()!;
        }

        [JsiiProperty(name: "geo", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireGeoOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireGeoOutputReference Geo
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireGeoOutputReference>()!;
        }

        [JsiiProperty(name: "githubOrganization", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireGithubOrganizationOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireGithubOrganizationOutputReference GithubOrganization
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireGithubOrganizationOutputReference>()!;
        }

        [JsiiProperty(name: "group", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireGroupOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireGroupOutputReference Group
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireGroupOutputReference>()!;
        }

        [JsiiProperty(name: "gsuite", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireGsuiteOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireGsuiteOutputReference Gsuite
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireGsuiteOutputReference>()!;
        }

        [JsiiProperty(name: "ip", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireIpOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireIpOutputReference Ip
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireIpOutputReference>()!;
        }

        [JsiiProperty(name: "ipList", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireIpListStructOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireIpListStructOutputReference IpList
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireIpListStructOutputReference>()!;
        }

        [JsiiProperty(name: "linkedAppToken", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireLinkedAppTokenOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireLinkedAppTokenOutputReference LinkedAppToken
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireLinkedAppTokenOutputReference>()!;
        }

        [JsiiProperty(name: "loginMethod", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireLoginMethodOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireLoginMethodOutputReference LoginMethod
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireLoginMethodOutputReference>()!;
        }

        [JsiiProperty(name: "oidc", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireOidcOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireOidcOutputReference Oidc
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireOidcOutputReference>()!;
        }

        [JsiiProperty(name: "okta", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireOktaOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireOktaOutputReference Okta
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireOktaOutputReference>()!;
        }

        [JsiiProperty(name: "saml", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireSamlOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireSamlOutputReference Saml
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireSamlOutputReference>()!;
        }

        [JsiiProperty(name: "serviceToken", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireServiceTokenOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireServiceTokenOutputReference ServiceToken
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequireServiceTokenOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultPoliciesRequire\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplications.IDataCloudflareZeroTrustAccessApplicationsResultPoliciesRequire? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplications.IDataCloudflareZeroTrustAccessApplicationsResultPoliciesRequire?>();
            set => SetInstanceProperty(value);
        }
    }
}
