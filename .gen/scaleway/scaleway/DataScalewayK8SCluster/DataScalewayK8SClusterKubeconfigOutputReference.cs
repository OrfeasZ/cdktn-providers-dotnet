using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayK8SCluster
{
    [JsiiClass(nativeType: typeof(scaleway.DataScalewayK8SCluster.DataScalewayK8SClusterKubeconfigOutputReference), fullyQualifiedName: "scaleway.dataScalewayK8SCluster.DataScalewayK8SClusterKubeconfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataScalewayK8SClusterKubeconfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataScalewayK8SClusterKubeconfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataScalewayK8SClusterKubeconfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayK8SClusterKubeconfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "clusterCaCertificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterCaCertificate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configFile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigFile
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Host
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Token
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.dataScalewayK8SCluster.DataScalewayK8SClusterKubeconfig\"}", isOptional: true)]
        public virtual scaleway.DataScalewayK8SCluster.IDataScalewayK8SClusterKubeconfig? InternalValue
        {
            get => GetInstanceProperty<scaleway.DataScalewayK8SCluster.IDataScalewayK8SClusterKubeconfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
