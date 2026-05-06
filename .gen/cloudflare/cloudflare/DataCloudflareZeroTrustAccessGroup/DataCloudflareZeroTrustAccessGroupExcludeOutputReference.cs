using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessGroup
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareZeroTrustAccessGroupExcludeOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareZeroTrustAccessGroupExcludeOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataCloudflareZeroTrustAccessGroupExcludeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustAccessGroupExcludeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "anyValidServiceToken", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeAnyValidServiceTokenOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeAnyValidServiceTokenOutputReference AnyValidServiceToken
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeAnyValidServiceTokenOutputReference>()!;
        }

        [JsiiProperty(name: "authContext", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeAuthContextOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeAuthContextOutputReference AuthContext
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeAuthContextOutputReference>()!;
        }

        [JsiiProperty(name: "authMethod", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeAuthMethodOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeAuthMethodOutputReference AuthMethod
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeAuthMethodOutputReference>()!;
        }

        [JsiiProperty(name: "azureAd", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeAzureAdOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeAzureAdOutputReference AzureAd
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeAzureAdOutputReference>()!;
        }

        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeCertificateOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeCertificateOutputReference Certificate
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeCertificateOutputReference>()!;
        }

        [JsiiProperty(name: "commonName", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeCommonNameOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeCommonNameOutputReference CommonName
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeCommonNameOutputReference>()!;
        }

        [JsiiProperty(name: "devicePosture", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeDevicePostureOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeDevicePostureOutputReference DevicePosture
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeDevicePostureOutputReference>()!;
        }

        [JsiiProperty(name: "email", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeEmailOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeEmailOutputReference Email
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeEmailOutputReference>()!;
        }

        [JsiiProperty(name: "emailDomain", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeEmailDomainOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeEmailDomainOutputReference EmailDomain
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeEmailDomainOutputReference>()!;
        }

        [JsiiProperty(name: "emailList", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeEmailListStructOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeEmailListStructOutputReference EmailList
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeEmailListStructOutputReference>()!;
        }

        [JsiiProperty(name: "everyone", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeEveryoneOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeEveryoneOutputReference Everyone
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeEveryoneOutputReference>()!;
        }

        [JsiiProperty(name: "externalEvaluation", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeExternalEvaluationOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeExternalEvaluationOutputReference ExternalEvaluation
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeExternalEvaluationOutputReference>()!;
        }

        [JsiiProperty(name: "geo", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeGeoOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeGeoOutputReference Geo
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeGeoOutputReference>()!;
        }

        [JsiiProperty(name: "githubOrganization", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeGithubOrganizationOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeGithubOrganizationOutputReference GithubOrganization
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeGithubOrganizationOutputReference>()!;
        }

        [JsiiProperty(name: "group", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeGroupOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeGroupOutputReference Group
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeGroupOutputReference>()!;
        }

        [JsiiProperty(name: "gsuite", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeGsuiteOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeGsuiteOutputReference Gsuite
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeGsuiteOutputReference>()!;
        }

        [JsiiProperty(name: "ip", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeIpOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeIpOutputReference Ip
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeIpOutputReference>()!;
        }

        [JsiiProperty(name: "ipList", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeIpListStructOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeIpListStructOutputReference IpList
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeIpListStructOutputReference>()!;
        }

        [JsiiProperty(name: "linkedAppToken", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeLinkedAppTokenOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeLinkedAppTokenOutputReference LinkedAppToken
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeLinkedAppTokenOutputReference>()!;
        }

        [JsiiProperty(name: "loginMethod", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeLoginMethodOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeLoginMethodOutputReference LoginMethod
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeLoginMethodOutputReference>()!;
        }

        [JsiiProperty(name: "oidc", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeOidcOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeOidcOutputReference Oidc
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeOidcOutputReference>()!;
        }

        [JsiiProperty(name: "okta", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeOktaOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeOktaOutputReference Okta
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeOktaOutputReference>()!;
        }

        [JsiiProperty(name: "saml", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeSamlOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeSamlOutputReference Saml
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeSamlOutputReference>()!;
        }

        [JsiiProperty(name: "serviceToken", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeServiceTokenOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeServiceTokenOutputReference ServiceToken
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeServiceTokenOutputReference>()!;
        }

        [JsiiProperty(name: "userRiskScore", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeUserRiskScoreOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeUserRiskScoreOutputReference UserRiskScore
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExcludeUserRiskScoreOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupExclude\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.IDataCloudflareZeroTrustAccessGroupExclude? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.IDataCloudflareZeroTrustAccessGroupExclude?>();
            set => SetInstanceProperty(value);
        }
    }
}
