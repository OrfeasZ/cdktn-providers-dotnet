using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsTrigger
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.devopsTrigger.DevopsTriggerActions")]
    public class DevopsTriggerActions : oci.DevopsTrigger.IDevopsTriggerActions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_trigger#build_pipeline_id DevopsTrigger#build_pipeline_id}.</summary>
        [JsiiProperty(name: "buildPipelineId", typeJson: "{\"primitive\":\"string\"}")]
        public string BuildPipelineId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_trigger#type DevopsTrigger#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_trigger#filter DevopsTrigger#filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"oci.devopsTrigger.DevopsTriggerActionsFilter\"}", isOptional: true)]
        public oci.DevopsTrigger.IDevopsTriggerActionsFilter? Filter
        {
            get;
            set;
        }
    }
}
