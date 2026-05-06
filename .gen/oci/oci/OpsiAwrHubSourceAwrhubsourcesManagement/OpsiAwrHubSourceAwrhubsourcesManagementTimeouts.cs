using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpsiAwrHubSourceAwrhubsourcesManagement
{
    [JsiiByValue(fqn: "oci.opsiAwrHubSourceAwrhubsourcesManagement.OpsiAwrHubSourceAwrhubsourcesManagementTimeouts")]
    public class OpsiAwrHubSourceAwrhubsourcesManagementTimeouts : oci.OpsiAwrHubSourceAwrhubsourcesManagement.IOpsiAwrHubSourceAwrhubsourcesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_awr_hub_source_awrhubsources_management#create OpsiAwrHubSourceAwrhubsourcesManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_awr_hub_source_awrhubsources_management#delete OpsiAwrHubSourceAwrhubsourcesManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_awr_hub_source_awrhubsources_management#update OpsiAwrHubSourceAwrhubsourcesManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
