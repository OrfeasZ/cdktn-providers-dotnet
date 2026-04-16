using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessPolicies
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareZeroTrustAccessPoliciesResultRequireOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareZeroTrustAccessPoliciesResultRequireOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataCloudflareZeroTrustAccessPoliciesResultRequireOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustAccessPoliciesResultRequireOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "anyValidServiceToken", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireAnyValidServiceTokenOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireAnyValidServiceTokenOutputReference AnyValidServiceToken
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireAnyValidServiceTokenOutputReference>()!;
        }

        [JsiiProperty(name: "authContext", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireAuthContextOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireAuthContextOutputReference AuthContext
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireAuthContextOutputReference>()!;
        }

        [JsiiProperty(name: "authMethod", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireAuthMethodOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireAuthMethodOutputReference AuthMethod
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireAuthMethodOutputReference>()!;
        }

        [JsiiProperty(name: "azureAd", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireAzureAdOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireAzureAdOutputReference AzureAd
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireAzureAdOutputReference>()!;
        }

        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireCertificateOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireCertificateOutputReference Certificate
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireCertificateOutputReference>()!;
        }

        [JsiiProperty(name: "commonName", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireCommonNameOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireCommonNameOutputReference CommonName
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireCommonNameOutputReference>()!;
        }

        [JsiiProperty(name: "devicePosture", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireDevicePostureOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireDevicePostureOutputReference DevicePosture
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireDevicePostureOutputReference>()!;
        }

        [JsiiProperty(name: "email", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireEmailOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireEmailOutputReference Email
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireEmailOutputReference>()!;
        }

        [JsiiProperty(name: "emailDomain", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireEmailDomainOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireEmailDomainOutputReference EmailDomain
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireEmailDomainOutputReference>()!;
        }

        [JsiiProperty(name: "emailList", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireEmailListStructOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireEmailListStructOutputReference EmailList
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireEmailListStructOutputReference>()!;
        }

        [JsiiProperty(name: "everyone", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireEveryoneOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireEveryoneOutputReference Everyone
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireEveryoneOutputReference>()!;
        }

        [JsiiProperty(name: "externalEvaluation", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireExternalEvaluationOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireExternalEvaluationOutputReference ExternalEvaluation
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireExternalEvaluationOutputReference>()!;
        }

        [JsiiProperty(name: "geo", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireGeoOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireGeoOutputReference Geo
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireGeoOutputReference>()!;
        }

        [JsiiProperty(name: "githubOrganization", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireGithubOrganizationOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireGithubOrganizationOutputReference GithubOrganization
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireGithubOrganizationOutputReference>()!;
        }

        [JsiiProperty(name: "group", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireGroupOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireGroupOutputReference Group
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireGroupOutputReference>()!;
        }

        [JsiiProperty(name: "gsuite", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireGsuiteOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireGsuiteOutputReference Gsuite
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireGsuiteOutputReference>()!;
        }

        [JsiiProperty(name: "ip", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireIpOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireIpOutputReference Ip
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireIpOutputReference>()!;
        }

        [JsiiProperty(name: "ipList", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireIpListStructOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireIpListStructOutputReference IpList
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireIpListStructOutputReference>()!;
        }

        [JsiiProperty(name: "linkedAppToken", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireLinkedAppTokenOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireLinkedAppTokenOutputReference LinkedAppToken
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireLinkedAppTokenOutputReference>()!;
        }

        [JsiiProperty(name: "loginMethod", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireLoginMethodOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireLoginMethodOutputReference LoginMethod
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireLoginMethodOutputReference>()!;
        }

        [JsiiProperty(name: "oidc", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireOidcOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireOidcOutputReference Oidc
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireOidcOutputReference>()!;
        }

        [JsiiProperty(name: "okta", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireOktaOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireOktaOutputReference Okta
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireOktaOutputReference>()!;
        }

        [JsiiProperty(name: "saml", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireSamlOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireSamlOutputReference Saml
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireSamlOutputReference>()!;
        }

        [JsiiProperty(name: "serviceToken", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireServiceTokenOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireServiceTokenOutputReference ServiceToken
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequireServiceTokenOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicies.DataCloudflareZeroTrustAccessPoliciesResultRequire\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicies.IDataCloudflareZeroTrustAccessPoliciesResultRequire? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicies.IDataCloudflareZeroTrustAccessPoliciesResultRequire?>();
            set => SetInstanceProperty(value);
        }
    }
}
