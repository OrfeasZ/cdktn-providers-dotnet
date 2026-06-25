using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciBdsBdsInstanceBdsCertificateConfigurations
{
    [JsiiClass(nativeType: typeof(oci.DataOciBdsBdsInstanceBdsCertificateConfigurations.DataOciBdsBdsInstanceBdsCertificateConfigurationsBdsCertificateConfigurationsOutputReference), fullyQualifiedName: "oci.dataOciBdsBdsInstanceBdsCertificateConfigurations.DataOciBdsBdsInstanceBdsCertificateConfigurationsBdsCertificateConfigurationsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciBdsBdsInstanceBdsCertificateConfigurationsBdsCertificateConfigurationsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciBdsBdsInstanceBdsCertificateConfigurationsBdsCertificateConfigurationsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciBdsBdsInstanceBdsCertificateConfigurationsBdsCertificateConfigurationsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciBdsBdsInstanceBdsCertificateConfigurationsBdsCertificateConfigurationsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "bdsInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BdsInstanceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificateAuthorityId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateAuthorityId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificateType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clusterAdminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterAdminPassword
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isDefaultConfiguration", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsDefaultConfiguration
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isMissingNodesOnly", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsMissingNodesOnly
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "issueCertificateTrigger", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IssueCertificateTrigger
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "renewCertificateTrigger", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RenewCertificateTrigger
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecretId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "setDefaultTrigger", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SetDefaultTrigger
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLastRefreshedOrGenerated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastRefreshedOrGenerated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciBdsBdsInstanceBdsCertificateConfigurations.DataOciBdsBdsInstanceBdsCertificateConfigurationsBdsCertificateConfigurations\"}", isOptional: true)]
        public virtual oci.DataOciBdsBdsInstanceBdsCertificateConfigurations.IDataOciBdsBdsInstanceBdsCertificateConfigurationsBdsCertificateConfigurations? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciBdsBdsInstanceBdsCertificateConfigurations.IDataOciBdsBdsInstanceBdsCertificateConfigurationsBdsCertificateConfigurations?>();
            set => SetInstanceProperty(value);
        }
    }
}
