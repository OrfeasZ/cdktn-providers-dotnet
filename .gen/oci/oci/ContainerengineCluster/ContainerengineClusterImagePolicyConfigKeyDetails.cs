using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineCluster
{
    [JsiiByValue(fqn: "oci.containerengineCluster.ContainerengineClusterImagePolicyConfigKeyDetails")]
    public class ContainerengineClusterImagePolicyConfigKeyDetails : oci.ContainerengineCluster.IContainerengineClusterImagePolicyConfigKeyDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#kms_key_id ContainerengineCluster#kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyId
        {
            get;
            set;
        }
    }
}
