using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeCalculateAuditVolumeAvailable
{
    [JsiiByValue(fqn: "oci.dataSafeCalculateAuditVolumeAvailable.DataSafeCalculateAuditVolumeAvailableTimeouts")]
    public class DataSafeCalculateAuditVolumeAvailableTimeouts : oci.DataSafeCalculateAuditVolumeAvailable.IDataSafeCalculateAuditVolumeAvailableTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_calculate_audit_volume_available#create DataSafeCalculateAuditVolumeAvailable#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_calculate_audit_volume_available#delete DataSafeCalculateAuditVolumeAvailable#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_calculate_audit_volume_available#update DataSafeCalculateAuditVolumeAvailable#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
