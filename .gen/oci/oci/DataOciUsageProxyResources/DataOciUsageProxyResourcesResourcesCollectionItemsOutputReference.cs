using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciUsageProxyResources
{
    [JsiiClass(nativeType: typeof(oci.DataOciUsageProxyResources.DataOciUsageProxyResourcesResourcesCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciUsageProxyResources.DataOciUsageProxyResourcesResourcesCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciUsageProxyResourcesResourcesCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciUsageProxyResourcesResourcesCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciUsageProxyResourcesResourcesCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciUsageProxyResourcesResourcesCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "childResources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ChildResources
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "dailyUnitDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DailyUnitDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hourlyUnitDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HourlyUnitDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isPurchased", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsPurchased
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rawUnitDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RawUnitDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "servicename", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Servicename
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "skus", typeJson: "{\"fqn\":\"oci.dataOciUsageProxyResources.DataOciUsageProxyResourcesResourcesCollectionItemsSkusList\"}")]
        public virtual oci.DataOciUsageProxyResources.DataOciUsageProxyResourcesResourcesCollectionItemsSkusList Skus
        {
            get => GetInstanceProperty<oci.DataOciUsageProxyResources.DataOciUsageProxyResourcesResourcesCollectionItemsSkusList>()!;
        }

        [JsiiProperty(name: "usageDataType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UsageDataType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciUsageProxyResources.DataOciUsageProxyResourcesResourcesCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciUsageProxyResources.IDataOciUsageProxyResourcesResourcesCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciUsageProxyResources.IDataOciUsageProxyResourcesResourcesCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
