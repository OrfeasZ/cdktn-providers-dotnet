using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpensearchOpensearchCluster
{
    [JsiiInterface(nativeType: typeof(IOpensearchOpensearchClusterSecuritySamlConfig), fullyQualifiedName: "oci.opensearchOpensearchCluster.OpensearchOpensearchClusterSecuritySamlConfig")]
    public interface IOpensearchOpensearchClusterSecuritySamlConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#idp_entity_id OpensearchOpensearchCluster#idp_entity_id}.</summary>
        [JsiiProperty(name: "idpEntityId", typeJson: "{\"primitive\":\"string\"}")]
        string IdpEntityId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#idp_metadata_content OpensearchOpensearchCluster#idp_metadata_content}.</summary>
        [JsiiProperty(name: "idpMetadataContent", typeJson: "{\"primitive\":\"string\"}")]
        string IdpMetadataContent
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#is_enabled OpensearchOpensearchCluster#is_enabled}.</summary>
        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsEnabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#admin_backend_role OpensearchOpensearchCluster#admin_backend_role}.</summary>
        [JsiiProperty(name: "adminBackendRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AdminBackendRole
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#opendashboard_url OpensearchOpensearchCluster#opendashboard_url}.</summary>
        [JsiiProperty(name: "opendashboardUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OpendashboardUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#roles_key OpensearchOpensearchCluster#roles_key}.</summary>
        [JsiiProperty(name: "rolesKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RolesKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#subject_key OpensearchOpensearchCluster#subject_key}.</summary>
        [JsiiProperty(name: "subjectKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubjectKey
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchOpensearchClusterSecuritySamlConfig), fullyQualifiedName: "oci.opensearchOpensearchCluster.OpensearchOpensearchClusterSecuritySamlConfig")]
        internal sealed class _Proxy : DeputyBase, oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterSecuritySamlConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#idp_entity_id OpensearchOpensearchCluster#idp_entity_id}.</summary>
            [JsiiProperty(name: "idpEntityId", typeJson: "{\"primitive\":\"string\"}")]
            public string IdpEntityId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#idp_metadata_content OpensearchOpensearchCluster#idp_metadata_content}.</summary>
            [JsiiProperty(name: "idpMetadataContent", typeJson: "{\"primitive\":\"string\"}")]
            public string IdpMetadataContent
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#is_enabled OpensearchOpensearchCluster#is_enabled}.</summary>
            [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#admin_backend_role OpensearchOpensearchCluster#admin_backend_role}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "adminBackendRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AdminBackendRole
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#opendashboard_url OpensearchOpensearchCluster#opendashboard_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "opendashboardUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OpendashboardUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#roles_key OpensearchOpensearchCluster#roles_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rolesKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RolesKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#subject_key OpensearchOpensearchCluster#subject_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subjectKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubjectKey
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
