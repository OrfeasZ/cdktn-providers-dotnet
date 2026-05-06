using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstanceSoftwareUpdateAction
{
    [JsiiByValue(fqn: "oci.bdsBdsInstanceSoftwareUpdateAction.BdsBdsInstanceSoftwareUpdateActionTimeouts")]
    public class BdsBdsInstanceSoftwareUpdateActionTimeouts : oci.BdsBdsInstanceSoftwareUpdateAction.IBdsBdsInstanceSoftwareUpdateActionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_software_update_action#create BdsBdsInstanceSoftwareUpdateAction#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_software_update_action#delete BdsBdsInstanceSoftwareUpdateAction#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_software_update_action#update BdsBdsInstanceSoftwareUpdateAction#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
