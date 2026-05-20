using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TimestreaminfluxdbDbInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.timestreaminfluxdbDbInstance.TimestreaminfluxdbDbInstanceMaintenanceSchedule")]
    public class TimestreaminfluxdbDbInstanceMaintenanceSchedule : aws.TimestreaminfluxdbDbInstance.ITimestreaminfluxdbDbInstanceMaintenanceSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/timestreaminfluxdb_db_instance#preferred_maintenance_window TimestreaminfluxdbDbInstance#preferred_maintenance_window}.</summary>
        [JsiiProperty(name: "preferredMaintenanceWindow", typeJson: "{\"primitive\":\"string\"}")]
        public string PreferredMaintenanceWindow
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/timestreaminfluxdb_db_instance#timezone TimestreaminfluxdbDbInstance#timezone}.</summary>
        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}")]
        public string Timezone
        {
            get;
            set;
        }
    }
}
