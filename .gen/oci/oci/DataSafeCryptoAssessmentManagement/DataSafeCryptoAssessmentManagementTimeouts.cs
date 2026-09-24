using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeCryptoAssessmentManagement
{
    [JsiiByValue(fqn: "oci.dataSafeCryptoAssessmentManagement.DataSafeCryptoAssessmentManagementTimeouts")]
    public class DataSafeCryptoAssessmentManagementTimeouts : oci.DataSafeCryptoAssessmentManagement.IDataSafeCryptoAssessmentManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/data_safe_crypto_assessment_management#create DataSafeCryptoAssessmentManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/data_safe_crypto_assessment_management#delete DataSafeCryptoAssessmentManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/data_safe_crypto_assessment_management#update DataSafeCryptoAssessmentManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
