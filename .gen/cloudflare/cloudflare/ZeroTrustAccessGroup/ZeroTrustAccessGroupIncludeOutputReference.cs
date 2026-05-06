using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessGroup
{
    [JsiiClass(nativeType: typeof(cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeOutputReference), fullyQualifiedName: "cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class ZeroTrustAccessGroupIncludeOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public ZeroTrustAccessGroupIncludeOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected ZeroTrustAccessGroupIncludeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ZeroTrustAccessGroupIncludeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAnyValidServiceToken", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeAnyValidServiceToken\"}}]")]
        public virtual void PutAnyValidServiceToken(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeAnyValidServiceToken @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeAnyValidServiceToken)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAuthContext", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeAuthContext\"}}]")]
        public virtual void PutAuthContext(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeAuthContext @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeAuthContext)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAuthMethod", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeAuthMethod\"}}]")]
        public virtual void PutAuthMethod(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeAuthMethod @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeAuthMethod)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAzureAd", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeAzureAd\"}}]")]
        public virtual void PutAzureAd(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeAzureAd @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeAzureAd)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCertificate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeCertificate\"}}]")]
        public virtual void PutCertificate(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeCertificate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeCertificate)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCommonName", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeCommonName\"}}]")]
        public virtual void PutCommonName(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeCommonName @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeCommonName)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDevicePosture", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeDevicePosture\"}}]")]
        public virtual void PutDevicePosture(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeDevicePosture @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeDevicePosture)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEmail", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeEmail\"}}]")]
        public virtual void PutEmail(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeEmail @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeEmail)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEmailDomain", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeEmailDomain\"}}]")]
        public virtual void PutEmailDomain(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeEmailDomain @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeEmailDomain)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEmailList", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeEmailListStruct\"}}]")]
        public virtual void PutEmailList(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeEmailListStruct @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeEmailListStruct)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEveryone", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeEveryone\"}}]")]
        public virtual void PutEveryone(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeEveryone @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeEveryone)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExternalEvaluation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeExternalEvaluation\"}}]")]
        public virtual void PutExternalEvaluation(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeExternalEvaluation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeExternalEvaluation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGeo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeGeo\"}}]")]
        public virtual void PutGeo(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeGeo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeGeo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGithubOrganization", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeGithubOrganization\"}}]")]
        public virtual void PutGithubOrganization(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeGithubOrganization @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeGithubOrganization)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGroup", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeGroup\"}}]")]
        public virtual void PutGroup(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeGroup @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeGroup)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGsuite", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeGsuite\"}}]")]
        public virtual void PutGsuite(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeGsuite @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeGsuite)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeIp\"}}]")]
        public virtual void PutIp(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeIp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeIp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIpList", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeIpListStruct\"}}]")]
        public virtual void PutIpList(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeIpListStruct @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeIpListStruct)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLinkedAppToken", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeLinkedAppToken\"}}]")]
        public virtual void PutLinkedAppToken(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeLinkedAppToken @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeLinkedAppToken)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLoginMethod", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeLoginMethod\"}}]")]
        public virtual void PutLoginMethod(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeLoginMethod @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeLoginMethod)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOidc", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeOidc\"}}]")]
        public virtual void PutOidc(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeOidc @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeOidc)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOkta", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeOkta\"}}]")]
        public virtual void PutOkta(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeOkta @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeOkta)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSaml", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeSaml\"}}]")]
        public virtual void PutSaml(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeSaml @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeSaml)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServiceToken", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeServiceToken\"}}]")]
        public virtual void PutServiceToken(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeServiceToken @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeServiceToken)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUserRiskScore", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeUserRiskScore\"}}]")]
        public virtual void PutUserRiskScore(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeUserRiskScore @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeUserRiskScore)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAnyValidServiceToken")]
        public virtual void ResetAnyValidServiceToken()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthContext")]
        public virtual void ResetAuthContext()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthMethod")]
        public virtual void ResetAuthMethod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAzureAd")]
        public virtual void ResetAzureAd()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCertificate")]
        public virtual void ResetCertificate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCommonName")]
        public virtual void ResetCommonName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDevicePosture")]
        public virtual void ResetDevicePosture()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmail")]
        public virtual void ResetEmail()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmailDomain")]
        public virtual void ResetEmailDomain()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmailList")]
        public virtual void ResetEmailList()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEveryone")]
        public virtual void ResetEveryone()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExternalEvaluation")]
        public virtual void ResetExternalEvaluation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGeo")]
        public virtual void ResetGeo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGithubOrganization")]
        public virtual void ResetGithubOrganization()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGroup")]
        public virtual void ResetGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGsuite")]
        public virtual void ResetGsuite()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIp")]
        public virtual void ResetIp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpList")]
        public virtual void ResetIpList()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLinkedAppToken")]
        public virtual void ResetLinkedAppToken()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoginMethod")]
        public virtual void ResetLoginMethod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOidc")]
        public virtual void ResetOidc()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOkta")]
        public virtual void ResetOkta()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSaml")]
        public virtual void ResetSaml()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceToken")]
        public virtual void ResetServiceToken()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserRiskScore")]
        public virtual void ResetUserRiskScore()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "anyValidServiceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeAnyValidServiceTokenOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeAnyValidServiceTokenOutputReference AnyValidServiceToken
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeAnyValidServiceTokenOutputReference>()!;
        }

        [JsiiProperty(name: "authContext", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeAuthContextOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeAuthContextOutputReference AuthContext
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeAuthContextOutputReference>()!;
        }

        [JsiiProperty(name: "authMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeAuthMethodOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeAuthMethodOutputReference AuthMethod
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeAuthMethodOutputReference>()!;
        }

        [JsiiProperty(name: "azureAd", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeAzureAdOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeAzureAdOutputReference AzureAd
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeAzureAdOutputReference>()!;
        }

        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeCertificateOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeCertificateOutputReference Certificate
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeCertificateOutputReference>()!;
        }

        [JsiiProperty(name: "commonName", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeCommonNameOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeCommonNameOutputReference CommonName
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeCommonNameOutputReference>()!;
        }

        [JsiiProperty(name: "devicePosture", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeDevicePostureOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeDevicePostureOutputReference DevicePosture
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeDevicePostureOutputReference>()!;
        }

        [JsiiProperty(name: "email", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeEmailOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeEmailOutputReference Email
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeEmailOutputReference>()!;
        }

        [JsiiProperty(name: "emailDomain", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeEmailDomainOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeEmailDomainOutputReference EmailDomain
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeEmailDomainOutputReference>()!;
        }

        [JsiiProperty(name: "emailList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeEmailListStructOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeEmailListStructOutputReference EmailList
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeEmailListStructOutputReference>()!;
        }

        [JsiiProperty(name: "everyone", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeEveryoneOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeEveryoneOutputReference Everyone
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeEveryoneOutputReference>()!;
        }

        [JsiiProperty(name: "externalEvaluation", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeExternalEvaluationOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeExternalEvaluationOutputReference ExternalEvaluation
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeExternalEvaluationOutputReference>()!;
        }

        [JsiiProperty(name: "geo", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeGeoOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeGeoOutputReference Geo
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeGeoOutputReference>()!;
        }

        [JsiiProperty(name: "githubOrganization", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeGithubOrganizationOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeGithubOrganizationOutputReference GithubOrganization
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeGithubOrganizationOutputReference>()!;
        }

        [JsiiProperty(name: "group", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeGroupOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeGroupOutputReference Group
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeGroupOutputReference>()!;
        }

        [JsiiProperty(name: "gsuite", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeGsuiteOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeGsuiteOutputReference Gsuite
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeGsuiteOutputReference>()!;
        }

        [JsiiProperty(name: "ip", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeIpOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeIpOutputReference Ip
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeIpOutputReference>()!;
        }

        [JsiiProperty(name: "ipList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeIpListStructOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeIpListStructOutputReference IpList
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeIpListStructOutputReference>()!;
        }

        [JsiiProperty(name: "linkedAppToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeLinkedAppTokenOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeLinkedAppTokenOutputReference LinkedAppToken
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeLinkedAppTokenOutputReference>()!;
        }

        [JsiiProperty(name: "loginMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeLoginMethodOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeLoginMethodOutputReference LoginMethod
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeLoginMethodOutputReference>()!;
        }

        [JsiiProperty(name: "oidc", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeOidcOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeOidcOutputReference Oidc
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeOidcOutputReference>()!;
        }

        [JsiiProperty(name: "okta", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeOktaOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeOktaOutputReference Okta
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeOktaOutputReference>()!;
        }

        [JsiiProperty(name: "saml", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeSamlOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeSamlOutputReference Saml
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeSamlOutputReference>()!;
        }

        [JsiiProperty(name: "serviceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeServiceTokenOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeServiceTokenOutputReference ServiceToken
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeServiceTokenOutputReference>()!;
        }

        [JsiiProperty(name: "userRiskScore", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeUserRiskScoreOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeUserRiskScoreOutputReference UserRiskScore
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupIncludeUserRiskScoreOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "anyValidServiceTokenInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeAnyValidServiceToken\"}]}}", isOptional: true)]
        public virtual object? AnyValidServiceTokenInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authContextInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeAuthContext\"}]}}", isOptional: true)]
        public virtual object? AuthContextInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authMethodInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeAuthMethod\"}]}}", isOptional: true)]
        public virtual object? AuthMethodInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "azureAdInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeAzureAd\"}]}}", isOptional: true)]
        public virtual object? AzureAdInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeCertificate\"}]}}", isOptional: true)]
        public virtual object? CertificateInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "commonNameInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeCommonName\"}]}}", isOptional: true)]
        public virtual object? CommonNameInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "devicePostureInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeDevicePosture\"}]}}", isOptional: true)]
        public virtual object? DevicePostureInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailDomainInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeEmailDomain\"}]}}", isOptional: true)]
        public virtual object? EmailDomainInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeEmail\"}]}}", isOptional: true)]
        public virtual object? EmailInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailListInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeEmailListStruct\"}]}}", isOptional: true)]
        public virtual object? EmailListInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "everyoneInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeEveryone\"}]}}", isOptional: true)]
        public virtual object? EveryoneInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "externalEvaluationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeExternalEvaluation\"}]}}", isOptional: true)]
        public virtual object? ExternalEvaluationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "geoInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeGeo\"}]}}", isOptional: true)]
        public virtual object? GeoInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "githubOrganizationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeGithubOrganization\"}]}}", isOptional: true)]
        public virtual object? GithubOrganizationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeGroup\"}]}}", isOptional: true)]
        public virtual object? GroupInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gsuiteInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeGsuite\"}]}}", isOptional: true)]
        public virtual object? GsuiteInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeIp\"}]}}", isOptional: true)]
        public virtual object? IpInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipListInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeIpListStruct\"}]}}", isOptional: true)]
        public virtual object? IpListInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "linkedAppTokenInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeLinkedAppToken\"}]}}", isOptional: true)]
        public virtual object? LinkedAppTokenInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loginMethodInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeLoginMethod\"}]}}", isOptional: true)]
        public virtual object? LoginMethodInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oidcInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeOidc\"}]}}", isOptional: true)]
        public virtual object? OidcInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oktaInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeOkta\"}]}}", isOptional: true)]
        public virtual object? OktaInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "samlInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeSaml\"}]}}", isOptional: true)]
        public virtual object? SamlInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceTokenInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeServiceToken\"}]}}", isOptional: true)]
        public virtual object? ServiceTokenInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userRiskScoreInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeUserRiskScore\"}]}}", isOptional: true)]
        public virtual object? UserRiskScoreInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupInclude\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupInclude cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupInclude).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
