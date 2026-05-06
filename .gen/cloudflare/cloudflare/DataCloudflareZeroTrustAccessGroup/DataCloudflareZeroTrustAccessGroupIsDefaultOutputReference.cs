using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessGroup
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareZeroTrustAccessGroupIsDefaultOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareZeroTrustAccessGroupIsDefaultOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataCloudflareZeroTrustAccessGroupIsDefaultOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustAccessGroupIsDefaultOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "anyValidServiceToken", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultAnyValidServiceTokenOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultAnyValidServiceTokenOutputReference AnyValidServiceToken
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultAnyValidServiceTokenOutputReference>()!;
        }

        [JsiiProperty(name: "authContext", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultAuthContextOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultAuthContextOutputReference AuthContext
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultAuthContextOutputReference>()!;
        }

        [JsiiProperty(name: "authMethod", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultAuthMethodOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultAuthMethodOutputReference AuthMethod
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultAuthMethodOutputReference>()!;
        }

        [JsiiProperty(name: "azureAd", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultAzureAdOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultAzureAdOutputReference AzureAd
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultAzureAdOutputReference>()!;
        }

        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultCertificateOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultCertificateOutputReference Certificate
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultCertificateOutputReference>()!;
        }

        [JsiiProperty(name: "commonName", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultCommonNameOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultCommonNameOutputReference CommonName
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultCommonNameOutputReference>()!;
        }

        [JsiiProperty(name: "devicePosture", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultDevicePostureOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultDevicePostureOutputReference DevicePosture
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultDevicePostureOutputReference>()!;
        }

        [JsiiProperty(name: "email", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultEmailOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultEmailOutputReference Email
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultEmailOutputReference>()!;
        }

        [JsiiProperty(name: "emailDomain", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultEmailDomainOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultEmailDomainOutputReference EmailDomain
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultEmailDomainOutputReference>()!;
        }

        [JsiiProperty(name: "emailList", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultEmailListStructOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultEmailListStructOutputReference EmailList
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultEmailListStructOutputReference>()!;
        }

        [JsiiProperty(name: "everyone", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultEveryoneOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultEveryoneOutputReference Everyone
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultEveryoneOutputReference>()!;
        }

        [JsiiProperty(name: "externalEvaluation", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultExternalEvaluationOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultExternalEvaluationOutputReference ExternalEvaluation
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultExternalEvaluationOutputReference>()!;
        }

        [JsiiProperty(name: "geo", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultGeoOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultGeoOutputReference Geo
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultGeoOutputReference>()!;
        }

        [JsiiProperty(name: "githubOrganization", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultGithubOrganizationOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultGithubOrganizationOutputReference GithubOrganization
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultGithubOrganizationOutputReference>()!;
        }

        [JsiiProperty(name: "group", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultGroupOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultGroupOutputReference Group
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultGroupOutputReference>()!;
        }

        [JsiiProperty(name: "gsuite", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultGsuiteOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultGsuiteOutputReference Gsuite
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultGsuiteOutputReference>()!;
        }

        [JsiiProperty(name: "ip", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultIpOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultIpOutputReference Ip
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultIpOutputReference>()!;
        }

        [JsiiProperty(name: "ipList", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultIpListStructOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultIpListStructOutputReference IpList
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultIpListStructOutputReference>()!;
        }

        [JsiiProperty(name: "linkedAppToken", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultLinkedAppTokenOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultLinkedAppTokenOutputReference LinkedAppToken
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultLinkedAppTokenOutputReference>()!;
        }

        [JsiiProperty(name: "loginMethod", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultLoginMethodOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultLoginMethodOutputReference LoginMethod
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultLoginMethodOutputReference>()!;
        }

        [JsiiProperty(name: "oidc", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultOidcOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultOidcOutputReference Oidc
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultOidcOutputReference>()!;
        }

        [JsiiProperty(name: "okta", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultOktaOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultOktaOutputReference Okta
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultOktaOutputReference>()!;
        }

        [JsiiProperty(name: "saml", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultSamlOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultSamlOutputReference Saml
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultSamlOutputReference>()!;
        }

        [JsiiProperty(name: "serviceToken", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultServiceTokenOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultServiceTokenOutputReference ServiceToken
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultServiceTokenOutputReference>()!;
        }

        [JsiiProperty(name: "userRiskScore", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultUserRiskScoreOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultUserRiskScoreOutputReference UserRiskScore
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefaultUserRiskScoreOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupIsDefault\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.IDataCloudflareZeroTrustAccessGroupIsDefault? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.IDataCloudflareZeroTrustAccessGroupIsDefault?>();
            set => SetInstanceProperty(value);
        }
    }
}
