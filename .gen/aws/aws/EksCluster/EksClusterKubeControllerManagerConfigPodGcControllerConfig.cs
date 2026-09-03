using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiByValue(fqn: "aws.eksCluster.EksClusterKubeControllerManagerConfigPodGcControllerConfig")]
    public class EksClusterKubeControllerManagerConfigPodGcControllerConfig : aws.EksCluster.IEksClusterKubeControllerManagerConfigPodGcControllerConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/eks_cluster#terminated_pod_gc_threshold EksCluster#terminated_pod_gc_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "terminatedPodGcThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TerminatedPodGcThreshold
        {
            get;
            set;
        }
    }
}
