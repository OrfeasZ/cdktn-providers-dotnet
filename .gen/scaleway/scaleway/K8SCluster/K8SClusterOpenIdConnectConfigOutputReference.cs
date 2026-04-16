using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.K8SCluster
{
    [JsiiClass(nativeType: typeof(scaleway.K8SCluster.K8SClusterOpenIdConnectConfigOutputReference), fullyQualifiedName: "scaleway.k8SCluster.K8SClusterOpenIdConnectConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class K8SClusterOpenIdConnectConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public K8SClusterOpenIdConnectConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected K8SClusterOpenIdConnectConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected K8SClusterOpenIdConnectConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetGroupsClaim")]
        public virtual void ResetGroupsClaim()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGroupsPrefix")]
        public virtual void ResetGroupsPrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequiredClaim")]
        public virtual void ResetRequiredClaim()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUsernameClaim")]
        public virtual void ResetUsernameClaim()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUsernamePrefix")]
        public virtual void ResetUsernamePrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupsClaimInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? GroupsClaimInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupsPrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GroupsPrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "issuerUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IssuerUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requiredClaimInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? RequiredClaimInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "usernameClaimInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UsernameClaimInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "usernamePrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UsernamePrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "groupsClaim", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] GroupsClaim
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "groupsPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GroupsPrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "issuerUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IssuerUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requiredClaim", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RequiredClaim
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "usernameClaim", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UsernameClaim
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "usernamePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UsernamePrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.k8SCluster.K8SClusterOpenIdConnectConfig\"}", isOptional: true)]
        public virtual scaleway.K8SCluster.IK8SClusterOpenIdConnectConfig? InternalValue
        {
            get => GetInstanceProperty<scaleway.K8SCluster.IK8SClusterOpenIdConnectConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
