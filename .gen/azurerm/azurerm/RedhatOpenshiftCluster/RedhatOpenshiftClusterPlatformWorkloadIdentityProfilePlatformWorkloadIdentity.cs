using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RedhatOpenshiftCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterPlatformWorkloadIdentityProfilePlatformWorkloadIdentity")]
    public class RedhatOpenshiftClusterPlatformWorkloadIdentityProfilePlatformWorkloadIdentity : azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterPlatformWorkloadIdentityProfilePlatformWorkloadIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/redhat_openshift_cluster#identity_id RedhatOpenshiftCluster#identity_id}.</summary>
        [JsiiProperty(name: "identityId", typeJson: "{\"primitive\":\"string\"}")]
        public string IdentityId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/redhat_openshift_cluster#name RedhatOpenshiftCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
