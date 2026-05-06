using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCoreShape
{
    [JsiiClass(nativeType: typeof(oci.DataOciCoreShape.DataOciCoreShapeShapesPlatformConfigOptionsOutputReference), fullyQualifiedName: "oci.dataOciCoreShape.DataOciCoreShapeShapesPlatformConfigOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCoreShapeShapesPlatformConfigOptionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCoreShapeShapesPlatformConfigOptionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCoreShapeShapesPlatformConfigOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreShapeShapesPlatformConfigOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accessControlServiceOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreShape.DataOciCoreShapeShapesPlatformConfigOptionsAccessControlServiceOptionsList\"}")]
        public virtual oci.DataOciCoreShape.DataOciCoreShapeShapesPlatformConfigOptionsAccessControlServiceOptionsList AccessControlServiceOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreShape.DataOciCoreShapeShapesPlatformConfigOptionsAccessControlServiceOptionsList>()!;
        }

        [JsiiProperty(name: "inputOutputMemoryManagementUnitOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreShape.DataOciCoreShapeShapesPlatformConfigOptionsInputOutputMemoryManagementUnitOptionsList\"}")]
        public virtual oci.DataOciCoreShape.DataOciCoreShapeShapesPlatformConfigOptionsInputOutputMemoryManagementUnitOptionsList InputOutputMemoryManagementUnitOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreShape.DataOciCoreShapeShapesPlatformConfigOptionsInputOutputMemoryManagementUnitOptionsList>()!;
        }

        [JsiiProperty(name: "measuredBootOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreShape.DataOciCoreShapeShapesPlatformConfigOptionsMeasuredBootOptionsList\"}")]
        public virtual oci.DataOciCoreShape.DataOciCoreShapeShapesPlatformConfigOptionsMeasuredBootOptionsList MeasuredBootOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreShape.DataOciCoreShapeShapesPlatformConfigOptionsMeasuredBootOptionsList>()!;
        }

        [JsiiProperty(name: "memoryEncryptionOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreShape.DataOciCoreShapeShapesPlatformConfigOptionsMemoryEncryptionOptionsList\"}")]
        public virtual oci.DataOciCoreShape.DataOciCoreShapeShapesPlatformConfigOptionsMemoryEncryptionOptionsList MemoryEncryptionOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreShape.DataOciCoreShapeShapesPlatformConfigOptionsMemoryEncryptionOptionsList>()!;
        }

        [JsiiProperty(name: "numaNodesPerSocketPlatformOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreShape.DataOciCoreShapeShapesPlatformConfigOptionsNumaNodesPerSocketPlatformOptionsList\"}")]
        public virtual oci.DataOciCoreShape.DataOciCoreShapeShapesPlatformConfigOptionsNumaNodesPerSocketPlatformOptionsList NumaNodesPerSocketPlatformOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreShape.DataOciCoreShapeShapesPlatformConfigOptionsNumaNodesPerSocketPlatformOptionsList>()!;
        }

        [JsiiProperty(name: "percentageOfCoresEnabledOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreShape.DataOciCoreShapeShapesPlatformConfigOptionsPercentageOfCoresEnabledOptionsList\"}")]
        public virtual oci.DataOciCoreShape.DataOciCoreShapeShapesPlatformConfigOptionsPercentageOfCoresEnabledOptionsList PercentageOfCoresEnabledOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreShape.DataOciCoreShapeShapesPlatformConfigOptionsPercentageOfCoresEnabledOptionsList>()!;
        }

        [JsiiProperty(name: "secureBootOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreShape.DataOciCoreShapeShapesPlatformConfigOptionsSecureBootOptionsList\"}")]
        public virtual oci.DataOciCoreShape.DataOciCoreShapeShapesPlatformConfigOptionsSecureBootOptionsList SecureBootOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreShape.DataOciCoreShapeShapesPlatformConfigOptionsSecureBootOptionsList>()!;
        }

        [JsiiProperty(name: "symmetricMultiThreadingOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreShape.DataOciCoreShapeShapesPlatformConfigOptionsSymmetricMultiThreadingOptionsList\"}")]
        public virtual oci.DataOciCoreShape.DataOciCoreShapeShapesPlatformConfigOptionsSymmetricMultiThreadingOptionsList SymmetricMultiThreadingOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreShape.DataOciCoreShapeShapesPlatformConfigOptionsSymmetricMultiThreadingOptionsList>()!;
        }

        [JsiiProperty(name: "trustedPlatformModuleOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreShape.DataOciCoreShapeShapesPlatformConfigOptionsTrustedPlatformModuleOptionsList\"}")]
        public virtual oci.DataOciCoreShape.DataOciCoreShapeShapesPlatformConfigOptionsTrustedPlatformModuleOptionsList TrustedPlatformModuleOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreShape.DataOciCoreShapeShapesPlatformConfigOptionsTrustedPlatformModuleOptionsList>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "virtualInstructionsOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreShape.DataOciCoreShapeShapesPlatformConfigOptionsVirtualInstructionsOptionsList\"}")]
        public virtual oci.DataOciCoreShape.DataOciCoreShapeShapesPlatformConfigOptionsVirtualInstructionsOptionsList VirtualInstructionsOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreShape.DataOciCoreShapeShapesPlatformConfigOptionsVirtualInstructionsOptionsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCoreShape.DataOciCoreShapeShapesPlatformConfigOptions\"}", isOptional: true)]
        public virtual oci.DataOciCoreShape.IDataOciCoreShapeShapesPlatformConfigOptions? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCoreShape.IDataOciCoreShapeShapesPlatformConfigOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
