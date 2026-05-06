using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCoreShapes
{
    [JsiiClass(nativeType: typeof(oci.DataOciCoreShapes.DataOciCoreShapesShapesPlatformConfigOptionsOutputReference), fullyQualifiedName: "oci.dataOciCoreShapes.DataOciCoreShapesShapesPlatformConfigOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCoreShapesShapesPlatformConfigOptionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCoreShapesShapesPlatformConfigOptionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCoreShapesShapesPlatformConfigOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreShapesShapesPlatformConfigOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accessControlServiceOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreShapes.DataOciCoreShapesShapesPlatformConfigOptionsAccessControlServiceOptionsList\"}")]
        public virtual oci.DataOciCoreShapes.DataOciCoreShapesShapesPlatformConfigOptionsAccessControlServiceOptionsList AccessControlServiceOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreShapes.DataOciCoreShapesShapesPlatformConfigOptionsAccessControlServiceOptionsList>()!;
        }

        [JsiiProperty(name: "inputOutputMemoryManagementUnitOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreShapes.DataOciCoreShapesShapesPlatformConfigOptionsInputOutputMemoryManagementUnitOptionsList\"}")]
        public virtual oci.DataOciCoreShapes.DataOciCoreShapesShapesPlatformConfigOptionsInputOutputMemoryManagementUnitOptionsList InputOutputMemoryManagementUnitOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreShapes.DataOciCoreShapesShapesPlatformConfigOptionsInputOutputMemoryManagementUnitOptionsList>()!;
        }

        [JsiiProperty(name: "measuredBootOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreShapes.DataOciCoreShapesShapesPlatformConfigOptionsMeasuredBootOptionsList\"}")]
        public virtual oci.DataOciCoreShapes.DataOciCoreShapesShapesPlatformConfigOptionsMeasuredBootOptionsList MeasuredBootOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreShapes.DataOciCoreShapesShapesPlatformConfigOptionsMeasuredBootOptionsList>()!;
        }

        [JsiiProperty(name: "memoryEncryptionOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreShapes.DataOciCoreShapesShapesPlatformConfigOptionsMemoryEncryptionOptionsList\"}")]
        public virtual oci.DataOciCoreShapes.DataOciCoreShapesShapesPlatformConfigOptionsMemoryEncryptionOptionsList MemoryEncryptionOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreShapes.DataOciCoreShapesShapesPlatformConfigOptionsMemoryEncryptionOptionsList>()!;
        }

        [JsiiProperty(name: "numaNodesPerSocketPlatformOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreShapes.DataOciCoreShapesShapesPlatformConfigOptionsNumaNodesPerSocketPlatformOptionsList\"}")]
        public virtual oci.DataOciCoreShapes.DataOciCoreShapesShapesPlatformConfigOptionsNumaNodesPerSocketPlatformOptionsList NumaNodesPerSocketPlatformOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreShapes.DataOciCoreShapesShapesPlatformConfigOptionsNumaNodesPerSocketPlatformOptionsList>()!;
        }

        [JsiiProperty(name: "percentageOfCoresEnabledOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreShapes.DataOciCoreShapesShapesPlatformConfigOptionsPercentageOfCoresEnabledOptionsList\"}")]
        public virtual oci.DataOciCoreShapes.DataOciCoreShapesShapesPlatformConfigOptionsPercentageOfCoresEnabledOptionsList PercentageOfCoresEnabledOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreShapes.DataOciCoreShapesShapesPlatformConfigOptionsPercentageOfCoresEnabledOptionsList>()!;
        }

        [JsiiProperty(name: "secureBootOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreShapes.DataOciCoreShapesShapesPlatformConfigOptionsSecureBootOptionsList\"}")]
        public virtual oci.DataOciCoreShapes.DataOciCoreShapesShapesPlatformConfigOptionsSecureBootOptionsList SecureBootOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreShapes.DataOciCoreShapesShapesPlatformConfigOptionsSecureBootOptionsList>()!;
        }

        [JsiiProperty(name: "symmetricMultiThreadingOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreShapes.DataOciCoreShapesShapesPlatformConfigOptionsSymmetricMultiThreadingOptionsList\"}")]
        public virtual oci.DataOciCoreShapes.DataOciCoreShapesShapesPlatformConfigOptionsSymmetricMultiThreadingOptionsList SymmetricMultiThreadingOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreShapes.DataOciCoreShapesShapesPlatformConfigOptionsSymmetricMultiThreadingOptionsList>()!;
        }

        [JsiiProperty(name: "trustedPlatformModuleOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreShapes.DataOciCoreShapesShapesPlatformConfigOptionsTrustedPlatformModuleOptionsList\"}")]
        public virtual oci.DataOciCoreShapes.DataOciCoreShapesShapesPlatformConfigOptionsTrustedPlatformModuleOptionsList TrustedPlatformModuleOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreShapes.DataOciCoreShapesShapesPlatformConfigOptionsTrustedPlatformModuleOptionsList>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "virtualInstructionsOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreShapes.DataOciCoreShapesShapesPlatformConfigOptionsVirtualInstructionsOptionsList\"}")]
        public virtual oci.DataOciCoreShapes.DataOciCoreShapesShapesPlatformConfigOptionsVirtualInstructionsOptionsList VirtualInstructionsOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreShapes.DataOciCoreShapesShapesPlatformConfigOptionsVirtualInstructionsOptionsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCoreShapes.DataOciCoreShapesShapesPlatformConfigOptions\"}", isOptional: true)]
        public virtual oci.DataOciCoreShapes.IDataOciCoreShapesShapesPlatformConfigOptions? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCoreShapes.IDataOciCoreShapesShapesPlatformConfigOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
