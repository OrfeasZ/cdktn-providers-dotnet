using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsClusterAdminPasswordResetAction
{
    [JsiiByValue(fqn: "oci.bdsBdsClusterAdminPasswordResetAction.BdsBdsClusterAdminPasswordResetActionTimeouts")]
    public class BdsBdsClusterAdminPasswordResetActionTimeouts : oci.BdsBdsClusterAdminPasswordResetAction.IBdsBdsClusterAdminPasswordResetActionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/bds_bds_cluster_admin_password_reset_action#create BdsBdsClusterAdminPasswordResetAction#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/bds_bds_cluster_admin_password_reset_action#delete BdsBdsClusterAdminPasswordResetAction#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/bds_bds_cluster_admin_password_reset_action#update BdsBdsClusterAdminPasswordResetAction#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
