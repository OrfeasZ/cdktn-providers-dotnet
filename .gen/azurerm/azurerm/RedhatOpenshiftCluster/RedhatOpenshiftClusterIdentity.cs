using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RedhatOpenshiftCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterIdentity")]
    public class RedhatOpenshiftClusterIdentity : azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/redhat_openshift_cluster#identity_ids RedhatOpenshiftCluster#identity_ids}.</summary>
        [JsiiProperty(name: "identityIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] IdentityIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/redhat_openshift_cluster#type RedhatOpenshiftCluster#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
