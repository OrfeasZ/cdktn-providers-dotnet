using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsFleet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.jmsFleet.JmsFleetInventoryLog")]
    public class JmsFleetInventoryLog : oci.JmsFleet.IJmsFleetInventoryLog
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet#log_group_id JmsFleet#log_group_id}.</summary>
        [JsiiProperty(name: "logGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public string LogGroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet#log_id JmsFleet#log_id}.</summary>
        [JsiiProperty(name: "logId", typeJson: "{\"primitive\":\"string\"}")]
        public string LogId
        {
            get;
            set;
        }
    }
}
