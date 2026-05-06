using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsTrigger
{
    [JsiiByValue(fqn: "oci.devopsTrigger.DevopsTriggerActionsFilterExcludeFileFilter")]
    public class DevopsTriggerActionsFilterExcludeFileFilter : oci.DevopsTrigger.IDevopsTriggerActionsFilterExcludeFileFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_trigger#file_paths DevopsTrigger#file_paths}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "filePaths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? FilePaths
        {
            get;
            set;
        }
    }
}
