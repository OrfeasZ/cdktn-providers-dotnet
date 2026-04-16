using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.K8SPool
{
    [JsiiByValue(fqn: "scaleway.k8SPool.K8SPoolUpgradePolicy")]
    public class K8SPoolUpgradePolicy : scaleway.K8SPool.IK8SPoolUpgradePolicy
    {
        /// <summary>The maximum number of nodes to be created during the upgrade.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#max_surge K8SPool#max_surge}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maxSurge", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxSurge
        {
            get;
            set;
        }

        /// <summary>The maximum number of nodes that can be not ready at the same time.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_pool#max_unavailable K8SPool#max_unavailable}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maxUnavailable", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxUnavailable
        {
            get;
            set;
        }
    }
}
