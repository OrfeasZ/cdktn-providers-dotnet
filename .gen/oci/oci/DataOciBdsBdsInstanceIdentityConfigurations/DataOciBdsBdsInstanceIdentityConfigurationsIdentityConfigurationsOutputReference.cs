using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciBdsBdsInstanceIdentityConfigurations
{
    [JsiiClass(nativeType: typeof(oci.DataOciBdsBdsInstanceIdentityConfigurations.DataOciBdsBdsInstanceIdentityConfigurationsIdentityConfigurationsOutputReference), fullyQualifiedName: "oci.dataOciBdsBdsInstanceIdentityConfigurations.DataOciBdsBdsInstanceIdentityConfigurationsIdentityConfigurationsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciBdsBdsInstanceIdentityConfigurationsIdentityConfigurationsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciBdsBdsInstanceIdentityConfigurationsIdentityConfigurationsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciBdsBdsInstanceIdentityConfigurationsIdentityConfigurationsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciBdsBdsInstanceIdentityConfigurationsIdentityConfigurationsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "activateIamUserSyncConfigurationTrigger", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActivateIamUserSyncConfigurationTrigger
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "activateUpstConfigurationTrigger", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActivateUpstConfigurationTrigger
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bdsInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BdsInstanceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clusterAdminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterAdminPassword
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "confidentialApplicationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfidentialApplicationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "iamUserSyncConfiguration", typeJson: "{\"fqn\":\"oci.dataOciBdsBdsInstanceIdentityConfigurations.DataOciBdsBdsInstanceIdentityConfigurationsIdentityConfigurationsIamUserSyncConfigurationList\"}")]
        public virtual oci.DataOciBdsBdsInstanceIdentityConfigurations.DataOciBdsBdsInstanceIdentityConfigurationsIdentityConfigurationsIamUserSyncConfigurationList IamUserSyncConfiguration
        {
            get => GetInstanceProperty<oci.DataOciBdsBdsInstanceIdentityConfigurations.DataOciBdsBdsInstanceIdentityConfigurationsIdentityConfigurationsIamUserSyncConfigurationList>()!;
        }

        [JsiiProperty(name: "iamUserSyncConfigurationDetails", typeJson: "{\"fqn\":\"oci.dataOciBdsBdsInstanceIdentityConfigurations.DataOciBdsBdsInstanceIdentityConfigurationsIdentityConfigurationsIamUserSyncConfigurationDetailsList\"}")]
        public virtual oci.DataOciBdsBdsInstanceIdentityConfigurations.DataOciBdsBdsInstanceIdentityConfigurationsIdentityConfigurationsIamUserSyncConfigurationDetailsList IamUserSyncConfigurationDetails
        {
            get => GetInstanceProperty<oci.DataOciBdsBdsInstanceIdentityConfigurations.DataOciBdsBdsInstanceIdentityConfigurationsIdentityConfigurationsIamUserSyncConfigurationDetailsList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "identityDomainId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdentityDomainId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "refreshConfidentialApplicationTrigger", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RefreshConfidentialApplicationTrigger
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "refreshUpstTokenExchangeKeytabTrigger", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RefreshUpstTokenExchangeKeytabTrigger
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

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "upstConfiguration", typeJson: "{\"fqn\":\"oci.dataOciBdsBdsInstanceIdentityConfigurations.DataOciBdsBdsInstanceIdentityConfigurationsIdentityConfigurationsUpstConfigurationList\"}")]
        public virtual oci.DataOciBdsBdsInstanceIdentityConfigurations.DataOciBdsBdsInstanceIdentityConfigurationsIdentityConfigurationsUpstConfigurationList UpstConfiguration
        {
            get => GetInstanceProperty<oci.DataOciBdsBdsInstanceIdentityConfigurations.DataOciBdsBdsInstanceIdentityConfigurationsIdentityConfigurationsUpstConfigurationList>()!;
        }

        [JsiiProperty(name: "upstConfigurationDetails", typeJson: "{\"fqn\":\"oci.dataOciBdsBdsInstanceIdentityConfigurations.DataOciBdsBdsInstanceIdentityConfigurationsIdentityConfigurationsUpstConfigurationDetailsList\"}")]
        public virtual oci.DataOciBdsBdsInstanceIdentityConfigurations.DataOciBdsBdsInstanceIdentityConfigurationsIdentityConfigurationsUpstConfigurationDetailsList UpstConfigurationDetails
        {
            get => GetInstanceProperty<oci.DataOciBdsBdsInstanceIdentityConfigurations.DataOciBdsBdsInstanceIdentityConfigurationsIdentityConfigurationsUpstConfigurationDetailsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciBdsBdsInstanceIdentityConfigurations.DataOciBdsBdsInstanceIdentityConfigurationsIdentityConfigurations\"}", isOptional: true)]
        public virtual oci.DataOciBdsBdsInstanceIdentityConfigurations.IDataOciBdsBdsInstanceIdentityConfigurationsIdentityConfigurations? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciBdsBdsInstanceIdentityConfigurations.IDataOciBdsBdsInstanceIdentityConfigurationsIdentityConfigurations?>();
            set => SetInstanceProperty(value);
        }
    }
}
