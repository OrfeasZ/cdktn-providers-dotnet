using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AdmRemediationRecipe
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.admRemediationRecipe.AdmRemediationRecipeScmConfiguration")]
    public class AdmRemediationRecipeScmConfiguration : oci.AdmRemediationRecipe.IAdmRemediationRecipeScmConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#branch AdmRemediationRecipe#branch}.</summary>
        [JsiiProperty(name: "branch", typeJson: "{\"primitive\":\"string\"}")]
        public string Branch
        {
            get;
            set;
        }

        private object _isAutomergeEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#is_automerge_enabled AdmRemediationRecipe#is_automerge_enabled}.</summary>
        [JsiiProperty(name: "isAutomergeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object IsAutomergeEnabled
        {
            get => _isAutomergeEnabled;
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
                _isAutomergeEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#scm_type AdmRemediationRecipe#scm_type}.</summary>
        [JsiiProperty(name: "scmType", typeJson: "{\"primitive\":\"string\"}")]
        public string ScmType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#build_file_location AdmRemediationRecipe#build_file_location}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "buildFileLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BuildFileLocation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#external_scm_type AdmRemediationRecipe#external_scm_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "externalScmType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExternalScmType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#oci_code_repository_id AdmRemediationRecipe#oci_code_repository_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ociCodeRepositoryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OciCodeRepositoryId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#pat_secret_id AdmRemediationRecipe#pat_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "patSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PatSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#repository_url AdmRemediationRecipe#repository_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "repositoryUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RepositoryUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#username AdmRemediationRecipe#username}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Username
        {
            get;
            set;
        }
    }
}
