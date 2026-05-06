using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsTrigger
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.devopsTrigger.DevopsTriggerActionsFilter")]
    public class DevopsTriggerActionsFilter : oci.DevopsTrigger.IDevopsTriggerActionsFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_trigger#trigger_source DevopsTrigger#trigger_source}.</summary>
        [JsiiProperty(name: "triggerSource", typeJson: "{\"primitive\":\"string\"}")]
        public string TriggerSource
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_trigger#events DevopsTrigger#events}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "events", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Events
        {
            get;
            set;
        }

        /// <summary>exclude block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_trigger#exclude DevopsTrigger#exclude}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "exclude", typeJson: "{\"fqn\":\"oci.devopsTrigger.DevopsTriggerActionsFilterExclude\"}", isOptional: true)]
        public oci.DevopsTrigger.IDevopsTriggerActionsFilterExclude? Exclude
        {
            get;
            set;
        }

        /// <summary>include block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_trigger#include DevopsTrigger#include}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "include", typeJson: "{\"fqn\":\"oci.devopsTrigger.DevopsTriggerActionsFilterInclude\"}", isOptional: true)]
        public oci.DevopsTrigger.IDevopsTriggerActionsFilterInclude? Include
        {
            get;
            set;
        }
    }
}
