using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciAiVisionStreamGroups
{
    [JsiiClass(nativeType: typeof(oci.DataOciAiVisionStreamGroups.DataOciAiVisionStreamGroupsStreamGroupCollectionItemsStreamOverlapsList), fullyQualifiedName: "oci.dataOciAiVisionStreamGroups.DataOciAiVisionStreamGroupsStreamGroupCollectionItemsStreamOverlapsList", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"wrapsSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciAiVisionStreamGroupsStreamGroupCollectionItemsStreamOverlapsList : Io.Cdktn.ComplexList
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="wrapsSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciAiVisionStreamGroupsStreamGroupCollectionItemsStreamOverlapsList(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, bool wrapsSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, wrapsSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, bool wrapsSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, wrapsSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciAiVisionStreamGroupsStreamGroupCollectionItemsStreamOverlapsList(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciAiVisionStreamGroupsStreamGroupCollectionItemsStreamOverlapsList(DeputyProps props): base(props)
        {
        }

        /// <param name="index">the index of the item to return.</param>
        [JsiiMethod(name: "get", returnsJson: "{\"type\":{\"fqn\":\"oci.dataOciAiVisionStreamGroups.DataOciAiVisionStreamGroupsStreamGroupCollectionItemsStreamOverlapsOutputReference\"}}", parametersJson: "[{\"docs\":{\"summary\":\"the index of the item to return.\"},\"name\":\"index\",\"type\":{\"primitive\":\"number\"}}]")]
        public virtual oci.DataOciAiVisionStreamGroups.DataOciAiVisionStreamGroupsStreamGroupCollectionItemsStreamOverlapsOutputReference Get(double index)
        {
            return InvokeInstanceMethod<oci.DataOciAiVisionStreamGroups.DataOciAiVisionStreamGroupsStreamGroupCollectionItemsStreamOverlapsOutputReference>(new System.Type[]{typeof(double)}, new object[]{index})!;
        }
    }
}
