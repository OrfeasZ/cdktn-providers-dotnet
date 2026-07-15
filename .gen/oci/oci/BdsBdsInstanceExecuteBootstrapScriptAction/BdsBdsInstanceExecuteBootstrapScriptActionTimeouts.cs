using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstanceExecuteBootstrapScriptAction
{
    [JsiiByValue(fqn: "oci.bdsBdsInstanceExecuteBootstrapScriptAction.BdsBdsInstanceExecuteBootstrapScriptActionTimeouts")]
    public class BdsBdsInstanceExecuteBootstrapScriptActionTimeouts : oci.BdsBdsInstanceExecuteBootstrapScriptAction.IBdsBdsInstanceExecuteBootstrapScriptActionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/bds_bds_instance_execute_bootstrap_script_action#create BdsBdsInstanceExecuteBootstrapScriptAction#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/bds_bds_instance_execute_bootstrap_script_action#delete BdsBdsInstanceExecuteBootstrapScriptAction#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/bds_bds_instance_execute_bootstrap_script_action#update BdsBdsInstanceExecuteBootstrapScriptAction#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
