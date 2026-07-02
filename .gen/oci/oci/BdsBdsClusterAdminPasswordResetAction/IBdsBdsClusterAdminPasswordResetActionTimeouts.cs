using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsClusterAdminPasswordResetAction
{
    [JsiiInterface(nativeType: typeof(IBdsBdsClusterAdminPasswordResetActionTimeouts), fullyQualifiedName: "oci.bdsBdsClusterAdminPasswordResetAction.BdsBdsClusterAdminPasswordResetActionTimeouts")]
    public interface IBdsBdsClusterAdminPasswordResetActionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/bds_bds_cluster_admin_password_reset_action#create BdsBdsClusterAdminPasswordResetAction#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/bds_bds_cluster_admin_password_reset_action#delete BdsBdsClusterAdminPasswordResetAction#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/bds_bds_cluster_admin_password_reset_action#update BdsBdsClusterAdminPasswordResetAction#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBdsBdsClusterAdminPasswordResetActionTimeouts), fullyQualifiedName: "oci.bdsBdsClusterAdminPasswordResetAction.BdsBdsClusterAdminPasswordResetActionTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.BdsBdsClusterAdminPasswordResetAction.IBdsBdsClusterAdminPasswordResetActionTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/bds_bds_cluster_admin_password_reset_action#create BdsBdsClusterAdminPasswordResetAction#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/bds_bds_cluster_admin_password_reset_action#delete BdsBdsClusterAdminPasswordResetAction#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/bds_bds_cluster_admin_password_reset_action#update BdsBdsClusterAdminPasswordResetAction#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
