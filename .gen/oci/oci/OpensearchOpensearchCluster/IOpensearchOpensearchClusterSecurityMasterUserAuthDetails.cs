using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpensearchOpensearchCluster
{
    [JsiiInterface(nativeType: typeof(IOpensearchOpensearchClusterSecurityMasterUserAuthDetails), fullyQualifiedName: "oci.opensearchOpensearchCluster.OpensearchOpensearchClusterSecurityMasterUserAuthDetails")]
    public interface IOpensearchOpensearchClusterSecurityMasterUserAuthDetails
    {
        /// <summary>user_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.10.0/docs/resources/opensearch_opensearch_cluster#user_details OpensearchOpensearchCluster#user_details}
        /// </remarks>
        [JsiiProperty(name: "userDetails", typeJson: "{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetails\"}")]
        oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetails UserDetails
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchOpensearchClusterSecurityMasterUserAuthDetails), fullyQualifiedName: "oci.opensearchOpensearchCluster.OpensearchOpensearchClusterSecurityMasterUserAuthDetails")]
        internal sealed class _Proxy : DeputyBase, oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterSecurityMasterUserAuthDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>user_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.10.0/docs/resources/opensearch_opensearch_cluster#user_details OpensearchOpensearchCluster#user_details}
            /// </remarks>
            [JsiiProperty(name: "userDetails", typeJson: "{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetails\"}")]
            public oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetails UserDetails
            {
                get => GetInstanceProperty<oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetails>()!;
            }
        }
    }
}
