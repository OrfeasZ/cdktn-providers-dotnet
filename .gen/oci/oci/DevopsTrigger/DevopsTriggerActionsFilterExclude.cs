using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsTrigger
{
    [JsiiByValue(fqn: "oci.devopsTrigger.DevopsTriggerActionsFilterExclude")]
    public class DevopsTriggerActionsFilterExclude : oci.DevopsTrigger.IDevopsTriggerActionsFilterExclude
    {
        /// <summary>file_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_trigger#file_filter DevopsTrigger#file_filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fileFilter", typeJson: "{\"fqn\":\"oci.devopsTrigger.DevopsTriggerActionsFilterExcludeFileFilter\"}", isOptional: true)]
        public oci.DevopsTrigger.IDevopsTriggerActionsFilterExcludeFileFilter? FileFilter
        {
            get;
            set;
        }
    }
}
