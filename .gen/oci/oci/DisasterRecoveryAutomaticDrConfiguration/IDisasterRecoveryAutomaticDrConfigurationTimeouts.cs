using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DisasterRecoveryAutomaticDrConfiguration
{
    [JsiiInterface(nativeType: typeof(IDisasterRecoveryAutomaticDrConfigurationTimeouts), fullyQualifiedName: "oci.disasterRecoveryAutomaticDrConfiguration.DisasterRecoveryAutomaticDrConfigurationTimeouts")]
    public interface IDisasterRecoveryAutomaticDrConfigurationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/disaster_recovery_automatic_dr_configuration#create DisasterRecoveryAutomaticDrConfiguration#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/disaster_recovery_automatic_dr_configuration#delete DisasterRecoveryAutomaticDrConfiguration#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/disaster_recovery_automatic_dr_configuration#update DisasterRecoveryAutomaticDrConfiguration#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDisasterRecoveryAutomaticDrConfigurationTimeouts), fullyQualifiedName: "oci.disasterRecoveryAutomaticDrConfiguration.DisasterRecoveryAutomaticDrConfigurationTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.DisasterRecoveryAutomaticDrConfiguration.IDisasterRecoveryAutomaticDrConfigurationTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/disaster_recovery_automatic_dr_configuration#create DisasterRecoveryAutomaticDrConfiguration#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/disaster_recovery_automatic_dr_configuration#delete DisasterRecoveryAutomaticDrConfiguration#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/disaster_recovery_automatic_dr_configuration#update DisasterRecoveryAutomaticDrConfiguration#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
