using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsTrigger
{
    [JsiiByValue(fqn: "oci.devopsTrigger.DevopsTriggerActionsFilterInclude")]
    public class DevopsTriggerActionsFilterInclude : oci.DevopsTrigger.IDevopsTriggerActionsFilterInclude
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_trigger#base_ref DevopsTrigger#base_ref}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "baseRef", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BaseRef
        {
            get;
            set;
        }

        /// <summary>file_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_trigger#file_filter DevopsTrigger#file_filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fileFilter", typeJson: "{\"fqn\":\"oci.devopsTrigger.DevopsTriggerActionsFilterIncludeFileFilter\"}", isOptional: true)]
        public oci.DevopsTrigger.IDevopsTriggerActionsFilterIncludeFileFilter? FileFilter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_trigger#head_ref DevopsTrigger#head_ref}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "headRef", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HeadRef
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_trigger#repository_name DevopsTrigger#repository_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "repositoryName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RepositoryName
        {
            get;
            set;
        }
    }
}
