using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.KmsKey
{
    [JsiiInterface(nativeType: typeof(IKmsKeyAutoKeyRotationDetails), fullyQualifiedName: "oci.kmsKey.KmsKeyAutoKeyRotationDetails")]
    public interface IKmsKeyAutoKeyRotationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_key#last_rotation_message KmsKey#last_rotation_message}.</summary>
        [JsiiProperty(name: "lastRotationMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LastRotationMessage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_key#last_rotation_status KmsKey#last_rotation_status}.</summary>
        [JsiiProperty(name: "lastRotationStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LastRotationStatus
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_key#rotation_interval_in_days KmsKey#rotation_interval_in_days}.</summary>
        [JsiiProperty(name: "rotationIntervalInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RotationIntervalInDays
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_key#time_of_last_rotation KmsKey#time_of_last_rotation}.</summary>
        [JsiiProperty(name: "timeOfLastRotation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeOfLastRotation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_key#time_of_next_rotation KmsKey#time_of_next_rotation}.</summary>
        [JsiiProperty(name: "timeOfNextRotation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeOfNextRotation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_key#time_of_schedule_start KmsKey#time_of_schedule_start}.</summary>
        [JsiiProperty(name: "timeOfScheduleStart", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeOfScheduleStart
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKmsKeyAutoKeyRotationDetails), fullyQualifiedName: "oci.kmsKey.KmsKeyAutoKeyRotationDetails")]
        internal sealed class _Proxy : DeputyBase, oci.KmsKey.IKmsKeyAutoKeyRotationDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_key#last_rotation_message KmsKey#last_rotation_message}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lastRotationMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LastRotationMessage
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_key#last_rotation_status KmsKey#last_rotation_status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lastRotationStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LastRotationStatus
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_key#rotation_interval_in_days KmsKey#rotation_interval_in_days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rotationIntervalInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RotationIntervalInDays
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_key#time_of_last_rotation KmsKey#time_of_last_rotation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeOfLastRotation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeOfLastRotation
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_key#time_of_next_rotation KmsKey#time_of_next_rotation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeOfNextRotation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeOfNextRotation
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_key#time_of_schedule_start KmsKey#time_of_schedule_start}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeOfScheduleStart", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeOfScheduleStart
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
