using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpensearchOpensearchCluster
{
    [JsiiInterface(nativeType: typeof(IOpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetails), fullyQualifiedName: "oci.opensearchOpensearchCluster.OpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetails")]
    public interface IOpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetails
    {
        /// <summary>password_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.10.0/docs/resources/opensearch_opensearch_cluster#password_details OpensearchOpensearchCluster#password_details}
        /// </remarks>
        [JsiiProperty(name: "passwordDetails", typeJson: "{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetailsPasswordDetails\"}")]
        oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetailsPasswordDetails PasswordDetails
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.10.0/docs/resources/opensearch_opensearch_cluster#username OpensearchOpensearchCluster#username}.</summary>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        string Username
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetails), fullyQualifiedName: "oci.opensearchOpensearchCluster.OpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetails")]
        internal sealed class _Proxy : DeputyBase, oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>password_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.10.0/docs/resources/opensearch_opensearch_cluster#password_details OpensearchOpensearchCluster#password_details}
            /// </remarks>
            [JsiiProperty(name: "passwordDetails", typeJson: "{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetailsPasswordDetails\"}")]
            public oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetailsPasswordDetails PasswordDetails
            {
                get => GetInstanceProperty<oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetailsPasswordDetails>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.10.0/docs/resources/opensearch_opensearch_cluster#username OpensearchOpensearchCluster#username}.</summary>
            [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
            public string Username
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
