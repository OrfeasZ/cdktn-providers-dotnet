using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudMigrationsMigrationPlan
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.cloudMigrationsMigrationPlan.CloudMigrationsMigrationPlanTargetEnvironments")]
    public class CloudMigrationsMigrationPlanTargetEnvironments : oci.CloudMigrationsMigrationPlan.ICloudMigrationsMigrationPlanTargetEnvironments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_migration_plan#subnet CloudMigrationsMigrationPlan#subnet}.</summary>
        [JsiiProperty(name: "subnet", typeJson: "{\"primitive\":\"string\"}")]
        public string Subnet
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_migration_plan#target_environment_type CloudMigrationsMigrationPlan#target_environment_type}.</summary>
        [JsiiProperty(name: "targetEnvironmentType", typeJson: "{\"primitive\":\"string\"}")]
        public string TargetEnvironmentType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_migration_plan#vcn CloudMigrationsMigrationPlan#vcn}.</summary>
        [JsiiProperty(name: "vcn", typeJson: "{\"primitive\":\"string\"}")]
        public string Vcn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_migration_plan#availability_domain CloudMigrationsMigrationPlan#availability_domain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AvailabilityDomain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_migration_plan#dedicated_vm_host CloudMigrationsMigrationPlan#dedicated_vm_host}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dedicatedVmHost", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DedicatedVmHost
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_migration_plan#fault_domain CloudMigrationsMigrationPlan#fault_domain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "faultDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FaultDomain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_migration_plan#ms_license CloudMigrationsMigrationPlan#ms_license}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "msLicense", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MsLicense
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_migration_plan#preferred_shape_type CloudMigrationsMigrationPlan#preferred_shape_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preferredShapeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PreferredShapeType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_migration_plan#target_compartment_id CloudMigrationsMigrationPlan#target_compartment_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetCompartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetCompartmentId
        {
            get;
            set;
        }
    }
}
