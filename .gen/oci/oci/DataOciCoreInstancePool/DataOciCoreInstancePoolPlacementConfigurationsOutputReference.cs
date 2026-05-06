using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCoreInstancePool
{
    [JsiiClass(nativeType: typeof(oci.DataOciCoreInstancePool.DataOciCoreInstancePoolPlacementConfigurationsOutputReference), fullyQualifiedName: "oci.dataOciCoreInstancePool.DataOciCoreInstancePoolPlacementConfigurationsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCoreInstancePoolPlacementConfigurationsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCoreInstancePoolPlacementConfigurationsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCoreInstancePoolPlacementConfigurationsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreInstancePoolPlacementConfigurationsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "faultDomains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] FaultDomains
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "primarySubnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimarySubnetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryVnicSubnets", typeJson: "{\"fqn\":\"oci.dataOciCoreInstancePool.DataOciCoreInstancePoolPlacementConfigurationsPrimaryVnicSubnetsList\"}")]
        public virtual oci.DataOciCoreInstancePool.DataOciCoreInstancePoolPlacementConfigurationsPrimaryVnicSubnetsList PrimaryVnicSubnets
        {
            get => GetInstanceProperty<oci.DataOciCoreInstancePool.DataOciCoreInstancePoolPlacementConfigurationsPrimaryVnicSubnetsList>()!;
        }

        [JsiiProperty(name: "secondaryVnicSubnets", typeJson: "{\"fqn\":\"oci.dataOciCoreInstancePool.DataOciCoreInstancePoolPlacementConfigurationsSecondaryVnicSubnetsList\"}")]
        public virtual oci.DataOciCoreInstancePool.DataOciCoreInstancePoolPlacementConfigurationsSecondaryVnicSubnetsList SecondaryVnicSubnets
        {
            get => GetInstanceProperty<oci.DataOciCoreInstancePool.DataOciCoreInstancePoolPlacementConfigurationsSecondaryVnicSubnetsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCoreInstancePool.DataOciCoreInstancePoolPlacementConfigurations\"}", isOptional: true)]
        public virtual oci.DataOciCoreInstancePool.IDataOciCoreInstancePoolPlacementConfigurations? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCoreInstancePool.IDataOciCoreInstancePoolPlacementConfigurations?>();
            set => SetInstanceProperty(value);
        }
    }
}
