using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciBdsBdsInstanceGetOsPatch
{
    [JsiiClass(nativeType: typeof(oci.DataOciBdsBdsInstanceGetOsPatch.DataOciBdsBdsInstanceGetOsPatchTargetPackagesOutputReference), fullyQualifiedName: "oci.dataOciBdsBdsInstanceGetOsPatch.DataOciBdsBdsInstanceGetOsPatchTargetPackagesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciBdsBdsInstanceGetOsPatchTargetPackagesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciBdsBdsInstanceGetOsPatchTargetPackagesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciBdsBdsInstanceGetOsPatchTargetPackagesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciBdsBdsInstanceGetOsPatchTargetPackagesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "packageName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PackageName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "packageType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PackageType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "relatedCvEs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RelatedCvEs
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "targetVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updateType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdateType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciBdsBdsInstanceGetOsPatch.DataOciBdsBdsInstanceGetOsPatchTargetPackages\"}", isOptional: true)]
        public virtual oci.DataOciBdsBdsInstanceGetOsPatch.IDataOciBdsBdsInstanceGetOsPatchTargetPackages? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciBdsBdsInstanceGetOsPatch.IDataOciBdsBdsInstanceGetOsPatchTargetPackages?>();
            set => SetInstanceProperty(value);
        }
    }
}
