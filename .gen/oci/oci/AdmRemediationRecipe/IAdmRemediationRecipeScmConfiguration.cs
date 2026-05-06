using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AdmRemediationRecipe
{
    [JsiiInterface(nativeType: typeof(IAdmRemediationRecipeScmConfiguration), fullyQualifiedName: "oci.admRemediationRecipe.AdmRemediationRecipeScmConfiguration")]
    public interface IAdmRemediationRecipeScmConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#branch AdmRemediationRecipe#branch}.</summary>
        [JsiiProperty(name: "branch", typeJson: "{\"primitive\":\"string\"}")]
        string Branch
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#is_automerge_enabled AdmRemediationRecipe#is_automerge_enabled}.</summary>
        [JsiiProperty(name: "isAutomergeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsAutomergeEnabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#scm_type AdmRemediationRecipe#scm_type}.</summary>
        [JsiiProperty(name: "scmType", typeJson: "{\"primitive\":\"string\"}")]
        string ScmType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#build_file_location AdmRemediationRecipe#build_file_location}.</summary>
        [JsiiProperty(name: "buildFileLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BuildFileLocation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#external_scm_type AdmRemediationRecipe#external_scm_type}.</summary>
        [JsiiProperty(name: "externalScmType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExternalScmType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#oci_code_repository_id AdmRemediationRecipe#oci_code_repository_id}.</summary>
        [JsiiProperty(name: "ociCodeRepositoryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OciCodeRepositoryId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#pat_secret_id AdmRemediationRecipe#pat_secret_id}.</summary>
        [JsiiProperty(name: "patSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PatSecretId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#repository_url AdmRemediationRecipe#repository_url}.</summary>
        [JsiiProperty(name: "repositoryUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RepositoryUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#username AdmRemediationRecipe#username}.</summary>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Username
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAdmRemediationRecipeScmConfiguration), fullyQualifiedName: "oci.admRemediationRecipe.AdmRemediationRecipeScmConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.AdmRemediationRecipe.IAdmRemediationRecipeScmConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#branch AdmRemediationRecipe#branch}.</summary>
            [JsiiProperty(name: "branch", typeJson: "{\"primitive\":\"string\"}")]
            public string Branch
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#is_automerge_enabled AdmRemediationRecipe#is_automerge_enabled}.</summary>
            [JsiiProperty(name: "isAutomergeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsAutomergeEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#scm_type AdmRemediationRecipe#scm_type}.</summary>
            [JsiiProperty(name: "scmType", typeJson: "{\"primitive\":\"string\"}")]
            public string ScmType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#build_file_location AdmRemediationRecipe#build_file_location}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "buildFileLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BuildFileLocation
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#external_scm_type AdmRemediationRecipe#external_scm_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "externalScmType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExternalScmType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#oci_code_repository_id AdmRemediationRecipe#oci_code_repository_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ociCodeRepositoryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OciCodeRepositoryId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#pat_secret_id AdmRemediationRecipe#pat_secret_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "patSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PatSecretId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#repository_url AdmRemediationRecipe#repository_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "repositoryUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RepositoryUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#username AdmRemediationRecipe#username}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Username
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
