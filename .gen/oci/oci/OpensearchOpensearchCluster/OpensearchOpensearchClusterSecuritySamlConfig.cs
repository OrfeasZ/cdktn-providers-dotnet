using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpensearchOpensearchCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.opensearchOpensearchCluster.OpensearchOpensearchClusterSecuritySamlConfig")]
    public class OpensearchOpensearchClusterSecuritySamlConfig : oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterSecuritySamlConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#idp_entity_id OpensearchOpensearchCluster#idp_entity_id}.</summary>
        [JsiiProperty(name: "idpEntityId", typeJson: "{\"primitive\":\"string\"}")]
        public string IdpEntityId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#idp_metadata_content OpensearchOpensearchCluster#idp_metadata_content}.</summary>
        [JsiiProperty(name: "idpMetadataContent", typeJson: "{\"primitive\":\"string\"}")]
        public string IdpMetadataContent
        {
            get;
            set;
        }

        private object _isEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#is_enabled OpensearchOpensearchCluster#is_enabled}.</summary>
        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object IsEnabled
        {
            get => _isEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#admin_backend_role OpensearchOpensearchCluster#admin_backend_role}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "adminBackendRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AdminBackendRole
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#opendashboard_url OpensearchOpensearchCluster#opendashboard_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "opendashboardUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OpendashboardUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#roles_key OpensearchOpensearchCluster#roles_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rolesKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RolesKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#subject_key OpensearchOpensearchCluster#subject_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subjectKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubjectKey
        {
            get;
            set;
        }
    }
}
