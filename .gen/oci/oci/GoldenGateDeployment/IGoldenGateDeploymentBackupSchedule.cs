using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GoldenGateDeployment
{
    [JsiiInterface(nativeType: typeof(IGoldenGateDeploymentBackupSchedule), fullyQualifiedName: "oci.goldenGateDeployment.GoldenGateDeploymentBackupSchedule")]
    public interface IGoldenGateDeploymentBackupSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#bucket GoldenGateDeployment#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        string Bucket
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#compartment_id GoldenGateDeployment#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#frequency_backup_scheduled GoldenGateDeployment#frequency_backup_scheduled}.</summary>
        [JsiiProperty(name: "frequencyBackupScheduled", typeJson: "{\"primitive\":\"string\"}")]
        string FrequencyBackupScheduled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#is_metadata_only GoldenGateDeployment#is_metadata_only}.</summary>
        [JsiiProperty(name: "isMetadataOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsMetadataOnly
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#namespace GoldenGateDeployment#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        string Namespace
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#time_backup_scheduled GoldenGateDeployment#time_backup_scheduled}.</summary>
        [JsiiProperty(name: "timeBackupScheduled", typeJson: "{\"primitive\":\"string\"}")]
        string TimeBackupScheduled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGoldenGateDeploymentBackupSchedule), fullyQualifiedName: "oci.goldenGateDeployment.GoldenGateDeploymentBackupSchedule")]
        internal sealed class _Proxy : DeputyBase, oci.GoldenGateDeployment.IGoldenGateDeploymentBackupSchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#bucket GoldenGateDeployment#bucket}.</summary>
            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
            public string Bucket
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#compartment_id GoldenGateDeployment#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#frequency_backup_scheduled GoldenGateDeployment#frequency_backup_scheduled}.</summary>
            [JsiiProperty(name: "frequencyBackupScheduled", typeJson: "{\"primitive\":\"string\"}")]
            public string FrequencyBackupScheduled
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#is_metadata_only GoldenGateDeployment#is_metadata_only}.</summary>
            [JsiiProperty(name: "isMetadataOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsMetadataOnly
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#namespace GoldenGateDeployment#namespace}.</summary>
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
            public string Namespace
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#time_backup_scheduled GoldenGateDeployment#time_backup_scheduled}.</summary>
            [JsiiProperty(name: "timeBackupScheduled", typeJson: "{\"primitive\":\"string\"}")]
            public string TimeBackupScheduled
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
