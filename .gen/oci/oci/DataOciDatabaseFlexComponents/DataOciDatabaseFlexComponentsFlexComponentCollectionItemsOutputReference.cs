using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseFlexComponents
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseFlexComponents.DataOciDatabaseFlexComponentsFlexComponentCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDatabaseFlexComponents.DataOciDatabaseFlexComponentsFlexComponentCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseFlexComponentsFlexComponentCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseFlexComponentsFlexComponentCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseFlexComponentsFlexComponentCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseFlexComponentsFlexComponentCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "availableCoreCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AvailableCoreCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "availableDbStorageInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AvailableDbStorageInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "availableLocalStorageInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AvailableLocalStorageInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "availableMemoryInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AvailableMemoryInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "computeModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeModel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "descriptionSummary", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DescriptionSummary
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hardwareType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HardwareType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "minimumCoreCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinimumCoreCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "runtimeMinimumCoreCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RuntimeMinimumCoreCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Shape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseFlexComponents.DataOciDatabaseFlexComponentsFlexComponentCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseFlexComponents.IDataOciDatabaseFlexComponentsFlexComponentCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseFlexComponents.IDataOciDatabaseFlexComponentsFlexComponentCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
