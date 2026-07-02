using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DisasterRecoveryAutomaticDrConfiguration
{
    [JsiiByValue(fqn: "oci.disasterRecoveryAutomaticDrConfiguration.DisasterRecoveryAutomaticDrConfigurationTimeouts")]
    public class DisasterRecoveryAutomaticDrConfigurationTimeouts : oci.DisasterRecoveryAutomaticDrConfiguration.IDisasterRecoveryAutomaticDrConfigurationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/disaster_recovery_automatic_dr_configuration#create DisasterRecoveryAutomaticDrConfiguration#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/disaster_recovery_automatic_dr_configuration#delete DisasterRecoveryAutomaticDrConfiguration#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/disaster_recovery_automatic_dr_configuration#update DisasterRecoveryAutomaticDrConfiguration#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
