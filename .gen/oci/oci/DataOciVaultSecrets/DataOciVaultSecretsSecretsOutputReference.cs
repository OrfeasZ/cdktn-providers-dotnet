using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciVaultSecrets
{
    [JsiiClass(nativeType: typeof(oci.DataOciVaultSecrets.DataOciVaultSecretsSecretsOutputReference), fullyQualifiedName: "oci.dataOciVaultSecrets.DataOciVaultSecretsSecretsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciVaultSecretsSecretsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciVaultSecretsSecretsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciVaultSecretsSecretsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciVaultSecretsSecretsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "currentVersionNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CurrentVersionNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enableAutoGeneration", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EnableAutoGeneration
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isAutoGenerationEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAutoGenerationEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isReplica", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsReplica
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastRotationTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastRotationTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Metadata
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "nextRotationTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NextRotationTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "replicationConfig", typeJson: "{\"fqn\":\"oci.dataOciVaultSecrets.DataOciVaultSecretsSecretsReplicationConfigList\"}")]
        public virtual oci.DataOciVaultSecrets.DataOciVaultSecretsSecretsReplicationConfigList ReplicationConfig
        {
            get => GetInstanceProperty<oci.DataOciVaultSecrets.DataOciVaultSecretsSecretsReplicationConfigList>()!;
        }

        [JsiiProperty(name: "rotationConfig", typeJson: "{\"fqn\":\"oci.dataOciVaultSecrets.DataOciVaultSecretsSecretsRotationConfigList\"}")]
        public virtual oci.DataOciVaultSecrets.DataOciVaultSecretsSecretsRotationConfigList RotationConfig
        {
            get => GetInstanceProperty<oci.DataOciVaultSecrets.DataOciVaultSecretsSecretsRotationConfigList>()!;
        }

        [JsiiProperty(name: "rotationStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RotationStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secretContent", typeJson: "{\"fqn\":\"oci.dataOciVaultSecrets.DataOciVaultSecretsSecretsSecretContentList\"}")]
        public virtual oci.DataOciVaultSecrets.DataOciVaultSecretsSecretsSecretContentList SecretContent
        {
            get => GetInstanceProperty<oci.DataOciVaultSecrets.DataOciVaultSecretsSecretsSecretContentList>()!;
        }

        [JsiiProperty(name: "secretGenerationContext", typeJson: "{\"fqn\":\"oci.dataOciVaultSecrets.DataOciVaultSecretsSecretsSecretGenerationContextList\"}")]
        public virtual oci.DataOciVaultSecrets.DataOciVaultSecretsSecretsSecretGenerationContextList SecretGenerationContext
        {
            get => GetInstanceProperty<oci.DataOciVaultSecrets.DataOciVaultSecretsSecretsSecretGenerationContextList>()!;
        }

        [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecretName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secretRules", typeJson: "{\"fqn\":\"oci.dataOciVaultSecrets.DataOciVaultSecretsSecretsSecretRulesList\"}")]
        public virtual oci.DataOciVaultSecrets.DataOciVaultSecretsSecretsSecretRulesList SecretRules
        {
            get => GetInstanceProperty<oci.DataOciVaultSecrets.DataOciVaultSecretsSecretsSecretRulesList>()!;
        }

        [JsiiProperty(name: "sourceRegionInformation", typeJson: "{\"fqn\":\"oci.dataOciVaultSecrets.DataOciVaultSecretsSecretsSourceRegionInformationList\"}")]
        public virtual oci.DataOciVaultSecrets.DataOciVaultSecretsSecretsSourceRegionInformationList SourceRegionInformation
        {
            get => GetInstanceProperty<oci.DataOciVaultSecrets.DataOciVaultSecretsSecretsSourceRegionInformationList>()!;
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

        [JsiiProperty(name: "timeOfCurrentVersionExpiry", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOfCurrentVersionExpiry
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeOfDeletion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOfDeletion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vaultId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VaultId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciVaultSecrets.DataOciVaultSecretsSecrets\"}", isOptional: true)]
        public virtual oci.DataOciVaultSecrets.IDataOciVaultSecretsSecrets? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciVaultSecrets.IDataOciVaultSecretsSecrets?>();
            set => SetInstanceProperty(value);
        }
    }
}
