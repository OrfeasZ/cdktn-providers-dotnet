using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.KmsKey
{
    [JsiiByValue(fqn: "oci.kmsKey.KmsKeyAutoKeyRotationDetails")]
    public class KmsKeyAutoKeyRotationDetails : oci.KmsKey.IKmsKeyAutoKeyRotationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_key#last_rotation_message KmsKey#last_rotation_message}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lastRotationMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LastRotationMessage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_key#last_rotation_status KmsKey#last_rotation_status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lastRotationStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LastRotationStatus
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_key#rotation_interval_in_days KmsKey#rotation_interval_in_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rotationIntervalInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RotationIntervalInDays
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_key#time_of_last_rotation KmsKey#time_of_last_rotation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeOfLastRotation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeOfLastRotation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_key#time_of_next_rotation KmsKey#time_of_next_rotation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeOfNextRotation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeOfNextRotation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_key#time_of_schedule_start KmsKey#time_of_schedule_start}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeOfScheduleStart", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeOfScheduleStart
        {
            get;
            set;
        }
    }
}
