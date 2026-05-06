using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCoreInstanceConfiguration
{
    [JsiiClass(nativeType: typeof(oci.DataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsOptionsBlockVolumesCreateDetailsOutputReference), fullyQualifiedName: "oci.dataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsOptionsBlockVolumesCreateDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCoreInstanceConfigurationInstanceDetailsOptionsBlockVolumesCreateDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCoreInstanceConfigurationInstanceDetailsOptionsBlockVolumesCreateDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCoreInstanceConfigurationInstanceDetailsOptionsBlockVolumesCreateDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreInstanceConfigurationInstanceDetailsOptionsBlockVolumesCreateDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "autotunePolicies", typeJson: "{\"fqn\":\"oci.dataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsOptionsBlockVolumesCreateDetailsAutotunePoliciesList\"}")]
        public virtual oci.DataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsOptionsBlockVolumesCreateDetailsAutotunePoliciesList AutotunePolicies
        {
            get => GetInstanceProperty<oci.DataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsOptionsBlockVolumesCreateDetailsAutotunePoliciesList>()!;
        }

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "backupPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupPolicyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "blockVolumeReplicas", typeJson: "{\"fqn\":\"oci.dataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsOptionsBlockVolumesCreateDetailsBlockVolumeReplicasList\"}")]
        public virtual oci.DataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsOptionsBlockVolumesCreateDetailsBlockVolumeReplicasList BlockVolumeReplicas
        {
            get => GetInstanceProperty<oci.DataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsOptionsBlockVolumesCreateDetailsBlockVolumeReplicasList>()!;
        }

        [JsiiProperty(name: "clusterPlacementGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterPlacementGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "isAutoTuneEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAutoTuneEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sizeInGbs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SizeInGbs
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceDetails", typeJson: "{\"fqn\":\"oci.dataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsOptionsBlockVolumesCreateDetailsSourceDetailsList\"}")]
        public virtual oci.DataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsOptionsBlockVolumesCreateDetailsSourceDetailsList SourceDetails
        {
            get => GetInstanceProperty<oci.DataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsOptionsBlockVolumesCreateDetailsSourceDetailsList>()!;
        }

        [JsiiProperty(name: "vpusPerGb", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpusPerGb
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "xrcKmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string XrcKmsKeyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsOptionsBlockVolumesCreateDetails\"}", isOptional: true)]
        public virtual oci.DataOciCoreInstanceConfiguration.IDataOciCoreInstanceConfigurationInstanceDetailsOptionsBlockVolumesCreateDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCoreInstanceConfiguration.IDataOciCoreInstanceConfigurationInstanceDetailsOptionsBlockVolumesCreateDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
