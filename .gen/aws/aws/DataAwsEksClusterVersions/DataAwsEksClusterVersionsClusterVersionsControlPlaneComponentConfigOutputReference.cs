using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEksClusterVersions
{
    [JsiiClass(nativeType: typeof(aws.DataAwsEksClusterVersions.DataAwsEksClusterVersionsClusterVersionsControlPlaneComponentConfigOutputReference), fullyQualifiedName: "aws.dataAwsEksClusterVersions.DataAwsEksClusterVersionsClusterVersionsControlPlaneComponentConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsEksClusterVersionsClusterVersionsControlPlaneComponentConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsEksClusterVersionsClusterVersionsControlPlaneComponentConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsEksClusterVersionsClusterVersionsControlPlaneComponentConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEksClusterVersionsClusterVersionsControlPlaneComponentConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "kubeApiServerConfig", typeJson: "{\"fqn\":\"aws.dataAwsEksClusterVersions.DataAwsEksClusterVersionsClusterVersionsControlPlaneComponentConfigKubeApiServerConfigList\"}")]
        public virtual aws.DataAwsEksClusterVersions.DataAwsEksClusterVersionsClusterVersionsControlPlaneComponentConfigKubeApiServerConfigList KubeApiServerConfig
        {
            get => GetInstanceProperty<aws.DataAwsEksClusterVersions.DataAwsEksClusterVersionsClusterVersionsControlPlaneComponentConfigKubeApiServerConfigList>()!;
        }

        [JsiiProperty(name: "kubeControllerManagerConfig", typeJson: "{\"fqn\":\"aws.dataAwsEksClusterVersions.DataAwsEksClusterVersionsClusterVersionsControlPlaneComponentConfigKubeControllerManagerConfigList\"}")]
        public virtual aws.DataAwsEksClusterVersions.DataAwsEksClusterVersionsClusterVersionsControlPlaneComponentConfigKubeControllerManagerConfigList KubeControllerManagerConfig
        {
            get => GetInstanceProperty<aws.DataAwsEksClusterVersions.DataAwsEksClusterVersionsClusterVersionsControlPlaneComponentConfigKubeControllerManagerConfigList>()!;
        }

        [JsiiProperty(name: "kubeSchedulerConfig", typeJson: "{\"fqn\":\"aws.dataAwsEksClusterVersions.DataAwsEksClusterVersionsClusterVersionsControlPlaneComponentConfigKubeSchedulerConfigList\"}")]
        public virtual aws.DataAwsEksClusterVersions.DataAwsEksClusterVersionsClusterVersionsControlPlaneComponentConfigKubeSchedulerConfigList KubeSchedulerConfig
        {
            get => GetInstanceProperty<aws.DataAwsEksClusterVersions.DataAwsEksClusterVersionsClusterVersionsControlPlaneComponentConfigKubeSchedulerConfigList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsEksClusterVersions.DataAwsEksClusterVersionsClusterVersionsControlPlaneComponentConfig\"}", isOptional: true)]
        public virtual aws.DataAwsEksClusterVersions.IDataAwsEksClusterVersionsClusterVersionsControlPlaneComponentConfig? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsEksClusterVersions.IDataAwsEksClusterVersionsClusterVersionsControlPlaneComponentConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
