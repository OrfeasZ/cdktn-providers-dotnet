using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpensearchOpensearchCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.opensearchOpensearchCluster.OpensearchOpensearchClusterSecurityMasterUserAuthDetails")]
    public class OpensearchOpensearchClusterSecurityMasterUserAuthDetails : oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterSecurityMasterUserAuthDetails
    {
        /// <summary>user_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/opensearch_opensearch_cluster#user_details OpensearchOpensearchCluster#user_details}
        /// </remarks>
        [JsiiProperty(name: "userDetails", typeJson: "{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetails\"}")]
        public oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetails UserDetails
        {
            get;
            set;
        }
    }
}
