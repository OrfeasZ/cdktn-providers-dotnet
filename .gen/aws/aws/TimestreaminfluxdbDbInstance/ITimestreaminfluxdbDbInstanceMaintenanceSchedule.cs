using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TimestreaminfluxdbDbInstance
{
    [JsiiInterface(nativeType: typeof(ITimestreaminfluxdbDbInstanceMaintenanceSchedule), fullyQualifiedName: "aws.timestreaminfluxdbDbInstance.TimestreaminfluxdbDbInstanceMaintenanceSchedule")]
    public interface ITimestreaminfluxdbDbInstanceMaintenanceSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/timestreaminfluxdb_db_instance#preferred_maintenance_window TimestreaminfluxdbDbInstance#preferred_maintenance_window}.</summary>
        [JsiiProperty(name: "preferredMaintenanceWindow", typeJson: "{\"primitive\":\"string\"}")]
        string PreferredMaintenanceWindow
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/timestreaminfluxdb_db_instance#timezone TimestreaminfluxdbDbInstance#timezone}.</summary>
        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}")]
        string Timezone
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ITimestreaminfluxdbDbInstanceMaintenanceSchedule), fullyQualifiedName: "aws.timestreaminfluxdbDbInstance.TimestreaminfluxdbDbInstanceMaintenanceSchedule")]
        internal sealed class _Proxy : DeputyBase, aws.TimestreaminfluxdbDbInstance.ITimestreaminfluxdbDbInstanceMaintenanceSchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/timestreaminfluxdb_db_instance#preferred_maintenance_window TimestreaminfluxdbDbInstance#preferred_maintenance_window}.</summary>
            [JsiiProperty(name: "preferredMaintenanceWindow", typeJson: "{\"primitive\":\"string\"}")]
            public string PreferredMaintenanceWindow
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/timestreaminfluxdb_db_instance#timezone TimestreaminfluxdbDbInstance#timezone}.</summary>
            [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}")]
            public string Timezone
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
