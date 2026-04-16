using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEmrSupportedInstanceTypes
{
    [JsiiClass(nativeType: typeof(aws.DataAwsEmrSupportedInstanceTypes.DataAwsEmrSupportedInstanceTypesSupportedInstanceTypesOutputReference), fullyQualifiedName: "aws.dataAwsEmrSupportedInstanceTypes.DataAwsEmrSupportedInstanceTypesSupportedInstanceTypesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsEmrSupportedInstanceTypesSupportedInstanceTypesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsEmrSupportedInstanceTypesSupportedInstanceTypesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsEmrSupportedInstanceTypesSupportedInstanceTypesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEmrSupportedInstanceTypesSupportedInstanceTypesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "architecture", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Architecture
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ebsOptimizedAvailable", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EbsOptimizedAvailable
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "ebsOptimizedByDefault", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EbsOptimizedByDefault
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "ebsStorageOnly", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EbsStorageOnly
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "instanceFamilyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceFamilyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "is64BitsOnly", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Is64BitsOnly
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "memoryGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemoryGb
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "numberOfDisks", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumberOfDisks
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "storageGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StorageGb
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vcpu", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Vcpu
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsEmrSupportedInstanceTypes.DataAwsEmrSupportedInstanceTypesSupportedInstanceTypes\"}", isOptional: true)]
        public virtual aws.DataAwsEmrSupportedInstanceTypes.IDataAwsEmrSupportedInstanceTypesSupportedInstanceTypes? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsEmrSupportedInstanceTypes.IDataAwsEmrSupportedInstanceTypesSupportedInstanceTypes?>();
            set => SetInstanceProperty(value);
        }
    }
}
