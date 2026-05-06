using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCoreInstanceConfigurations
{
    [JsiiClass(nativeType: typeof(oci.DataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsOutputReference), fullyQualifiedName: "oci.dataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "blockVolumes", typeJson: "{\"fqn\":\"oci.dataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsBlockVolumesList\"}")]
        public virtual oci.DataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsBlockVolumesList BlockVolumes
        {
            get => GetInstanceProperty<oci.DataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsBlockVolumesList>()!;
        }

        [JsiiProperty(name: "launchDetails", typeJson: "{\"fqn\":\"oci.dataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsList\"}")]
        public virtual oci.DataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsList LaunchDetails
        {
            get => GetInstanceProperty<oci.DataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsLaunchDetailsList>()!;
        }

        [JsiiProperty(name: "secondaryVnics", typeJson: "{\"fqn\":\"oci.dataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsSecondaryVnicsList\"}")]
        public virtual oci.DataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsSecondaryVnicsList SecondaryVnics
        {
            get => GetInstanceProperty<oci.DataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptionsSecondaryVnicsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptions\"}", isOptional: true)]
        public virtual oci.DataOciCoreInstanceConfigurations.IDataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptions? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCoreInstanceConfigurations.IDataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
