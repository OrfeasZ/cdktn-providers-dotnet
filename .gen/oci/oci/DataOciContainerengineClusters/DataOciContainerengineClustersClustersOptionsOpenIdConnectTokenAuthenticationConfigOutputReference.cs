using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciContainerengineClusters
{
    [JsiiClass(nativeType: typeof(oci.DataOciContainerengineClusters.DataOciContainerengineClustersClustersOptionsOpenIdConnectTokenAuthenticationConfigOutputReference), fullyQualifiedName: "oci.dataOciContainerengineClusters.DataOciContainerengineClustersClustersOptionsOpenIdConnectTokenAuthenticationConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciContainerengineClustersClustersOptionsOpenIdConnectTokenAuthenticationConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciContainerengineClustersClustersOptionsOpenIdConnectTokenAuthenticationConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciContainerengineClustersClustersOptionsOpenIdConnectTokenAuthenticationConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciContainerengineClustersClustersOptionsOpenIdConnectTokenAuthenticationConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "caCertificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CaCertificate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configurationFile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigurationFile
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "groupsClaim", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GroupsClaim
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "groupsPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GroupsPrefix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isOpenIdConnectAuthEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsOpenIdConnectAuthEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "issuerUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IssuerUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requiredClaims", typeJson: "{\"fqn\":\"oci.dataOciContainerengineClusters.DataOciContainerengineClustersClustersOptionsOpenIdConnectTokenAuthenticationConfigRequiredClaimsList\"}")]
        public virtual oci.DataOciContainerengineClusters.DataOciContainerengineClustersClustersOptionsOpenIdConnectTokenAuthenticationConfigRequiredClaimsList RequiredClaims
        {
            get => GetInstanceProperty<oci.DataOciContainerengineClusters.DataOciContainerengineClustersClustersOptionsOpenIdConnectTokenAuthenticationConfigRequiredClaimsList>()!;
        }

        [JsiiProperty(name: "signingAlgorithms", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SigningAlgorithms
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "usernameClaim", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UsernameClaim
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "usernamePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UsernamePrefix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciContainerengineClusters.DataOciContainerengineClustersClustersOptionsOpenIdConnectTokenAuthenticationConfig\"}", isOptional: true)]
        public virtual oci.DataOciContainerengineClusters.IDataOciContainerengineClustersClustersOptionsOpenIdConnectTokenAuthenticationConfig? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciContainerengineClusters.IDataOciContainerengineClustersClustersOptionsOpenIdConnectTokenAuthenticationConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
