using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpsiEnterpriseManagerBridge
{
    [JsiiByValue(fqn: "oci.opsiEnterpriseManagerBridge.OpsiEnterpriseManagerBridgeTimeouts")]
    public class OpsiEnterpriseManagerBridgeTimeouts : oci.OpsiEnterpriseManagerBridge.IOpsiEnterpriseManagerBridgeTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_enterprise_manager_bridge#create OpsiEnterpriseManagerBridge#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_enterprise_manager_bridge#delete OpsiEnterpriseManagerBridge#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_enterprise_manager_bridge#update OpsiEnterpriseManagerBridge#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
