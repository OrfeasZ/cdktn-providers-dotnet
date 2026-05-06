using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCoreInstanceConfiguration
{
    [JsiiClass(nativeType: typeof(oci.DataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsBlockVolumesOutputReference), fullyQualifiedName: "oci.dataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsBlockVolumesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCoreInstanceConfigurationInstanceDetailsBlockVolumesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCoreInstanceConfigurationInstanceDetailsBlockVolumesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCoreInstanceConfigurationInstanceDetailsBlockVolumesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreInstanceConfigurationInstanceDetailsBlockVolumesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "attachDetails", typeJson: "{\"fqn\":\"oci.dataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsBlockVolumesAttachDetailsList\"}")]
        public virtual oci.DataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsBlockVolumesAttachDetailsList AttachDetails
        {
            get => GetInstanceProperty<oci.DataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsBlockVolumesAttachDetailsList>()!;
        }

        [JsiiProperty(name: "createDetails", typeJson: "{\"fqn\":\"oci.dataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsBlockVolumesCreateDetailsList\"}")]
        public virtual oci.DataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsBlockVolumesCreateDetailsList CreateDetails
        {
            get => GetInstanceProperty<oci.DataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsBlockVolumesCreateDetailsList>()!;
        }

        [JsiiProperty(name: "volumeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VolumeId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCoreInstanceConfiguration.DataOciCoreInstanceConfigurationInstanceDetailsBlockVolumes\"}", isOptional: true)]
        public virtual oci.DataOciCoreInstanceConfiguration.IDataOciCoreInstanceConfigurationInstanceDetailsBlockVolumes? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCoreInstanceConfiguration.IDataOciCoreInstanceConfigurationInstanceDetailsBlockVolumes?>();
            set => SetInstanceProperty(value);
        }
    }
}
