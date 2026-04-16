using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    [JsiiClass(nativeType: typeof(cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeOutputReference), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class ZeroTrustAccessApplicationPoliciesExcludeOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public ZeroTrustAccessApplicationPoliciesExcludeOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected ZeroTrustAccessApplicationPoliciesExcludeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ZeroTrustAccessApplicationPoliciesExcludeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAnyValidServiceToken", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeAnyValidServiceToken\"}}]")]
        public virtual void PutAnyValidServiceToken(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeAnyValidServiceToken @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeAnyValidServiceToken)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAuthContext", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeAuthContext\"}}]")]
        public virtual void PutAuthContext(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeAuthContext @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeAuthContext)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAuthMethod", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeAuthMethod\"}}]")]
        public virtual void PutAuthMethod(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeAuthMethod @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeAuthMethod)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAzureAd", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeAzureAd\"}}]")]
        public virtual void PutAzureAd(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeAzureAd @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeAzureAd)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCertificate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeCertificate\"}}]")]
        public virtual void PutCertificate(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeCertificate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeCertificate)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCommonName", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeCommonName\"}}]")]
        public virtual void PutCommonName(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeCommonName @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeCommonName)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDevicePosture", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeDevicePosture\"}}]")]
        public virtual void PutDevicePosture(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeDevicePosture @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeDevicePosture)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEmail", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeEmail\"}}]")]
        public virtual void PutEmail(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeEmail @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeEmail)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEmailDomain", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeEmailDomain\"}}]")]
        public virtual void PutEmailDomain(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeEmailDomain @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeEmailDomain)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEmailList", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeEmailListStruct\"}}]")]
        public virtual void PutEmailList(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeEmailListStruct @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeEmailListStruct)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEveryone", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeEveryone\"}}]")]
        public virtual void PutEveryone(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeEveryone @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeEveryone)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExternalEvaluation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeExternalEvaluation\"}}]")]
        public virtual void PutExternalEvaluation(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeExternalEvaluation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeExternalEvaluation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGeo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeGeo\"}}]")]
        public virtual void PutGeo(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeGeo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeGeo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGithubOrganization", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeGithubOrganization\"}}]")]
        public virtual void PutGithubOrganization(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeGithubOrganization @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeGithubOrganization)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGroup", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeGroup\"}}]")]
        public virtual void PutGroup(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeGroup @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeGroup)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGsuite", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeGsuite\"}}]")]
        public virtual void PutGsuite(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeGsuite @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeGsuite)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeIp\"}}]")]
        public virtual void PutIp(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeIp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeIp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIpList", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeIpListStruct\"}}]")]
        public virtual void PutIpList(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeIpListStruct @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeIpListStruct)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLinkedAppToken", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeLinkedAppToken\"}}]")]
        public virtual void PutLinkedAppToken(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeLinkedAppToken @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeLinkedAppToken)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLoginMethod", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeLoginMethod\"}}]")]
        public virtual void PutLoginMethod(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeLoginMethod @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeLoginMethod)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOidc", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeOidc\"}}]")]
        public virtual void PutOidc(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeOidc @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeOidc)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOkta", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeOkta\"}}]")]
        public virtual void PutOkta(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeOkta @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeOkta)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSaml", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeSaml\"}}]")]
        public virtual void PutSaml(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeSaml @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeSaml)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServiceToken", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeServiceToken\"}}]")]
        public virtual void PutServiceToken(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeServiceToken @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeServiceToken)}, new object[]{@value});
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

        [JsiiProperty(name: "anyValidServiceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeAnyValidServiceTokenOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeAnyValidServiceTokenOutputReference AnyValidServiceToken
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeAnyValidServiceTokenOutputReference>()!;
        }

        [JsiiProperty(name: "authContext", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeAuthContextOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeAuthContextOutputReference AuthContext
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeAuthContextOutputReference>()!;
        }

        [JsiiProperty(name: "authMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeAuthMethodOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeAuthMethodOutputReference AuthMethod
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeAuthMethodOutputReference>()!;
        }

        [JsiiProperty(name: "azureAd", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeAzureAdOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeAzureAdOutputReference AzureAd
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeAzureAdOutputReference>()!;
        }

        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeCertificateOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeCertificateOutputReference Certificate
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeCertificateOutputReference>()!;
        }

        [JsiiProperty(name: "commonName", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeCommonNameOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeCommonNameOutputReference CommonName
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeCommonNameOutputReference>()!;
        }

        [JsiiProperty(name: "devicePosture", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeDevicePostureOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeDevicePostureOutputReference DevicePosture
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeDevicePostureOutputReference>()!;
        }

        [JsiiProperty(name: "email", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeEmailOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeEmailOutputReference Email
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeEmailOutputReference>()!;
        }

        [JsiiProperty(name: "emailDomain", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeEmailDomainOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeEmailDomainOutputReference EmailDomain
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeEmailDomainOutputReference>()!;
        }

        [JsiiProperty(name: "emailList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeEmailListStructOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeEmailListStructOutputReference EmailList
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeEmailListStructOutputReference>()!;
        }

        [JsiiProperty(name: "everyone", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeEveryoneOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeEveryoneOutputReference Everyone
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeEveryoneOutputReference>()!;
        }

        [JsiiProperty(name: "externalEvaluation", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeExternalEvaluationOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeExternalEvaluationOutputReference ExternalEvaluation
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeExternalEvaluationOutputReference>()!;
        }

        [JsiiProperty(name: "geo", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeGeoOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeGeoOutputReference Geo
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeGeoOutputReference>()!;
        }

        [JsiiProperty(name: "githubOrganization", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeGithubOrganizationOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeGithubOrganizationOutputReference GithubOrganization
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeGithubOrganizationOutputReference>()!;
        }

        [JsiiProperty(name: "group", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeGroupOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeGroupOutputReference Group
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeGroupOutputReference>()!;
        }

        [JsiiProperty(name: "gsuite", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeGsuiteOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeGsuiteOutputReference Gsuite
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeGsuiteOutputReference>()!;
        }

        [JsiiProperty(name: "ip", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeIpOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeIpOutputReference Ip
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeIpOutputReference>()!;
        }

        [JsiiProperty(name: "ipList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeIpListStructOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeIpListStructOutputReference IpList
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeIpListStructOutputReference>()!;
        }

        [JsiiProperty(name: "linkedAppToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeLinkedAppTokenOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeLinkedAppTokenOutputReference LinkedAppToken
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeLinkedAppTokenOutputReference>()!;
        }

        [JsiiProperty(name: "loginMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeLoginMethodOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeLoginMethodOutputReference LoginMethod
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeLoginMethodOutputReference>()!;
        }

        [JsiiProperty(name: "oidc", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeOidcOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeOidcOutputReference Oidc
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeOidcOutputReference>()!;
        }

        [JsiiProperty(name: "okta", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeOktaOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeOktaOutputReference Okta
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeOktaOutputReference>()!;
        }

        [JsiiProperty(name: "saml", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeSamlOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeSamlOutputReference Saml
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeSamlOutputReference>()!;
        }

        [JsiiProperty(name: "serviceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeServiceTokenOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeServiceTokenOutputReference ServiceToken
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeServiceTokenOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "anyValidServiceTokenInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeAnyValidServiceToken\"}]}}", isOptional: true)]
        public virtual object? AnyValidServiceTokenInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authContextInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeAuthContext\"}]}}", isOptional: true)]
        public virtual object? AuthContextInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authMethodInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeAuthMethod\"}]}}", isOptional: true)]
        public virtual object? AuthMethodInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "azureAdInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeAzureAd\"}]}}", isOptional: true)]
        public virtual object? AzureAdInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeCertificate\"}]}}", isOptional: true)]
        public virtual object? CertificateInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "commonNameInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeCommonName\"}]}}", isOptional: true)]
        public virtual object? CommonNameInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "devicePostureInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeDevicePosture\"}]}}", isOptional: true)]
        public virtual object? DevicePostureInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailDomainInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeEmailDomain\"}]}}", isOptional: true)]
        public virtual object? EmailDomainInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeEmail\"}]}}", isOptional: true)]
        public virtual object? EmailInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailListInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeEmailListStruct\"}]}}", isOptional: true)]
        public virtual object? EmailListInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "everyoneInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeEveryone\"}]}}", isOptional: true)]
        public virtual object? EveryoneInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "externalEvaluationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeExternalEvaluation\"}]}}", isOptional: true)]
        public virtual object? ExternalEvaluationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "geoInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeGeo\"}]}}", isOptional: true)]
        public virtual object? GeoInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "githubOrganizationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeGithubOrganization\"}]}}", isOptional: true)]
        public virtual object? GithubOrganizationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeGroup\"}]}}", isOptional: true)]
        public virtual object? GroupInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gsuiteInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeGsuite\"}]}}", isOptional: true)]
        public virtual object? GsuiteInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeIp\"}]}}", isOptional: true)]
        public virtual object? IpInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipListInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeIpListStruct\"}]}}", isOptional: true)]
        public virtual object? IpListInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "linkedAppTokenInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeLinkedAppToken\"}]}}", isOptional: true)]
        public virtual object? LinkedAppTokenInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loginMethodInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeLoginMethod\"}]}}", isOptional: true)]
        public virtual object? LoginMethodInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oidcInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeOidc\"}]}}", isOptional: true)]
        public virtual object? OidcInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oktaInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeOkta\"}]}}", isOptional: true)]
        public virtual object? OktaInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "samlInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeSaml\"}]}}", isOptional: true)]
        public virtual object? SamlInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceTokenInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeServiceToken\"}]}}", isOptional: true)]
        public virtual object? ServiceTokenInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExclude\"}]}}", isOptional: true)]
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
                        case cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExclude cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExclude).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
