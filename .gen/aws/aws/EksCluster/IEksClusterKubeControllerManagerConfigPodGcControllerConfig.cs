using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiInterface(nativeType: typeof(IEksClusterKubeControllerManagerConfigPodGcControllerConfig), fullyQualifiedName: "aws.eksCluster.EksClusterKubeControllerManagerConfigPodGcControllerConfig")]
    public interface IEksClusterKubeControllerManagerConfigPodGcControllerConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/eks_cluster#terminated_pod_gc_threshold EksCluster#terminated_pod_gc_threshold}.</summary>
        [JsiiProperty(name: "terminatedPodGcThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TerminatedPodGcThreshold
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEksClusterKubeControllerManagerConfigPodGcControllerConfig), fullyQualifiedName: "aws.eksCluster.EksClusterKubeControllerManagerConfigPodGcControllerConfig")]
        internal sealed class _Proxy : DeputyBase, aws.EksCluster.IEksClusterKubeControllerManagerConfigPodGcControllerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/eks_cluster#terminated_pod_gc_threshold EksCluster#terminated_pod_gc_threshold}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "terminatedPodGcThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TerminatedPodGcThreshold
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
