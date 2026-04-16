using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessGroup
{
    [JsiiClass(nativeType: typeof(cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeOutputReference), fullyQualifiedName: "cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class ZeroTrustAccessGroupExcludeOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public ZeroTrustAccessGroupExcludeOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected ZeroTrustAccessGroupExcludeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ZeroTrustAccessGroupExcludeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAnyValidServiceToken", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeAnyValidServiceToken\"}}]")]
        public virtual void PutAnyValidServiceToken(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeAnyValidServiceToken @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeAnyValidServiceToken)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAuthContext", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeAuthContext\"}}]")]
        public virtual void PutAuthContext(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeAuthContext @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeAuthContext)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAuthMethod", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeAuthMethod\"}}]")]
        public virtual void PutAuthMethod(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeAuthMethod @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeAuthMethod)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAzureAd", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeAzureAd\"}}]")]
        public virtual void PutAzureAd(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeAzureAd @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeAzureAd)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCertificate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeCertificate\"}}]")]
        public virtual void PutCertificate(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeCertificate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeCertificate)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCommonName", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeCommonName\"}}]")]
        public virtual void PutCommonName(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeCommonName @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeCommonName)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDevicePosture", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeDevicePosture\"}}]")]
        public virtual void PutDevicePosture(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeDevicePosture @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeDevicePosture)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEmail", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeEmail\"}}]")]
        public virtual void PutEmail(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeEmail @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeEmail)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEmailDomain", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeEmailDomain\"}}]")]
        public virtual void PutEmailDomain(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeEmailDomain @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeEmailDomain)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEmailList", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeEmailListStruct\"}}]")]
        public virtual void PutEmailList(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeEmailListStruct @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeEmailListStruct)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEveryone", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeEveryone\"}}]")]
        public virtual void PutEveryone(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeEveryone @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeEveryone)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExternalEvaluation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeExternalEvaluation\"}}]")]
        public virtual void PutExternalEvaluation(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeExternalEvaluation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeExternalEvaluation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGeo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeGeo\"}}]")]
        public virtual void PutGeo(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeGeo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeGeo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGithubOrganization", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeGithubOrganization\"}}]")]
        public virtual void PutGithubOrganization(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeGithubOrganization @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeGithubOrganization)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGroup", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeGroup\"}}]")]
        public virtual void PutGroup(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeGroup @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeGroup)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGsuite", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeGsuite\"}}]")]
        public virtual void PutGsuite(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeGsuite @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeGsuite)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeIp\"}}]")]
        public virtual void PutIp(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeIp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeIp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIpList", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeIpListStruct\"}}]")]
        public virtual void PutIpList(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeIpListStruct @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeIpListStruct)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLinkedAppToken", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeLinkedAppToken\"}}]")]
        public virtual void PutLinkedAppToken(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeLinkedAppToken @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeLinkedAppToken)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLoginMethod", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeLoginMethod\"}}]")]
        public virtual void PutLoginMethod(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeLoginMethod @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeLoginMethod)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOidc", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeOidc\"}}]")]
        public virtual void PutOidc(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeOidc @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeOidc)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOkta", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeOkta\"}}]")]
        public virtual void PutOkta(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeOkta @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeOkta)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSaml", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeSaml\"}}]")]
        public virtual void PutSaml(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeSaml @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeSaml)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServiceToken", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeServiceToken\"}}]")]
        public virtual void PutServiceToken(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeServiceToken @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeServiceToken)}, new object[]{@value});
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

        [JsiiProperty(name: "anyValidServiceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeAnyValidServiceTokenOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeAnyValidServiceTokenOutputReference AnyValidServiceToken
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeAnyValidServiceTokenOutputReference>()!;
        }

        [JsiiProperty(name: "authContext", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeAuthContextOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeAuthContextOutputReference AuthContext
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeAuthContextOutputReference>()!;
        }

        [JsiiProperty(name: "authMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeAuthMethodOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeAuthMethodOutputReference AuthMethod
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeAuthMethodOutputReference>()!;
        }

        [JsiiProperty(name: "azureAd", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeAzureAdOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeAzureAdOutputReference AzureAd
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeAzureAdOutputReference>()!;
        }

        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeCertificateOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeCertificateOutputReference Certificate
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeCertificateOutputReference>()!;
        }

        [JsiiProperty(name: "commonName", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeCommonNameOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeCommonNameOutputReference CommonName
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeCommonNameOutputReference>()!;
        }

        [JsiiProperty(name: "devicePosture", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeDevicePostureOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeDevicePostureOutputReference DevicePosture
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeDevicePostureOutputReference>()!;
        }

        [JsiiProperty(name: "email", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeEmailOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeEmailOutputReference Email
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeEmailOutputReference>()!;
        }

        [JsiiProperty(name: "emailDomain", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeEmailDomainOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeEmailDomainOutputReference EmailDomain
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeEmailDomainOutputReference>()!;
        }

        [JsiiProperty(name: "emailList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeEmailListStructOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeEmailListStructOutputReference EmailList
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeEmailListStructOutputReference>()!;
        }

        [JsiiProperty(name: "everyone", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeEveryoneOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeEveryoneOutputReference Everyone
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeEveryoneOutputReference>()!;
        }

        [JsiiProperty(name: "externalEvaluation", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeExternalEvaluationOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeExternalEvaluationOutputReference ExternalEvaluation
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeExternalEvaluationOutputReference>()!;
        }

        [JsiiProperty(name: "geo", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeGeoOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeGeoOutputReference Geo
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeGeoOutputReference>()!;
        }

        [JsiiProperty(name: "githubOrganization", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeGithubOrganizationOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeGithubOrganizationOutputReference GithubOrganization
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeGithubOrganizationOutputReference>()!;
        }

        [JsiiProperty(name: "group", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeGroupOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeGroupOutputReference Group
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeGroupOutputReference>()!;
        }

        [JsiiProperty(name: "gsuite", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeGsuiteOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeGsuiteOutputReference Gsuite
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeGsuiteOutputReference>()!;
        }

        [JsiiProperty(name: "ip", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeIpOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeIpOutputReference Ip
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeIpOutputReference>()!;
        }

        [JsiiProperty(name: "ipList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeIpListStructOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeIpListStructOutputReference IpList
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeIpListStructOutputReference>()!;
        }

        [JsiiProperty(name: "linkedAppToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeLinkedAppTokenOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeLinkedAppTokenOutputReference LinkedAppToken
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeLinkedAppTokenOutputReference>()!;
        }

        [JsiiProperty(name: "loginMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeLoginMethodOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeLoginMethodOutputReference LoginMethod
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeLoginMethodOutputReference>()!;
        }

        [JsiiProperty(name: "oidc", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeOidcOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeOidcOutputReference Oidc
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeOidcOutputReference>()!;
        }

        [JsiiProperty(name: "okta", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeOktaOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeOktaOutputReference Okta
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeOktaOutputReference>()!;
        }

        [JsiiProperty(name: "saml", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeSamlOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeSamlOutputReference Saml
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeSamlOutputReference>()!;
        }

        [JsiiProperty(name: "serviceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeServiceTokenOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeServiceTokenOutputReference ServiceToken
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.ZeroTrustAccessGroupExcludeServiceTokenOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "anyValidServiceTokenInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeAnyValidServiceToken\"}]}}", isOptional: true)]
        public virtual object? AnyValidServiceTokenInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authContextInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeAuthContext\"}]}}", isOptional: true)]
        public virtual object? AuthContextInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authMethodInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeAuthMethod\"}]}}", isOptional: true)]
        public virtual object? AuthMethodInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "azureAdInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeAzureAd\"}]}}", isOptional: true)]
        public virtual object? AzureAdInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeCertificate\"}]}}", isOptional: true)]
        public virtual object? CertificateInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "commonNameInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeCommonName\"}]}}", isOptional: true)]
        public virtual object? CommonNameInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "devicePostureInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeDevicePosture\"}]}}", isOptional: true)]
        public virtual object? DevicePostureInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailDomainInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeEmailDomain\"}]}}", isOptional: true)]
        public virtual object? EmailDomainInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeEmail\"}]}}", isOptional: true)]
        public virtual object? EmailInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailListInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeEmailListStruct\"}]}}", isOptional: true)]
        public virtual object? EmailListInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "everyoneInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeEveryone\"}]}}", isOptional: true)]
        public virtual object? EveryoneInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "externalEvaluationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeExternalEvaluation\"}]}}", isOptional: true)]
        public virtual object? ExternalEvaluationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "geoInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeGeo\"}]}}", isOptional: true)]
        public virtual object? GeoInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "githubOrganizationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeGithubOrganization\"}]}}", isOptional: true)]
        public virtual object? GithubOrganizationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeGroup\"}]}}", isOptional: true)]
        public virtual object? GroupInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gsuiteInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeGsuite\"}]}}", isOptional: true)]
        public virtual object? GsuiteInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeIp\"}]}}", isOptional: true)]
        public virtual object? IpInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipListInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeIpListStruct\"}]}}", isOptional: true)]
        public virtual object? IpListInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "linkedAppTokenInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeLinkedAppToken\"}]}}", isOptional: true)]
        public virtual object? LinkedAppTokenInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loginMethodInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeLoginMethod\"}]}}", isOptional: true)]
        public virtual object? LoginMethodInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oidcInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeOidc\"}]}}", isOptional: true)]
        public virtual object? OidcInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oktaInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeOkta\"}]}}", isOptional: true)]
        public virtual object? OktaInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "samlInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeSaml\"}]}}", isOptional: true)]
        public virtual object? SamlInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceTokenInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeServiceToken\"}]}}", isOptional: true)]
        public virtual object? ServiceTokenInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExclude\"}]}}", isOptional: true)]
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
                        case cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExclude cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExclude).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
